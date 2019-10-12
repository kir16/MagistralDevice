using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

using MagistralDevice.DataClasses;
using MagistralDevice.Properties;

namespace MagistralDevice
{
  public partial class DeviceMain : Form
  {
    #region Constructors

    public DeviceMain() {
      InitializeComponent();

      _interactionControls = new object[]
                             {
                               tbName, tbSerial, tbVersion, tsbLoadConfig, tsbSaveConfig, tsbAddParameter, tsbRemoveParameter
                             };
    }

    #endregion

    #region Private fields

    private dxDeviceData _data;

    private BluetoothListener _radioListener;

    private readonly object[] _interactionControls;

    #endregion

    #region Private methods

    private void UpdateControls() {
      if( _data?.Attributes == null ) {
        return;
      }

      if( tbName != null ) {
        tbName.Text = _data.Attributes.Name;
      }

      if( tbSerial != null ) {
        tbSerial.Text = _data.Attributes.Serial;
      }

      if( tbVersion != null ) {
        tbVersion.Text = _data.Attributes.Version;
      }
    }

    [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
    private void CreateValuesControls() {
      if( _data?.Parameters?.ParameterItem == null ) {
        return;
      }

      for( int index = 0; index < _data.Parameters.Count; ++index ) {
        CreateRowControls(index + 1, _data.Parameters[index]);
        if( index + 1 >= tlpParameters.RowStyles.Count ) {
          tlpParameters.RowStyles.Add(new RowStyle
                                      {
                                        SizeType = SizeType.Absolute
                                      , Height = Settings.Default.DefaultRowHeight
                                      });
        }
        else {
          tlpParameters.RowStyles[index + 1].SizeType = SizeType.Absolute;
          tlpParameters.RowStyles[index + 1].Height = Settings.Default.DefaultRowHeight;
        }
      }

      if( tlpParameters.RowStyles.Count < _data.Parameters.Count + 1 ) {
        tlpParameters.RowStyles.Add(new RowStyle
                                    {
                                      SizeType = SizeType.Percent
                                    , Height = 100
                                    });
      }
      else {
        tlpParameters.RowStyles[tlpParameters.RowStyles.Count - 1].SizeType = SizeType.Percent;
        tlpParameters.RowStyles[tlpParameters.RowStyles.Count - 1].Height = 100;
      }
    }

    private void UpdateValuesControls() {
      if( _data?.Parameters?.ParameterItem == null ) {
        return;
      }

      for( int index = 0; index < _data.Parameters.ParameterItem.Count; ++index ) {
        UpdateRowControls(tlpParameters, index + 1, _data.Parameters[index]);
      }
    }

    private void UpdateData() {
      if( _data?.Attributes == null ) {
        return;
      }

      _data.Attributes.Name = tbName?.Text;
      _data.Attributes.Serial = tbSerial?.Text;
      _data.Attributes.Version = tbVersion?.Text;

      UpdateParameters();
    }

    private void UpdateParameters() {
      if( _data?.Parameters == null ) {
        return;
      }

      // ReSharper disable once PossibleNullReferenceException
      for( int row = 0; row < _data.Parameters.Count; ++row ) {
        UpdateRowData(row + 1);
      }
    }

    private void EnableControls(bool enabled) {
      EnableParametersControls(enabled);

      if( _interactionControls == null ) {
        return;
      }

      foreach( object theControl in _interactionControls ) {
        switch( theControl ) {
          case TextBox box:
          {
            box.ReadOnly = !enabled;

            break;
          }
          case ToolStripButton button:
          {
            button.Enabled = enabled;

            break;
          }
        }
      }
    }

    private void EnableParametersControls(bool enabled) {
      if( tlpParameters?.Controls == null ) {
        return;
      }

      foreach( Control theControl in tlpParameters?.Controls ) {
        switch( theControl ) {
          case TextBox box:
          {
            box.ReadOnly = !enabled;
            break;
          }
          case ComboBox combo:
          {
            combo.Enabled = enabled;
            break;
          }
          case CheckBox check:
          {
            check.Enabled = enabled;
            break;
          }
        }
      }
    }

    private int GetSelectedRow() {
      if( tlpParameters == null || _data?.Parameters == null ) {
        return -1;
      }

      for( int rowIndex = 1; rowIndex <= _data.Parameters.Count; ++rowIndex ) {
        for( int columnIndex = 0; columnIndex < tlpParameters.ColumnCount; ++columnIndex ) {
          Control theControl = tlpParameters.GetControlFromPosition(columnIndex, rowIndex);

          if( theControl != null && theControl.Focused ) {
            return rowIndex;
          }
        }
      }

      return -1;
    }

    private void RemoveRowControls(int row) {
      if( tlpParameters == null || _data?.Parameters == null || row < 1 || row > _data.Parameters.Count ) {
        return;
      }

      for( int columnIndex = 0; columnIndex < tlpParameters.ColumnCount; ++columnIndex ) {
        Control theControl = tlpParameters.GetControlFromPosition(columnIndex, row);

        if( theControl != null ) {
          tlpParameters.Controls.Remove(theControl);
        }
      }
    }

    private void ShiftRowControlsUp(int row) {
      if( tlpParameters == null || _data?.Parameters == null || row < 1 || row > _data.Parameters.Count ) {
        return;
      }

      for( int columnIndex = 0; columnIndex < tlpParameters.ColumnCount; ++columnIndex ) {
        Control theControl = tlpParameters.GetControlFromPosition(columnIndex, row);

        if( theControl != null ) {
          tlpParameters.SetRow(theControl, row -1);
        }
      }
    }

    private bool StartListening() {
      BluetoothRadio mainRadio = BluetoothRadio.PrimaryRadio;

      if( mainRadio == null ) {
        return false;
      }

      if( mainRadio.Mode != RadioMode.Discoverable ) {
        mainRadio.Mode = RadioMode.Discoverable;
      }

      _radioListener = new BluetoothListener(Marshal.GetTypeLibGuidForAssembly(Assembly.GetExecutingAssembly()));

      return true;
    }

    private void StopListening() {
      _radioListener = null;
    }

    private void NewNameTextBox(int row, dxParameter parameter) {
      if( tlpParameters == null || Settings.Default == null || parameter == null ) {
        return;
      }

      TextBox textBox = new TextBox
                        {
                         Dock = DockStyle.Fill
                        , Margin = new Padding(1)
                        , Text = parameter.Name
                        };

      textBox.TextChanged += CommonEventHandlers.tbName_TextChanged;

      tlpParameters.Controls.Add(textBox, Settings.Default.NameColumn, row);
    }

    private void NewValueControl(int row, dxParameter parameter) {
      if( tlpParameters == null || Settings.Default == null || parameter == null ) {
        return;
      }

      Control valueControl;
      if( parameter.Type == ParameterType.Bool ) {
        valueControl = new CheckBox
                            {
                              Dock = DockStyle.Top
                            , Margin = new Padding(1)
                            , Checked = parameter.BoolValue
                            };
        ((CheckBox)valueControl).Click += CommonEventHandlers.chbValue_Click;
      }
      else {
        valueControl = new TextBox
                       {
                         Dock = DockStyle.Fill
                       , Margin = new Padding(1)
                       , Text = $@"{parameter.IntValue:D1}"
                       };

        ((TextBox)valueControl).TextChanged += CommonEventHandlers.tbValue_TextChanged;
        ((TextBox)valueControl).KeyPress += CommonEventHandlers.tbValue_KeyPress;
      }

      tlpParameters.Controls.Add(valueControl, Settings.Default.ValueColumn, row);
    }

    private void NewAccessComboBox(int row, dxParameter parameter) {
      if( tlpParameters == null || Settings.Default == null || parameter == null ) {
        return;
      }

      ComboBox accessComboBox = new ComboBox
                                {
                                  Dock = DockStyle.Fill
                                , Margin = new Padding(1)
                                , DropDownStyle = ComboBoxStyle.DropDownList
                                , AutoCompleteMode = AutoCompleteMode.None
                                };

      accessComboBox.Items.AddRange(new object[]
                                    {
                                      Settings.Default.SystemAccess, Settings.Default.UserAccess
                                    });

      accessComboBox.Text = parameter.Access == AccessLevel.Sys ? Settings.Default.SystemAccess : Settings.Default.UserAccess;

      accessComboBox.SelectedIndexChanged += CommonEventHandlers.cbAccess_SelectedIndexChanged;

      tlpParameters.Controls.Add(accessComboBox, Settings.Default.AccessColumn, row);
    }

    private void NewTypeComboBox(int row, dxParameter parameter) {
      if( tlpParameters == null || Settings.Default == null || parameter == null ) {
        return;
      }

      ComboBox typeComboBox = new ComboBox
                              {
                                Dock = DockStyle.Fill
                              , Margin = new Padding(1)
                              , DropDownStyle = ComboBoxStyle.DropDownList
                              , AutoCompleteMode = AutoCompleteMode.None
                              };

      typeComboBox.Items.AddRange(new object[]
                                  {
                                    Settings.Default.BoolType, Settings.Default.IntType
                                  });

      typeComboBox.Text = parameter.Type == ParameterType.Bool ? Settings.Default.BoolType : Settings.Default.IntType;

      typeComboBox.SelectedIndexChanged += cbType_SelectedIndexChanged;

      tlpParameters.Controls.Add(typeComboBox, Settings.Default.TypeColumn, row);
    }

    private void CreateRowControls(int row, dxParameter parameter) {
      NewAccessComboBox(row, parameter);
      NewTypeComboBox(row, parameter);
      NewNameTextBox(row, parameter);
      NewValueControl(row, parameter);
    }

    private static void UpdateRowControls(TableLayoutPanel panel, int row, dxParameter parameter) {
      if( Settings.Default == null || panel == null || parameter == null || row < 1 || row > panel.RowCount - 2 ) {
        return;
      }

      if( panel.GetControlFromPosition(Settings.Default.AccessColumn, row) is ComboBox accessComboBox ) {
        accessComboBox.SelectedIndex = parameter.Access == AccessLevel.Sys ? 0 : 1;
      }

      if( panel.GetControlFromPosition(Settings.Default.TypeColumn, row) is ComboBox typeComboBox ) {
        typeComboBox.SelectedIndex = parameter.Type == ParameterType.Bool ? 0 : 1;
      }

      if( panel.GetControlFromPosition(Settings.Default.NameColumn, row) is TextBox nameTextBox ) {
        nameTextBox.Text = parameter.Name;
      }

      switch( parameter.Type ) {
        case ParameterType.Bool when panel.GetControlFromPosition(Settings.Default.ValueColumn, row) is CheckBox valueCheckBox:
          valueCheckBox.Checked = parameter.BoolValue;
          break;
        case ParameterType.Int when panel.GetControlFromPosition(Settings.Default.ValueColumn, row) is TextBox valueTextBox:
          valueTextBox.Text = $@"{parameter.IntValue:D1}";
          break;
        default:
          throw new ArgumentOutOfRangeException();
      }
    }

    private void UpdateRowData(int row) {
      if( Settings.Default == null || tlpParameters == null || _data?.Parameters?.ParameterItem == null || row < 1 || row > _data.Parameters.ParameterItem.Count - 1 ) {
        return;
      }

      // ReSharper disable PossibleNullReferenceException
      if( _data.Parameters[row - 1] == null ) {
        return;
      }

      if( tlpParameters.GetControlFromPosition(Settings.Default.AccessColumn, row) is ComboBox accessComboBox ) {
        _data.Parameters[row - 1].Access = accessComboBox.SelectedIndex == 0 ? AccessLevel.Sys : AccessLevel.Usr;
      }

      if( tlpParameters.GetControlFromPosition(Settings.Default.TypeColumn, row) is ComboBox typeComboBox ) {
        _data.Parameters[row - 1].Type = typeComboBox.SelectedIndex == 0 ? ParameterType.Bool : ParameterType.Int;
      }

      if( tlpParameters.GetControlFromPosition(Settings.Default.NameColumn, row) is TextBox nameTextBox ) {
        _data.Parameters[row - 1].Name = nameTextBox.Text;
      }

      Control valueControl = tlpParameters.GetControlFromPosition(Settings.Default.ValueColumn, row);

      switch( _data.Parameters[row - 1].Type ) {
        case ParameterType.Bool:
        {
          if( valueControl is CheckBox box ) {
            _data.Parameters[row - 1].BoolValue = box.Checked;
          }

          break;
        }
        case ParameterType.Int:
        {
          if( valueControl is TextBox box ) {
            _data.Parameters[row - 1].IntValue = int.Parse(box.Text ?? throw new InvalidOperationException());
          }

          break;
        }
      }

      // ReSharper restore PossibleNullReferenceException
    }

    #endregion Private methods

    #region Event handlers

    private void DeviceMain_Load(object sender, EventArgs e) {
      // Check if Bluetooth available
      if( !BluetoothRadio.IsSupported ) {
        MessageBox.Show(@"Не найдено доступное устройство Bluetooth", Resources.Magistral_Device_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        if( tsbStartStopEmulation != null ) {
          tsbStartStopEmulation.Enabled = false;
        }
      }

      Icon = Resources.Reaktor;

      _data = dxDeviceData.Deserialize(Settings.Default?.DeviceData);

      if( _data?.Parameters?.ParameterItem == null ) {
        _data = new dxDeviceData();
      }

      if( tlpParameters?.RowStyles != null ) {
        tlpParameters.Tag = _data;
      }

      UpdateControls();
      CreateValuesControls();
    }

    private void DeviceMain_FormClosing(object sender, FormClosingEventArgs e) {
      if( Settings.Default == null ) {
        return;
      }

      UpdateData();
      if( _data != null ) {
        Settings.Default.DeviceData = _data.Serialize();
      }

      Settings.Default.Save();
    }

    private void tbName_TextChanged(object sender, EventArgs e) {
      if( _data?.Attributes == null ) {
        return;
      }

      _data.Attributes.Name = (sender as TextBox)?.Text;
    }

    private void tbSerial_TextChanged(object sender, EventArgs e) {
      if( _data?.Attributes == null ) {
        return;
      }

      _data.Attributes.Serial = (sender as TextBox)?.Text;
    }

    private void tbVersion_TextChanged(object sender, EventArgs e) {
      if( _data?.Attributes == null ) {
        return;
      }

      _data.Attributes.Version = (sender as TextBox)?.Text;
    }

    private void tsbStartStopEmulation_Click(object sender, EventArgs e) {
      if( _radioListener == null ) {
        UpdateData();

        if( !StartListening() ) {
          return;
        }

        // ReSharper disable once PossibleNullReferenceException
        tsbStartStopEmulation.Text = Resources.btStartStop_TextWhenWork;
        EnableControls(false);
      }
      else {
        StopListening();

        // ReSharper disable once PossibleNullReferenceException
        tsbStartStopEmulation.Text = Resources.btStartStop_TextWhenIdle;
        EnableControls(true);
      }
    }

    private void tsbSave_Click(object sender, EventArgs e) {
      if( _data == null ) {
        return;
      }

      UpdateData();

      // ReSharper disable PossibleNullReferenceException
      if( sfdParameters.ShowDialog() == DialogResult.OK ) {
        _data.SaveToFile(sfdParameters.FileName);
      }

      // ReSharper restore PossibleNullReferenceException
    }

    private void tsbLoad_Click(object sender, EventArgs e) {
      if( _data != null ) {
        if( MessageBox.Show(@"Заменить существующие параметры?", Resources.Magistral_Device_Title, MessageBoxButtons.YesNoCancel) != DialogResult.Yes ) {
          return;
        }
      }

      // ReSharper disable once PossibleNullReferenceException
      if( ofdParameters.ShowDialog() != DialogResult.OK ) {
        return;
      }

      _data = dxDeviceData.LoadFromFile(ofdParameters.FileName);
      UpdateControls();
      // ReSharper disable once PossibleNullReferenceException
      tlpParameters.Controls.Clear();
      CreateValuesControls();
    }

    private void tsbAddParameter_Click(object sender, EventArgs e) {
      if( _data?.Parameters?.ParameterItem == null || tlpParameters?.RowStyles == null || Settings.Default == null ) {
        return;
      }

      _data.Parameters.ParameterItem.Add(new dxParameter());
      CreateRowControls(_data.Parameters.ParameterItem.Count, _data.Parameters[_data.Parameters.ParameterItem.Count - 1]);
    }

    [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
    private void tsbRemoveParameter_Click(object sender, EventArgs e) {
      int selectedIndex = GetSelectedRow();
      if( selectedIndex < 0 ) {
        return;
      }
      
      RemoveRowControls(selectedIndex);
      // ReSharper disable once PossibleNullReferenceException
      for( int index = selectedIndex + 1; index <= _data.Parameters.Count; ++index ) {
        ShiftRowControlsUp(index);
      }

      _data.Parameters.ParameterItem.RemoveAt(selectedIndex - 1);
    }

    private void cbType_SelectedIndexChanged(object sender, EventArgs e) {
      if( tlpParameters == null || !(sender is ComboBox typeCombo) || Settings.Default == null || _data?.Parameters?.ParameterItem == null ) {
        return;
      }

      int row = tlpParameters.GetRow(typeCombo);
      Control valueControl = tlpParameters.GetControlFromPosition(Settings.Default.ValueColumn, row);
      if( valueControl != null ) {
        tlpParameters.Controls.Remove(valueControl);
      }
      dxParameter parameter = _data.Parameters[row - 1];
      if( parameter != null && typeCombo.Text == Settings.Default.BoolType ) {
        parameter.Type = ParameterType.Bool;
      }
      else if( parameter != null && typeCombo.Text == Settings.Default.IntType ) {
        parameter.Type = ParameterType.Int;
      }
      NewValueControl(row, parameter);
    }

    #endregion Event handlers
  }
}

using System;
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

    private void CreateValuesControls() {
      if( _data?.Parameters?.ParameterItem == null || tlpParameters?.RowStyles == null ) {
        return;
      }

      tlpParameters.RowCount = 2;

      foreach( dxParameter parameter in _data.Parameters.ParameterItem ) {
        ++tlpParameters.RowCount;

        RowStyle rowStyle = tlpParameters.RowStyles[tlpParameters.RowCount - 2];
        // ReSharper disable once PossibleNullReferenceException
        rowStyle.Height = 22;
        CreateRowControls(tlpParameters, tlpParameters.RowCount - 2, parameter);
      }

      // ReSharper disable once PossibleNullReferenceException
      tlpParameters.RowStyles[tlpParameters.RowCount - 1].SizeType = SizeType.AutoSize;
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
      if( _data == null ) {
        return;
      }

      // ReSharper disable PossibleNullReferenceException
      _data.Attributes.Name = tbName?.Text;
      _data.Attributes.Serial = tbSerial?.Text;
      _data.Attributes.Version = tbVersion?.Text;

      // ReSharper restore PossibleNullReferenceException
      UpdateParameters();
    }

    private void UpdateParameters() {
      if( tlpParameters == null ) {
        return;
      }

      for( int row = 1; row < tlpParameters.RowCount - 1; ++row ) {
        UpdateRowData(row);
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

    private static void NewNameTextBox(TableLayoutPanel panel, int row, dxParameter parameter) {
      if( panel == null || Settings.Default == null || parameter == null ) {
        return;
      }

      TextBox textBox = new TextBox
                        {
                          Parent = panel
                        , Dock = DockStyle.Fill
                        , Margin = new Padding(1),
                          Text = parameter.Name
                        };

      textBox.TextChanged += CommonEventHandlers.tbName_TextChanged;

      panel.Controls.Add(textBox, Settings.Default.NameColumn, row);
    }

    private static void NewValueCheckBox(TableLayoutPanel panel, int row, dxParameter parameter) {
      if( panel == null || Settings.Default == null || parameter == null ) {
        return;
      }

      CheckBox valueBox = new CheckBox
                          {
                           Dock = DockStyle.Fill
                          , Margin = new Padding(1),
                            Checked = parameter.BoolValue
                          };

      valueBox.Click += CommonEventHandlers.chbValue_Click;

      panel.Controls.Add(valueBox, Settings.Default.ValueColumn, row);
    }

    private static void NewValueTextBox(TableLayoutPanel panel, int row, dxParameter parameter) {
      if( panel == null || Settings.Default == null || parameter == null ) {
        return;
      }

      TextBox valueBox = new TextBox
                         {
                           Dock = DockStyle.Fill
                         , Margin = new Padding(1)
                         , Text = $@"{parameter.IntValue:D1}"
                         };


      valueBox.TextChanged += CommonEventHandlers.tbValue_TextChanged;
      valueBox.KeyPress += CommonEventHandlers.tbValue_KeyPress;

      panel.Controls.Add(valueBox, Settings.Default.ValueColumn, row);
    }

    private static void NewAccessComboBox(TableLayoutPanel panel, int row, dxParameter parameter) {
      if( panel == null || Settings.Default == null || parameter == null) {
        return;
      }

      ComboBox accessComboBox = new ComboBox
                                {
                                  Dock = DockStyle.Fill
                                , Margin = new Padding(1)
                                , DropDownStyle = ComboBoxStyle.DropDownList
                                , AutoCompleteMode = AutoCompleteMode.Suggest
                                };

      accessComboBox.Items.AddRange(new object[]
                                    {
                                      Settings.Default.SystemAccess, Settings.Default.UserAccess
                                    });

      accessComboBox.Text = parameter.Access == AccessLevel.Sys ? Settings.Default.SystemAccess : Settings.Default.UserAccess;

      accessComboBox.TextChanged += CommonEventHandlers.cbAccess_TextChanged;
      
      panel.Controls.Add(accessComboBox, Settings.Default.AccessColumn, row);
    }

    private static void NewTypeComboBox(TableLayoutPanel panel, int row, dxParameter parameter) {
      if( panel == null || Settings.Default == null || parameter == null ) {
        return;
      }

      ComboBox typeComboBox = new ComboBox
                                {
                                  Dock = DockStyle.Fill
                                , Margin = new Padding(1)
                                , DropDownStyle = ComboBoxStyle.DropDownList
                                , AutoCompleteMode = AutoCompleteMode.Suggest
                                };

      typeComboBox.Items.AddRange(new object[]
                                    {
                                      Settings.Default.BoolType, Settings.Default.IntType
                                    });

      typeComboBox.Text = parameter.Type == ParameterType.Bool ? Settings.Default.BoolType : Settings.Default.IntType;

      typeComboBox.TextChanged += CommonEventHandlers.cbType_TextChanged;
      
      panel.Controls.Add(typeComboBox, Settings.Default.TypeColumn, row);
    }

    private static void CreateRowControls(TableLayoutPanel panel, int row, dxParameter parameter) {
      NewAccessComboBox(panel, row, parameter);
      NewTypeComboBox(panel, row, parameter);
      NewNameTextBox(panel, row, parameter);

      // ReSharper disable once PossibleNullReferenceException
      if( parameter.Type == ParameterType.Bool ) {
        NewValueCheckBox(panel, row, parameter);
      }
      else {
        NewValueTextBox(panel, row, parameter);
      }
    }

    private static void UpdateRowControls(TableLayoutPanel panel, int row, dxParameter parameter) {
      if( Settings.Default == null || panel == null || parameter == null || row < 1 || row > panel.RowCount - 2 ) {
        return;
      }

      if( panel.GetControlFromPosition(Settings.Default.AccessColumn, row) is ComboBox accessComboBox ) {
        accessComboBox.Text = parameter.Access == AccessLevel.Sys ? Settings.Default.SystemAccess : Settings.Default.UserAccess;
      }

      if( panel.GetControlFromPosition(Settings.Default.TypeColumn, row) is ComboBox typeComboBox ) {
        typeComboBox.Text = parameter.Type == ParameterType.Bool ? Settings.Default.BoolType : Settings.Default.IntType;
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
        _data.Parameters[row - 1].Access = accessComboBox.Text == Settings.Default.SystemAccess ? AccessLevel.Sys : AccessLevel.Usr;
      }

      if( tlpParameters.GetControlFromPosition(Settings.Default.TypeColumn, row) is ComboBox typeComboBox ) {
        _data.Parameters[row - 1].Type = typeComboBox.Text == Settings.Default.BoolType ? ParameterType.Bool : ParameterType.Int;
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

      if( tlpParameters != null ) {
        tlpParameters.Tag = _data;
      }

      CreateValuesControls();
      UpdateControls();
    }

    private void DeviceMain_FormClosing(object sender, FormClosingEventArgs e) {
      if( Settings.Default == null || _data == null ) {
        return;
      }

      Settings.Default.DeviceData = _data?.Serialize();
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
      if( ofdParameters.ShowDialog() == DialogResult.OK ) {
        _data = dxDeviceData.LoadFromFile(ofdParameters.FileName);
      }
    }

    #endregion Event handlers
  }
}

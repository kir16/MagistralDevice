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
                                 tbName,
                                 tbSerial,
                                 tbVersion,
                                 tcParameters
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

      UpdateValuesControls();
    }

    private void CreateValuesControls() {
      if( _data?.SystemBoolParameters?.ParameterItem == null || _data?.SystemIntParameters?.ParameterItem == null || _data?.UserBoolParameters?.ParameterItem == null || _data?.UserIntParameters?.ParameterItem == null ) {
        return;
      }

      for( int index = 0; index < _data.SystemBoolParameters.ParameterItem.Count; ++index ) {
        AddBoolControls(tlpSysBoolValues, index);
      }

      for( int index = 0; index < _data.SystemIntParameters.ParameterItem.Count; ++index ) {
        AddIntControls(tlpSysIntValues, index);
      }

      for( int index = 0; index < _data.UserBoolParameters.ParameterItem.Count; ++index ) {
        AddBoolControls(tlpUserBoolValues, index);
      }

      for( int index = 0; index < _data.UserIntParameters.ParameterItem.Count; ++index ) {
        AddIntControls(tlpUserIntValues, index);
      }
    }

    private void UpdateValuesControls() {
      if( _data?.SystemBoolParameters?.ParameterItem == null || _data?.SystemIntParameters?.ParameterItem == null || _data?.UserBoolParameters?.ParameterItem == null || _data?.UserIntParameters?.ParameterItem == null ) {
        return;
      }

      for( int index = 0; index < _data.SystemBoolParameters.ParameterItem.Count; ++index ) {
        UpdateBoolControls(tlpSysBoolValues, index, _data.SystemBoolParameters.ParameterItem[index]);
      }

      for( int index = 0; index < _data.SystemIntParameters.ParameterItem.Count; ++index ) {
        UpdateIntControls(tlpSysIntValues, index, _data.SystemIntParameters.ParameterItem[index]);
      }

      for( int index = 0; index < _data.UserBoolParameters.ParameterItem.Count; ++index ) {
        UpdateBoolControls(tlpUserBoolValues, index, _data.UserBoolParameters.ParameterItem[index]);
      }

      for( int index = 0; index < _data.UserIntParameters.ParameterItem.Count; ++index ) {
        UpdateIntControls(tlpUserIntValues, index, _data.UserIntParameters.ParameterItem[index]);
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
      UpdateValues();
    }

    [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
    private void UpdateValues() {
      if( tlpSysBoolValues == null
          || tlpSysIntValues == null
          || tlpUserBoolValues == null
          || tlpUserIntValues == null
          || _data?.SystemBoolParameters?.ParameterItem == null
          || _data?.SystemIntParameters?.ParameterItem == null
          || _data?.UserBoolParameters?.ParameterItem == null
          || _data?.UserIntParameters?.ParameterItem == null ) {
        return;
      }

      for( int index = 0; index < tlpSysBoolValues.RowCount; ++index ) {
        if( !(tlpSysBoolValues.GetControlFromPosition(1, index) is CheckBox valueBox) ) {
          continue;
        }

        _data.SystemBoolParameters.ParameterItem[index].BoolValue = valueBox.Checked;
      }

      for( int index = 0; index < tlpSysIntValues.RowCount; ++index ) {
        if( !(tlpSysIntValues.GetControlFromPosition(1, index) is TextBox valueBox) ) {
          continue;
        }

        _data.SystemBoolParameters.ParameterItem[index].IntValue = int.Parse(valueBox.Text ?? throw new InvalidOperationException());
      }

      for( int index = 0; index < tlpUserBoolValues.RowCount; ++index ) {
        if( !(tlpUserBoolValues.GetControlFromPosition(1, index) is CheckBox valueBox) ) {
          continue;
        }

        _data.UserBoolParameters.ParameterItem[index].BoolValue = valueBox.Checked;
      }

      for( int index = 0; index < tlpUserIntValues.RowCount; ++index ) {
        if( !(tlpUserIntValues.GetControlFromPosition(1, index) is TextBox valueBox) ) {
          continue;
        }

        _data.SystemBoolParameters.ParameterItem[index].IntValue = int.Parse(valueBox.Text ?? throw new InvalidOperationException());
      }
    }

    private void EnableControls(bool enabled) {
      // ReSharper disable once PossibleNullReferenceException
      foreach( object theControl in _interactionControls ) {
        switch( theControl ) {
          case TextBox _:
            ((TextBox)theControl).ReadOnly = !enabled;
            break;
          case ToolStripButton _:
            ((ToolStripButton)theControl).Enabled = enabled;
            break;
          case TabControl _:
            ((TabControl)theControl).Enabled = enabled;
            break;
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

    private static TextBox AddTextBoxToPanel(TableLayoutPanel panel, int column, int row) {
      if( panel == null ) {
        return null;
      }

      TextBox textBox = new TextBox
                        {
                            Parent = panel,
                            Dock = DockStyle.Fill
                        };
      panel.Controls.Add(textBox, column, row);
      return textBox;
    }

    private static CheckBox AddCheckBoxToPanel(TableLayoutPanel panel, int column, int row) {
      if( panel == null ) {
        return null;
      }

      CheckBox checkBox = new CheckBox
                          {
                              Parent = panel,
                              Padding = new Padding(3, 3, 3, 3)
                          };
      panel.Controls.Add(checkBox, column, row);
      return checkBox;
    }

    private static void AddBoolControls(TableLayoutPanel panel, int row) {
      if( panel == null ) {
        return;
      }

      if( panel.RowCount <= row ) {
        panel.RowCount = row + 1;
      }

      TextBox tbParamName = panel.GetControlFromPosition(0, row) as TextBox;
      CheckBox chbParamValue = panel.GetControlFromPosition(1, row) as CheckBox;
      if( tbParamName != null && chbParamValue != null ) {
        return;
      }

      tbParamName = AddTextBoxToPanel(panel, 0, row);
      if( tbParamName != null ) {
        tbParamName.Leave += CommonEventHandlers.tbParamName_Leave;
      }

      chbParamValue = AddCheckBoxToPanel(panel, 1, row);
      if( chbParamValue == null ) {
        return;
      }

      chbParamValue.Click += CommonEventHandlers.chbParamValue_Click;
    }

    private static void UpdateBoolControls(TableLayoutPanel panel, int row, dxParameter parameter) {
      if( panel == null || parameter == null ) {
        return;
      }

      TextBox tbParamName = panel.GetControlFromPosition(0, row) as TextBox;
      CheckBox chbParamValue = panel.GetControlFromPosition(1, row) as CheckBox;
      if( tbParamName == null || chbParamValue == null ) {
        return;
      }

      tbParamName.Text = parameter.Name;
      if( parameter.BoolValue != null ) {
        chbParamValue.Checked = (bool)parameter.BoolValue;
      }
    }

    private static void AddIntControls(TableLayoutPanel panel, int row) {
      if( panel == null ) {
        return;
      }

      if( panel.RowCount <= row ) {
        panel.RowCount = row + 1;
      }

      TextBox tbParamName = panel.GetControlFromPosition(0, row) as TextBox;
      TextBox tbParamValue = panel.GetControlFromPosition(1, row) as TextBox;
      if( tbParamName != null && tbParamValue != null ) {
        return;
      }

      tbParamName = AddTextBoxToPanel(panel, 0, row);
      if( tbParamName != null ) {
        tbParamName.Leave += CommonEventHandlers.tbParamName_Leave;
      }

      tbParamValue = AddTextBoxToPanel(panel, 1, row);
      if( tbParamValue == null ) {
        return;
      }

      tbParamValue.Leave += CommonEventHandlers.tbParamValue_Leave;
      tbParamValue.KeyPress += CommonEventHandlers.tbParamValue_KeyPress;
      // ReSharper disable once LocalizableElement
    }

    private static void UpdateIntControls(TableLayoutPanel panel, int row, dxParameter parameter) {
      if( panel == null || parameter == null ) {
        return;
      }

      TextBox tbParamName = panel.GetControlFromPosition(0, row) as TextBox;
      TextBox tbParamValue = panel.GetControlFromPosition(1, row) as TextBox;
      if( tbParamName == null || tbParamValue == null ) {
        return;
      }

      tbParamName.Text = parameter.Name;
      // ReSharper disable once UseStringInterpolation
      tbParamValue.Text = parameter.IntValue != null ? string.Format("{0:D}", (int)parameter.IntValue) : @"0";
    }

    #endregion Private methods

    #region Event handlers

    private void DeviceMain_Load(object sender, EventArgs e) {
      // Check if Bluetooth available
      if( !BluetoothRadio.IsSupported ) {
        MessageBox.Show(@"Не найдено доступное устройство Bluetooth", Resources.Magistral_Device_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        if( btStartStop != null ) {
          btStartStop.Enabled = false;
        }
      }

      Icon = Resources.Reaktor;

      _data = dxDeviceData.Deserialize(Settings.Default?.DeviceData);
      if( _data?.SystemBoolParameters?.ParameterItem == null || _data?.SystemIntParameters?.ParameterItem == null || _data?.UserBoolParameters?.ParameterItem == null || _data?.UserIntParameters?.ParameterItem == null ) {
        _data = new dxDeviceData();
      }

      // ReSharper disable PossibleNullReferenceException
      if( tlpSysBoolValues != null ) {
        tlpSysBoolValues.Tag = _data.SystemBoolParameters.ParameterItem;
      }

      if( tlpSysIntValues != null ) {
        tlpSysIntValues.Tag = _data.SystemIntParameters.ParameterItem;
      }

      if( tlpUserBoolValues != null ) {
        tlpUserBoolValues.Tag = _data.UserBoolParameters.ParameterItem;
      }

      if( tlpUserIntValues != null ) {
        tlpUserIntValues.Tag = _data.UserIntParameters.ParameterItem;
      }
      // ReSharper restore PossibleNullReferenceException

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

    private void tbName_Leave(object sender, EventArgs e) {
      if( _data?.Attributes == null ) {
        return;
      }

      _data.Attributes.Name = (sender as TextBox)?.Text;
    }

    private void tbSerial_Leave(object sender, EventArgs e) {
      if( _data?.Attributes == null ) {
        return;
      }

      _data.Attributes.Serial = (sender as TextBox)?.Text;
    }

    private void tbVersion_Leave(object sender, EventArgs e) {
      if( _data?.Attributes == null ) {
        return;
      }

      _data.Attributes.Version = (sender as TextBox)?.Text;
    }

    private void btStartStop_Click(object sender, EventArgs e) {
      if( _radioListener == null ) {
        if( !StartListening() ) {
          return;
        }

        // ReSharper disable once PossibleNullReferenceException
        btStartStop.Text = Resources.btStartStop_TextWhenWork;
        EnableControls(false);
      }
      else {
        StopListening();
        // ReSharper disable once PossibleNullReferenceException
        btStartStop.Text = Resources.btStartStop_TextWhenIdle;
        EnableControls(true);
      }
    }

    private void tsbAdd_EnabledChanged(object sender, EventArgs e) {
      ToolStripButton button = (ToolStripButton)sender;
      if( button != null ) {
        button.Image = button.Enabled ? Resources.Add : Resources.Add_Dis;
      }
    }

    private void tsbDel_EnabledChanged(object sender, EventArgs e) {
      ToolStripButton button = (ToolStripButton)sender;
      if( button != null ) {
        button.Image = button.Enabled ? Resources.Del : Resources.Del_Dis;
      }
    }

    private void tsbSysBoolAdd_Click(object sender, EventArgs e) {
      if( _data?.SystemBoolParameters?.ParameterItem == null ) {
        return;
      }

      dxParameter parameter = new dxParameter
                              {
                                  BoolValue = false
                              };
      _data.SystemBoolParameters.ParameterItem.Add(parameter);
      AddBoolControls(tlpSysBoolValues, _data.SystemBoolParameters.ParameterItem.Count - 1);
    }

    private void tsbSysBoolDelete_Click(object sender, EventArgs e) {
      if( _data?.SystemBoolParameters?.ParameterItem == null || tlpSysBoolValues == null || _data.SystemBoolParameters.ParameterItem.Count == 0 ) {
        return;
      }

      int deleteAt = -1;
      for( int index = 0; index < tlpSysBoolValues.RowCount; ++index ) {
        Control textBox = tlpSysBoolValues.GetControlFromPosition(0, index);
        Control checkBox = tlpSysBoolValues.GetControlFromPosition(1, index);
        if( (textBox == null || !textBox.Focused) && (checkBox == null || !checkBox.Focused) ) {
          continue;
        }

        deleteAt = index;
        if( textBox != null && checkBox != null ) {
          tlpSysBoolValues.Controls.Remove(textBox);
          tlpSysBoolValues.Controls.Remove(checkBox);
        }

        break;
      }

      if( deleteAt < 0 ) {
        deleteAt = _data.SystemBoolParameters.ParameterItem.Count - 1;
      }

      for( int index = deleteAt + 1; index < _data.SystemBoolParameters.ParameterItem.Count; ++index ) {
        Control textBox = tlpSysBoolValues.GetControlFromPosition(0, index);
        Control checkBox = tlpSysBoolValues.GetControlFromPosition(1, index);
        tlpSysBoolValues.SetRow(textBox ?? throw new InvalidOperationException(), index - 1);
        tlpSysBoolValues.SetRow(checkBox ?? throw new InvalidOperationException(), index - 1);
      }

      if( tlpSysBoolValues.RowCount > 1 ) {
        tlpSysBoolValues.RowCount -= 1;
      }

      _data.SystemBoolParameters.ParameterItem.RemoveAt(deleteAt);
    }

    private void tsbSysIntAdd_Click(object sender, EventArgs e) {
      if( _data?.SystemIntParameters?.ParameterItem == null ) {
        return;
      }

      dxParameter parameter = new dxParameter
                              {
                                  IntValue = 0
                              };
      _data.SystemIntParameters.ParameterItem.Add(parameter);
      AddIntControls(tlpSysIntValues, _data.SystemIntParameters.ParameterItem.Count - 1);
    }

    private void tsbSysIntDelete_Click(object sender, EventArgs e) {
      if( _data?.SystemIntParameters?.ParameterItem == null || tlpSysIntValues == null || _data.SystemIntParameters.ParameterItem.Count == 0 ) {
        return;
      }

      int deleteAt = -1;
      for( int index = 0; index < tlpSysIntValues.RowCount; ++index ) {
        Control textBox = tlpSysIntValues.GetControlFromPosition(0, index);
        Control valueBox = tlpSysIntValues.GetControlFromPosition(1, index);
        if( (textBox == null || !textBox.Focused) && (valueBox == null || !valueBox.Focused) ) {
          continue;
        }

        deleteAt = index;
        if( textBox != null && valueBox != null ) {
          tlpSysIntValues.Controls.Remove(textBox);
          tlpSysIntValues.Controls.Remove(valueBox);
        }

        break;
      }

      if( deleteAt < 0 ) {
        deleteAt = _data.SystemIntParameters.ParameterItem.Count - 1;
      }

      for( int index = deleteAt + 1; index < _data.SystemIntParameters.ParameterItem.Count; ++index ) {
        Control textBox = tlpSysIntValues.GetControlFromPosition(0, index);
        Control valueBox = tlpSysIntValues.GetControlFromPosition(1, index);
        tlpSysIntValues.SetRow(textBox ?? throw new InvalidOperationException(), index - 1);
        tlpSysIntValues.SetRow(valueBox ?? throw new InvalidOperationException(), index - 1);
      }

      if( tlpSysIntValues.RowCount > 1 ) {
        tlpSysIntValues.RowCount -= 1;
      }

      _data.SystemIntParameters.ParameterItem.RemoveAt(deleteAt);
    }

    private void tsbUserBoolAdd_Click(object sender, EventArgs e) {
      if( _data?.UserBoolParameters?.ParameterItem == null ) {
        return;
      }

      dxParameter parameter = new dxParameter
                              {
                                  BoolValue = false
                              };
      _data.UserBoolParameters.ParameterItem.Add(parameter);
      AddBoolControls(tlpUserBoolValues, _data.UserBoolParameters.ParameterItem.Count - 1);
    }

    private void tsbUserBoolDelete_Click(object sender, EventArgs e) {
      if( _data?.UserBoolParameters?.ParameterItem == null || tlpUserBoolValues == null || _data.UserBoolParameters.ParameterItem.Count == 0 ) {
        return;
      }

      int deleteAt = -1;
      for( int index = 0; index < tlpUserBoolValues.RowCount; ++index ) {
        Control textBox = tlpUserBoolValues.GetControlFromPosition(0, index);
        Control checkBox = tlpUserBoolValues.GetControlFromPosition(1, index);
        if( (textBox == null || !textBox.Focused) && (checkBox == null || !checkBox.Focused) ) {
          continue;
        }

        deleteAt = index;
        if( textBox != null && checkBox != null ) {
          tlpUserBoolValues.Controls.Remove(textBox);
          tlpUserBoolValues.Controls.Remove(checkBox);
        }

        break;
      }

      if( deleteAt < 0 ) {
        deleteAt = _data.UserBoolParameters.ParameterItem.Count - 1;
      }

      for( int index = deleteAt + 1; index < _data.UserBoolParameters.ParameterItem.Count; ++index ) {
        Control textBox = tlpUserBoolValues.GetControlFromPosition(0, index);
        Control checkBox = tlpUserBoolValues.GetControlFromPosition(1, index);
        tlpUserBoolValues.SetRow(textBox ?? throw new InvalidOperationException(), index - 1);
        tlpUserBoolValues.SetRow(checkBox ?? throw new InvalidOperationException(), index - 1);
      }

      if( tlpUserBoolValues.RowCount > 1 ) {
        tlpUserBoolValues.RowCount -= 1;
      }

      _data.UserBoolParameters.ParameterItem.RemoveAt(deleteAt);
    }

    private void tsbUserIntAdd_Click(object sender, EventArgs e) {
      if( _data?.UserIntParameters?.ParameterItem == null ) {
        return;
      }

      dxParameter parameter = new dxParameter
                              {
                                  IntValue = 0
                              };
      _data.UserIntParameters.ParameterItem.Add(parameter);
      AddIntControls(tlpSysIntValues, _data.UserIntParameters.ParameterItem.Count - 1);
    }

    private void tsbUserIntDelete_Click(object sender, EventArgs e) {
      if( _data?.UserIntParameters?.ParameterItem == null || tlpUserIntValues == null || _data.UserIntParameters.ParameterItem.Count == 0 ) {
        return;
      }

      int deleteAt = -1;
      for( int index = 0; index < tlpUserIntValues.RowCount; ++index ) {
        Control textBox = tlpUserIntValues.GetControlFromPosition(0, index);
        Control valueBox = tlpUserIntValues.GetControlFromPosition(1, index);
        if( (textBox == null || !textBox.Focused) && (valueBox == null || !valueBox.Focused) ) {
          continue;
        }

        deleteAt = index;
        if( textBox != null && valueBox != null ) {
          tlpUserIntValues.Controls.Remove(textBox);
          tlpUserIntValues.Controls.Remove(valueBox);
        }

        break;
      }

      if( deleteAt < 0 ) {
        deleteAt = _data.UserIntParameters.ParameterItem.Count - 1;
      }

      for( int index = deleteAt + 1; index < _data.UserIntParameters.ParameterItem.Count; ++index ) {
        Control textBox = tlpUserIntValues.GetControlFromPosition(0, index);
        Control valueBox = tlpUserIntValues.GetControlFromPosition(1, index);
        tlpUserIntValues.SetRow(textBox ?? throw new InvalidOperationException(), index - 1);
        tlpUserIntValues.SetRow(valueBox ?? throw new InvalidOperationException(), index - 1);
      }

      if( tlpUserIntValues.RowCount > 1 ) {
        tlpUserIntValues.RowCount -= 1;
      }

      _data.UserIntParameters.ParameterItem.RemoveAt(deleteAt);
    }

    #endregion Event handlers
  }
}

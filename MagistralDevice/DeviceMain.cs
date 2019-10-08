using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
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
      if( _data == null ) {
        return;
      }

      if( tbName != null ) {
        tbName.Text = _data.Attributes?.Name;
      }

      if( tbSerial != null ) {
        tbSerial.Text = _data.Attributes?.Serial;
      }

      if( tbVersion != null ) {
        tbVersion.Text = _data.Attributes?.Version;
      }
    }

    [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
    //****************************************************************************************************
    private void UpdateData() {
      if( _data == null ) {
        return;
      }

      _data.Attributes.Name = tbName?.Text;
      _data.Attributes.Serial = tbSerial?.Text;
      _data.Attributes.Version = tbVersion?.Text;
    }
    //****************************************************************************************************

    //****************************************************************************************************
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
    //****************************************************************************************************

    //****************************************************************************************************
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
    //****************************************************************************************************

    //****************************************************************************************************
    private void StopListening() {
      _radioListener = null;
    }
    //****************************************************************************************************

    #endregion

    #region Event handlers

    //****************************************************************************************************
    private void DeviceMain_Load(object sender, EventArgs e) {
      Icon = Resources.Reaktor;
      _data = dxDeviceData.Deserialize(Settings.Default?.DeviceData);
      UpdateControls();
    }
    //****************************************************************************************************

    //****************************************************************************************************
    private void DeviceMain_FormClosing(object sender, FormClosingEventArgs e) {
      if( Settings.Default == null || _data == null ) {
        return;
      }

      UpdateData();

      Settings.Default.DeviceData = _data?.Serialize();
      Settings.Default.Save();
    }
    //****************************************************************************************************

    //****************************************************************************************************
    private void tstbDeleteParameter_EnabledChanged(object sender, EventArgs e) {
      if( tstbDeleteParameter != null && tstbDeleteParameter.Enabled ) {
        tstbDeleteParameter.Image = Resources.Symbol_Delete;
      }
      else if( tstbDeleteParameter != null ) {
        tstbDeleteParameter.Image = Resources.Symbol_Delete_Disabled;
      }
    }
    //****************************************************************************************************

    //****************************************************************************************************
    private void tstbAddParameter_EnabledChanged(object sender, EventArgs e) {
      if( tstbAddParameter != null && tstbAddParameter.Enabled ) {
        tstbAddParameter.Image = Resources.Symbol_Add;
      }
      else if( tstbAddParameter != null ) {
        tstbAddParameter.Image = Resources.Symbol_Add_Disabled;
      }
    }
    //****************************************************************************************************

    //****************************************************************************************************
    private void btStartStop_Click(object sender, EventArgs e) {
      if( _radioListener == null ) {
        if( !StartListening() ) {
          return;
        }

        if( btStartStop == null ) {
          return;
        }

        btStartStop.Text = Resources.btStartStop_TextWhenWork;
        EnableControls(false);
      }
      else {
        StopListening();
        if( btStartStop == null ) {
          return;
        }

        btStartStop.Text = Resources.btStartStop_TextWhenIdle;
        EnableControls(true);
      }
    }
    //****************************************************************************************************

    #endregion

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
  }
}

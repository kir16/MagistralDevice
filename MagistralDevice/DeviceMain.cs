using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using MagistralDevice.DataClasses;
using MagistralDevice.Properties;

namespace MagistralDevice
{
  public partial class DeviceMain : Form
  {
    #region Private fields

    private DeviceData _data;

#pragma warning disable 649
    private BluetoothListener _radioListener;
#pragma warning restore 649

    private readonly object[] _interactionControls;

    #endregion

    #region Constructors

    public DeviceMain() {
      InitializeComponent();

      _interactionControls = new object[]
                             {
                                 tbName,
                                 tbSerial,
                                 tbVersion,
                                 tstbAddParameter,
                                 tstbDeleteParameter
                             };
    }

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
    private void UpdateData() {
      if( _data == null ) {
        return;
      }

      _data.Attributes.Name = tbName?.Text;
      _data.Attributes.Serial = tbSerial?.Text;
      _data.Attributes.Version = tbVersion?.Text;
    }

    //****************************************************************************************************
    private static string SerializeObject(object someObject, Type objectType) {
      if( someObject == null || objectType == null ) {
        return"";
      }

      StringBuilder builder = new StringBuilder();
      using( TextWriter writer = new StringWriter(builder) ) {
        using( XmlWriter xmlWriter = XmlWriter.Create(writer) ) {
          XmlSerializer serializer = new XmlSerializer(objectType);
          // ReSharper disable once AssignNullToNotNullAttribute
          serializer.Serialize(xmlWriter, someObject);
        }
      }

      return builder.ToString();
    }
    //****************************************************************************************************

    //****************************************************************************************************
    private static object DeserializeObject(string xml, Type resulType) {
      object result;

      if( string.IsNullOrEmpty(xml) || resulType == null ) {
        return null;
      }

      using( TextReader reader = new StringReader(xml) ) {
        using( XmlReader xmlReader = XmlReader.Create(reader) ) {
          XmlSerializer serializer = new XmlSerializer(resulType);
          result = serializer.Deserialize(xmlReader);
        }
      }

      return result;
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
        }
      }
    }
    //****************************************************************************************************

    //****************************************************************************************************
    private bool StartListening() {
      if( !BluetoothRadio.IsSupported ) {
        return false;
      }

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
    }
    //****************************************************************************************************

    #endregion

    #region Event handlers

    //****************************************************************************************************
    private void DeviceMain_Load(object sender, EventArgs e) {
      _data = (DeviceData)DeserializeObject(Settings.Default?.DeviceData, typeof(DeviceData)) ?? new DeviceData();
      UpdateControls();
    }
    //****************************************************************************************************

    //****************************************************************************************************
    private void DeviceMain_FormClosing(object sender, FormClosingEventArgs e) {
      if( Settings.Default == null || _data == null ) {
        return;
      }

      UpdateData();

      Settings.Default.DeviceData = SerializeObject(_data, typeof(DeviceData));
      Settings.Default.Save();
    }
    //****************************************************************************************************

    //****************************************************************************************************
    private void DeviceMain_Shown(object sender, EventArgs e) {
      if( BluetoothRadio.IsSupported ) {
        return;
      }

      if( MessageBox.Show(Resources.Init_DeviceNotSupported_Text, Resources.Init_DeviceNotSupported_Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel ) {
        Close();
      }
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
  }
}

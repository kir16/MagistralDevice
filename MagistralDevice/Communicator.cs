using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using InTheHand.Net.Sockets;

using MagistralDevice.DataClasses;

namespace MagistralDevice
{
  internal class Communicator : IDisposable
  {
    #region Private fields

    private readonly BluetoothListener _listener;

    #endregion

    #region Constructors

    public Communicator(string serviceName) {
      _listener = new BluetoothListener(Marshal.GetTypeLibGuidForAssembly(Assembly.GetExecutingAssembly()))
                  {
                      ServiceName = serviceName
                  };
      StopRequired = false;
    }

    #endregion

    #region Properties

    public bool StopRequired { private get; set; }

    #endregion

    #region Implementation of IDisposable

    /// <inheritdoc />
    /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
    public void Dispose() {
      _listener?.Stop();
    }

    #endregion

    #region Private methods

    [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
    private void ListenerLoop() {
      while( !StopRequired ) {
        if( StopRequired || _listener == null ) {
          return;
        }

        try {
          while( !StopRequired ) {
            BluetoothClient client = _listener.AcceptBluetoothClient();

            if( !client.Connected ) {
              continue;
            }

            StreamReader reader = new StreamReader(client.GetStream());
            string commandText = reader.ReadToEnd();
            dxCommand command = dxCommand.Deserialize(commandText);

            if( command.Name == CommandNames.Get_Attributes ) {
            }
          }
        }
        catch( Exception ) {
          return;
        }
      }
    }

    #endregion
  }
}

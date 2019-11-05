using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

using MagistralDevice.DataClasses;

namespace MagistralDevice
{
  internal class Communicator
  {
    #region Constructors

    public Communicator(DeviceMain mainForm) {
      _mainForm = mainForm;
      _stringBuilder = new StringBuilder();
    }

    #endregion Constructors

    #region Public methods

    public Task StartAsync(CancellationToken token) {
      _needCancel = false;
      token.Register(Cancel);
      return Task.Run(ListenerLoop, token);
    }

    #endregion Public methods

    #region Private fields

    private readonly DeviceMain _mainForm;

    private Socket _clientSocket;

    private bool _needCancel;

    private readonly StringBuilder _stringBuilder;

    private const string c_socket_Guid = "1AC4846F-974C-45AB-987E-F14F7F542813";

    #endregion Private fields

    #region Private methods

    [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
    private void ListenerLoop() {
      if( _stringBuilder == null ) {
        return;
      }

      BluetoothListener listener = new BluetoothListener(new Guid(c_socket_Guid))
                                   {
                                     Authenticate = false
                                   , ServiceClass = ServiceClass.Network|ServiceClass.Information
                                   };

      try {
        listener.Start();
        while( !_needCancel ) {
          if( listener.Pending() ) {
            _clientSocket = listener.AcceptSocket();
            if( _clientSocket == null ) {
              throw new ArgumentNullException(nameof(_clientSocket));
            }

            UpdateMessages($"Получено клиентское соединение для {_clientSocket.RemoteEndPoint}");

            byte[] buffer = new byte[4096];
            while( _clientSocket.Connected ) {
              try {
                int bytes = _clientSocket.Receive(buffer);
                if( bytes == 0 ) {
                  continue;
                }
                
                string message = Encoding.UTF8.GetString(buffer, 0, bytes);

                _stringBuilder.Append(message);
                string fullMessage = _stringBuilder.ToString();
                int endIndex = fullMessage.IndexOf("\r\n", StringComparison.Ordinal);
                if( endIndex < 0 ) {
                  continue;
                }

                _stringBuilder.Clear();
                UpdateMessages(@"Принята команда: " + fullMessage);

                dxCommand command = dxCommand.Deserialize(fullMessage);
                if( command == null ) {
                  continue;
                }

                // ReSharper disable once SwitchStatementMissingSomeCases
                switch( command.Name ) {
                  case CommandNames.Get_Attributes:
                  {
                    dxCommand result = new dxCommand(_mainForm.Data.Attributes)
                                       {
                                         Name = CommandNames.Get_Attributes
                                       };

                    string reply = result.Serialize() + "\r\n";
                    byte[] toSend = Encoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(reply));
                    _clientSocket.Send(toSend, toSend.Length, SocketFlags.None);
                    UpdateMessages("Отправлен ответ: " + reply);
                    break;
                  }
                  case CommandNames.Get_Parameters:
                  {
                    dxCommand result = new dxCommand(_mainForm.Data.Parameters)
                                       {
                                         Name = CommandNames.Get_Parameters
                                       };

                    string reply = result.Serialize() + "\r\n";
                    byte[] toSend = Encoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(reply));
                    _clientSocket.Send(toSend, toSend.Length, SocketFlags.None);
                    UpdateMessages("Отправлен ответ: " + reply);
                    break;
                  }
                  case CommandNames.Set_Parameters:
                  {
                    foreach( dxParameter parameter in command.Parameters.ParameterItem ) {
                      foreach( dxParameter deviceParameter in _mainForm.Data.Parameters.ParameterItem.Where(deviceParameter => deviceParameter.Id.Equals(parameter.Id)) ) {
                        switch( deviceParameter.Type ) {
                          case ParameterType.Bool:
                          {
                            deviceParameter.BoolValue = parameter.BoolValue;
                            break;
                          }
                          case ParameterType.Int:
                          {
                            deviceParameter.IntValue = parameter.IntValue;
                            break;
                          }
                          default:
                          {
                            continue;
                          }
                        }

                        UpdateParameterValue(_mainForm.Data.Parameters.ParameterItem.IndexOf(deviceParameter), deviceParameter);
                        UpdateMessages(@"Установить значение параметра " + deviceParameter.Name);
                      }
                    }
                    break;
                  }
                }
              }
              catch( IOException ex ) {
                UpdateMessages(@"Соединение разорвано: " + ex);
                break;
              }
            }
          }
          else {
            Thread.Sleep(500);
          }
        }
      }
      catch( Exception ex ) {
        UpdateMessages(ex.ToString());
      }
      finally {
        CloseCommunication();
        listener.Stop();
      }
    }

    private void Cancel() {
      _clientSocket?.Close();
      _needCancel = true;
    }

    private void CloseCommunication() {
      if( _clientSocket == null ) {
        return;
      }

      try {
        _clientSocket.Close();
      }
      catch( Exception ex ) {
        UpdateMessages(@"Ошибка при завершении соединения: " + ex);
      }
      finally {
        _clientSocket = null;
      }
    }

    private void UpdateMessages(string message) {
      _mainForm?.UpdateMessages(message);
    }

    private void UpdateParameterValue(int index, dxParameter parameter) {
      _mainForm?.UpdateParameterValue(index, parameter);
    }

    #endregion
  }
}

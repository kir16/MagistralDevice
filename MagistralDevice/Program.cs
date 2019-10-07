using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MagistralDevice.Properties;

namespace MagistralDevice
{
  internal static class Program
  {
    /// <summary>
    ///   The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main() {
      // ReSharper disable once ObjectCreationAsStatement
      Mutex isSingleInstance = new Mutex(true, Assembly.GetExecutingAssembly().GetType().GUID.ToString(), out bool owned);
      if( owned ) {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new DeviceMain());
      }
      else {
        MessageBox.Show(@"Приложение уже запущено", Resources.Magistral_Device_Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      isSingleInstance.ReleaseMutex();
    }
  }
}

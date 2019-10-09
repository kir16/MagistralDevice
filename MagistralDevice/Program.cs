using System;
using System.Reflection;
using System.Runtime.InteropServices;
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
      // Ensure single app instance
      Mutex isSingleInstance = new Mutex(true, Marshal.GetTypeLibGuidForAssembly(Assembly.GetExecutingAssembly()).ToString(), out bool owned);
      try {
        if( owned ) {
          Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);
          Application.Run(new DeviceMain());
        }
        else {
          MessageBox.Show(@"Приложение уже запущено", Resources.Magistral_Device_Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
      finally {
        isSingleInstance.ReleaseMutex();
      }
    }
  }
}

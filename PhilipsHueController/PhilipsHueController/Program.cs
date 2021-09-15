using PhilipsHueController.Helpers;
using System;
using System.Windows.Forms;

namespace PhilipsHueController
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigHelpers.DeleteSettingByKey("AppKey");
            var isApplicationRegistered = HueConnectionHelpers.IsApplicationRegistered();
            if (isApplicationRegistered)
            {
                HueConnectionHelpers.LoadConfiguredBridge();
                Application.Run(new Dashboard());

                return;
            }
            Application.Run(new SetupWindow());
        }
    }
}

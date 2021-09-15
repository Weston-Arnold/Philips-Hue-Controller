using PhilipsHueController.Helpers;
using System;
using System.Windows.Forms;

namespace PhilipsHueController
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            await HueConnectionHelpers.GetAllNearbyBridges();
            var isApplicationRegistered = HueConnectionHelpers.IsApplicationRegistered();
            if (isApplicationRegistered) 
            {
                pnlApplicationRegistration.Visible = false;
                HueConnectionHelpers.LoadConfiguredBridge();
            }
            //ConfigHelpers.DeleteSettingByKey("AppKey");
            //await HueConnectionHelpers.ConfigureBridge();
        }

        private async void btnConnectBridge_Click(object sender, EventArgs e)
        {
            await HueConnectionHelpers.ConfigureBridge();
        }
    }
}

﻿using PhilipsHueController.Helpers;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhilipsHueController
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void Dashboard_Load(object sender, System.EventArgs e)
        {
            pnlContinueSetup.Visible = false;

            var isApplicationRegistered = HueConnectionHelpers.IsApplicationRegistered();
            if (!isApplicationRegistered)
            {
                pnlContinueSetup.Visible = true;
                LaunchSetup(sender, e);

                return;
            }

            HueConnectionHelpers.LoadConfiguredBridge();
            var bridge = await HueConnectionHelpers.GetConnectedBridge();

            btnRename.Enabled = false;
            pnlContinueSetup.Visible = false;
            txtAdditionalInformation.Text = "Select a light to show additional information...";

            txtBridgeInfo.Text = $"Bridge Information - " +
                $"{bridge.Config.Name} | " +
                $"Id : {bridge.Config.BridgeId} | " +
                $"{bridge.Config.IpAddress} | " +
                $"{bridge.Config.MacAddress}";

            await LoadLightListBox();
        }

        private async Task LoadLightListBox()
        {
            lbLights.Items.Clear();

            var lightList = await HueLightHelpers.GetAllLights();

            foreach (var light in lightList.OrderBy(x => x.Name))
            {
                lbLights.Items.Add(new { 
                    Id = light.Id,
                    LightName = light.Name
                });
            }

            lbLights.DisplayMember = "LightName";
        }

        private void LaunchSetup(object sender, System.EventArgs e)
        {
            var setupWindow = new Setup();

            setupWindow.ShowDialog();

            var isApplicationRegisteredAfterWindowClose = HueConnectionHelpers.IsApplicationRegistered();
            if (isApplicationRegisteredAfterWindowClose)
            {
                Dashboard_Load(sender, e);
            }
        }

        private void btnCompleteSetup_Click(object sender, System.EventArgs e)
        {
            LaunchSetup(sender, e);
        }

        private async void btnRename_Click(object sender, System.EventArgs e)
        {
            var currentlySelectedLightIndex = lbLights.SelectedIndex;
            var renameLightWindow = new RenameLight(lbLights.SelectedItem);
            renameLightWindow.ShowDialog();

            await LoadLightListBox();
            lbLights.SelectedIndex = currentlySelectedLightIndex;
        }

        private async void lbLights_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lbLights.SelectedItem != null)
            {
                btnRename.Enabled = true;
                txtAdditionalInformation.Text = await HueLightHelpers.GetSelectedLightInformation(lbLights.SelectedItem);
            }
            else
            {
                btnRename.Enabled = false;
            }
        }

        private void btnDisconnect_Click(object sender, System.EventArgs e)
        {
            var disconnectWindow = new Disconnect();
            disconnectWindow.ShowDialog();

            var appKey = ConfigHelpers.GetSettingByKey("AppKey");
            if (string.IsNullOrEmpty(appKey))
            {
                pnlContinueSetup.Visible = true;
            }
        }
    }
}

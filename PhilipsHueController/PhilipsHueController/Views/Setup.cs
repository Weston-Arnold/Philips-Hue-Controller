using PhilipsHueController.Common.Extensions;
using System;
using System.Windows.Forms;

namespace PhilipsHueController
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void SetupWindow_Load(object sender, EventArgs e)
        {
            btnConnectBridge.Visible = false;
            lblConnectionError.Visible = false;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Text = "Searching...";
            btnConnectBridge.Visible = false;

            var bridges = await HueConnectionService.GetLocalBridgesAsync();

            lbBridgeList.Items.Clear();
            var bridgeCount = 0;

            foreach(var bridge in bridges)
            {
                bridgeCount++;
                lbBridgeList.Items.Add(new
                {
                    bridge.IpAddress,
                    bridge.BridgeId,
                    DisplayName = $"Bridge #{bridgeCount} - {bridge.BridgeId} - ({bridge.IpAddress})"
                });
            }

            lbBridgeList.DisplayMember = "DisplayName";
            btnSearch.Text = "Search Again";
        }

        private async void btnConnectBridge_Click(object sender, EventArgs e)
        {
            btnConnectBridge.Text = "Connecting...";

            var selectedItem = lbBridgeList.SelectedItem;
            var ipAddress = selectedItem.GetObjectPropertyByName("IpAddress");

            var connectedSuccessfully = await HueConnectionService.ConfigureBridgeAsync(ipAddress);
            if (!connectedSuccessfully)
            {
                lblConnectionError.Visible = true;
                btnConnectBridge.Text = "Connect Hue Bridge";
                return;
            }

            Close();
        }

        private void lbBridgeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConnectBridge.Visible = lbBridgeList.SelectedItem != null;
        }
    }
}

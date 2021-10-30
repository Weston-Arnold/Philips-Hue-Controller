using PhilipsHueController.Extensions;
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

            var bridges = await HueConnectionManager.GetNearbyBridges();

            lbBridgeList.Items.Clear();
            var count = 0;

            foreach(var bridge in bridges)
            {
                count++;
                lbBridgeList.Items.Add(new
                {
                    IpAddress = bridge.IpAddress,
                    BridgeId = bridge.BridgeId,
                    DisplayName = $"Bridge #{count} - {bridge.BridgeId} - ({bridge.IpAddress})"
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

            var connectedSuccessfully = await HueConnectionManager.ConfigureBridge(ipAddress);
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

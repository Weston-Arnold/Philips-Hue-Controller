using System;
using System.Windows.Forms;

namespace PhilipsHueController
{
    public partial class SetupWindow : Form
    {
        private string ListItemPrefix = "Bridge: ";

        public SetupWindow()
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

            var bridges = await HueConnectionHelpers.GetNearbyBridges();

            lbBridgeList.Items.Clear();
            var count = 0;

            foreach(var bridge in bridges)
            {
                count++;
                lbBridgeList.Items.Add($"{ListItemPrefix}{bridge.IpAddress}");
            }

            btnSearch.Text = "Search Again";
        }

        private async void btnConnectBridge_Click(object sender, EventArgs e)
        {
            btnConnectBridge.Text = "Connecting...";

            var selectedItem = lbBridgeList.SelectedItem.ToString();
            var ipAddress = selectedItem.Remove(0, ListItemPrefix.Length);

            var connectedSuccessfully = await HueConnectionHelpers.ConfigureBridge(ipAddress);
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

using System;
using System.Windows.Forms;

namespace PhilipsHueController
{
    public partial class SetupWindow : Form
    {
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
            var bridges = await HueConnectionHelpers.GetNearbyBridges();

            lbBridgeList.Items.Clear();
            foreach(var bridge in bridges)
            {
                lbBridgeList.Items.Add(bridge.IpAddress);
            }

            btnSearch.Text = "Search Again";
        }

        private async void btnConnectBridge_Click(object sender, EventArgs e)
        {
            var connectedSuccessfully = await HueConnectionHelpers.ConfigureBridge(lbBridgeList.SelectedItem.ToString());
            if (connectedSuccessfully)
            {
                pnlApplicationRegistration.Visible = false;
                Close();

                var dashboard = new Dashboard();
                dashboard.Show();

                return;
            }
            lblConnectionError.Visible = true;
        }

        private void lbBridgeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConnectBridge.Visible = true;
        }
    }
}

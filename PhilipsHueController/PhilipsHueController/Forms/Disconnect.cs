using PhilipsHueController.Helpers;
using System.Windows.Forms;

namespace PhilipsHueController
{
    public partial class Disconnect : Form
    {
        public Disconnect()
        {
            InitializeComponent();
        }

        private void btnDisconnect_Click(object sender, System.EventArgs e)
        {
            ConfigHelpers.DeleteSettingByKey("AppKey");
            ConfigHelpers.DeleteSettingByKey("BridgeIpAddress");

            Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}

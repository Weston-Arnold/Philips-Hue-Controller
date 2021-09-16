using PhilipsHueController.Helpers;
using System.Windows.Forms;

namespace PhilipsHueController
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, System.EventArgs e)
        {
            var isApplicationRegistered = HueConnectionHelpers.IsApplicationRegistered();
            if (isApplicationRegistered)
            {
                btnRename.Visible = false;
                pnlContinueSetup.Visible = false;

                HueConnectionHelpers.LoadConfiguredBridge();
                LoadLightListBox();

                return;
            }
            else
            {
                LaunchSetup(sender, e);
            }
        }

        private async void LoadLightListBox()
        {
            lbLights.Items.Clear();

            var lightList = await HueLightHelpers.GetAllLights();
            foreach (var light in lightList)
            {
                lbLights.Items.Add(light.Name);
            }
        }

        private void LaunchSetup(object sender, System.EventArgs e)
        {
            var setupWindow = new SetupWindow();
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

        private void btnRename_Click(object sender, System.EventArgs e)
        {
            var renameLightWindow = new RenameLightWindow(lbLights.SelectedItem.ToString());
            renameLightWindow.ShowDialog();

            LoadLightListBox();
        }

        private void lbLights_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            btnRename.Visible = lbLights.SelectedItem != null;
        }
    }
}

using PhilipsHueController.Helpers;
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
            var isApplicationRegistered = HueConnectionHelpers.IsApplicationRegistered();
            if (isApplicationRegistered)
            {
                btnRename.Enabled = false;
                pnlContinueSetup.Visible = false;
                txtAdditionalInformation.Text = "Select a light to show additional information...";

                HueConnectionHelpers.LoadConfiguredBridge();
                await LoadLightListBox();

                return;
            }
            else
            {
                LaunchSetup(sender, e);
            }
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

        private async void btnRename_Click(object sender, System.EventArgs e)
        {
            var currentlySelectedLightIndex = lbLights.SelectedIndex;
            var renameLightWindow = new RenameLightWindow(lbLights.SelectedItem);
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
    }
}

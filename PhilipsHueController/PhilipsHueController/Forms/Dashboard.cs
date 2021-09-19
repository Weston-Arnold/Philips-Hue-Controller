using PhilipsHueController.Forms;
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
            pnlContinueSetup.Visible = false;

            var isApplicationRegistered = HueConnectionHelpers.IsApplicationRegistered();
            if (!isApplicationRegistered)
            {
                pnlContinueSetup.Visible = true;
                LaunchSetup(sender, e);

                return;
            }

            HueConnectionHelpers.LoadConfiguredBridge();

            btnRename.Enabled = false;
            btnRenameGroup.Enabled = false;

            pnlContinueSetup.Visible = false;
            txtAdditionalInformation.Text = "Select a light to show additional information...";
            txtBridgeInfo.Text = await HueConnectionHelpers.GetConnectedBridgeFooterInformation();

            await LoadLightListBox();
            await LoadGroupListBox();
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

        private async Task LoadGroupListBox()
        {
            lbLightGroups.Items.Clear();

            var groupList = await HueGroupHelpers.GetAllGroups();

            foreach (var group in groupList.OrderBy(x => x.Name))
            {
                lbLightGroups.Items.Add(new
                {
                    Id = group.Id,
                    GroupName = group.Name
                });
            }

            lbLightGroups.DisplayMember = "GroupName";
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

        private async void btnRenameGroup_Click(object sender, System.EventArgs e)
        {
            var currentlySelectedGroupIndex = lbLightGroups.SelectedIndex;
            var renameGroupWindow = new RenameGroup(lbLightGroups.SelectedItem);

            renameGroupWindow.ShowDialog();

            await LoadGroupListBox();
            lbLightGroups.SelectedIndex = currentlySelectedGroupIndex;
        }

        //We use OnClick instead of SelectedindexChanged in the event the user clicks twice -- we still want the light to blip
        private async void lbLights_OnClick(object sender, System.EventArgs e)
        {
            if (lbLights.SelectedItem != null)
            {
                btnRename.Enabled = true;
                txtAdditionalInformation.Text = await HueLightHelpers.GetSelectedLightInformation(lbLights.SelectedItem);

                await HueLightHelpers.BlipSelectedLight(lbLights.SelectedItem);
            }
            else
            {
                btnRename.Enabled = false;
            }
        }

        private void lbLightGroups_OnClick(object sender, System.EventArgs e)
        {
            btnRenameGroup.Enabled = lbLightGroups.SelectedItem != null;
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

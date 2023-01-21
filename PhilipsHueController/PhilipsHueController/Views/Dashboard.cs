using PhilipsHueController.Common.Extensions;
using PhilipsHueController.Common.Helpers;
using PhilipsHueController.Controllers;
using PhilipsHueController.Forms;
using Q42.HueApi.Models.Groups;
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

            var isApplicationRegistered = HueConnectionService.IsApplicationRegistered();
            if (!isApplicationRegistered)
            {
                pnlContinueSetup.Visible = true;
                LaunchSetup(sender, e);
                return;
            }

            HueConnectionService.LoadConfiguredBridge();

            btnRenameLight.Enabled = false;
            btnEditGroup.Enabled = false;
            pnlContinueSetup.Visible = false;
            txtAdditionalInformation.Text = "Select a light or group to show additional information...";

            txtBridgeInfo.Text = await HueConnectionService.GetConnectedBridgeFooterInformation();
            ToggleActionControls(false);

            await LoadLightListBox();
            await LoadGroupListBox();
        }

        private async Task LoadLightListBox()
        {
            lbLights.Items.Clear();

            var lights = await LightController.GetAllLights();

            foreach (var light in lights.OrderBy(x => x.Name))
            {
                lbLights.Items.Add(new
                {
                    Id = light.Id,
                    LightName = light.Name
                });
            }
            lbLights.DisplayMember = "LightName";
        }

        private async Task LoadGroupListBox()
        {
            lbLightGroups.Items.Clear();

            var groups = await GroupController.GetAllGroups(GroupType.Room);

            foreach (var group in groups.OrderBy(x => x.Name))
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

            if (HueConnectionService.IsApplicationRegistered())
            {
                Dashboard_Load(sender, e);
            }
        }

        private void btnCompleteSetup_Click(object sender, System.EventArgs e)
        {
            LaunchSetup(sender, e);
        }

        private void btnRenameLight_Click(object sender, System.EventArgs e)
        {
            OpenLightEditDialogue();
        }

        private void btnEditGroup_Click(object sender, System.EventArgs e)
        {
            OpenGroupEditDialogue();
        }

        private async void OpenLightEditDialogue()
        {
            var currentlySelectedLightIndex = lbLights.SelectedIndex;
            var renameLightWindow = new RenameLight(lbLights.SelectedItem);

            renameLightWindow.ShowDialog();

            var currentlySelectedLightId = lbLights.SelectedItem.GetObjectPropertyByName("Id");

            txtAdditionalInformation.Text = await LightController.GetSelectedLightInformation(currentlySelectedLightId);
            await LoadLightListBox();

            lbLights.SelectedIndex = currentlySelectedLightIndex;
        }

        private async void OpenGroupEditDialogue()
        {
            var currentlySelectedGroupIndex = lbLightGroups.SelectedIndex;
            var currentlySelectedGroupId = lbLightGroups.SelectedItem.GetObjectPropertyByName("Id");

            var renameGroupWindow = new EditGroup(lbLightGroups.SelectedItem);

            renameGroupWindow.ShowDialog();

            txtAdditionalInformation.Text = await GroupController.GetGroupInformation(currentlySelectedGroupId);
            await LoadGroupListBox();

            lbLightGroups.SelectedIndex = currentlySelectedGroupIndex;
        }

        private void lbLights_MouseDoubleClick(object sender, System.EventArgs e)
        {
            OpenLightEditDialogue();
        }

        private void lbLightGroups_MouseDoubleClick(object sender, System.EventArgs e)
        {
            OpenGroupEditDialogue();
        }

        private async void lbLightGroups_OnClick(object sender, System.EventArgs e)
        {
            lbLights.SelectedItem = null;

            if (lbLightGroups.SelectedItem != null)
            {
                var selectedGroupId = lbLightGroups.SelectedItem.GetObjectPropertyByName("Id");

                btnEditGroup.Enabled = true;
                btnRenameLight.Enabled = false;

                ToggleActionControls(true);

                txtAdditionalInformation.Text = await GroupController.GetGroupInformation(selectedGroupId);
            }
            else
            {
                btnEditGroup.Enabled = false;
            }
        }

        private async void lbLights_OnClick(object sender, System.EventArgs e)
        {
            lbLightGroups.SelectedItem = null;

            if (lbLights.SelectedItem != null)
            {
                btnRenameLight.Enabled = true;
                btnEditGroup.Enabled = false;

                ToggleActionControls(true);

                var currentlySelectedLightId = lbLights.SelectedItem.GetObjectPropertyByName("Id");

                txtAdditionalInformation.Text = await LightController.GetSelectedLightInformation(currentlySelectedLightId);
                tbBrightness.Value = (int)(await LightController.GetLightBrightness(currentlySelectedLightId) / 25.4);

                await LightController.BlinkSelectedLight(currentlySelectedLightId);
            }
            else
            {
                btnRenameLight.Enabled = false;
            }
        }

        private void btnDisconnect_Click(object sender, System.EventArgs e)
        {
            var disconnectWindow = new Disconnect();
            disconnectWindow.ShowDialog();

            var appKey = ConfigurationHelpers.GetAppSettingByKey("AppKey");
            if (string.IsNullOrEmpty(appKey))
            {
                pnlContinueSetup.Visible = true;
            }
        }

        private async void btnLightsOn_Click(object sender, System.EventArgs e)
        {
            await ToggleButtonPower(lbLights.SelectedItem, lbLightGroups.SelectedItem, true);
        }

        private async void btnLightsOff_Click(object sender, System.EventArgs e)
        {
            await ToggleButtonPower(lbLights.SelectedItem, lbLightGroups.SelectedItem, false);
        }

        public async static Task ToggleButtonPower(object selectedLight, object selectedGroup, bool on)
        {
            if (selectedLight != null)
            {
                await LightController.SetLightOnOff(selectedLight.GetObjectPropertyByName("Id"), on);
            }

            if (selectedGroup != null)
            {
                await GroupController.ToggleGroupLightsOnOff(selectedGroup.GetObjectPropertyByName("Id"), on);
            }
        }

        private async void btnChangeColor_Click(object sender, System.EventArgs e)
        {
            var currentlySelectedLight = lbLights.SelectedItem;
            var currentlySelectedGroup = lbLightGroups.SelectedItem;

            dlgChangeColor.ShowDialog();
            var selectedColor = dlgChangeColor.Color;

            if (currentlySelectedLight != null)
            {
                var lightId = currentlySelectedLight.GetObjectPropertyByName("Id");
                
                await LightController.SetLightColor(lightId, selectedColor);
                txtAdditionalInformation.Text = await LightController.GetSelectedLightInformation(lightId);
            }

            if (currentlySelectedGroup != null)
            {
                var groupId = currentlySelectedGroup.GetObjectPropertyByName("Id");

                await GroupController.SetGroupColor(groupId, selectedColor);
                txtAdditionalInformation.Text = await GroupController.GetGroupInformation(groupId);
            }
        }

        private async void tbBrightness_Scroll(object sender, System.EventArgs e)
        {
            var currentlySelectedLight = lbLights.SelectedItem;
            var currentlySelectedGroup = lbLightGroups.SelectedItem;

            var selectedBrightness = tbBrightness.Value * 25.4;
            if (currentlySelectedLight != null)
            {
                var lightId = currentlySelectedLight.GetObjectPropertyByName("Id");

                await LightController.SetLightBrightness(lightId, (byte)selectedBrightness);
                txtAdditionalInformation.Text = await LightController.GetSelectedLightInformation(lightId);
            }

            if (currentlySelectedGroup != null)
            {
                var groupId = currentlySelectedGroup.GetObjectPropertyByName("Id");

                await GroupController.SetGroupBrightness(groupId, (byte)selectedBrightness);
                txtAdditionalInformation.Text = await GroupController.GetGroupInformation(groupId);
            }
        }

        private void ToggleActionControls(bool toggleOn)
        {
            btnChangeColor.Enabled = toggleOn;
            btnLightsOn.Enabled = toggleOn;
            btnLightsOff.Enabled = toggleOn;
            tbBrightness.Enabled = toggleOn;
        }
    }
}

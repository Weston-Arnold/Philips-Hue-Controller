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
                pnlContinueSetup.Visible = false;

                HueConnectionHelpers.LoadConfiguredBridge();
                return;
            }
            else
            {
                LaunchSetup(sender, e);
            }
        }

        private void btnCompleteSetup_Click(object sender, System.EventArgs e)
        {
            LaunchSetup(sender, e);
        }

        private void LaunchSetup(object sender, System.EventArgs e)
        {
            var setupWindow = new SetupWindow();
            setupWindow.ShowDialog();

            //Allows us to know whether the window was closed prior to connection (e.g. manually closed by user)
            //If so, reload the dashboard so we can render the Setup Button -- required before anything else on Dashboard can show
            var isApplicationRegisteredAfterWindowClose = HueConnectionHelpers.IsApplicationRegistered();
            if (isApplicationRegisteredAfterWindowClose)
            {
                Dashboard_Load(sender, e);
            }
        }
    }
}

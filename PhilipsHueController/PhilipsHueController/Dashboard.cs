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
                HueConnectionHelpers.LoadConfiguredBridge();
                return;
            }
            else
            {
                var setupWindow = new SetupWindow();
                setupWindow.ShowDialog();
            }
        }
    }
}

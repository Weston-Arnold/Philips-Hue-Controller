
namespace PhilipsHueController
{
    partial class SetupWindow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlApplicationRegistration = new System.Windows.Forms.Panel();
            this.lblConnectionError = new System.Windows.Forms.Label();
            this.lbBridgeList = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnectBridge = new System.Windows.Forms.Button();
            this.pnlApplicationRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlApplicationRegistration
            // 
            this.pnlApplicationRegistration.Controls.Add(this.lblConnectionError);
            this.pnlApplicationRegistration.Controls.Add(this.lbBridgeList);
            this.pnlApplicationRegistration.Controls.Add(this.btnSearch);
            this.pnlApplicationRegistration.Controls.Add(this.label1);
            this.pnlApplicationRegistration.Controls.Add(this.btnConnectBridge);
            this.pnlApplicationRegistration.Location = new System.Drawing.Point(2, 96);
            this.pnlApplicationRegistration.Name = "pnlApplicationRegistration";
            this.pnlApplicationRegistration.Size = new System.Drawing.Size(757, 680);
            this.pnlApplicationRegistration.TabIndex = 0;
            // 
            // lblConnectionError
            // 
            this.lblConnectionError.AutoSize = true;
            this.lblConnectionError.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionError.Location = new System.Drawing.Point(20, 616);
            this.lblConnectionError.MaximumSize = new System.Drawing.Size(750, 0);
            this.lblConnectionError.Name = "lblConnectionError";
            this.lblConnectionError.Size = new System.Drawing.Size(737, 50);
            this.lblConnectionError.TabIndex = 4;
            this.lblConnectionError.Text = "Could not connect to selected bridge. Ensure that you are pressing the button on " +
    "your Hue Bridge within 30 seconds prior to clicking the connect button.";
            // 
            // lbBridgeList
            // 
            this.lbBridgeList.FormattingEnabled = true;
            this.lbBridgeList.ItemHeight = 25;
            this.lbBridgeList.Location = new System.Drawing.Point(214, 135);
            this.lbBridgeList.Name = "lbBridgeList";
            this.lbBridgeList.Size = new System.Drawing.Size(316, 279);
            this.lbBridgeList.TabIndex = 3;
            this.lbBridgeList.SelectedIndexChanged += new System.EventHandler(this.lbBridgeList_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(214, 446);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(316, 65);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 22);
            this.label1.MaximumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the button below to search for your Hue Bridge and select the one you wish " +
    "to connect to. Once selected, press the button on your Hue bridge and click conn" +
    "ect within 30 seconds.";
            // 
            // btnConnectBridge
            // 
            this.btnConnectBridge.BackColor = System.Drawing.Color.White;
            this.btnConnectBridge.Location = new System.Drawing.Point(214, 535);
            this.btnConnectBridge.Name = "btnConnectBridge";
            this.btnConnectBridge.Size = new System.Drawing.Size(316, 64);
            this.btnConnectBridge.TabIndex = 0;
            this.btnConnectBridge.Text = "Connect Hue Bridge";
            this.btnConnectBridge.UseVisualStyleBackColor = false;
            this.btnConnectBridge.Click += new System.EventHandler(this.btnConnectBridge_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 779);
            this.Controls.Add(this.pnlApplicationRegistration);
            this.Name = "MainWindow";
            this.Text = "Philips Hue Controller";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.pnlApplicationRegistration.ResumeLayout(false);
            this.pnlApplicationRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlApplicationRegistration;
        private System.Windows.Forms.Button btnConnectBridge;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbBridgeList;
        private System.Windows.Forms.Label lblConnectionError;
    }
}


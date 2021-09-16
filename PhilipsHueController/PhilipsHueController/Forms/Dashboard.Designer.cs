
namespace PhilipsHueController
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCompleteSetup = new System.Windows.Forms.Button();
            this.pnlContinueSetup = new System.Windows.Forms.Panel();
            this.lblSetupRequiredTitle = new System.Windows.Forms.Label();
            this.lblContinueSetupPrompt = new System.Windows.Forms.Label();
            this.lbLights = new System.Windows.Forms.ListBox();
            this.lblLightListHeader = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.txtAdditionalInformation = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBridgeInfo = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.pnlContinueSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompleteSetup
            // 
            this.btnCompleteSetup.Location = new System.Drawing.Point(863, 628);
            this.btnCompleteSetup.Name = "btnCompleteSetup";
            this.btnCompleteSetup.Size = new System.Drawing.Size(344, 73);
            this.btnCompleteSetup.TabIndex = 0;
            this.btnCompleteSetup.Text = "Complete Setup";
            this.btnCompleteSetup.UseVisualStyleBackColor = true;
            this.btnCompleteSetup.Click += new System.EventHandler(this.btnCompleteSetup_Click);
            // 
            // pnlContinueSetup
            // 
            this.pnlContinueSetup.Controls.Add(this.lblSetupRequiredTitle);
            this.pnlContinueSetup.Controls.Add(this.lblContinueSetupPrompt);
            this.pnlContinueSetup.Controls.Add(this.btnCompleteSetup);
            this.pnlContinueSetup.Location = new System.Drawing.Point(2, -3);
            this.pnlContinueSetup.Name = "pnlContinueSetup";
            this.pnlContinueSetup.Size = new System.Drawing.Size(931, 60);
            this.pnlContinueSetup.TabIndex = 1;
            this.pnlContinueSetup.Visible = false;
            // 
            // lblSetupRequiredTitle
            // 
            this.lblSetupRequiredTitle.AutoSize = true;
            this.lblSetupRequiredTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSetupRequiredTitle.Location = new System.Drawing.Point(832, 344);
            this.lblSetupRequiredTitle.Name = "lblSetupRequiredTitle";
            this.lblSetupRequiredTitle.Size = new System.Drawing.Size(410, 74);
            this.lblSetupRequiredTitle.TabIndex = 2;
            this.lblSetupRequiredTitle.Text = "Setup Required";
            // 
            // lblContinueSetupPrompt
            // 
            this.lblContinueSetupPrompt.AutoSize = true;
            this.lblContinueSetupPrompt.Location = new System.Drawing.Point(668, 498);
            this.lblContinueSetupPrompt.MaximumSize = new System.Drawing.Size(750, 0);
            this.lblContinueSetupPrompt.Name = "lblContinueSetupPrompt";
            this.lblContinueSetupPrompt.Size = new System.Drawing.Size(724, 50);
            this.lblContinueSetupPrompt.TabIndex = 1;
            this.lblContinueSetupPrompt.Text = "Connection to a Philips Hue Bridge is required to use this application. Please Co" +
    "mplete the setup process before continuing.";
            this.lblContinueSetupPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLights
            // 
            this.lbLights.FormattingEnabled = true;
            this.lbLights.ItemHeight = 25;
            this.lbLights.Location = new System.Drawing.Point(27, 116);
            this.lbLights.Name = "lbLights";
            this.lbLights.ScrollAlwaysVisible = true;
            this.lbLights.Size = new System.Drawing.Size(431, 304);
            this.lbLights.TabIndex = 2;
            this.lbLights.SelectedIndexChanged += new System.EventHandler(this.lbLights_SelectedIndexChanged);
            // 
            // lblLightListHeader
            // 
            this.lblLightListHeader.AutoSize = true;
            this.lblLightListHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLightListHeader.Location = new System.Drawing.Point(27, 60);
            this.lblLightListHeader.Name = "lblLightListHeader";
            this.lblLightListHeader.Size = new System.Drawing.Size(240, 41);
            this.lblLightListHeader.TabIndex = 3;
            this.lblLightListHeader.Text = "Avbailable Lights";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(27, 442);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(431, 65);
            this.btnRename.TabIndex = 4;
            this.btnRename.Text = "Rename Light";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // txtAdditionalInformation
            // 
            this.txtAdditionalInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdditionalInformation.Enabled = false;
            this.txtAdditionalInformation.Location = new System.Drawing.Point(27, 588);
            this.txtAdditionalInformation.Name = "txtAdditionalInformation";
            this.txtAdditionalInformation.Size = new System.Drawing.Size(431, 571);
            this.txtAdditionalInformation.TabIndex = 5;
            this.txtAdditionalInformation.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Additional Information";
            // 
            // txtBridgeInfo
            // 
            this.txtBridgeInfo.AutoSize = true;
            this.txtBridgeInfo.Location = new System.Drawing.Point(27, 1175);
            this.txtBridgeInfo.Name = "txtBridgeInfo";
            this.txtBridgeInfo.Size = new System.Drawing.Size(0, 25);
            this.txtBridgeInfo.TabIndex = 7;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(1815, 1136);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(233, 61);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect Application";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2060, 1209);
            this.Controls.Add(this.pnlContinueSetup);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.txtBridgeInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdditionalInformation);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.lblLightListHeader);
            this.Controls.Add(this.lbLights);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlContinueSetup.ResumeLayout(false);
            this.pnlContinueSetup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompleteSetup;
        private System.Windows.Forms.Panel pnlContinueSetup;
        private System.Windows.Forms.Label lblContinueSetupPrompt;
        private System.Windows.Forms.Label lblSetupRequiredTitle;
        private System.Windows.Forms.ListBox lbLights;
        private System.Windows.Forms.Label lblLightListHeader;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.RichTextBox txtAdditionalInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtBridgeInfo;
        private System.Windows.Forms.Button btnDisconnect;
    }
}
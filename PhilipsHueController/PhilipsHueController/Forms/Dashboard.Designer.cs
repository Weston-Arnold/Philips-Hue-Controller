
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
            this.btnRenameLight = new System.Windows.Forms.Button();
            this.txtAdditionalInformation = new System.Windows.Forms.RichTextBox();
            this.lblAdditionalLightInformation = new System.Windows.Forms.Label();
            this.txtBridgeInfo = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lbLightRooms = new System.Windows.Forms.ListBox();
            this.lblLightRooms = new System.Windows.Forms.Label();
            this.btnEditRoom = new System.Windows.Forms.Button();
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
            this.pnlContinueSetup.Size = new System.Drawing.Size(635, 52);
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
            this.lbLights.Size = new System.Drawing.Size(391, 304);
            this.lbLights.TabIndex = 2;
            this.lbLights.Click += new System.EventHandler(this.lbLights_OnClick);
            this.lbLights.DoubleClick += new System.EventHandler(this.lbLights_MouseDoubleClick);
            // 
            // lblLightListHeader
            // 
            this.lblLightListHeader.AutoSize = true;
            this.lblLightListHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLightListHeader.Location = new System.Drawing.Point(27, 60);
            this.lblLightListHeader.Name = "lblLightListHeader";
            this.lblLightListHeader.Size = new System.Drawing.Size(147, 41);
            this.lblLightListHeader.TabIndex = 3;
            this.lblLightListHeader.Text = "My Lights";
            // 
            // btnRenameLight
            // 
            this.btnRenameLight.Location = new System.Drawing.Point(27, 442);
            this.btnRenameLight.Name = "btnRenameLight";
            this.btnRenameLight.Size = new System.Drawing.Size(391, 65);
            this.btnRenameLight.TabIndex = 4;
            this.btnRenameLight.Text = "Rename Light";
            this.btnRenameLight.UseVisualStyleBackColor = true;
            this.btnRenameLight.Click += new System.EventHandler(this.btnRenameLight_Click);
            // 
            // txtAdditionalInformation
            // 
            this.txtAdditionalInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdditionalInformation.Enabled = false;
            this.txtAdditionalInformation.Location = new System.Drawing.Point(27, 588);
            this.txtAdditionalInformation.Name = "txtAdditionalInformation";
            this.txtAdditionalInformation.Size = new System.Drawing.Size(391, 571);
            this.txtAdditionalInformation.TabIndex = 5;
            this.txtAdditionalInformation.Text = "";
            // 
            // lblAdditionalLightInformation
            // 
            this.lblAdditionalLightInformation.AutoSize = true;
            this.lblAdditionalLightInformation.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdditionalLightInformation.Location = new System.Drawing.Point(27, 533);
            this.lblAdditionalLightInformation.Name = "lblAdditionalLightInformation";
            this.lblAdditionalLightInformation.Size = new System.Drawing.Size(317, 41);
            this.lblAdditionalLightInformation.TabIndex = 6;
            this.lblAdditionalLightInformation.Text = "Additional Information";
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
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lbLightRooms
            // 
            this.lbLightRooms.FormattingEnabled = true;
            this.lbLightRooms.ItemHeight = 25;
            this.lbLightRooms.Location = new System.Drawing.Point(438, 116);
            this.lbLightRooms.Name = "lbLightRooms";
            this.lbLightRooms.ScrollAlwaysVisible = true;
            this.lbLightRooms.Size = new System.Drawing.Size(390, 304);
            this.lbLightRooms.TabIndex = 9;
            this.lbLightRooms.Click += new System.EventHandler(this.lbLightGroups_OnClick);
            this.lbLightRooms.DoubleClick += new System.EventHandler(this.lbLightGroups_MouseDoubleClick);
            // 
            // lblLightRooms
            // 
            this.lblLightRooms.AutoSize = true;
            this.lblLightRooms.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLightRooms.Location = new System.Drawing.Point(438, 60);
            this.lblLightRooms.Name = "lblLightRooms";
            this.lblLightRooms.Size = new System.Drawing.Size(160, 41);
            this.lblLightRooms.TabIndex = 10;
            this.lblLightRooms.Text = "My Rooms";
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.Location = new System.Drawing.Point(438, 442);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Size = new System.Drawing.Size(390, 65);
            this.btnEditRoom.TabIndex = 11;
            this.btnEditRoom.Text = "Edit Room";
            this.btnEditRoom.UseVisualStyleBackColor = true;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditGroup_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2060, 1209);
            this.Controls.Add(this.btnEditRoom);
            this.Controls.Add(this.lblLightRooms);
            this.Controls.Add(this.lbLightRooms);
            this.Controls.Add(this.pnlContinueSetup);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.txtBridgeInfo);
            this.Controls.Add(this.lblAdditionalLightInformation);
            this.Controls.Add(this.txtAdditionalInformation);
            this.Controls.Add(this.btnRenameLight);
            this.Controls.Add(this.lblLightListHeader);
            this.Controls.Add(this.lbLights);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button btnRenameLight;
        private System.Windows.Forms.RichTextBox txtAdditionalInformation;
        private System.Windows.Forms.Label lblAdditionalLightInformation;
        private System.Windows.Forms.Label txtBridgeInfo;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ListBox lbLightRooms;
        private System.Windows.Forms.Label lblLightRooms;
        private System.Windows.Forms.Button btnEditRoom;
    }
}
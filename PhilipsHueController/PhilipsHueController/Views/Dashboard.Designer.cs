
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
            this.lbLightGroups = new System.Windows.Forms.ListBox();
            this.lblLightRooms = new System.Windows.Forms.Label();
            this.btnEditGroup = new System.Windows.Forms.Button();
            this.txtQuickOptionsTitle = new System.Windows.Forms.Label();
            this.btnLightsOff = new System.Windows.Forms.Button();
            this.btnLightsOn = new System.Windows.Forms.Button();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.dlgChangeColor = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBrightness = new System.Windows.Forms.TrackBar();
            this.pnlContinueSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCompleteSetup
            // 
            this.btnCompleteSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleteSetup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompleteSetup.Location = new System.Drawing.Point(205, 271);
            this.btnCompleteSetup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCompleteSetup.Name = "btnCompleteSetup";
            this.btnCompleteSetup.Size = new System.Drawing.Size(275, 56);
            this.btnCompleteSetup.TabIndex = 0;
            this.btnCompleteSetup.Text = "Go to setup";
            this.btnCompleteSetup.UseVisualStyleBackColor = true;
            this.btnCompleteSetup.Click += new System.EventHandler(this.btnCompleteSetup_Click);
            // 
            // pnlContinueSetup
            // 
            this.pnlContinueSetup.Controls.Add(this.lblSetupRequiredTitle);
            this.pnlContinueSetup.Controls.Add(this.lblContinueSetupPrompt);
            this.pnlContinueSetup.Controls.Add(this.btnCompleteSetup);
            this.pnlContinueSetup.Location = new System.Drawing.Point(1, -1);
            this.pnlContinueSetup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlContinueSetup.Name = "pnlContinueSetup";
            this.pnlContinueSetup.Size = new System.Drawing.Size(699, 794);
            this.pnlContinueSetup.TabIndex = 1;
            this.pnlContinueSetup.Visible = false;
            // 
            // lblSetupRequiredTitle
            // 
            this.lblSetupRequiredTitle.AutoSize = true;
            this.lblSetupRequiredTitle.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSetupRequiredTitle.Location = new System.Drawing.Point(174, 114);
            this.lblSetupRequiredTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetupRequiredTitle.Name = "lblSetupRequiredTitle";
            this.lblSetupRequiredTitle.Size = new System.Drawing.Size(367, 59);
            this.lblSetupRequiredTitle.TabIndex = 2;
            this.lblSetupRequiredTitle.Text = "Setup Incomplete";
            // 
            // lblContinueSetupPrompt
            // 
            this.lblContinueSetupPrompt.AutoSize = true;
            this.lblContinueSetupPrompt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContinueSetupPrompt.Location = new System.Drawing.Point(174, 184);
            this.lblContinueSetupPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContinueSetupPrompt.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblContinueSetupPrompt.Name = "lblContinueSetupPrompt";
            this.lblContinueSetupPrompt.Size = new System.Drawing.Size(357, 19);
            this.lblContinueSetupPrompt.TabIndex = 1;
            this.lblContinueSetupPrompt.Text = "Please complete the setup process before continuing.";
            this.lblContinueSetupPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLights
            // 
            this.lbLights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLights.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLights.FormattingEnabled = true;
            this.lbLights.ItemHeight = 18;
            this.lbLights.Location = new System.Drawing.Point(22, 56);
            this.lbLights.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbLights.Name = "lbLights";
            this.lbLights.ScrollAlwaysVisible = true;
            this.lbLights.Size = new System.Drawing.Size(314, 166);
            this.lbLights.TabIndex = 2;
            this.lbLights.Click += new System.EventHandler(this.lbLights_OnClick);
            this.lbLights.DoubleClick += new System.EventHandler(this.lbLights_MouseDoubleClick);
            // 
            // lblLightListHeader
            // 
            this.lblLightListHeader.AutoSize = true;
            this.lblLightListHeader.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLightListHeader.Location = new System.Drawing.Point(22, 13);
            this.lblLightListHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLightListHeader.Name = "lblLightListHeader";
            this.lblLightListHeader.Size = new System.Drawing.Size(79, 33);
            this.lblLightListHeader.TabIndex = 3;
            this.lblLightListHeader.Text = "Lights";
            // 
            // btnRenameLight
            // 
            this.btnRenameLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenameLight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRenameLight.Location = new System.Drawing.Point(22, 228);
            this.btnRenameLight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRenameLight.Name = "btnRenameLight";
            this.btnRenameLight.Size = new System.Drawing.Size(313, 49);
            this.btnRenameLight.TabIndex = 4;
            this.btnRenameLight.Text = "Edit Light";
            this.btnRenameLight.UseVisualStyleBackColor = true;
            this.btnRenameLight.Click += new System.EventHandler(this.btnRenameLight_Click);
            // 
            // txtAdditionalInformation
            // 
            this.txtAdditionalInformation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAdditionalInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdditionalInformation.CausesValidation = false;
            this.txtAdditionalInformation.Enabled = false;
            this.txtAdditionalInformation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdditionalInformation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAdditionalInformation.Location = new System.Drawing.Point(22, 348);
            this.txtAdditionalInformation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAdditionalInformation.Name = "txtAdditionalInformation";
            this.txtAdditionalInformation.ReadOnly = true;
            this.txtAdditionalInformation.Size = new System.Drawing.Size(313, 383);
            this.txtAdditionalInformation.TabIndex = 5;
            this.txtAdditionalInformation.Text = "";
            // 
            // lblAdditionalLightInformation
            // 
            this.lblAdditionalLightInformation.AutoSize = true;
            this.lblAdditionalLightInformation.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdditionalLightInformation.Location = new System.Drawing.Point(22, 306);
            this.lblAdditionalLightInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdditionalLightInformation.Name = "lblAdditionalLightInformation";
            this.lblAdditionalLightInformation.Size = new System.Drawing.Size(175, 33);
            this.lblAdditionalLightInformation.TabIndex = 6;
            this.lblAdditionalLightInformation.Text = "Additional Info";
            // 
            // txtBridgeInfo
            // 
            this.txtBridgeInfo.AutoSize = true;
            this.txtBridgeInfo.Location = new System.Drawing.Point(22, 893);
            this.txtBridgeInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBridgeInfo.Name = "txtBridgeInfo";
            this.txtBridgeInfo.Size = new System.Drawing.Size(0, 19);
            this.txtBridgeInfo.TabIndex = 7;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.White;
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDisconnect.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDisconnect.Location = new System.Drawing.Point(22, 737);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(189, 47);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect Bridge";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lbLightGroups
            // 
            this.lbLightGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLightGroups.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLightGroups.FormattingEnabled = true;
            this.lbLightGroups.ItemHeight = 18;
            this.lbLightGroups.Location = new System.Drawing.Point(351, 56);
            this.lbLightGroups.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbLightGroups.Name = "lbLightGroups";
            this.lbLightGroups.ScrollAlwaysVisible = true;
            this.lbLightGroups.Size = new System.Drawing.Size(313, 166);
            this.lbLightGroups.TabIndex = 9;
            this.lbLightGroups.Click += new System.EventHandler(this.lbLightGroups_OnClick);
            this.lbLightGroups.DoubleClick += new System.EventHandler(this.lbLightGroups_MouseDoubleClick);
            // 
            // lblLightRooms
            // 
            this.lblLightRooms.AutoSize = true;
            this.lblLightRooms.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLightRooms.Location = new System.Drawing.Point(351, 13);
            this.lblLightRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLightRooms.Name = "lblLightRooms";
            this.lblLightRooms.Size = new System.Drawing.Size(90, 33);
            this.lblLightRooms.TabIndex = 10;
            this.lblLightRooms.Text = "Rooms";
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditGroup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditGroup.Location = new System.Drawing.Point(351, 228);
            this.btnEditGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Size = new System.Drawing.Size(312, 49);
            this.btnEditGroup.TabIndex = 11;
            this.btnEditGroup.Text = "Edit Room";
            this.btnEditGroup.UseVisualStyleBackColor = true;
            this.btnEditGroup.Click += new System.EventHandler(this.btnEditGroup_Click);
            // 
            // txtQuickOptionsTitle
            // 
            this.txtQuickOptionsTitle.AutoSize = true;
            this.txtQuickOptionsTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuickOptionsTitle.Location = new System.Drawing.Point(351, 306);
            this.txtQuickOptionsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtQuickOptionsTitle.Name = "txtQuickOptionsTitle";
            this.txtQuickOptionsTitle.Size = new System.Drawing.Size(200, 33);
            this.txtQuickOptionsTitle.TabIndex = 12;
            this.txtQuickOptionsTitle.Text = "Available Actions";
            // 
            // btnLightsOff
            // 
            this.btnLightsOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLightsOff.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLightsOff.Location = new System.Drawing.Point(511, 348);
            this.btnLightsOff.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLightsOff.Name = "btnLightsOff";
            this.btnLightsOff.Size = new System.Drawing.Size(165, 49);
            this.btnLightsOff.TabIndex = 13;
            this.btnLightsOff.Text = "OFF";
            this.btnLightsOff.UseVisualStyleBackColor = true;
            this.btnLightsOff.Click += new System.EventHandler(this.btnLightsOff_Click);
            // 
            // btnLightsOn
            // 
            this.btnLightsOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLightsOn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLightsOn.Location = new System.Drawing.Point(351, 348);
            this.btnLightsOn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLightsOn.Name = "btnLightsOn";
            this.btnLightsOn.Size = new System.Drawing.Size(155, 49);
            this.btnLightsOn.TabIndex = 14;
            this.btnLightsOn.Text = "ON";
            this.btnLightsOn.UseVisualStyleBackColor = true;
            this.btnLightsOn.Click += new System.EventHandler(this.btnLightsOn_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeColor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeColor.Location = new System.Drawing.Point(351, 409);
            this.btnChangeColor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(325, 49);
            this.btnChangeColor.TabIndex = 15;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(351, 488);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 33);
            this.label2.TabIndex = 17;
            this.label2.Text = "Brightness";
            // 
            // tbBrightness
            // 
            this.tbBrightness.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbBrightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbBrightness.Location = new System.Drawing.Point(351, 551);
            this.tbBrightness.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbBrightness.Minimum = 1;
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(312, 45);
            this.tbBrightness.TabIndex = 18;
            this.tbBrightness.Value = 1;
            this.tbBrightness.Scroll += new System.EventHandler(this.tbBrightness_Scroll);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(699, 792);
            this.Controls.Add(this.pnlContinueSetup);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.txtBridgeInfo);
            this.Controls.Add(this.lblAdditionalLightInformation);
            this.Controls.Add(this.txtAdditionalInformation);
            this.Controls.Add(this.btnRenameLight);
            this.Controls.Add(this.lblLightListHeader);
            this.Controls.Add(this.lbLights);
            this.Controls.Add(this.btnLightsOn);
            this.Controls.Add(this.btnLightsOff);
            this.Controls.Add(this.txtQuickOptionsTitle);
            this.Controls.Add(this.btnEditGroup);
            this.Controls.Add(this.lblLightRooms);
            this.Controls.Add(this.lbLightGroups);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.tbBrightness);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlContinueSetup.ResumeLayout(false);
            this.pnlContinueSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).EndInit();
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
        private System.Windows.Forms.ListBox lbLightGroups;
        private System.Windows.Forms.Label lblLightRooms;
        private System.Windows.Forms.Button btnEditGroup;
        private System.Windows.Forms.Label txtQuickOptionsTitle;
        private System.Windows.Forms.Button btnLightsOff;
        private System.Windows.Forms.Button btnLightsOn;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.ColorDialog dlgChangeColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbBrightness;
    }
}
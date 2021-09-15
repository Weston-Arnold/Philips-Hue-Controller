
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
            this.lblContinueSetupPrompt = new System.Windows.Forms.Label();
            this.lblSetupRequiredTitle = new System.Windows.Forms.Label();
            this.pnlContinueSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompleteSetup
            // 
            this.btnCompleteSetup.Location = new System.Drawing.Point(218, 268);
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
            this.pnlContinueSetup.Location = new System.Drawing.Point(2, 1);
            this.pnlContinueSetup.Name = "pnlContinueSetup";
            this.pnlContinueSetup.Size = new System.Drawing.Size(795, 447);
            this.pnlContinueSetup.TabIndex = 1;
            // 
            // lblContinueSetupPrompt
            // 
            this.lblContinueSetupPrompt.AutoSize = true;
            this.lblContinueSetupPrompt.Location = new System.Drawing.Point(68, 137);
            this.lblContinueSetupPrompt.MaximumSize = new System.Drawing.Size(750, 0);
            this.lblContinueSetupPrompt.Name = "lblContinueSetupPrompt";
            this.lblContinueSetupPrompt.Size = new System.Drawing.Size(729, 50);
            this.lblContinueSetupPrompt.TabIndex = 1;
            this.lblContinueSetupPrompt.Text = "Connection to a Philips Hue Bridge is required to use this application. Please Co" +
    "mplete the setup process before continuing.";
            // 
            // lblSetupRequiredTitle
            // 
            this.lblSetupRequiredTitle.AutoSize = true;
            this.lblSetupRequiredTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSetupRequiredTitle.Location = new System.Drawing.Point(187, 27);
            this.lblSetupRequiredTitle.Name = "lblSetupRequiredTitle";
            this.lblSetupRequiredTitle.Size = new System.Drawing.Size(410, 74);
            this.lblSetupRequiredTitle.TabIndex = 2;
            this.lblSetupRequiredTitle.Text = "Setup Required";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContinueSetup);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlContinueSetup.ResumeLayout(false);
            this.pnlContinueSetup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompleteSetup;
        private System.Windows.Forms.Panel pnlContinueSetup;
        private System.Windows.Forms.Label lblContinueSetupPrompt;
        private System.Windows.Forms.Label lblSetupRequiredTitle;
    }
}
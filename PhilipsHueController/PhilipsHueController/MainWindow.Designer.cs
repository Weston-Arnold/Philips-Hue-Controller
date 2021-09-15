
namespace PhilipsHueController
{
    partial class MainWindow
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
            this.btnConnectBridge = new System.Windows.Forms.Button();
            this.pnlApplicationRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlApplicationRegistration
            // 
            this.pnlApplicationRegistration.Controls.Add(this.btnConnectBridge);
            this.pnlApplicationRegistration.Location = new System.Drawing.Point(2, 104);
            this.pnlApplicationRegistration.Name = "pnlApplicationRegistration";
            this.pnlApplicationRegistration.Size = new System.Drawing.Size(1235, 672);
            this.pnlApplicationRegistration.TabIndex = 0;
            // 
            // btnConnectBridge
            // 
            this.btnConnectBridge.Location = new System.Drawing.Point(486, 304);
            this.btnConnectBridge.Name = "btnConnectBridge";
            this.btnConnectBridge.Size = new System.Drawing.Size(262, 64);
            this.btnConnectBridge.TabIndex = 0;
            this.btnConnectBridge.Text = "Connect Hue Bridge";
            this.btnConnectBridge.UseVisualStyleBackColor = true;
            this.btnConnectBridge.Click += new System.EventHandler(this.btnConnectBridge_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 779);
            this.Controls.Add(this.pnlApplicationRegistration);
            this.Name = "MainWindow";
            this.Text = "Philips Hue Controller";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.pnlApplicationRegistration.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlApplicationRegistration;
        private System.Windows.Forms.Button btnConnectBridge;
    }
}


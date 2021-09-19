
namespace PhilipsHueController.Forms
{
    partial class ErrorMessage
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
            this.txtErrorMessage = new System.Windows.Forms.Label();
            this.btnCloseErrorMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtErrorMessage
            // 
            this.txtErrorMessage.AutoSize = true;
            this.txtErrorMessage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.txtErrorMessage.Location = new System.Drawing.Point(31, 21);
            this.txtErrorMessage.MaximumSize = new System.Drawing.Size(300, 0);
            this.txtErrorMessage.MinimumSize = new System.Drawing.Size(500, 0);
            this.txtErrorMessage.Name = "txtErrorMessage";
            this.txtErrorMessage.Size = new System.Drawing.Size(500, 30);
            this.txtErrorMessage.TabIndex = 0;
            this.txtErrorMessage.Text = " ";
            this.txtErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseErrorMessage
            // 
            this.btnCloseErrorMessage.Location = new System.Drawing.Point(173, 112);
            this.btnCloseErrorMessage.Name = "btnCloseErrorMessage";
            this.btnCloseErrorMessage.Size = new System.Drawing.Size(219, 49);
            this.btnCloseErrorMessage.TabIndex = 1;
            this.btnCloseErrorMessage.Text = "Close";
            this.btnCloseErrorMessage.UseVisualStyleBackColor = true;
            this.btnCloseErrorMessage.Click += new System.EventHandler(this.btnCloseErrorMessage_Click);
            // 
            // ErrorMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 184);
            this.Controls.Add(this.btnCloseErrorMessage);
            this.Controls.Add(this.txtErrorMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtErrorMessage;
        private System.Windows.Forms.Button btnCloseErrorMessage;
    }
}

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
            this.txtErrorMessage.Location = new System.Drawing.Point(279, 44);
            this.txtErrorMessage.Name = "txtErrorMessage";
            this.txtErrorMessage.Size = new System.Drawing.Size(0, 25);
            this.txtErrorMessage.TabIndex = 0;
            // 
            // btnCloseErrorMessage
            // 
            this.btnCloseErrorMessage.Location = new System.Drawing.Point(136, 95);
            this.btnCloseErrorMessage.Name = "btnCloseErrorMessage";
            this.btnCloseErrorMessage.Size = new System.Drawing.Size(289, 65);
            this.btnCloseErrorMessage.TabIndex = 1;
            this.btnCloseErrorMessage.Text = "Close";
            this.btnCloseErrorMessage.UseVisualStyleBackColor = true;
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
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtErrorMessage;
        private System.Windows.Forms.Button btnCloseErrorMessage;
    }
}
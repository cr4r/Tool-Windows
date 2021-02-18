
namespace Tool_Windows
{
    partial class Menu
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
            this.btnNordVPN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNordVPN
            // 
            this.btnNordVPN.Location = new System.Drawing.Point(12, 12);
            this.btnNordVPN.Name = "btnNordVPN";
            this.btnNordVPN.Size = new System.Drawing.Size(99, 34);
            this.btnNordVPN.TabIndex = 0;
            this.btnNordVPN.Text = "NordVPN";
            this.btnNordVPN.UseVisualStyleBackColor = true;
            this.btnNordVPN.Click += new System.EventHandler(this.btnNordVPN_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 313);
            this.Controls.Add(this.btnNordVPN);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNordVPN;
    }
}


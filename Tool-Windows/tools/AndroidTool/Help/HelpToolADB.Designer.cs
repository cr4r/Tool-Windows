
namespace Tool_Windows.tools.AndroidTool.Help
{
    partial class HelpToolADB
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInstallAPK = new System.Windows.Forms.TabPage();
            this.rtbInstallAPK = new System.Windows.Forms.RichTextBox();
            this.tabBackup = new System.Windows.Forms.TabPage();
            this.tabSideload = new System.Windows.Forms.TabPage();
            this.tabWireles = new System.Windows.Forms.TabPage();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.rtbAdbWireles = new System.Windows.Forms.RichTextBox();
            this.rtbBackup = new System.Windows.Forms.RichTextBox();
            this.rtbSideload = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabInstallAPK.SuspendLayout();
            this.tabBackup.SuspendLayout();
            this.tabSideload.SuspendLayout();
            this.tabWireles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInstallAPK);
            this.tabControl1.Controls.Add(this.tabBackup);
            this.tabControl1.Controls.Add(this.tabSideload);
            this.tabControl1.Controls.Add(this.tabWireles);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 512);
            this.tabControl1.TabIndex = 1;
            // 
            // tabInstallAPK
            // 
            this.tabInstallAPK.Controls.Add(this.rtbInstallAPK);
            this.tabInstallAPK.Location = new System.Drawing.Point(4, 22);
            this.tabInstallAPK.Name = "tabInstallAPK";
            this.tabInstallAPK.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstallAPK.Size = new System.Drawing.Size(420, 486);
            this.tabInstallAPK.TabIndex = 1;
            this.tabInstallAPK.Text = "Install APK";
            this.tabInstallAPK.UseVisualStyleBackColor = true;
            // 
            // rtbInstallAPK
            // 
            this.rtbInstallAPK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInstallAPK.Location = new System.Drawing.Point(3, 3);
            this.rtbInstallAPK.Name = "rtbInstallAPK";
            this.rtbInstallAPK.Size = new System.Drawing.Size(414, 480);
            this.rtbInstallAPK.TabIndex = 0;
            this.rtbInstallAPK.Text = "";
            // 
            // tabBackup
            // 
            this.tabBackup.Controls.Add(this.rtbBackup);
            this.tabBackup.Location = new System.Drawing.Point(4, 22);
            this.tabBackup.Name = "tabBackup";
            this.tabBackup.Size = new System.Drawing.Size(420, 486);
            this.tabBackup.TabIndex = 2;
            this.tabBackup.Text = "Backup";
            this.tabBackup.UseVisualStyleBackColor = true;
            // 
            // tabSideload
            // 
            this.tabSideload.Controls.Add(this.rtbSideload);
            this.tabSideload.Location = new System.Drawing.Point(4, 22);
            this.tabSideload.Name = "tabSideload";
            this.tabSideload.Padding = new System.Windows.Forms.Padding(3);
            this.tabSideload.Size = new System.Drawing.Size(420, 486);
            this.tabSideload.TabIndex = 0;
            this.tabSideload.Text = "Sideload";
            this.tabSideload.UseVisualStyleBackColor = true;
            // 
            // tabWireles
            // 
            this.tabWireles.Controls.Add(this.rtbAdbWireles);
            this.tabWireles.Location = new System.Drawing.Point(4, 22);
            this.tabWireles.Name = "tabWireles";
            this.tabWireles.Size = new System.Drawing.Size(420, 486);
            this.tabWireles.TabIndex = 3;
            this.tabWireles.Text = "ADB Wireles";
            this.tabWireles.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.DisabledState.Parent = this.btnClose;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(0, 512);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(428, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rtbAdbWireles
            // 
            this.rtbAdbWireles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAdbWireles.Location = new System.Drawing.Point(0, 0);
            this.rtbAdbWireles.Name = "rtbAdbWireles";
            this.rtbAdbWireles.Size = new System.Drawing.Size(420, 486);
            this.rtbAdbWireles.TabIndex = 0;
            this.rtbAdbWireles.Text = "";
            // 
            // rtbBackup
            // 
            this.rtbBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbBackup.Location = new System.Drawing.Point(0, 0);
            this.rtbBackup.Name = "rtbBackup";
            this.rtbBackup.Size = new System.Drawing.Size(420, 486);
            this.rtbBackup.TabIndex = 1;
            this.rtbBackup.Text = "";
            // 
            // rtbSideload
            // 
            this.rtbSideload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSideload.Location = new System.Drawing.Point(3, 3);
            this.rtbSideload.Name = "rtbSideload";
            this.rtbSideload.Size = new System.Drawing.Size(414, 480);
            this.rtbSideload.TabIndex = 1;
            this.rtbSideload.Text = "";
            // 
            // HelpToolADB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(428, 542);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpToolADB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpToolADB";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabInstallAPK.ResumeLayout(false);
            this.tabBackup.ResumeLayout(false);
            this.tabSideload.ResumeLayout(false);
            this.tabWireles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInstallAPK;
        private System.Windows.Forms.RichTextBox rtbInstallAPK;
        private System.Windows.Forms.TabPage tabBackup;
        private System.Windows.Forms.TabPage tabSideload;
        private System.Windows.Forms.TabPage tabWireles;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.RichTextBox rtbAdbWireles;
        private System.Windows.Forms.RichTextBox rtbBackup;
        private System.Windows.Forms.RichTextBox rtbSideload;
    }
}
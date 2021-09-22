
namespace Tool_Windows.tools
{
    partial class frmFile
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
            this.btnCopy = new Guna.UI2.WinForms.Guna2Button();
            this.lblPersen = new System.Windows.Forms.Label();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseTarget = new Guna.UI2.WinForms.Guna2Button();
            this.btnBrowseSource = new Guna.UI2.WinForms.Guna2Button();
            this.txtTarget = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstFile = new System.Windows.Forms.ListBox();
            this.lstDone = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopy.CheckedState.Parent = this.btnCopy;
            this.btnCopy.CustomImages.Parent = this.btnCopy;
            this.btnCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCopy.DisabledState.Parent = this.btnCopy;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.HoverState.Parent = this.btnCopy;
            this.btnCopy.Location = new System.Drawing.Point(199, 181);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ShadowDecoration.Parent = this.btnCopy;
            this.btnCopy.Size = new System.Drawing.Size(119, 30);
            this.btnCopy.TabIndex = 17;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblPersen
            // 
            this.lblPersen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPersen.Location = new System.Drawing.Point(453, 118);
            this.lblPersen.Name = "lblPersen";
            this.lblPersen.Size = new System.Drawing.Size(57, 24);
            this.lblPersen.TabIndex = 16;
            this.lblPersen.Text = "0%";
            this.lblPersen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ProgressBar1.Location = new System.Drawing.Point(15, 145);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(495, 30);
            this.guna2ProgressBar1.TabIndex = 15;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Target";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowseTarget
            // 
            this.btnBrowseTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseTarget.CheckedState.Parent = this.btnBrowseTarget;
            this.btnBrowseTarget.CustomImages.Parent = this.btnBrowseTarget;
            this.btnBrowseTarget.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseTarget.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseTarget.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowseTarget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowseTarget.DisabledState.Parent = this.btnBrowseTarget;
            this.btnBrowseTarget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseTarget.ForeColor = System.Drawing.Color.White;
            this.btnBrowseTarget.HoverState.Parent = this.btnBrowseTarget;
            this.btnBrowseTarget.Location = new System.Drawing.Point(469, 69);
            this.btnBrowseTarget.Name = "btnBrowseTarget";
            this.btnBrowseTarget.ShadowDecoration.Parent = this.btnBrowseTarget;
            this.btnBrowseTarget.Size = new System.Drawing.Size(41, 30);
            this.btnBrowseTarget.TabIndex = 12;
            this.btnBrowseTarget.Text = "...";
            this.btnBrowseTarget.Click += new System.EventHandler(this.btnBrowseTarget_Click);
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSource.CheckedState.Parent = this.btnBrowseSource;
            this.btnBrowseSource.CustomImages.Parent = this.btnBrowseSource;
            this.btnBrowseSource.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseSource.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseSource.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowseSource.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowseSource.DisabledState.Parent = this.btnBrowseSource;
            this.btnBrowseSource.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseSource.ForeColor = System.Drawing.Color.White;
            this.btnBrowseSource.HoverState.Parent = this.btnBrowseSource;
            this.btnBrowseSource.Location = new System.Drawing.Point(15, 20);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.ShadowDecoration.Parent = this.btnBrowseSource;
            this.btnBrowseSource.Size = new System.Drawing.Size(495, 29);
            this.btnBrowseSource.TabIndex = 11;
            this.btnBrowseSource.Text = "Pilih File";
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarget.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTarget.DefaultText = "C:\\Users\\fatur\\Music";
            this.txtTarget.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTarget.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTarget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTarget.DisabledState.Parent = this.txtTarget;
            this.txtTarget.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTarget.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTarget.FocusedState.Parent = this.txtTarget;
            this.txtTarget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTarget.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTarget.HoverState.Parent = this.txtTarget;
            this.txtTarget.Location = new System.Drawing.Point(84, 69);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.PasswordChar = '\0';
            this.txtTarget.PlaceholderText = "Lokasi File Target Terakhir";
            this.txtTarget.SelectedText = "";
            this.txtTarget.SelectionStart = 20;
            this.txtTarget.ShadowDecoration.Parent = this.txtTarget;
            this.txtTarget.Size = new System.Drawing.Size(379, 30);
            this.txtTarget.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTarget);
            this.panel1.Controls.Add(this.guna2ProgressBar1);
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.btnBrowseTarget);
            this.panel1.Controls.Add(this.btnBrowseSource);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPersen);
            this.panel1.Location = new System.Drawing.Point(12, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 227);
            this.panel1.TabIndex = 18;
            // 
            // lstFile
            // 
            this.lstFile.FormattingEnabled = true;
            this.lstFile.Location = new System.Drawing.Point(12, 13);
            this.lstFile.Name = "lstFile";
            this.lstFile.Size = new System.Drawing.Size(521, 69);
            this.lstFile.TabIndex = 19;
            // 
            // lstDone
            // 
            this.lstDone.FormattingEnabled = true;
            this.lstDone.Location = new System.Drawing.Point(12, 103);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(521, 69);
            this.lstDone.TabIndex = 20;
            // 
            // frmFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 428);
            this.Controls.Add(this.lstDone);
            this.Controls.Add(this.lstFile);
            this.Controls.Add(this.panel1);
            this.Name = "frmFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFile";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCopy;
        private System.Windows.Forms.Label lblPersen;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnBrowseTarget;
        private Guna.UI2.WinForms.Guna2Button btnBrowseSource;
        private Guna.UI2.WinForms.Guna2TextBox txtTarget;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstFile;
        private System.Windows.Forms.ListBox lstDone;
    }
}
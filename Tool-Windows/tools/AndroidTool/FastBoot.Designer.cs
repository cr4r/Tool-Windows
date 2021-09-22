
namespace Tool_Windows.tools.AndroidTool
{
    partial class FastBoot
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.gbAdvanced = new System.Windows.Forms.GroupBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblJudulLetakADB = new System.Windows.Forms.Label();
            this.txtLetakADB = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbFastbootOptions = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnBoot = new Guna.UI2.WinForms.Guna2Button();
            this.txtBoot = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRecovery = new Guna.UI2.WinForms.Guna2Button();
            this.txtRecovery = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLockBootLoader = new Guna.UI2.WinForms.Guna2Button();
            this.btnUnlockBootloader = new Guna.UI2.WinForms.Guna2Button();
            this.btnRebootFastboot = new Guna.UI2.WinForms.Guna2Button();
            this.txtZipFile = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnZipFile = new Guna.UI2.WinForms.Guna2Button();
            this.btnSystem = new Guna.UI2.WinForms.Guna2Button();
            this.txtSystem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnData = new Guna.UI2.WinForms.Guna2Button();
            this.txtData = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbAdvanced.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.gbFastbootOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbConsole
            // 
            this.rtbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbConsole.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rtbConsole.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbConsole.Location = new System.Drawing.Point(0, 369);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.Size = new System.Drawing.Size(596, 80);
            this.rtbConsole.TabIndex = 29;
            this.rtbConsole.Text = ">> ";
            // 
            // gbAdvanced
            // 
            this.gbAdvanced.Controls.Add(this.guna2Panel1);
            this.gbAdvanced.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbAdvanced.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAdvanced.Location = new System.Drawing.Point(0, 0);
            this.gbAdvanced.Name = "gbAdvanced";
            this.gbAdvanced.Size = new System.Drawing.Size(596, 79);
            this.gbAdvanced.TabIndex = 32;
            this.gbAdvanced.TabStop = false;
            this.gbAdvanced.Text = "Advanced";
            this.gbAdvanced.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblJudulLetakADB);
            this.guna2Panel1.Controls.Add(this.txtLetakADB);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 16);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(182, 60);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblJudulLetakADB
            // 
            this.lblJudulLetakADB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJudulLetakADB.Location = new System.Drawing.Point(17, 13);
            this.lblJudulLetakADB.Name = "lblJudulLetakADB";
            this.lblJudulLetakADB.Size = new System.Drawing.Size(145, 13);
            this.lblJudulLetakADB.TabIndex = 3;
            this.lblJudulLetakADB.Text = "Letak Fastboot";
            this.lblJudulLetakADB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLetakADB
            // 
            this.txtLetakADB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLetakADB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLetakADB.DefaultText = "fastboot.exe";
            this.txtLetakADB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLetakADB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLetakADB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLetakADB.DisabledState.Parent = this.txtLetakADB;
            this.txtLetakADB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLetakADB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLetakADB.FocusedState.Parent = this.txtLetakADB;
            this.txtLetakADB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLetakADB.ForeColor = System.Drawing.Color.Black;
            this.txtLetakADB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLetakADB.HoverState.Parent = this.txtLetakADB;
            this.txtLetakADB.Location = new System.Drawing.Point(13, 29);
            this.txtLetakADB.Name = "txtLetakADB";
            this.txtLetakADB.PasswordChar = '\0';
            this.txtLetakADB.PlaceholderText = "adb.exe";
            this.txtLetakADB.SelectedText = "";
            this.txtLetakADB.ShadowDecoration.Parent = this.txtLetakADB;
            this.txtLetakADB.Size = new System.Drawing.Size(149, 19);
            this.txtLetakADB.TabIndex = 2;
            // 
            // gbFastbootOptions
            // 
            this.gbFastbootOptions.BorderColor = System.Drawing.Color.Yellow;
            this.gbFastbootOptions.BorderRadius = 25;
            this.gbFastbootOptions.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.gbFastbootOptions.Controls.Add(this.btnBoot);
            this.gbFastbootOptions.Controls.Add(this.txtBoot);
            this.gbFastbootOptions.Controls.Add(this.btnRecovery);
            this.gbFastbootOptions.Controls.Add(this.txtRecovery);
            this.gbFastbootOptions.Controls.Add(this.btnLockBootLoader);
            this.gbFastbootOptions.Controls.Add(this.btnUnlockBootloader);
            this.gbFastbootOptions.Controls.Add(this.btnRebootFastboot);
            this.gbFastbootOptions.Controls.Add(this.txtZipFile);
            this.gbFastbootOptions.Controls.Add(this.btnZipFile);
            this.gbFastbootOptions.Controls.Add(this.btnSystem);
            this.gbFastbootOptions.Controls.Add(this.txtSystem);
            this.gbFastbootOptions.Controls.Add(this.btnData);
            this.gbFastbootOptions.Controls.Add(this.txtData);
            this.gbFastbootOptions.CustomBorderColor = System.Drawing.Color.MidnightBlue;
            this.gbFastbootOptions.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.gbFastbootOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFastbootOptions.FillColor = System.Drawing.Color.Transparent;
            this.gbFastbootOptions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbFastbootOptions.ForeColor = System.Drawing.Color.White;
            this.gbFastbootOptions.Location = new System.Drawing.Point(0, 79);
            this.gbFastbootOptions.Name = "gbFastbootOptions";
            this.gbFastbootOptions.ShadowDecoration.Parent = this.gbFastbootOptions;
            this.gbFastbootOptions.Size = new System.Drawing.Size(596, 257);
            this.gbFastbootOptions.TabIndex = 33;
            this.gbFastbootOptions.Text = "Fastboot Options";
            // 
            // btnBoot
            // 
            this.btnBoot.BorderRadius = 5;
            this.btnBoot.CheckedState.Parent = this.btnBoot;
            this.btnBoot.CustomImages.Parent = this.btnBoot;
            this.btnBoot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBoot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBoot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBoot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBoot.DisabledState.Parent = this.btnBoot;
            this.btnBoot.FillColor = System.Drawing.Color.Green;
            this.btnBoot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBoot.ForeColor = System.Drawing.Color.White;
            this.btnBoot.HoverState.Parent = this.btnBoot;
            this.btnBoot.Location = new System.Drawing.Point(8, 214);
            this.btnBoot.Name = "btnBoot";
            this.btnBoot.ShadowDecoration.Parent = this.btnBoot;
            this.btnBoot.Size = new System.Drawing.Size(74, 25);
            this.btnBoot.TabIndex = 23;
            this.btnBoot.Text = "Boot";
            // 
            // txtBoot
            // 
            this.txtBoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoot.BorderRadius = 3;
            this.txtBoot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoot.DefaultText = "";
            this.txtBoot.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoot.DisabledState.Parent = this.txtBoot;
            this.txtBoot.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoot.FocusedState.Parent = this.txtBoot;
            this.txtBoot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoot.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoot.HoverState.Parent = this.txtBoot;
            this.txtBoot.Location = new System.Drawing.Point(91, 214);
            this.txtBoot.Name = "txtBoot";
            this.txtBoot.PasswordChar = '\0';
            this.txtBoot.PlaceholderText = "Lokasi File";
            this.txtBoot.SelectedText = "";
            this.txtBoot.ShadowDecoration.Parent = this.txtBoot;
            this.txtBoot.Size = new System.Drawing.Size(499, 25);
            this.txtBoot.TabIndex = 24;
            // 
            // btnRecovery
            // 
            this.btnRecovery.BorderRadius = 5;
            this.btnRecovery.CheckedState.Parent = this.btnRecovery;
            this.btnRecovery.CustomImages.Parent = this.btnRecovery;
            this.btnRecovery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecovery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRecovery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecovery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRecovery.DisabledState.Parent = this.btnRecovery;
            this.btnRecovery.FillColor = System.Drawing.Color.Green;
            this.btnRecovery.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRecovery.ForeColor = System.Drawing.Color.White;
            this.btnRecovery.HoverState.Parent = this.btnRecovery;
            this.btnRecovery.Location = new System.Drawing.Point(8, 183);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.ShadowDecoration.Parent = this.btnRecovery;
            this.btnRecovery.Size = new System.Drawing.Size(74, 25);
            this.btnRecovery.TabIndex = 21;
            this.btnRecovery.Text = "Recovery";
            this.btnRecovery.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtRecovery
            // 
            this.txtRecovery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecovery.BorderRadius = 3;
            this.txtRecovery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecovery.DefaultText = "";
            this.txtRecovery.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRecovery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRecovery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecovery.DisabledState.Parent = this.txtRecovery;
            this.txtRecovery.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecovery.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRecovery.FocusedState.Parent = this.txtRecovery;
            this.txtRecovery.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRecovery.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRecovery.HoverState.Parent = this.txtRecovery;
            this.txtRecovery.Location = new System.Drawing.Point(91, 183);
            this.txtRecovery.Name = "txtRecovery";
            this.txtRecovery.PasswordChar = '\0';
            this.txtRecovery.PlaceholderText = "Lokasi File";
            this.txtRecovery.SelectedText = "";
            this.txtRecovery.ShadowDecoration.Parent = this.txtRecovery;
            this.txtRecovery.Size = new System.Drawing.Size(499, 25);
            this.txtRecovery.TabIndex = 22;
            // 
            // btnLockBootLoader
            // 
            this.btnLockBootLoader.BorderRadius = 5;
            this.btnLockBootLoader.CheckedState.Parent = this.btnLockBootLoader;
            this.btnLockBootLoader.CustomImages.Parent = this.btnLockBootLoader;
            this.btnLockBootLoader.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLockBootLoader.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLockBootLoader.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLockBootLoader.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLockBootLoader.DisabledState.Parent = this.btnLockBootLoader;
            this.btnLockBootLoader.FillColor = System.Drawing.Color.Aqua;
            this.btnLockBootLoader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLockBootLoader.ForeColor = System.Drawing.Color.Black;
            this.btnLockBootLoader.HoverState.Parent = this.btnLockBootLoader;
            this.btnLockBootLoader.Location = new System.Drawing.Point(86, 44);
            this.btnLockBootLoader.Name = "btnLockBootLoader";
            this.btnLockBootLoader.ShadowDecoration.Parent = this.btnLockBootLoader;
            this.btnLockBootLoader.Size = new System.Drawing.Size(114, 25);
            this.btnLockBootLoader.TabIndex = 13;
            this.btnLockBootLoader.Text = "Lock Bootloader";
            // 
            // btnUnlockBootloader
            // 
            this.btnUnlockBootloader.BorderRadius = 5;
            this.btnUnlockBootloader.CheckedState.Parent = this.btnUnlockBootloader;
            this.btnUnlockBootloader.CustomImages.Parent = this.btnUnlockBootloader;
            this.btnUnlockBootloader.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUnlockBootloader.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUnlockBootloader.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUnlockBootloader.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUnlockBootloader.DisabledState.Parent = this.btnUnlockBootloader;
            this.btnUnlockBootloader.FillColor = System.Drawing.Color.Aqua;
            this.btnUnlockBootloader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUnlockBootloader.ForeColor = System.Drawing.Color.Black;
            this.btnUnlockBootloader.HoverState.Parent = this.btnUnlockBootloader;
            this.btnUnlockBootloader.Location = new System.Drawing.Point(206, 44);
            this.btnUnlockBootloader.Name = "btnUnlockBootloader";
            this.btnUnlockBootloader.ShadowDecoration.Parent = this.btnUnlockBootloader;
            this.btnUnlockBootloader.Size = new System.Drawing.Size(127, 25);
            this.btnUnlockBootloader.TabIndex = 14;
            this.btnUnlockBootloader.Text = "Unlock Bootloader";
            // 
            // btnRebootFastboot
            // 
            this.btnRebootFastboot.BorderRadius = 5;
            this.btnRebootFastboot.CheckedState.Parent = this.btnRebootFastboot;
            this.btnRebootFastboot.CustomImages.Parent = this.btnRebootFastboot;
            this.btnRebootFastboot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRebootFastboot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRebootFastboot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRebootFastboot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRebootFastboot.DisabledState.Parent = this.btnRebootFastboot;
            this.btnRebootFastboot.FillColor = System.Drawing.Color.Aqua;
            this.btnRebootFastboot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRebootFastboot.ForeColor = System.Drawing.Color.Black;
            this.btnRebootFastboot.HoverState.Parent = this.btnRebootFastboot;
            this.btnRebootFastboot.Location = new System.Drawing.Point(8, 44);
            this.btnRebootFastboot.Name = "btnRebootFastboot";
            this.btnRebootFastboot.ShadowDecoration.Parent = this.btnRebootFastboot;
            this.btnRebootFastboot.Size = new System.Drawing.Size(74, 25);
            this.btnRebootFastboot.TabIndex = 12;
            this.btnRebootFastboot.Text = "Reboot";
            // 
            // txtZipFile
            // 
            this.txtZipFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZipFile.BorderRadius = 3;
            this.txtZipFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtZipFile.DefaultText = "";
            this.txtZipFile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtZipFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtZipFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtZipFile.DisabledState.Parent = this.txtZipFile;
            this.txtZipFile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtZipFile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtZipFile.FocusedState.Parent = this.txtZipFile;
            this.txtZipFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtZipFile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtZipFile.HoverState.Parent = this.txtZipFile;
            this.txtZipFile.Location = new System.Drawing.Point(90, 75);
            this.txtZipFile.Name = "txtZipFile";
            this.txtZipFile.PasswordChar = '\0';
            this.txtZipFile.PlaceholderText = "Lokasi File";
            this.txtZipFile.SelectedText = "";
            this.txtZipFile.ShadowDecoration.Parent = this.txtZipFile;
            this.txtZipFile.Size = new System.Drawing.Size(500, 25);
            this.txtZipFile.TabIndex = 16;
            // 
            // btnZipFile
            // 
            this.btnZipFile.BorderRadius = 5;
            this.btnZipFile.CheckedState.Parent = this.btnZipFile;
            this.btnZipFile.CustomImages.Parent = this.btnZipFile;
            this.btnZipFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnZipFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnZipFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnZipFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnZipFile.DisabledState.Parent = this.btnZipFile;
            this.btnZipFile.FillColor = System.Drawing.Color.Green;
            this.btnZipFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnZipFile.ForeColor = System.Drawing.Color.White;
            this.btnZipFile.HoverState.Parent = this.btnZipFile;
            this.btnZipFile.Location = new System.Drawing.Point(8, 75);
            this.btnZipFile.Name = "btnZipFile";
            this.btnZipFile.ShadowDecoration.Parent = this.btnZipFile;
            this.btnZipFile.Size = new System.Drawing.Size(74, 25);
            this.btnZipFile.TabIndex = 15;
            this.btnZipFile.Text = "Zip File";
            // 
            // btnSystem
            // 
            this.btnSystem.BorderRadius = 5;
            this.btnSystem.CheckedState.Parent = this.btnSystem;
            this.btnSystem.CustomImages.Parent = this.btnSystem;
            this.btnSystem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSystem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSystem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSystem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSystem.DisabledState.Parent = this.btnSystem;
            this.btnSystem.FillColor = System.Drawing.Color.Green;
            this.btnSystem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSystem.ForeColor = System.Drawing.Color.White;
            this.btnSystem.HoverState.Parent = this.btnSystem;
            this.btnSystem.Location = new System.Drawing.Point(8, 106);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.ShadowDecoration.Parent = this.btnSystem;
            this.btnSystem.Size = new System.Drawing.Size(74, 25);
            this.btnSystem.TabIndex = 17;
            this.btnSystem.Text = "System";
            // 
            // txtSystem
            // 
            this.txtSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSystem.BorderRadius = 3;
            this.txtSystem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSystem.DefaultText = "";
            this.txtSystem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSystem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSystem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSystem.DisabledState.Parent = this.txtSystem;
            this.txtSystem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSystem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSystem.FocusedState.Parent = this.txtSystem;
            this.txtSystem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSystem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSystem.HoverState.Parent = this.txtSystem;
            this.txtSystem.Location = new System.Drawing.Point(91, 106);
            this.txtSystem.Name = "txtSystem";
            this.txtSystem.PasswordChar = '\0';
            this.txtSystem.PlaceholderText = "Lokasi File";
            this.txtSystem.SelectedText = "";
            this.txtSystem.ShadowDecoration.Parent = this.txtSystem;
            this.txtSystem.Size = new System.Drawing.Size(499, 25);
            this.txtSystem.TabIndex = 18;
            // 
            // btnData
            // 
            this.btnData.BorderRadius = 5;
            this.btnData.CheckedState.Parent = this.btnData;
            this.btnData.CustomImages.Parent = this.btnData;
            this.btnData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnData.DisabledState.Parent = this.btnData;
            this.btnData.FillColor = System.Drawing.Color.Green;
            this.btnData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnData.ForeColor = System.Drawing.Color.White;
            this.btnData.HoverState.Parent = this.btnData;
            this.btnData.Location = new System.Drawing.Point(8, 137);
            this.btnData.Name = "btnData";
            this.btnData.ShadowDecoration.Parent = this.btnData;
            this.btnData.Size = new System.Drawing.Size(74, 25);
            this.btnData.TabIndex = 19;
            this.btnData.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.BorderRadius = 3;
            this.txtData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtData.DefaultText = "";
            this.txtData.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtData.DisabledState.Parent = this.txtData;
            this.txtData.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtData.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtData.FocusedState.Parent = this.txtData;
            this.txtData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtData.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtData.HoverState.Parent = this.txtData;
            this.txtData.Location = new System.Drawing.Point(91, 137);
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.PlaceholderText = "Lokasi File";
            this.txtData.SelectedText = "";
            this.txtData.ShadowDecoration.Parent = this.txtData;
            this.txtData.Size = new System.Drawing.Size(499, 25);
            this.txtData.TabIndex = 20;
            // 
            // FastBoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gbFastbootOptions);
            this.Controls.Add(this.gbAdvanced);
            this.Controls.Add(this.rtbConsole);
            this.Name = "FastBoot";
            this.Size = new System.Drawing.Size(596, 449);
            this.gbAdvanced.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.gbFastbootOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.GroupBox gbAdvanced;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblJudulLetakADB;
        private Guna.UI2.WinForms.Guna2TextBox txtLetakADB;
        private Guna.UI2.WinForms.Guna2GroupBox gbFastbootOptions;
        private Guna.UI2.WinForms.Guna2Button btnBoot;
        private Guna.UI2.WinForms.Guna2TextBox txtBoot;
        private Guna.UI2.WinForms.Guna2Button btnRecovery;
        private Guna.UI2.WinForms.Guna2TextBox txtRecovery;
        private Guna.UI2.WinForms.Guna2Button btnLockBootLoader;
        private Guna.UI2.WinForms.Guna2Button btnUnlockBootloader;
        private Guna.UI2.WinForms.Guna2Button btnRebootFastboot;
        private Guna.UI2.WinForms.Guna2TextBox txtZipFile;
        private Guna.UI2.WinForms.Guna2Button btnZipFile;
        private Guna.UI2.WinForms.Guna2Button btnSystem;
        private Guna.UI2.WinForms.Guna2TextBox txtSystem;
        private Guna.UI2.WinForms.Guna2Button btnData;
        private Guna.UI2.WinForms.Guna2TextBox txtData;
    }
}


namespace Tool_Windows.tools.AndroidTool
{
    partial class ADB
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
            this.gbAdvanced = new System.Windows.Forms.GroupBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblJudulLetakADB = new System.Windows.Forms.Label();
            this.txtLetakADB = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbAdbOptions = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAdvanced = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearConsole = new Guna.UI2.WinForms.Guna2Button();
            this.btnHelpIADB = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnIpDevices = new Guna.UI2.WinForms.Guna2Button();
            this.txtIpDevices = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnkillServer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdbDevices = new Guna.UI2.WinForms.Guna2Button();
            this.btnSideload = new Guna.UI2.WinForms.Guna2Button();
            this.txtInstallApk = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBackup = new Guna.UI2.WinForms.Guna2Button();
            this.btnBrowseInstallApk = new Guna.UI2.WinForms.Guna2Button();
            this.btnBrowseBackup = new Guna.UI2.WinForms.Guna2Button();
            this.txtBackup = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBrowseSideload = new Guna.UI2.WinForms.Guna2Button();
            this.btnInstallApk = new Guna.UI2.WinForms.Guna2Button();
            this.btnReboot = new Guna.UI2.WinForms.Guna2Button();
            this.txtSideload = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRebootRecovery = new Guna.UI2.WinForms.Guna2Button();
            this.btnRecoveryBootloader = new Guna.UI2.WinForms.Guna2Button();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.gbAdvanced.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.gbAdbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdvanced
            // 
            this.gbAdvanced.Controls.Add(this.guna2Panel1);
            this.gbAdvanced.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAdvanced.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAdvanced.Location = new System.Drawing.Point(0, 0);
            this.gbAdvanced.Name = "gbAdvanced";
            this.gbAdvanced.Size = new System.Drawing.Size(680, 79);
            this.gbAdvanced.TabIndex = 31;
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
            this.lblJudulLetakADB.Text = "Letak ADB";
            this.lblJudulLetakADB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLetakADB
            // 
            this.txtLetakADB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLetakADB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLetakADB.DefaultText = "adb.exe";
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
            this.txtLetakADB.SelectionStart = 7;
            this.txtLetakADB.ShadowDecoration.Parent = this.txtLetakADB;
            this.txtLetakADB.Size = new System.Drawing.Size(149, 19);
            this.txtLetakADB.TabIndex = 2;
            // 
            // gbAdbOptions
            // 
            this.gbAdbOptions.BorderColor = System.Drawing.Color.Yellow;
            this.gbAdbOptions.BorderRadius = 10;
            this.gbAdbOptions.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.gbAdbOptions.Controls.Add(this.btnAdvanced);
            this.gbAdbOptions.Controls.Add(this.btnClearConsole);
            this.gbAdbOptions.Controls.Add(this.btnHelpIADB);
            this.gbAdbOptions.Controls.Add(this.btnIpDevices);
            this.gbAdbOptions.Controls.Add(this.txtIpDevices);
            this.gbAdbOptions.Controls.Add(this.btnkillServer);
            this.gbAdbOptions.Controls.Add(this.btnAdbDevices);
            this.gbAdbOptions.Controls.Add(this.btnSideload);
            this.gbAdbOptions.Controls.Add(this.txtInstallApk);
            this.gbAdbOptions.Controls.Add(this.btnBackup);
            this.gbAdbOptions.Controls.Add(this.btnBrowseInstallApk);
            this.gbAdbOptions.Controls.Add(this.btnBrowseBackup);
            this.gbAdbOptions.Controls.Add(this.txtBackup);
            this.gbAdbOptions.Controls.Add(this.btnBrowseSideload);
            this.gbAdbOptions.Controls.Add(this.btnInstallApk);
            this.gbAdbOptions.Controls.Add(this.btnReboot);
            this.gbAdbOptions.Controls.Add(this.txtSideload);
            this.gbAdbOptions.Controls.Add(this.btnRebootRecovery);
            this.gbAdbOptions.Controls.Add(this.btnRecoveryBootloader);
            this.gbAdbOptions.CustomBorderColor = System.Drawing.Color.MidnightBlue;
            this.gbAdbOptions.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.gbAdbOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAdbOptions.FillColor = System.Drawing.Color.Transparent;
            this.gbAdbOptions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAdbOptions.ForeColor = System.Drawing.Color.White;
            this.gbAdbOptions.Location = new System.Drawing.Point(0, 79);
            this.gbAdbOptions.Name = "gbAdbOptions";
            this.gbAdbOptions.ShadowDecoration.Parent = this.gbAdbOptions;
            this.gbAdbOptions.Size = new System.Drawing.Size(680, 220);
            this.gbAdbOptions.TabIndex = 102;
            this.gbAdbOptions.Text = "ADB Options";
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdvanced.BorderRadius = 10;
            this.btnAdvanced.CheckedState.Parent = this.btnAdvanced;
            this.btnAdvanced.CustomImages.Parent = this.btnAdvanced;
            this.btnAdvanced.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdvanced.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdvanced.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdvanced.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdvanced.DisabledState.Parent = this.btnAdvanced;
            this.btnAdvanced.FillColor = System.Drawing.Color.Silver;
            this.btnAdvanced.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdvanced.ForeColor = System.Drawing.Color.Black;
            this.btnAdvanced.HoverState.Parent = this.btnAdvanced;
            this.btnAdvanced.Location = new System.Drawing.Point(396, 175);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.ShadowDecoration.Parent = this.btnAdvanced;
            this.btnAdvanced.Size = new System.Drawing.Size(91, 33);
            this.btnAdvanced.TabIndex = 18;
            this.btnAdvanced.Text = "Advanced";
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearConsole.BorderRadius = 10;
            this.btnClearConsole.CheckedState.Parent = this.btnClearConsole;
            this.btnClearConsole.CustomImages.Parent = this.btnClearConsole;
            this.btnClearConsole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearConsole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearConsole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearConsole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearConsole.DisabledState.Parent = this.btnClearConsole;
            this.btnClearConsole.FillColor = System.Drawing.Color.Silver;
            this.btnClearConsole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearConsole.ForeColor = System.Drawing.Color.Black;
            this.btnClearConsole.HoverState.Parent = this.btnClearConsole;
            this.btnClearConsole.Location = new System.Drawing.Point(314, 175);
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.ShadowDecoration.Parent = this.btnClearConsole;
            this.btnClearConsole.Size = new System.Drawing.Size(76, 33);
            this.btnClearConsole.TabIndex = 17;
            this.btnClearConsole.Text = "Clear";
            this.btnClearConsole.Click += new System.EventHandler(this.btnClearConsole_Click);
            // 
            // btnHelpIADB
            // 
            this.btnHelpIADB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelpIADB.Animated = true;
            this.btnHelpIADB.CheckedState.Parent = this.btnHelpIADB;
            this.btnHelpIADB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelpIADB.CustomImages.Parent = this.btnHelpIADB;
            this.btnHelpIADB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHelpIADB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHelpIADB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHelpIADB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHelpIADB.DisabledState.Parent = this.btnHelpIADB;
            this.btnHelpIADB.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpIADB.ForeColor = System.Drawing.Color.White;
            this.btnHelpIADB.HoverState.Parent = this.btnHelpIADB;
            this.btnHelpIADB.Location = new System.Drawing.Point(643, 0);
            this.btnHelpIADB.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpIADB.Name = "btnHelpIADB";
            this.btnHelpIADB.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnHelpIADB.ShadowDecoration.Parent = this.btnHelpIADB;
            this.btnHelpIADB.Size = new System.Drawing.Size(29, 30);
            this.btnHelpIADB.TabIndex = 11;
            this.btnHelpIADB.Text = "?";
            this.btnHelpIADB.TextFormatNoPrefix = true;
            this.btnHelpIADB.Click += new System.EventHandler(this.btnHelpIADB_Click);
            // 
            // btnIpDevices
            // 
            this.btnIpDevices.Animated = true;
            this.btnIpDevices.AnimatedGIF = true;
            this.btnIpDevices.AutoRoundedCorners = true;
            this.btnIpDevices.BorderRadius = 11;
            this.btnIpDevices.CheckedState.Parent = this.btnIpDevices;
            this.btnIpDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIpDevices.CustomImages.Parent = this.btnIpDevices;
            this.btnIpDevices.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIpDevices.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIpDevices.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIpDevices.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIpDevices.DisabledState.Parent = this.btnIpDevices;
            this.btnIpDevices.FillColor = System.Drawing.Color.Aqua;
            this.btnIpDevices.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnIpDevices.ForeColor = System.Drawing.Color.Black;
            this.btnIpDevices.HoverState.Parent = this.btnIpDevices;
            this.btnIpDevices.Location = new System.Drawing.Point(5, 140);
            this.btnIpDevices.Name = "btnIpDevices";
            this.btnIpDevices.ShadowDecoration.Parent = this.btnIpDevices;
            this.btnIpDevices.Size = new System.Drawing.Size(117, 25);
            this.btnIpDevices.TabIndex = 9;
            this.btnIpDevices.Text = "Hubungkan IP";
            this.btnIpDevices.Click += new System.EventHandler(this.btnIpDevices_Click);
            // 
            // txtIpDevices
            // 
            this.txtIpDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIpDevices.BorderRadius = 3;
            this.txtIpDevices.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIpDevices.DefaultText = "";
            this.txtIpDevices.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIpDevices.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIpDevices.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIpDevices.DisabledState.Parent = this.txtIpDevices;
            this.txtIpDevices.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIpDevices.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIpDevices.FocusedState.Parent = this.txtIpDevices;
            this.txtIpDevices.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIpDevices.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIpDevices.HoverState.Parent = this.txtIpDevices;
            this.txtIpDevices.Location = new System.Drawing.Point(138, 140);
            this.txtIpDevices.Name = "txtIpDevices";
            this.txtIpDevices.PasswordChar = '\0';
            this.txtIpDevices.PlaceholderText = "Ip Android xxxx.xxxx.xxxx.xxxx";
            this.txtIpDevices.SelectedText = "";
            this.txtIpDevices.ShadowDecoration.Parent = this.txtIpDevices;
            this.txtIpDevices.Size = new System.Drawing.Size(454, 25);
            this.txtIpDevices.TabIndex = 10;
            // 
            // btnkillServer
            // 
            this.btnkillServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnkillServer.BorderRadius = 10;
            this.btnkillServer.CheckedState.Parent = this.btnkillServer;
            this.btnkillServer.CustomImages.Parent = this.btnkillServer;
            this.btnkillServer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnkillServer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnkillServer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnkillServer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnkillServer.DisabledState.Parent = this.btnkillServer;
            this.btnkillServer.FillColor = System.Drawing.Color.Silver;
            this.btnkillServer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnkillServer.ForeColor = System.Drawing.Color.Black;
            this.btnkillServer.HoverState.Parent = this.btnkillServer;
            this.btnkillServer.Location = new System.Drawing.Point(198, 175);
            this.btnkillServer.Name = "btnkillServer";
            this.btnkillServer.ShadowDecoration.Parent = this.btnkillServer;
            this.btnkillServer.Size = new System.Drawing.Size(99, 33);
            this.btnkillServer.TabIndex = 14;
            this.btnkillServer.Text = "Kill Server";
            this.btnkillServer.Click += new System.EventHandler(this.btnkillServer_Click);
            // 
            // btnAdbDevices
            // 
            this.btnAdbDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdbDevices.BorderRadius = 10;
            this.btnAdbDevices.CheckedState.Parent = this.btnAdbDevices;
            this.btnAdbDevices.CustomImages.Parent = this.btnAdbDevices;
            this.btnAdbDevices.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdbDevices.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdbDevices.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdbDevices.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdbDevices.DisabledState.Parent = this.btnAdbDevices;
            this.btnAdbDevices.FillColor = System.Drawing.Color.Silver;
            this.btnAdbDevices.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdbDevices.ForeColor = System.Drawing.Color.Black;
            this.btnAdbDevices.HoverState.Parent = this.btnAdbDevices;
            this.btnAdbDevices.Location = new System.Drawing.Point(91, 175);
            this.btnAdbDevices.Name = "btnAdbDevices";
            this.btnAdbDevices.ShadowDecoration.Parent = this.btnAdbDevices;
            this.btnAdbDevices.Size = new System.Drawing.Size(94, 33);
            this.btnAdbDevices.TabIndex = 13;
            this.btnAdbDevices.Text = "Cek Devices";
            this.btnAdbDevices.Click += new System.EventHandler(this.btnAdbDevices_Click);
            // 
            // btnSideload
            // 
            this.btnSideload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSideload.Animated = true;
            this.btnSideload.AnimatedGIF = true;
            this.btnSideload.AutoRoundedCorners = true;
            this.btnSideload.BorderRadius = 11;
            this.btnSideload.CheckedState.Parent = this.btnSideload;
            this.btnSideload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideload.CustomImages.Parent = this.btnSideload;
            this.btnSideload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSideload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSideload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSideload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSideload.DisabledState.Parent = this.btnSideload;
            this.btnSideload.FillColor = System.Drawing.Color.Aqua;
            this.btnSideload.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.btnSideload.ForeColor = System.Drawing.Color.Black;
            this.btnSideload.HoverState.Parent = this.btnSideload;
            this.btnSideload.Location = new System.Drawing.Point(598, 109);
            this.btnSideload.Name = "btnSideload";
            this.btnSideload.ShadowDecoration.Parent = this.btnSideload;
            this.btnSideload.Size = new System.Drawing.Size(74, 25);
            this.btnSideload.TabIndex = 8;
            this.btnSideload.Text = "Sideload zip";
            this.btnSideload.Click += new System.EventHandler(this.btnSideload_Click);
            // 
            // txtInstallApk
            // 
            this.txtInstallApk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstallApk.BorderRadius = 3;
            this.txtInstallApk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInstallApk.DefaultText = "";
            this.txtInstallApk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInstallApk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInstallApk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstallApk.DisabledState.Parent = this.txtInstallApk;
            this.txtInstallApk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInstallApk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstallApk.FocusedState.Parent = this.txtInstallApk;
            this.txtInstallApk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInstallApk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInstallApk.HoverState.Parent = this.txtInstallApk;
            this.txtInstallApk.Location = new System.Drawing.Point(85, 47);
            this.txtInstallApk.Name = "txtInstallApk";
            this.txtInstallApk.PasswordChar = '\0';
            this.txtInstallApk.PlaceholderText = "Lokasi File";
            this.txtInstallApk.SelectedText = "";
            this.txtInstallApk.ShadowDecoration.Parent = this.txtInstallApk;
            this.txtInstallApk.Size = new System.Drawing.Size(507, 25);
            this.txtInstallApk.TabIndex = 1;
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackup.Animated = true;
            this.btnBackup.AnimatedGIF = true;
            this.btnBackup.AutoRoundedCorners = true;
            this.btnBackup.BorderRadius = 11;
            this.btnBackup.CheckedState.Parent = this.btnBackup;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.CustomImages.Parent = this.btnBackup;
            this.btnBackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackup.DisabledState.Parent = this.btnBackup;
            this.btnBackup.FillColor = System.Drawing.Color.Aqua;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.Black;
            this.btnBackup.HoverState.Parent = this.btnBackup;
            this.btnBackup.Location = new System.Drawing.Point(598, 78);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.ShadowDecoration.Parent = this.btnBackup;
            this.btnBackup.Size = new System.Drawing.Size(74, 25);
            this.btnBackup.TabIndex = 5;
            this.btnBackup.Text = "Backup";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBrowseInstallApk
            // 
            this.btnBrowseInstallApk.Animated = true;
            this.btnBrowseInstallApk.AnimatedGIF = true;
            this.btnBrowseInstallApk.AutoRoundedCorners = true;
            this.btnBrowseInstallApk.BorderRadius = 11;
            this.btnBrowseInstallApk.CheckedState.Parent = this.btnBrowseInstallApk;
            this.btnBrowseInstallApk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseInstallApk.CustomImages.Parent = this.btnBrowseInstallApk;
            this.btnBrowseInstallApk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseInstallApk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseInstallApk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowseInstallApk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowseInstallApk.DisabledState.Parent = this.btnBrowseInstallApk;
            this.btnBrowseInstallApk.FillColor = System.Drawing.Color.Green;
            this.btnBrowseInstallApk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseInstallApk.ForeColor = System.Drawing.Color.White;
            this.btnBrowseInstallApk.HoverState.Parent = this.btnBrowseInstallApk;
            this.btnBrowseInstallApk.Location = new System.Drawing.Point(5, 47);
            this.btnBrowseInstallApk.Name = "btnBrowseInstallApk";
            this.btnBrowseInstallApk.ShadowDecoration.Parent = this.btnBrowseInstallApk;
            this.btnBrowseInstallApk.Size = new System.Drawing.Size(74, 25);
            this.btnBrowseInstallApk.TabIndex = 0;
            this.btnBrowseInstallApk.Text = "Browse";
            this.btnBrowseInstallApk.Click += new System.EventHandler(this.btnBrowseInstallApk_Click);
            // 
            // btnBrowseBackup
            // 
            this.btnBrowseBackup.Animated = true;
            this.btnBrowseBackup.AnimatedGIF = true;
            this.btnBrowseBackup.AutoRoundedCorners = true;
            this.btnBrowseBackup.BorderRadius = 11;
            this.btnBrowseBackup.CheckedState.Parent = this.btnBrowseBackup;
            this.btnBrowseBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseBackup.CustomImages.Parent = this.btnBrowseBackup;
            this.btnBrowseBackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseBackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowseBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowseBackup.DisabledState.Parent = this.btnBrowseBackup;
            this.btnBrowseBackup.FillColor = System.Drawing.Color.Green;
            this.btnBrowseBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseBackup.ForeColor = System.Drawing.Color.White;
            this.btnBrowseBackup.HoverState.Parent = this.btnBrowseBackup;
            this.btnBrowseBackup.Location = new System.Drawing.Point(5, 78);
            this.btnBrowseBackup.Name = "btnBrowseBackup";
            this.btnBrowseBackup.ShadowDecoration.Parent = this.btnBrowseBackup;
            this.btnBrowseBackup.Size = new System.Drawing.Size(74, 25);
            this.btnBrowseBackup.TabIndex = 3;
            this.btnBrowseBackup.Text = "Browse";
            this.btnBrowseBackup.Click += new System.EventHandler(this.btnBrowseBackup_Click);
            // 
            // txtBackup
            // 
            this.txtBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackup.BorderRadius = 3;
            this.txtBackup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBackup.DefaultText = "";
            this.txtBackup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBackup.DisabledState.Parent = this.txtBackup;
            this.txtBackup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBackup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBackup.FocusedState.Parent = this.txtBackup;
            this.txtBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBackup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBackup.HoverState.Parent = this.txtBackup;
            this.txtBackup.Location = new System.Drawing.Point(86, 78);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.PasswordChar = '\0';
            this.txtBackup.PlaceholderText = "Lokasi File";
            this.txtBackup.SelectedText = "";
            this.txtBackup.ShadowDecoration.Parent = this.txtBackup;
            this.txtBackup.Size = new System.Drawing.Size(506, 25);
            this.txtBackup.TabIndex = 4;
            // 
            // btnBrowseSideload
            // 
            this.btnBrowseSideload.Animated = true;
            this.btnBrowseSideload.AnimatedGIF = true;
            this.btnBrowseSideload.AutoRoundedCorners = true;
            this.btnBrowseSideload.BorderRadius = 11;
            this.btnBrowseSideload.CheckedState.Parent = this.btnBrowseSideload;
            this.btnBrowseSideload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseSideload.CustomImages.Parent = this.btnBrowseSideload;
            this.btnBrowseSideload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseSideload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowseSideload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowseSideload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowseSideload.DisabledState.Parent = this.btnBrowseSideload;
            this.btnBrowseSideload.FillColor = System.Drawing.Color.Green;
            this.btnBrowseSideload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseSideload.ForeColor = System.Drawing.Color.White;
            this.btnBrowseSideload.HoverState.Parent = this.btnBrowseSideload;
            this.btnBrowseSideload.Location = new System.Drawing.Point(5, 109);
            this.btnBrowseSideload.Name = "btnBrowseSideload";
            this.btnBrowseSideload.ShadowDecoration.Parent = this.btnBrowseSideload;
            this.btnBrowseSideload.Size = new System.Drawing.Size(74, 25);
            this.btnBrowseSideload.TabIndex = 6;
            this.btnBrowseSideload.Text = "Browse";
            this.btnBrowseSideload.Click += new System.EventHandler(this.btnBrowseSideload_Click);
            // 
            // btnInstallApk
            // 
            this.btnInstallApk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstallApk.Animated = true;
            this.btnInstallApk.AnimatedGIF = true;
            this.btnInstallApk.AutoRoundedCorners = true;
            this.btnInstallApk.BorderRadius = 11;
            this.btnInstallApk.CheckedState.Parent = this.btnInstallApk;
            this.btnInstallApk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstallApk.CustomImages.Parent = this.btnInstallApk;
            this.btnInstallApk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInstallApk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInstallApk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInstallApk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInstallApk.DisabledState.Parent = this.btnInstallApk;
            this.btnInstallApk.FillColor = System.Drawing.Color.Aqua;
            this.btnInstallApk.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallApk.ForeColor = System.Drawing.Color.Black;
            this.btnInstallApk.HoverState.Parent = this.btnInstallApk;
            this.btnInstallApk.Location = new System.Drawing.Point(598, 47);
            this.btnInstallApk.Name = "btnInstallApk";
            this.btnInstallApk.ShadowDecoration.Parent = this.btnInstallApk;
            this.btnInstallApk.Size = new System.Drawing.Size(74, 25);
            this.btnInstallApk.TabIndex = 2;
            this.btnInstallApk.Text = "Install APK";
            this.btnInstallApk.Click += new System.EventHandler(this.btnInstallApk_Click);
            // 
            // btnReboot
            // 
            this.btnReboot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReboot.BorderRadius = 10;
            this.btnReboot.CheckedState.Parent = this.btnReboot;
            this.btnReboot.CustomImages.Parent = this.btnReboot;
            this.btnReboot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReboot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReboot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReboot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReboot.DisabledState.Parent = this.btnReboot;
            this.btnReboot.FillColor = System.Drawing.Color.Silver;
            this.btnReboot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReboot.ForeColor = System.Drawing.Color.Black;
            this.btnReboot.HoverState.Parent = this.btnReboot;
            this.btnReboot.Location = new System.Drawing.Point(5, 175);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.ShadowDecoration.Parent = this.btnReboot;
            this.btnReboot.Size = new System.Drawing.Size(74, 33);
            this.btnReboot.TabIndex = 12;
            this.btnReboot.Text = "Reboot";
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // txtSideload
            // 
            this.txtSideload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSideload.BorderRadius = 3;
            this.txtSideload.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSideload.DefaultText = "";
            this.txtSideload.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSideload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSideload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSideload.DisabledState.Parent = this.txtSideload;
            this.txtSideload.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSideload.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSideload.FocusedState.Parent = this.txtSideload;
            this.txtSideload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSideload.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSideload.HoverState.Parent = this.txtSideload;
            this.txtSideload.Location = new System.Drawing.Point(86, 109);
            this.txtSideload.Name = "txtSideload";
            this.txtSideload.PasswordChar = '\0';
            this.txtSideload.PlaceholderText = "Lokasi File";
            this.txtSideload.SelectedText = "";
            this.txtSideload.ShadowDecoration.Parent = this.txtSideload;
            this.txtSideload.Size = new System.Drawing.Size(506, 25);
            this.txtSideload.TabIndex = 7;
            // 
            // btnRebootRecovery
            // 
            this.btnRebootRecovery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRebootRecovery.BorderRadius = 10;
            this.btnRebootRecovery.CheckedState.Parent = this.btnRebootRecovery;
            this.btnRebootRecovery.CustomImages.Parent = this.btnRebootRecovery;
            this.btnRebootRecovery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRebootRecovery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRebootRecovery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRebootRecovery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRebootRecovery.DisabledState.Parent = this.btnRebootRecovery;
            this.btnRebootRecovery.FillColor = System.Drawing.Color.Silver;
            this.btnRebootRecovery.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRebootRecovery.ForeColor = System.Drawing.Color.Black;
            this.btnRebootRecovery.HoverState.Parent = this.btnRebootRecovery;
            this.btnRebootRecovery.Location = new System.Drawing.Point(493, 175);
            this.btnRebootRecovery.Name = "btnRebootRecovery";
            this.btnRebootRecovery.ShadowDecoration.Parent = this.btnRebootRecovery;
            this.btnRebootRecovery.Size = new System.Drawing.Size(99, 33);
            this.btnRebootRecovery.TabIndex = 15;
            this.btnRebootRecovery.Text = "Recovery";
            this.btnRebootRecovery.Click += new System.EventHandler(this.btnRebootRecovery_Click);
            // 
            // btnRecoveryBootloader
            // 
            this.btnRecoveryBootloader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecoveryBootloader.BorderRadius = 10;
            this.btnRecoveryBootloader.CheckedState.Parent = this.btnRecoveryBootloader;
            this.btnRecoveryBootloader.CustomImages.Parent = this.btnRecoveryBootloader;
            this.btnRecoveryBootloader.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecoveryBootloader.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRecoveryBootloader.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecoveryBootloader.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRecoveryBootloader.DisabledState.Parent = this.btnRecoveryBootloader;
            this.btnRecoveryBootloader.FillColor = System.Drawing.Color.Silver;
            this.btnRecoveryBootloader.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnRecoveryBootloader.ForeColor = System.Drawing.Color.Black;
            this.btnRecoveryBootloader.HoverState.Parent = this.btnRecoveryBootloader;
            this.btnRecoveryBootloader.Location = new System.Drawing.Point(598, 175);
            this.btnRecoveryBootloader.Name = "btnRecoveryBootloader";
            this.btnRecoveryBootloader.ShadowDecoration.Parent = this.btnRecoveryBootloader;
            this.btnRecoveryBootloader.Size = new System.Drawing.Size(74, 33);
            this.btnRecoveryBootloader.TabIndex = 16;
            this.btnRecoveryBootloader.Text = "Bootloader";
            this.btnRecoveryBootloader.Click += new System.EventHandler(this.btnRecoveryBootloader_Click);
            // 
            // rtbConsole
            // 
            this.rtbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbConsole.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rtbConsole.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rtbConsole.Location = new System.Drawing.Point(0, 305);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.Size = new System.Drawing.Size(677, 95);
            this.rtbConsole.TabIndex = 30;
            this.rtbConsole.Text = ">> ";
            // 
            // ADB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gbAdbOptions);
            this.Controls.Add(this.gbAdvanced);
            this.Controls.Add(this.rtbConsole);
            this.Name = "ADB";
            this.Size = new System.Drawing.Size(680, 401);
            this.gbAdvanced.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.gbAdbOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbAdvanced;
        private Guna.UI2.WinForms.Guna2GroupBox gbAdbOptions;
        private Guna.UI2.WinForms.Guna2Button btnClearConsole;
        private Guna.UI2.WinForms.Guna2CircleButton btnHelpIADB;
        private Guna.UI2.WinForms.Guna2Button btnIpDevices;
        private Guna.UI2.WinForms.Guna2TextBox txtIpDevices;
        private Guna.UI2.WinForms.Guna2Button btnkillServer;
        private Guna.UI2.WinForms.Guna2Button btnAdbDevices;
        private Guna.UI2.WinForms.Guna2Button btnSideload;
        private Guna.UI2.WinForms.Guna2TextBox txtInstallApk;
        private Guna.UI2.WinForms.Guna2Button btnBackup;
        private Guna.UI2.WinForms.Guna2Button btnBrowseInstallApk;
        private Guna.UI2.WinForms.Guna2Button btnBrowseBackup;
        private Guna.UI2.WinForms.Guna2TextBox txtBackup;
        private Guna.UI2.WinForms.Guna2Button btnBrowseSideload;
        private Guna.UI2.WinForms.Guna2Button btnInstallApk;
        private Guna.UI2.WinForms.Guna2Button btnReboot;
        private Guna.UI2.WinForms.Guna2TextBox txtSideload;
        private Guna.UI2.WinForms.Guna2Button btnRebootRecovery;
        private Guna.UI2.WinForms.Guna2Button btnRecoveryBootloader;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblJudulLetakADB;
        private Guna.UI2.WinForms.Guna2TextBox txtLetakADB;
        private Guna.UI2.WinForms.Guna2Button btnAdvanced;
        private System.Windows.Forms.RichTextBox rtbConsole;
    }
}

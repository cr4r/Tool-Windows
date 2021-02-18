
namespace Tool_Windows.tools
{
    partial class nordVPN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nordVPN));
            this.gbGenerate = new System.Windows.Forms.GroupBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnSalin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblExpired = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblRefresh = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbGenerate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGenerate
            // 
            resources.ApplyResources(this.gbGenerate, "gbGenerate");
            this.gbGenerate.Controls.Add(this.btnKembali);
            this.gbGenerate.Controls.Add(this.btnSalin);
            this.gbGenerate.Controls.Add(this.groupBox1);
            this.gbGenerate.Controls.Add(this.btnGenerate);
            this.gbGenerate.Name = "gbGenerate";
            this.gbGenerate.TabStop = false;
            this.toolTip1.SetToolTip(this.gbGenerate, resources.GetString("gbGenerate.ToolTip"));
            // 
            // btnKembali
            // 
            resources.ApplyResources(this.btnKembali, "btnKembali");
            this.btnKembali.Name = "btnKembali";
            this.toolTip1.SetToolTip(this.btnKembali, resources.GetString("btnKembali.ToolTip"));
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnSalin
            // 
            resources.ApplyResources(this.btnSalin, "btnSalin");
            this.btnSalin.Name = "btnSalin";
            this.toolTip1.SetToolTip(this.btnSalin, resources.GetString("btnSalin.ToolTip"));
            this.btnSalin.UseVisualStyleBackColor = true;
            this.btnSalin.Click += new System.EventHandler(this.btnSalin_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.lblExpired);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // lblExpired
            // 
            resources.ApplyResources(this.lblExpired, "lblExpired");
            this.lblExpired.Name = "lblExpired";
            this.toolTip1.SetToolTip(this.lblExpired, resources.GetString("lblExpired.ToolTip"));
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            this.toolTip1.SetToolTip(this.lblPassword, resources.GetString("lblPassword.ToolTip"));
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            this.toolTip1.SetToolTip(this.lblEmail, resources.GetString("lblEmail.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // btnGenerate
            // 
            resources.ApplyResources(this.btnGenerate, "btnGenerate");
            this.btnGenerate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Name = "btnGenerate";
            this.toolTip1.SetToolTip(this.btnGenerate, resources.GetString("btnGenerate.ToolTip"));
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblRefresh
            // 
            resources.ApplyResources(this.lblRefresh, "lblRefresh");
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.TabStop = true;
            this.toolTip1.SetToolTip(this.lblRefresh, resources.GetString("lblRefresh.ToolTip"));
            this.lblRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRefresh_LinkClicked);
            this.lblRefresh.MouseHover += new System.EventHandler(this.lblRefresh_MouseHover);
            // 
            // nordVPN
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRefresh);
            this.Controls.Add(this.gbGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "nordVPN";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.nordVPN_Load);
            this.gbGenerate.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGenerate;
        private System.Windows.Forms.Button btnSalin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblExpired;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.LinkLabel lblRefresh;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
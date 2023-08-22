namespace SchoolManagement
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.spMenu = new Siticone.UI.WinForms.SiticonePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spSubAdministrator = new Siticone.UI.WinForms.SiticonePanel();
            this.siticoneButton4 = new Siticone.UI.WinForms.SiticoneButton();
            this.smAdminUser = new Siticone.UI.WinForms.SiticoneButton();
            this.sbmAdministrator = new Siticone.UI.WinForms.SiticoneButton();
            this.sbmDashboard = new Siticone.UI.WinForms.SiticoneButton();
            this.spbSlide = new Siticone.UI.WinForms.SiticonePictureBox();
            this.siticonePanel2 = new Siticone.UI.WinForms.SiticonePanel();
            this.siticoneControlBox3 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.spSubAdministrator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spbSlide)).BeginInit();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // spMenu
            // 
            this.spMenu.BackColor = System.Drawing.Color.White;
            this.spMenu.Controls.Add(this.panel1);
            this.spMenu.Controls.Add(this.spbSlide);
            this.spMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.spMenu.Location = new System.Drawing.Point(0, 0);
            this.spMenu.Name = "spMenu";
            this.spMenu.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.spMenu.ShadowDecoration.Enabled = true;
            this.spMenu.ShadowDecoration.Parent = this.spMenu;
            this.spMenu.Size = new System.Drawing.Size(200, 534);
            this.spMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.spSubAdministrator);
            this.panel1.Controls.Add(this.sbmAdministrator);
            this.panel1.Controls.Add(this.sbmDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 8;
            // 
            // spSubAdministrator
            // 
            this.spSubAdministrator.AutoSize = true;
            this.spSubAdministrator.Controls.Add(this.siticoneButton4);
            this.spSubAdministrator.Controls.Add(this.smAdminUser);
            this.spSubAdministrator.Dock = System.Windows.Forms.DockStyle.Top;
            this.spSubAdministrator.Location = new System.Drawing.Point(0, 74);
            this.spSubAdministrator.Name = "spSubAdministrator";
            this.spSubAdministrator.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.spSubAdministrator.ShadowDecoration.Parent = this.spSubAdministrator;
            this.spSubAdministrator.Size = new System.Drawing.Size(200, 74);
            this.spSubAdministrator.TabIndex = 10;
            this.spSubAdministrator.Visible = false;
            this.spSubAdministrator.VisibleChanged += new System.EventHandler(this.spSubAdministrator_VisibleChanged);
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.BackColor = System.Drawing.Color.White;
            this.siticoneButton4.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneButton4.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.siticoneButton4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.siticoneButton4.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.siticoneButton4.CheckedState.Image = global::SchoolManagement.Properties.Resources.Vector;
            this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
            this.siticoneButton4.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
            this.siticoneButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneButton4.FillColor = System.Drawing.Color.White;
            this.siticoneButton4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton4.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton4.HoveredState.Parent = this.siticoneButton4;
            this.siticoneButton4.Image = ((System.Drawing.Image)(resources.GetObject("siticoneButton4.Image")));
            this.siticoneButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton4.ImageOffset = new System.Drawing.Point(10, 0);
            this.siticoneButton4.ImageSize = new System.Drawing.Size(16, 16);
            this.siticoneButton4.Location = new System.Drawing.Point(4, 37);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
            this.siticoneButton4.Size = new System.Drawing.Size(196, 37);
            this.siticoneButton4.TabIndex = 13;
            this.siticoneButton4.Text = "Employees";
            this.siticoneButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton4.TextOffset = new System.Drawing.Point(19, 0);
            // 
            // smAdminUser
            // 
            this.smAdminUser.BackColor = System.Drawing.Color.White;
            this.smAdminUser.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.smAdminUser.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smAdminUser.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.smAdminUser.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smAdminUser.CheckedState.Image = global::SchoolManagement.Properties.Resources.Vector;
            this.smAdminUser.CheckedState.Parent = this.smAdminUser;
            this.smAdminUser.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.smAdminUser.CustomImages.Parent = this.smAdminUser;
            this.smAdminUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.smAdminUser.FillColor = System.Drawing.Color.White;
            this.smAdminUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smAdminUser.ForeColor = System.Drawing.Color.Black;
            this.smAdminUser.HoveredState.Parent = this.smAdminUser;
            this.smAdminUser.Image = ((System.Drawing.Image)(resources.GetObject("smAdminUser.Image")));
            this.smAdminUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smAdminUser.ImageOffset = new System.Drawing.Point(10, 0);
            this.smAdminUser.ImageSize = new System.Drawing.Size(16, 16);
            this.smAdminUser.Location = new System.Drawing.Point(4, 0);
            this.smAdminUser.Name = "smAdminUser";
            this.smAdminUser.ShadowDecoration.Parent = this.smAdminUser;
            this.smAdminUser.Size = new System.Drawing.Size(196, 37);
            this.smAdminUser.TabIndex = 12;
            this.smAdminUser.Text = "Users";
            this.smAdminUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smAdminUser.TextOffset = new System.Drawing.Point(19, 0);
            // 
            // sbmAdministrator
            // 
            this.sbmAdministrator.BackColor = System.Drawing.Color.White;
            this.sbmAdministrator.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.sbmAdministrator.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbmAdministrator.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sbmAdministrator.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbmAdministrator.CheckedState.Image = global::SchoolManagement.Properties.Resources.admin__1_;
            this.sbmAdministrator.CheckedState.Parent = this.sbmAdministrator;
            this.sbmAdministrator.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.sbmAdministrator.CustomImages.Parent = this.sbmAdministrator;
            this.sbmAdministrator.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbmAdministrator.FillColor = System.Drawing.Color.White;
            this.sbmAdministrator.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbmAdministrator.ForeColor = System.Drawing.Color.Black;
            this.sbmAdministrator.HoveredState.Parent = this.sbmAdministrator;
            this.sbmAdministrator.Image = global::SchoolManagement.Properties.Resources.admin;
            this.sbmAdministrator.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbmAdministrator.ImageOffset = new System.Drawing.Point(10, 0);
            this.sbmAdministrator.ImageSize = new System.Drawing.Size(16, 16);
            this.sbmAdministrator.Location = new System.Drawing.Point(0, 37);
            this.sbmAdministrator.Name = "sbmAdministrator";
            this.sbmAdministrator.ShadowDecoration.Parent = this.sbmAdministrator;
            this.sbmAdministrator.Size = new System.Drawing.Size(200, 37);
            this.sbmAdministrator.TabIndex = 9;
            this.sbmAdministrator.Text = "Administrator";
            this.sbmAdministrator.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbmAdministrator.TextOffset = new System.Drawing.Point(19, 0);
            this.sbmAdministrator.Click += new System.EventHandler(this.sbmAdministrator_Click);
            // 
            // sbmDashboard
            // 
            this.sbmDashboard.BackColor = System.Drawing.Color.White;
            this.sbmDashboard.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.sbmDashboard.Checked = true;
            this.sbmDashboard.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbmDashboard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sbmDashboard.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbmDashboard.CheckedState.Image = global::SchoolManagement.Properties.Resources.dashboard;
            this.sbmDashboard.CheckedState.Parent = this.sbmDashboard;
            this.sbmDashboard.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.sbmDashboard.CustomImages.Parent = this.sbmDashboard;
            this.sbmDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbmDashboard.FillColor = System.Drawing.Color.White;
            this.sbmDashboard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbmDashboard.ForeColor = System.Drawing.Color.Black;
            this.sbmDashboard.HoveredState.Parent = this.sbmDashboard;
            this.sbmDashboard.Image = global::SchoolManagement.Properties.Resources.dashboard__1_;
            this.sbmDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbmDashboard.ImageOffset = new System.Drawing.Point(10, 0);
            this.sbmDashboard.ImageSize = new System.Drawing.Size(16, 16);
            this.sbmDashboard.Location = new System.Drawing.Point(0, 0);
            this.sbmDashboard.Name = "sbmDashboard";
            this.sbmDashboard.ShadowDecoration.Parent = this.sbmDashboard;
            this.sbmDashboard.Size = new System.Drawing.Size(200, 37);
            this.sbmDashboard.TabIndex = 8;
            this.sbmDashboard.Text = "Dashboard";
            this.sbmDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbmDashboard.TextOffset = new System.Drawing.Point(19, 0);
            this.sbmDashboard.CheckedChanged += new System.EventHandler(this.sbmDashboard_CheckedChanged);
            // 
            // spbSlide
            // 
            this.spbSlide.Dock = System.Windows.Forms.DockStyle.Top;
            this.spbSlide.Image = global::SchoolManagement.Properties.Resources.logo_frm;
            this.spbSlide.Location = new System.Drawing.Point(0, 0);
            this.spbSlide.Name = "spbSlide";
            this.spbSlide.ShadowDecoration.Parent = this.spbSlide;
            this.spbSlide.Size = new System.Drawing.Size(200, 84);
            this.spbSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.spbSlide.TabIndex = 3;
            this.spbSlide.TabStop = false;
            this.spbSlide.Click += new System.EventHandler(this.spbSlide_Click);
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticonePanel2.Controls.Add(this.siticoneControlBox3);
            this.siticonePanel2.Controls.Add(this.siticoneControlBox2);
            this.siticonePanel2.Controls.Add(this.siticoneControlBox1);
            this.siticonePanel2.Location = new System.Drawing.Point(206, 0);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.ShadowDecoration.Parent = this.siticonePanel2;
            this.siticonePanel2.Size = new System.Drawing.Size(627, 29);
            this.siticonePanel2.TabIndex = 1;
            // 
            // siticoneControlBox3
            // 
            this.siticoneControlBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.siticoneControlBox3.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneControlBox3.FillColor = System.Drawing.SystemColors.Control;
            this.siticoneControlBox3.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.siticoneControlBox3.HoveredState.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox3.Location = new System.Drawing.Point(492, 0);
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox3.TabIndex = 2;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.siticoneControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneControlBox2.FillColor = System.Drawing.SystemColors.Control;
            this.siticoneControlBox2.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox2.Location = new System.Drawing.Point(537, 0);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 1;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneControlBox1.FillColor = System.Drawing.SystemColors.Control;
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox1.Location = new System.Drawing.Point(582, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.siticonePanel2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(435, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(833, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.spMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(833, 534);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Management System";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.spMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.spSubAdministrator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spbSlide)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel spMenu;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticonePictureBox spbSlide;
        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticoneButton sbmDashboard;
        private Siticone.UI.WinForms.SiticoneButton sbmAdministrator;
        private Siticone.UI.WinForms.SiticonePanel spSubAdministrator;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton4;
        private Siticone.UI.WinForms.SiticoneButton smAdminUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


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
            this.stpSideMenu = new Siticone.UI.WinForms.SiticonePanel();
            this.mbtnDashboard = new Siticone.UI.WinForms.SiticoneButton();
            this.mspDashboard = new Siticone.UI.WinForms.SiticonePanel();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.stpSideMenu.SuspendLayout();
            this.mspDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // stpSideMenu
            // 
            this.stpSideMenu.BackColor = System.Drawing.Color.White;
            this.stpSideMenu.Controls.Add(this.mspDashboard);
            this.stpSideMenu.Controls.Add(this.mbtnDashboard);
            this.stpSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.stpSideMenu.Location = new System.Drawing.Point(0, 0);
            this.stpSideMenu.Name = "stpSideMenu";
            this.stpSideMenu.ShadowDecoration.Parent = this.stpSideMenu;
            this.stpSideMenu.Size = new System.Drawing.Size(200, 481);
            this.stpSideMenu.TabIndex = 0;
            // 
            // mbtnDashboard
            // 
            this.mbtnDashboard.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.mbtnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.mbtnDashboard.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.mbtnDashboard.CheckedState.Image = global::SchoolManagement.Properties.Resources.Vector1;
            this.mbtnDashboard.CheckedState.Parent = this.mbtnDashboard;
            this.mbtnDashboard.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.mbtnDashboard.CustomImages.Parent = this.mbtnDashboard;
            this.mbtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.mbtnDashboard.FillColor = System.Drawing.Color.White;
            this.mbtnDashboard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtnDashboard.ForeColor = System.Drawing.Color.Black;
            this.mbtnDashboard.HoveredState.Parent = this.mbtnDashboard;
            this.mbtnDashboard.Image = global::SchoolManagement.Properties.Resources.Vector__1_;
            this.mbtnDashboard.ImageOffset = new System.Drawing.Point(-15, 0);
            this.mbtnDashboard.ImageSize = new System.Drawing.Size(16, 16);
            this.mbtnDashboard.Location = new System.Drawing.Point(0, 0);
            this.mbtnDashboard.Name = "mbtnDashboard";
            this.mbtnDashboard.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.mbtnDashboard.ShadowDecoration.Parent = this.mbtnDashboard;
            this.mbtnDashboard.Size = new System.Drawing.Size(200, 45);
            this.mbtnDashboard.TabIndex = 1;
            this.mbtnDashboard.Text = "Dashboard";
            this.mbtnDashboard.TextOffset = new System.Drawing.Point(-12, 0);
            this.mbtnDashboard.Click += new System.EventHandler(this.mbtnDashboard_Click);
            // 
            // mspDashboard
            // 
            this.mspDashboard.Controls.Add(this.siticoneButton1);
            this.mspDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.mspDashboard.Location = new System.Drawing.Point(0, 45);
            this.mspDashboard.Name = "mspDashboard";
            this.mspDashboard.ShadowDecoration.Parent = this.mspDashboard;
            this.mspDashboard.Size = new System.Drawing.Size(200, 67);
            this.mspDashboard.TabIndex = 2;
            this.mspDashboard.Visible = false;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.siticoneButton1.CheckedState.FillColor = System.Drawing.Color.White;
            this.siticoneButton1.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.siticoneButton1.CheckedState.Image = global::SchoolManagement.Properties.Resources.Vector1;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneButton1.FillColor = System.Drawing.Color.White;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Image = global::SchoolManagement.Properties.Resources.Vector__1_;
            this.siticoneButton1.ImageOffset = new System.Drawing.Point(-15, 0);
            this.siticoneButton1.ImageSize = new System.Drawing.Size(16, 16);
            this.siticoneButton1.Location = new System.Drawing.Point(0, 0);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(200, 45);
            this.siticoneButton1.TabIndex = 2;
            this.siticoneButton1.Text = "Dashboard";
            this.siticoneButton1.TextOffset = new System.Drawing.Point(-12, 0);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 481);
            this.Controls.Add(this.stpSideMenu);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MinimumSize = new System.Drawing.Size(843, 520);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Management System";
            this.stpSideMenu.ResumeLayout(false);
            this.mspDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel stpSideMenu;
        private Siticone.UI.WinForms.SiticoneButton mbtnDashboard;
        private Siticone.UI.WinForms.SiticonePanel mspDashboard;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
    }
}


namespace SchoolManagement.Controls
{
    partial class UCTeacher
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbRegister = new Siticone.UI.WinForms.SiticoneButton();
            this.sucTeacherDis1 = new SchoolManagement.Controls.SUCTeacherDis(this.sbRegister);
            this.sucTeacherRegist1 = new SchoolManagement.Controls.SUCTeacherRegist();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sbAllTeachers = new Siticone.UI.WinForms.SiticoneButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.sucTeacherDis1);
            this.panel1.Controls.Add(this.sucTeacherRegist1);
            this.panel1.Location = new System.Drawing.Point(3, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 459);
            this.panel1.TabIndex = 1;
            // 
            // sbRegister
            // 
            this.sbRegister.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.sbRegister.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbRegister.CheckedState.ForeColor = System.Drawing.Color.White;
            this.sbRegister.CheckedState.Parent = this.sbRegister;
            this.sbRegister.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbRegister.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.sbRegister.CustomImages.Parent = this.sbRegister;
            this.sbRegister.Dock = System.Windows.Forms.DockStyle.Left;
            this.sbRegister.FillColor = System.Drawing.Color.White;
            this.sbRegister.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.sbRegister.ForeColor = System.Drawing.Color.Black;
            this.sbRegister.HoveredState.Parent = this.sbRegister;
            this.sbRegister.Location = new System.Drawing.Point(169, 0);
            this.sbRegister.Name = "sbRegister";
            this.sbRegister.ShadowDecoration.Parent = this.sbRegister;
            this.sbRegister.Size = new System.Drawing.Size(169, 35);
            this.sbRegister.TabIndex = 1;
            this.sbRegister.Text = "Register / Update";
            this.sbRegister.CheckedChanged += new System.EventHandler(this.sbRegister_CheckedChanged);
            this.sbRegister.Click += new System.EventHandler(this.sbRegister_Click);
            // 
            // sucTeacherDis1
            // 
            this.sucTeacherDis1.BackColor = System.Drawing.Color.White;
            this.sucTeacherDis1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sucTeacherDis1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sucTeacherDis1.Location = new System.Drawing.Point(0, 0);
            this.sucTeacherDis1.Margin = new System.Windows.Forms.Padding(4);
            this.sucTeacherDis1.Name = "sucTeacherDis1";
            this.sucTeacherDis1.Size = new System.Drawing.Size(744, 459);
            this.sucTeacherDis1.TabIndex = 2;
            this.sucTeacherDis1.Tid = ((long)(0));
            // 
            // sucTeacherRegist1
            // 
            this.sucTeacherRegist1.BackColor = System.Drawing.Color.White;
            this.sucTeacherRegist1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sucTeacherRegist1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sucTeacherRegist1.Location = new System.Drawing.Point(0, 0);
            this.sucTeacherRegist1.Margin = new System.Windows.Forms.Padding(4);
            this.sucTeacherRegist1.Name = "sucTeacherRegist1";
            this.sucTeacherRegist1.Size = new System.Drawing.Size(744, 459);
            this.sucTeacherRegist1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.sbRegister);
            this.panel2.Controls.Add(this.sbAllTeachers);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 35);
            this.panel2.TabIndex = 2;
            // 
            // sbAllTeachers
            // 
            this.sbAllTeachers.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.sbAllTeachers.Checked = true;
            this.sbAllTeachers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbAllTeachers.CheckedState.ForeColor = System.Drawing.Color.White;
            this.sbAllTeachers.CheckedState.Parent = this.sbAllTeachers;
            this.sbAllTeachers.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbAllTeachers.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.sbAllTeachers.CustomImages.Parent = this.sbAllTeachers;
            this.sbAllTeachers.Dock = System.Windows.Forms.DockStyle.Left;
            this.sbAllTeachers.FillColor = System.Drawing.Color.White;
            this.sbAllTeachers.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.sbAllTeachers.ForeColor = System.Drawing.Color.Black;
            this.sbAllTeachers.HoveredState.Parent = this.sbAllTeachers;
            this.sbAllTeachers.Location = new System.Drawing.Point(0, 0);
            this.sbAllTeachers.Name = "sbAllTeachers";
            this.sbAllTeachers.ShadowDecoration.Parent = this.sbAllTeachers;
            this.sbAllTeachers.Size = new System.Drawing.Size(169, 35);
            this.sbAllTeachers.TabIndex = 0;
            this.sbAllTeachers.Text = "All Teachers";
            this.sbAllTeachers.Click += new System.EventHandler(this.sbAllTeachers_Click);
            this.sbAllTeachers.DoubleClick += new System.EventHandler(this.sbAllTeachers_DoubleClick);
            // 
            // UCTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCTeacher";
            this.Size = new System.Drawing.Size(750, 506);
            this.Load += new System.EventHandler(this.UCTeacher_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Siticone.UI.WinForms.SiticoneButton sbAllTeachers;
        private SUCTeacherRegist sucTeacherRegist1;
        public Siticone.UI.WinForms.SiticoneButton sbRegister;
        private SUCTeacherDis sucTeacherDis1;
    }
}

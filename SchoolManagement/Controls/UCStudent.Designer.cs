namespace SchoolManagement.Controls
{
    partial class UCStudent
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.sbRegister = new Siticone.UI.WinForms.SiticoneButton();
            this.sbAllStudent = new Siticone.UI.WinForms.SiticoneButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sucCreateStudent1 = new SchoolManagement.Controls.SUCCreateStudent();
            this.sucAllStudent1 = new SchoolManagement.Controls.SUCAllStudent(this.sbRegister);
            this.sucStudentClasses1 = new SchoolManagement.Controls.SUCStudentClasses();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.sbRegister);
            this.panel2.Controls.Add(this.sbAllStudent);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 35);
            this.panel2.TabIndex = 8;
            // 
            // sbRegister
            // 
            this.sbRegister.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.sbRegister.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbRegister.CheckedState.ForeColor = System.Drawing.Color.White;
            this.sbRegister.CheckedState.Parent = this.sbRegister;
            this.sbRegister.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.sbRegister.Text = "Create / Update";
            this.sbRegister.CheckedChanged += new System.EventHandler(this.sbRegister_CheckedChanged);
            this.sbRegister.Click += new System.EventHandler(this.sbRegister_Click);
            // 
            // sbAllStudent
            // 
            this.sbAllStudent.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.sbAllStudent.Checked = true;
            this.sbAllStudent.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbAllStudent.CheckedState.ForeColor = System.Drawing.Color.White;
            this.sbAllStudent.CheckedState.Parent = this.sbAllStudent;
            this.sbAllStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbAllStudent.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbAllStudent.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.sbAllStudent.CustomImages.Parent = this.sbAllStudent;
            this.sbAllStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.sbAllStudent.FillColor = System.Drawing.Color.White;
            this.sbAllStudent.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.sbAllStudent.ForeColor = System.Drawing.Color.Black;
            this.sbAllStudent.HoveredState.Parent = this.sbAllStudent;
            this.sbAllStudent.Location = new System.Drawing.Point(0, 0);
            this.sbAllStudent.Name = "sbAllStudent";
            this.sbAllStudent.ShadowDecoration.Parent = this.sbAllStudent;
            this.sbAllStudent.Size = new System.Drawing.Size(169, 35);
            this.sbAllStudent.TabIndex = 0;
            this.sbAllStudent.Text = "All Students";
            this.sbAllStudent.Click += new System.EventHandler(this.sbAllStudent_Click);
            this.sbAllStudent.DoubleClick += new System.EventHandler(this.sbAllStudent_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.sucStudentClasses1);
            this.panel1.Controls.Add(this.sucCreateStudent1);
            this.panel1.Controls.Add(this.sucAllStudent1);
            this.panel1.Location = new System.Drawing.Point(3, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 474);
            this.panel1.TabIndex = 9;
            // 
            // sucCreateStudent1
            // 
            this.sucCreateStudent1.BackColor = System.Drawing.Color.White;
            this.sucCreateStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sucCreateStudent1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sucCreateStudent1.Location = new System.Drawing.Point(0, 0);
            this.sucCreateStudent1.Margin = new System.Windows.Forms.Padding(4);
            this.sucCreateStudent1.Name = "sucCreateStudent1";
            this.sucCreateStudent1.Size = new System.Drawing.Size(740, 474);
            this.sucCreateStudent1.TabIndex = 1;
            // 
            // sucAllStudent1
            // 
            this.sucAllStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sucAllStudent1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sucAllStudent1.Location = new System.Drawing.Point(0, 0);
            this.sucAllStudent1.Margin = new System.Windows.Forms.Padding(4);
            this.sucAllStudent1.Name = "sucAllStudent1";
            this.sucAllStudent1.Size = new System.Drawing.Size(740, 474);
            this.sucAllStudent1.TabIndex = 0;
            // 
            // sucStudentClasses1
            // 
            this.sucStudentClasses1.BackColor = System.Drawing.Color.White;
            this.sucStudentClasses1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sucStudentClasses1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sucStudentClasses1.Location = new System.Drawing.Point(0, 0);
            this.sucStudentClasses1.Margin = new System.Windows.Forms.Padding(4);
            this.sucStudentClasses1.Name = "sucStudentClasses1";
            this.sucStudentClasses1.Size = new System.Drawing.Size(740, 474);
            this.sucStudentClasses1.TabIndex = 2;
            // 
            // UCStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCStudent";
            this.Size = new System.Drawing.Size(746, 522);
            this.Load += new System.EventHandler(this.UCStudent_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public Siticone.UI.WinForms.SiticoneButton sbRegister;
        private Siticone.UI.WinForms.SiticoneButton sbAllStudent;
        private System.Windows.Forms.Panel panel1;
        private SUCAllStudent sucAllStudent1;
        private SUCCreateStudent sucCreateStudent1;
        private SUCStudentClasses sucStudentClasses1;
    }
}

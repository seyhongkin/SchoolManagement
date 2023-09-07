namespace SchoolManagement.Controls
{
    partial class SUCCreateClass
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
            this.scbCourse = new Siticone.UI.WinForms.SiticoneComboBox();
            this.sbDelete = new Siticone.UI.WinForms.SiticoneButton();
            this.lbMsg = new System.Windows.Forms.Label();
            this.sbClear = new Siticone.UI.WinForms.SiticoneButton();
            this.sbConfirm = new Siticone.UI.WinForms.SiticoneButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stxtSection = new Siticone.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scbRoom = new Siticone.UI.WinForms.SiticoneComboBox();
            this.scbTeacher = new Siticone.UI.WinForms.SiticoneComboBox();
            this.sdtStart = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.sdtEnd = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.SuspendLayout();
            // 
            // scbCourse
            // 
            this.scbCourse.BackColor = System.Drawing.Color.Transparent;
            this.scbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.scbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scbCourse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.scbCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.scbCourse.FormattingEnabled = true;
            this.scbCourse.HoveredState.Parent = this.scbCourse;
            this.scbCourse.ItemHeight = 30;
            this.scbCourse.Items.AddRange(new object[] {
            "Null"});
            this.scbCourse.ItemsAppearance.Parent = this.scbCourse;
            this.scbCourse.Location = new System.Drawing.Point(23, 42);
            this.scbCourse.Name = "scbCourse";
            this.scbCourse.ShadowDecoration.Parent = this.scbCourse;
            this.scbCourse.Size = new System.Drawing.Size(344, 36);
            this.scbCourse.Sorted = true;
            this.scbCourse.TabIndex = 73;
            this.scbCourse.SelectedIndexChanged += new System.EventHandler(this.scbCourse_SelectedIndexChanged);
            // 
            // sbDelete
            // 
            this.sbDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sbDelete.CheckedState.Parent = this.sbDelete;
            this.sbDelete.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sbDelete.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.sbDelete.CustomImages.Parent = this.sbDelete;
            this.sbDelete.FillColor = System.Drawing.Color.White;
            this.sbDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sbDelete.HoveredState.Parent = this.sbDelete;
            this.sbDelete.Location = new System.Drawing.Point(570, 413);
            this.sbDelete.Name = "sbDelete";
            this.sbDelete.PressedColor = System.Drawing.Color.Gainsboro;
            this.sbDelete.ShadowDecoration.Parent = this.sbDelete;
            this.sbDelete.Size = new System.Drawing.Size(146, 38);
            this.sbDelete.TabIndex = 72;
            this.sbDelete.Text = "Delete This";
            this.sbDelete.Visible = false;
            this.sbDelete.Click += new System.EventHandler(this.sbDelete_Click);
            // 
            // lbMsg
            // 
            this.lbMsg.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsg.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbMsg.Location = new System.Drawing.Point(20, 231);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(364, 22);
            this.lbMsg.TabIndex = 71;
            // 
            // sbClear
            // 
            this.sbClear.CheckedState.Parent = this.sbClear;
            this.sbClear.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.sbClear.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.sbClear.CustomImages.Parent = this.sbClear;
            this.sbClear.FillColor = System.Drawing.Color.White;
            this.sbClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbClear.ForeColor = System.Drawing.Color.Black;
            this.sbClear.HoveredState.Parent = this.sbClear;
            this.sbClear.Location = new System.Drawing.Point(617, 180);
            this.sbClear.Name = "sbClear";
            this.sbClear.ShadowDecoration.Parent = this.sbClear;
            this.sbClear.Size = new System.Drawing.Size(108, 38);
            this.sbClear.TabIndex = 70;
            this.sbClear.Text = "Clear";
            this.sbClear.Click += new System.EventHandler(this.sbClear_Click);
            // 
            // sbConfirm
            // 
            this.sbConfirm.CheckedState.Parent = this.sbConfirm;
            this.sbConfirm.CustomImages.Parent = this.sbConfirm;
            this.sbConfirm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbConfirm.ForeColor = System.Drawing.Color.White;
            this.sbConfirm.HoveredState.Parent = this.sbConfirm;
            this.sbConfirm.Location = new System.Drawing.Point(494, 180);
            this.sbConfirm.Name = "sbConfirm";
            this.sbConfirm.ShadowDecoration.Parent = this.sbConfirm;
            this.sbConfirm.Size = new System.Drawing.Size(108, 38);
            this.sbConfirm.TabIndex = 69;
            this.sbConfirm.Text = "Confirm";
            this.sbConfirm.Click += new System.EventHandler(this.sbConfirm_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(375, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 68;
            this.label7.Text = "Teacher";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(250, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 65;
            this.label8.Text = "Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "End Date";
            // 
            // stxtSection
            // 
            this.stxtSection.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stxtSection.DefaultText = "";
            this.stxtSection.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stxtSection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stxtSection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtSection.DisabledState.Parent = this.stxtSection;
            this.stxtSection.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtSection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtSection.FocusedState.Parent = this.stxtSection;
            this.stxtSection.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtSection.HoveredState.Parent = this.stxtSection;
            this.stxtSection.Location = new System.Drawing.Point(23, 180);
            this.stxtSection.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.stxtSection.Name = "stxtSection";
            this.stxtSection.PasswordChar = '\0';
            this.stxtSection.PlaceholderText = "";
            this.stxtSection.SelectedText = "";
            this.stxtSection.ShadowDecoration.Parent = this.stxtSection;
            this.stxtSection.Size = new System.Drawing.Size(216, 38);
            this.stxtSection.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Course";
            // 
            // scbRoom
            // 
            this.scbRoom.BackColor = System.Drawing.Color.Transparent;
            this.scbRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.scbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scbRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.scbRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.scbRoom.FormattingEnabled = true;
            this.scbRoom.HoveredState.Parent = this.scbRoom;
            this.scbRoom.ItemHeight = 30;
            this.scbRoom.Items.AddRange(new object[] {
            "Null"});
            this.scbRoom.ItemsAppearance.Parent = this.scbRoom;
            this.scbRoom.Location = new System.Drawing.Point(24, 110);
            this.scbRoom.Name = "scbRoom";
            this.scbRoom.ShadowDecoration.Parent = this.scbRoom;
            this.scbRoom.Size = new System.Drawing.Size(220, 36);
            this.scbRoom.Sorted = true;
            this.scbRoom.TabIndex = 74;
            this.scbRoom.SelectedIndexChanged += new System.EventHandler(this.scbRoom_SelectedIndexChanged);
            // 
            // scbTeacher
            // 
            this.scbTeacher.BackColor = System.Drawing.Color.Transparent;
            this.scbTeacher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.scbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scbTeacher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.scbTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.scbTeacher.FormattingEnabled = true;
            this.scbTeacher.HoveredState.Parent = this.scbTeacher;
            this.scbTeacher.ItemHeight = 30;
            this.scbTeacher.Items.AddRange(new object[] {
            "Null"});
            this.scbTeacher.ItemsAppearance.Parent = this.scbTeacher;
            this.scbTeacher.Location = new System.Drawing.Point(379, 42);
            this.scbTeacher.Name = "scbTeacher";
            this.scbTeacher.ShadowDecoration.Parent = this.scbTeacher;
            this.scbTeacher.Size = new System.Drawing.Size(344, 36);
            this.scbTeacher.Sorted = true;
            this.scbTeacher.TabIndex = 75;
            this.scbTeacher.SelectedIndexChanged += new System.EventHandler(this.scbTeacher_SelectedIndexChanged);
            // 
            // sdtStart
            // 
            this.sdtStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.sdtStart.BorderThickness = 1;
            this.sdtStart.CheckedState.Parent = this.sdtStart;
            this.sdtStart.FillColor = System.Drawing.Color.White;
            this.sdtStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.sdtStart.HoveredState.Parent = this.sdtStart;
            this.sdtStart.Location = new System.Drawing.Point(254, 110);
            this.sdtStart.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.sdtStart.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.sdtStart.Name = "sdtStart";
            this.sdtStart.ShadowDecoration.Parent = this.sdtStart;
            this.sdtStart.Size = new System.Drawing.Size(229, 36);
            this.sdtStart.TabIndex = 76;
            this.sdtStart.Value = new System.DateTime(2023, 9, 2, 18, 41, 39, 57);
            // 
            // sdtEnd
            // 
            this.sdtEnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.sdtEnd.BorderThickness = 1;
            this.sdtEnd.CheckedState.Parent = this.sdtEnd;
            this.sdtEnd.FillColor = System.Drawing.Color.White;
            this.sdtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.sdtEnd.HoveredState.Parent = this.sdtEnd;
            this.sdtEnd.Location = new System.Drawing.Point(494, 110);
            this.sdtEnd.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.sdtEnd.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.sdtEnd.Name = "sdtEnd";
            this.sdtEnd.ShadowDecoration.Parent = this.sdtEnd;
            this.sdtEnd.Size = new System.Drawing.Size(229, 36);
            this.sdtEnd.TabIndex = 77;
            this.sdtEnd.Value = new System.DateTime(2023, 9, 2, 18, 41, 39, 57);
            // 
            // SUCCreateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sdtEnd);
            this.Controls.Add(this.sdtStart);
            this.Controls.Add(this.scbTeacher);
            this.Controls.Add(this.scbRoom);
            this.Controls.Add(this.scbCourse);
            this.Controls.Add(this.sbDelete);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.sbClear);
            this.Controls.Add(this.sbConfirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stxtSection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SUCCreateClass";
            this.Size = new System.Drawing.Size(743, 471);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Siticone.UI.WinForms.SiticoneComboBox scbCourse;
        public Siticone.UI.WinForms.SiticoneButton sbDelete;
        public System.Windows.Forms.Label lbMsg;
        private Siticone.UI.WinForms.SiticoneButton sbClear;
        private Siticone.UI.WinForms.SiticoneButton sbConfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public Siticone.UI.WinForms.SiticoneTextBox stxtSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Siticone.UI.WinForms.SiticoneComboBox scbRoom;
        public Siticone.UI.WinForms.SiticoneComboBox scbTeacher;
        public Siticone.UI.WinForms.SiticoneDateTimePicker sdtStart;
        public Siticone.UI.WinForms.SiticoneDateTimePicker sdtEnd;
    }
}

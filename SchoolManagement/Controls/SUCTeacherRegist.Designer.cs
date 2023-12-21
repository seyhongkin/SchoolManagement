namespace SchoolManagement.Controls
{
    partial class SUCTeacherRegist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scbGender = new Siticone.UI.WinForms.SiticoneComboBox();
            this.stxtLNameEng = new Siticone.UI.WinForms.SiticoneTextBox();
            this.stxtLNameKh = new Siticone.UI.WinForms.SiticoneTextBox();
            this.stxtFNameKh = new Siticone.UI.WinForms.SiticoneTextBox();
            this.stxtFNameEng = new Siticone.UI.WinForms.SiticoneTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sdtDob = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.stxtEmailAdress = new Siticone.UI.WinForms.SiticoneTextBox();
            this.stxtPhoneNum = new Siticone.UI.WinForms.SiticoneTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sbUpload = new Siticone.UI.WinForms.SiticoneButton();
            this.sbConfirm = new Siticone.UI.WinForms.SiticoneButton();
            this.sbClear = new Siticone.UI.WinForms.SiticoneButton();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.lbFilePath = new System.Windows.Forms.Label();
            this.spiLoading = new Siticone.UI.WinForms.SiticoneProgressIndicator();
            this.sbRemoveImg = new Siticone.UI.WinForms.SiticoneButton();
            this.lbMsg = new System.Windows.Forms.Label();
            this.sbDelete = new Siticone.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "នាមត្រកូល";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "គោត្ដនាម";
            // 
            // scbGender
            // 
            this.scbGender.BackColor = System.Drawing.Color.Transparent;
            this.scbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.scbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.scbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.scbGender.FormattingEnabled = true;
            this.scbGender.HoveredState.Parent = this.scbGender;
            this.scbGender.ItemHeight = 30;
            this.scbGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.scbGender.ItemsAppearance.Parent = this.scbGender;
            this.scbGender.Location = new System.Drawing.Point(37, 185);
            this.scbGender.Name = "scbGender";
            this.scbGender.ShadowDecoration.Parent = this.scbGender;
            this.scbGender.Size = new System.Drawing.Size(239, 36);
            this.scbGender.TabIndex = 9;
            // 
            // stxtLNameEng
            // 
            this.stxtLNameEng.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stxtLNameEng.DefaultText = "";
            this.stxtLNameEng.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stxtLNameEng.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stxtLNameEng.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtLNameEng.DisabledState.Parent = this.stxtLNameEng;
            this.stxtLNameEng.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtLNameEng.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtLNameEng.FocusedState.Parent = this.stxtLNameEng;
            this.stxtLNameEng.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtLNameEng.HoveredState.Parent = this.stxtLNameEng;
            this.stxtLNameEng.Location = new System.Drawing.Point(37, 44);
            this.stxtLNameEng.Margin = new System.Windows.Forms.Padding(4);
            this.stxtLNameEng.Name = "stxtLNameEng";
            this.stxtLNameEng.PasswordChar = '\0';
            this.stxtLNameEng.PlaceholderText = "";
            this.stxtLNameEng.SelectedText = "";
            this.stxtLNameEng.ShadowDecoration.Parent = this.stxtLNameEng;
            this.stxtLNameEng.Size = new System.Drawing.Size(239, 37);
            this.stxtLNameEng.TabIndex = 10;
            // 
            // stxtLNameKh
            // 
            this.stxtLNameKh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stxtLNameKh.DefaultText = "";
            this.stxtLNameKh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stxtLNameKh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stxtLNameKh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtLNameKh.DisabledState.Parent = this.stxtLNameKh;
            this.stxtLNameKh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtLNameKh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtLNameKh.FocusedState.Parent = this.stxtLNameKh;
            this.stxtLNameKh.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtLNameKh.HoveredState.Parent = this.stxtLNameKh;
            this.stxtLNameKh.Location = new System.Drawing.Point(306, 44);
            this.stxtLNameKh.Margin = new System.Windows.Forms.Padding(5);
            this.stxtLNameKh.Name = "stxtLNameKh";
            this.stxtLNameKh.PasswordChar = '\0';
            this.stxtLNameKh.PlaceholderText = "";
            this.stxtLNameKh.SelectedText = "";
            this.stxtLNameKh.ShadowDecoration.Parent = this.stxtLNameKh;
            this.stxtLNameKh.Size = new System.Drawing.Size(237, 37);
            this.stxtLNameKh.TabIndex = 11;
            // 
            // stxtFNameKh
            // 
            this.stxtFNameKh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stxtFNameKh.DefaultText = "";
            this.stxtFNameKh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stxtFNameKh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stxtFNameKh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtFNameKh.DisabledState.Parent = this.stxtFNameKh;
            this.stxtFNameKh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtFNameKh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtFNameKh.FocusedState.Parent = this.stxtFNameKh;
            this.stxtFNameKh.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtFNameKh.HoveredState.Parent = this.stxtFNameKh;
            this.stxtFNameKh.Location = new System.Drawing.Point(306, 116);
            this.stxtFNameKh.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.stxtFNameKh.Name = "stxtFNameKh";
            this.stxtFNameKh.PasswordChar = '\0';
            this.stxtFNameKh.PlaceholderText = "";
            this.stxtFNameKh.SelectedText = "";
            this.stxtFNameKh.ShadowDecoration.Parent = this.stxtFNameKh;
            this.stxtFNameKh.Size = new System.Drawing.Size(237, 37);
            this.stxtFNameKh.TabIndex = 13;
            // 
            // stxtFNameEng
            // 
            this.stxtFNameEng.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stxtFNameEng.DefaultText = "";
            this.stxtFNameEng.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stxtFNameEng.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stxtFNameEng.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtFNameEng.DisabledState.Parent = this.stxtFNameEng;
            this.stxtFNameEng.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtFNameEng.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtFNameEng.FocusedState.Parent = this.stxtFNameEng;
            this.stxtFNameEng.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtFNameEng.HoveredState.Parent = this.stxtFNameEng;
            this.stxtFNameEng.Location = new System.Drawing.Point(37, 116);
            this.stxtFNameEng.Margin = new System.Windows.Forms.Padding(5);
            this.stxtFNameEng.Name = "stxtFNameEng";
            this.stxtFNameEng.PasswordChar = '\0';
            this.stxtFNameEng.PlaceholderText = "";
            this.stxtFNameEng.SelectedText = "";
            this.stxtFNameEng.ShadowDecoration.Parent = this.stxtFNameEng;
            this.stxtFNameEng.Size = new System.Drawing.Size(239, 37);
            this.stxtFNameEng.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gender";
            // 
            // sdtDob
            // 
            this.sdtDob.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.sdtDob.BorderThickness = 1;
            this.sdtDob.CheckedState.Parent = this.sdtDob;
            this.sdtDob.FillColor = System.Drawing.Color.White;
            this.sdtDob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.sdtDob.HoveredState.Parent = this.sdtDob;
            this.sdtDob.Location = new System.Drawing.Point(306, 185);
            this.sdtDob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.sdtDob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.sdtDob.Name = "sdtDob";
            this.sdtDob.ShadowDecoration.Parent = this.sdtDob;
            this.sdtDob.Size = new System.Drawing.Size(237, 36);
            this.sdtDob.TabIndex = 16;
            this.sdtDob.Value = new System.DateTime(2023, 9, 2, 18, 41, 39, 57);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date of Birth";
            // 
            // stxtEmailAdress
            // 
            this.stxtEmailAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stxtEmailAdress.DefaultText = "";
            this.stxtEmailAdress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stxtEmailAdress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stxtEmailAdress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtEmailAdress.DisabledState.Parent = this.stxtEmailAdress;
            this.stxtEmailAdress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtEmailAdress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtEmailAdress.FocusedState.Parent = this.stxtEmailAdress;
            this.stxtEmailAdress.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtEmailAdress.HoveredState.Parent = this.stxtEmailAdress;
            this.stxtEmailAdress.Location = new System.Drawing.Point(306, 260);
            this.stxtEmailAdress.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.stxtEmailAdress.Name = "stxtEmailAdress";
            this.stxtEmailAdress.PasswordChar = '\0';
            this.stxtEmailAdress.PlaceholderText = "";
            this.stxtEmailAdress.SelectedText = "";
            this.stxtEmailAdress.ShadowDecoration.Parent = this.stxtEmailAdress;
            this.stxtEmailAdress.Size = new System.Drawing.Size(239, 37);
            this.stxtEmailAdress.TabIndex = 21;
            // 
            // stxtPhoneNum
            // 
            this.stxtPhoneNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stxtPhoneNum.DefaultText = "";
            this.stxtPhoneNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stxtPhoneNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stxtPhoneNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtPhoneNum.DisabledState.Parent = this.stxtPhoneNum;
            this.stxtPhoneNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stxtPhoneNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtPhoneNum.FocusedState.Parent = this.stxtPhoneNum;
            this.stxtPhoneNum.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stxtPhoneNum.HoveredState.Parent = this.stxtPhoneNum;
            this.stxtPhoneNum.Location = new System.Drawing.Point(37, 260);
            this.stxtPhoneNum.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.stxtPhoneNum.Name = "stxtPhoneNum";
            this.stxtPhoneNum.PasswordChar = '\0';
            this.stxtPhoneNum.PlaceholderText = "";
            this.stxtPhoneNum.SelectedText = "";
            this.stxtPhoneNum.ShadowDecoration.Parent = this.stxtPhoneNum;
            this.stxtPhoneNum.Size = new System.Drawing.Size(239, 37);
            this.stxtPhoneNum.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(303, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Email Adress";
            // 
            // sbUpload
            // 
            this.sbUpload.CheckedState.Parent = this.sbUpload;
            this.sbUpload.CustomImages.Parent = this.sbUpload;
            this.sbUpload.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbUpload.ForeColor = System.Drawing.Color.White;
            this.sbUpload.HoveredState.Parent = this.sbUpload;
            this.sbUpload.Location = new System.Drawing.Point(573, 205);
            this.sbUpload.Name = "sbUpload";
            this.sbUpload.ShadowDecoration.Parent = this.sbUpload;
            this.sbUpload.Size = new System.Drawing.Size(146, 38);
            this.sbUpload.TabIndex = 23;
            this.sbUpload.Text = "Upload";
            this.sbUpload.Click += new System.EventHandler(this.sbUpload_Click);
            // 
            // sbConfirm
            // 
            this.sbConfirm.CheckedState.Parent = this.sbConfirm;
            this.sbConfirm.CustomImages.Parent = this.sbConfirm;
            this.sbConfirm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbConfirm.ForeColor = System.Drawing.Color.White;
            this.sbConfirm.HoveredState.Parent = this.sbConfirm;
            this.sbConfirm.Location = new System.Drawing.Point(37, 310);
            this.sbConfirm.Name = "sbConfirm";
            this.sbConfirm.ShadowDecoration.Parent = this.sbConfirm;
            this.sbConfirm.Size = new System.Drawing.Size(146, 38);
            this.sbConfirm.TabIndex = 24;
            this.sbConfirm.Text = "Confirm";
            this.sbConfirm.Click += new System.EventHandler(this.sbConfirm_Click);
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
            this.sbClear.Location = new System.Drawing.Point(189, 310);
            this.sbClear.Name = "sbClear";
            this.sbClear.ShadowDecoration.Parent = this.sbClear;
            this.sbClear.Size = new System.Drawing.Size(146, 38);
            this.sbClear.TabIndex = 25;
            this.sbClear.Text = "Clear";
            this.sbClear.Click += new System.EventHandler(this.sbClear_Click);
            // 
            // pbImg
            // 
            this.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg.Location = new System.Drawing.Point(573, 18);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(146, 176);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 26;
            this.pbImg.TabStop = false;
            // 
            // lbFilePath
            // 
            this.lbFilePath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilePath.Location = new System.Drawing.Point(355, 318);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(364, 22);
            this.lbFilePath.TabIndex = 27;
            // 
            // spiLoading
            // 
            this.spiLoading.AutoStart = true;
            this.spiLoading.CircleSize = 1F;
            this.spiLoading.Location = new System.Drawing.Point(628, 88);
            this.spiLoading.Name = "spiLoading";
            this.spiLoading.Size = new System.Drawing.Size(37, 37);
            this.spiLoading.TabIndex = 28;
            // 
            // sbRemoveImg
            // 
            this.sbRemoveImg.CheckedState.Parent = this.sbRemoveImg;
            this.sbRemoveImg.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.sbRemoveImg.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.sbRemoveImg.CustomImages.Parent = this.sbRemoveImg;
            this.sbRemoveImg.FillColor = System.Drawing.Color.White;
            this.sbRemoveImg.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbRemoveImg.ForeColor = System.Drawing.Color.Black;
            this.sbRemoveImg.HoveredState.Parent = this.sbRemoveImg;
            this.sbRemoveImg.Location = new System.Drawing.Point(573, 249);
            this.sbRemoveImg.Name = "sbRemoveImg";
            this.sbRemoveImg.ShadowDecoration.Parent = this.sbRemoveImg;
            this.sbRemoveImg.Size = new System.Drawing.Size(146, 38);
            this.sbRemoveImg.TabIndex = 29;
            this.sbRemoveImg.Text = "Remove Image";
            this.sbRemoveImg.Click += new System.EventHandler(this.sbRemoveImg_Click);
            // 
            // lbMsg
            // 
            this.lbMsg.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsg.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbMsg.Location = new System.Drawing.Point(34, 358);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(364, 22);
            this.lbMsg.TabIndex = 30;
            // 
            // sbDelete
            // 
            this.sbDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sbDelete.CheckedState.Parent = this.sbDelete;
            this.sbDelete.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sbDelete.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.sbDelete.CustomImages.Parent = this.sbDelete;
            this.sbDelete.FillColor = System.Drawing.Color.White;
            this.sbDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sbDelete.HoveredState.Parent = this.sbDelete;
            this.sbDelete.Location = new System.Drawing.Point(573, 416);
            this.sbDelete.Name = "sbDelete";
            this.sbDelete.PressedColor = System.Drawing.Color.Gainsboro;
            this.sbDelete.ShadowDecoration.Parent = this.sbDelete;
            this.sbDelete.Size = new System.Drawing.Size(146, 38);
            this.sbDelete.TabIndex = 31;
            this.sbDelete.Text = "Delete This";
            this.sbDelete.Visible = false;
            this.sbDelete.Click += new System.EventHandler(this.sbDelete_Click);
            // 
            // SUCTeacherRegist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sbDelete);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.sbRemoveImg);
            this.Controls.Add(this.lbFilePath);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.sbClear);
            this.Controls.Add(this.sbConfirm);
            this.Controls.Add(this.sbUpload);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stxtEmailAdress);
            this.Controls.Add(this.stxtPhoneNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sdtDob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stxtFNameKh);
            this.Controls.Add(this.stxtFNameEng);
            this.Controls.Add(this.stxtLNameKh);
            this.Controls.Add(this.stxtLNameEng);
            this.Controls.Add(this.scbGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spiLoading);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SUCTeacherRegist";
            this.Size = new System.Drawing.Size(743, 471);
            this.Load += new System.EventHandler(this.SUCTeacherRegist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Siticone.UI.WinForms.SiticoneButton sbUpload;
        private Siticone.UI.WinForms.SiticoneButton sbConfirm;
        private Siticone.UI.WinForms.SiticoneButton sbClear;
        public Siticone.UI.WinForms.SiticoneComboBox scbGender;
        public Siticone.UI.WinForms.SiticoneTextBox stxtLNameEng;
        public Siticone.UI.WinForms.SiticoneTextBox stxtLNameKh;
        public Siticone.UI.WinForms.SiticoneTextBox stxtFNameKh;
        public Siticone.UI.WinForms.SiticoneTextBox stxtFNameEng;
        public Siticone.UI.WinForms.SiticoneDateTimePicker sdtDob;
        public Siticone.UI.WinForms.SiticoneTextBox stxtEmailAdress;
        public Siticone.UI.WinForms.SiticoneTextBox stxtPhoneNum;
        public System.Windows.Forms.PictureBox pbImg;
        public Siticone.UI.WinForms.SiticoneProgressIndicator spiLoading;
        private Siticone.UI.WinForms.SiticoneButton sbRemoveImg;
        public System.Windows.Forms.Label lbFilePath;
        public System.Windows.Forms.Label lbMsg;
        public Siticone.UI.WinForms.SiticoneButton sbDelete;
    }
}

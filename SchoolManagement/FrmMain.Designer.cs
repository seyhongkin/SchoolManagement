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
            this.spMenu = new Siticone.UI.WinForms.SiticonePanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sbmSettings = new Siticone.UI.WinForms.SiticoneButton();
            this.sbmLogout = new Siticone.UI.WinForms.SiticoneButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spSubExaminations = new Siticone.UI.WinForms.SiticonePanel();
            this.smResults = new Siticone.UI.WinForms.SiticoneButton();
            this.smTimeTables = new Siticone.UI.WinForms.SiticoneButton();
            this.sbmExam = new Siticone.UI.WinForms.SiticoneButton();
            this.spSubInformations = new Siticone.UI.WinForms.SiticonePanel();
            this.smClasses = new Siticone.UI.WinForms.SiticoneButton();
            this.smStudents = new Siticone.UI.WinForms.SiticoneButton();
            this.sbmInformations = new Siticone.UI.WinForms.SiticoneButton();
            this.sbmTransactions = new Siticone.UI.WinForms.SiticoneButton();
            this.spSubAdministrator = new Siticone.UI.WinForms.SiticonePanel();
            this.smCourse = new Siticone.UI.WinForms.SiticoneButton();
            this.smClassroom = new Siticone.UI.WinForms.SiticoneButton();
            this.smTeacher = new Siticone.UI.WinForms.SiticoneButton();
            this.smUser = new Siticone.UI.WinForms.SiticoneButton();
            this.sbmAdministrator = new Siticone.UI.WinForms.SiticoneButton();
            this.sbmDashboard = new Siticone.UI.WinForms.SiticoneButton();
            this.spbSlide = new Siticone.UI.WinForms.SiticonePictureBox();
            this.siticonePanel2 = new Siticone.UI.WinForms.SiticonePanel();
            this.siticoneControlBox3 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucTransaction1 = new SchoolManagement.Controls.UCTransaction();
            this.ucDashboard1 = new SchoolManagement.Controls.UCDashboard();
            this.lbHeader = new System.Windows.Forms.Label();
            this.spMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.spSubExaminations.SuspendLayout();
            this.spSubInformations.SuspendLayout();
            this.spSubAdministrator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spbSlide)).BeginInit();
            this.siticonePanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // spMenu
            // 
            this.spMenu.BackColor = System.Drawing.Color.White;
            this.spMenu.Controls.Add(this.panel2);
            this.spMenu.Controls.Add(this.panel1);
            this.spMenu.Controls.Add(this.spbSlide);
            this.spMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.spMenu.Location = new System.Drawing.Point(0, 0);
            this.spMenu.Name = "spMenu";
            this.spMenu.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.spMenu.ShadowDecoration.Enabled = true;
            this.spMenu.ShadowDecoration.Parent = this.spMenu;
            this.spMenu.Size = new System.Drawing.Size(200, 596);
            this.spMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.sbmSettings);
            this.panel2.Controls.Add(this.sbmLogout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 74);
            this.panel2.TabIndex = 9;
            // 
            // sbmSettings
            // 
            this.sbmSettings.BackColor = System.Drawing.Color.White;
            this.sbmSettings.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.sbmSettings.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbmSettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sbmSettings.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbmSettings.CheckedState.Image = global::SchoolManagement.Properties.Resources.settings__1_;
            this.sbmSettings.CheckedState.Parent = this.sbmSettings;
            this.sbmSettings.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.sbmSettings.CustomImages.Parent = this.sbmSettings;
            this.sbmSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sbmSettings.FillColor = System.Drawing.Color.White;
            this.sbmSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbmSettings.ForeColor = System.Drawing.Color.Black;
            this.sbmSettings.HoveredState.Parent = this.sbmSettings;
            this.sbmSettings.Image = global::SchoolManagement.Properties.Resources.settings;
            this.sbmSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbmSettings.ImageOffset = new System.Drawing.Point(14, 0);
            this.sbmSettings.ImageSize = new System.Drawing.Size(16, 16);
            this.sbmSettings.Location = new System.Drawing.Point(0, 0);
            this.sbmSettings.Name = "sbmSettings";
            this.sbmSettings.ShadowDecoration.Parent = this.sbmSettings;
            this.sbmSettings.Size = new System.Drawing.Size(200, 37);
            this.sbmSettings.TabIndex = 10;
            this.sbmSettings.Text = "Settings";
            this.sbmSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbmSettings.TextOffset = new System.Drawing.Point(22, 0);
            this.sbmSettings.CheckedChanged += new System.EventHandler(this.sbmSettings_CheckedChanged);
            this.sbmSettings.Click += new System.EventHandler(this.sbmSettings_Click);
            // 
            // sbmLogout
            // 
            this.sbmLogout.BackColor = System.Drawing.Color.White;
            this.sbmLogout.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbmLogout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sbmLogout.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbmLogout.CheckedState.Image = global::SchoolManagement.Properties.Resources.dashboard;
            this.sbmLogout.CheckedState.Parent = this.sbmLogout;
            this.sbmLogout.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.sbmLogout.CustomImages.Parent = this.sbmLogout;
            this.sbmLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sbmLogout.FillColor = System.Drawing.Color.White;
            this.sbmLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbmLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(38)))), ((int)(((byte)(76)))));
            this.sbmLogout.HoveredState.Parent = this.sbmLogout;
            this.sbmLogout.Image = global::SchoolManagement.Properties.Resources.power_off;
            this.sbmLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbmLogout.ImageOffset = new System.Drawing.Point(14, 0);
            this.sbmLogout.ImageSize = new System.Drawing.Size(18, 18);
            this.sbmLogout.Location = new System.Drawing.Point(0, 37);
            this.sbmLogout.Name = "sbmLogout";
            this.sbmLogout.ShadowDecoration.Parent = this.sbmLogout;
            this.sbmLogout.Size = new System.Drawing.Size(200, 37);
            this.sbmLogout.TabIndex = 9;
            this.sbmLogout.Text = "Logout";
            this.sbmLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbmLogout.TextOffset = new System.Drawing.Point(22, 0);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.spSubExaminations);
            this.panel1.Controls.Add(this.sbmExam);
            this.panel1.Controls.Add(this.spSubInformations);
            this.panel1.Controls.Add(this.sbmInformations);
            this.panel1.Controls.Add(this.sbmTransactions);
            this.panel1.Controls.Add(this.spSubAdministrator);
            this.panel1.Controls.Add(this.sbmAdministrator);
            this.panel1.Controls.Add(this.sbmDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 380);
            this.panel1.TabIndex = 8;
            // 
            // spSubExaminations
            // 
            this.spSubExaminations.AutoSize = true;
            this.spSubExaminations.Controls.Add(this.smResults);
            this.spSubExaminations.Controls.Add(this.smTimeTables);
            this.spSubExaminations.Dock = System.Windows.Forms.DockStyle.Top;
            this.spSubExaminations.Location = new System.Drawing.Point(0, 407);
            this.spSubExaminations.Name = "spSubExaminations";
            this.spSubExaminations.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.spSubExaminations.ShadowDecoration.Parent = this.spSubExaminations;
            this.spSubExaminations.Size = new System.Drawing.Size(183, 74);
            this.spSubExaminations.TabIndex = 29;
            this.spSubExaminations.Visible = false;
            this.spSubExaminations.VisibleChanged += new System.EventHandler(this.spSubExaminations_VisibleChanged);
            // 
            // smResults
            // 
            this.smResults.BackColor = System.Drawing.Color.White;
            this.smResults.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.smResults.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smResults.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.smResults.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smResults.CheckedState.Image = global::SchoolManagement.Properties.Resources.analysis__1_;
            this.smResults.CheckedState.Parent = this.smResults;
            this.smResults.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.smResults.CustomImages.Parent = this.smResults;
            this.smResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.smResults.FillColor = System.Drawing.Color.White;
            this.smResults.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smResults.ForeColor = System.Drawing.Color.Black;
            this.smResults.HoveredState.Parent = this.smResults;
            this.smResults.Image = global::SchoolManagement.Properties.Resources.analysis;
            this.smResults.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smResults.ImageOffset = new System.Drawing.Point(14, 0);
            this.smResults.ImageSize = new System.Drawing.Size(16, 16);
            this.smResults.Location = new System.Drawing.Point(4, 37);
            this.smResults.Name = "smResults";
            this.smResults.ShadowDecoration.Parent = this.smResults;
            this.smResults.Size = new System.Drawing.Size(179, 37);
            this.smResults.TabIndex = 13;
            this.smResults.Text = "Results";
            this.smResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smResults.TextOffset = new System.Drawing.Point(22, 0);
            // 
            // smTimeTables
            // 
            this.smTimeTables.BackColor = System.Drawing.Color.White;
            this.smTimeTables.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.smTimeTables.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smTimeTables.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.smTimeTables.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smTimeTables.CheckedState.Image = global::SchoolManagement.Properties.Resources.calendar__2_;
            this.smTimeTables.CheckedState.Parent = this.smTimeTables;
            this.smTimeTables.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.smTimeTables.CustomImages.Parent = this.smTimeTables;
            this.smTimeTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.smTimeTables.FillColor = System.Drawing.Color.White;
            this.smTimeTables.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smTimeTables.ForeColor = System.Drawing.Color.Black;
            this.smTimeTables.HoveredState.Parent = this.smTimeTables;
            this.smTimeTables.Image = global::SchoolManagement.Properties.Resources.calendar__1_;
            this.smTimeTables.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smTimeTables.ImageOffset = new System.Drawing.Point(14, 0);
            this.smTimeTables.ImageSize = new System.Drawing.Size(16, 16);
            this.smTimeTables.Location = new System.Drawing.Point(4, 0);
            this.smTimeTables.Name = "smTimeTables";
            this.smTimeTables.ShadowDecoration.Parent = this.smTimeTables;
            this.smTimeTables.Size = new System.Drawing.Size(179, 37);
            this.smTimeTables.TabIndex = 12;
            this.smTimeTables.Text = "Time Tables";
            this.smTimeTables.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smTimeTables.TextOffset = new System.Drawing.Point(22, 0);
            // 
            // sbmExam
            // 
            this.sbmExam.BackColor = System.Drawing.Color.White;
            this.sbmExam.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.sbmExam.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbmExam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sbmExam.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbmExam.CheckedState.Image = global::SchoolManagement.Properties.Resources.test_results__1_;
            this.sbmExam.CheckedState.Parent = this.sbmExam;
            this.sbmExam.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.sbmExam.CustomImages.Parent = this.sbmExam;
            this.sbmExam.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbmExam.FillColor = System.Drawing.Color.White;
            this.sbmExam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbmExam.ForeColor = System.Drawing.Color.Black;
            this.sbmExam.HoveredState.Parent = this.sbmExam;
            this.sbmExam.Image = global::SchoolManagement.Properties.Resources.test_results;
            this.sbmExam.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbmExam.ImageOffset = new System.Drawing.Point(14, 0);
            this.sbmExam.ImageSize = new System.Drawing.Size(16, 16);
            this.sbmExam.Location = new System.Drawing.Point(0, 370);
            this.sbmExam.Name = "sbmExam";
            this.sbmExam.ShadowDecoration.Parent = this.sbmExam;
            this.sbmExam.Size = new System.Drawing.Size(183, 37);
            this.sbmExam.TabIndex = 28;
            this.sbmExam.Text = "Examinations";
            this.sbmExam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbmExam.TextOffset = new System.Drawing.Point(22, 0);
            this.sbmExam.Click += new System.EventHandler(this.sbmExam_Click);
            // 
            // spSubInformations
            // 
            this.spSubInformations.AutoSize = true;
            this.spSubInformations.Controls.Add(this.smClasses);
            this.spSubInformations.Controls.Add(this.smStudents);
            this.spSubInformations.Dock = System.Windows.Forms.DockStyle.Top;
            this.spSubInformations.Location = new System.Drawing.Point(0, 296);
            this.spSubInformations.Name = "spSubInformations";
            this.spSubInformations.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.spSubInformations.ShadowDecoration.Parent = this.spSubInformations;
            this.spSubInformations.Size = new System.Drawing.Size(183, 74);
            this.spSubInformations.TabIndex = 27;
            this.spSubInformations.Visible = false;
            this.spSubInformations.VisibleChanged += new System.EventHandler(this.spSubInformations_VisibleChanged);
            // 
            // smClasses
            // 
            this.smClasses.BackColor = System.Drawing.Color.White;
            this.smClasses.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.smClasses.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smClasses.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.smClasses.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smClasses.CheckedState.Image = global::SchoolManagement.Properties.Resources.learning__1_;
            this.smClasses.CheckedState.Parent = this.smClasses;
            this.smClasses.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.smClasses.CustomImages.Parent = this.smClasses;
            this.smClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.smClasses.FillColor = System.Drawing.Color.White;
            this.smClasses.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smClasses.ForeColor = System.Drawing.Color.Black;
            this.smClasses.HoveredState.Parent = this.smClasses;
            this.smClasses.Image = global::SchoolManagement.Properties.Resources.learning;
            this.smClasses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smClasses.ImageOffset = new System.Drawing.Point(14, 0);
            this.smClasses.ImageSize = new System.Drawing.Size(18, 18);
            this.smClasses.Location = new System.Drawing.Point(4, 37);
            this.smClasses.Name = "smClasses";
            this.smClasses.ShadowDecoration.Parent = this.smClasses;
            this.smClasses.Size = new System.Drawing.Size(179, 37);
            this.smClasses.TabIndex = 13;
            this.smClasses.Text = "Classes";
            this.smClasses.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smClasses.TextOffset = new System.Drawing.Point(22, 0);
            // 
            // smStudents
            // 
            this.smStudents.BackColor = System.Drawing.Color.White;
            this.smStudents.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.smStudents.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smStudents.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.smStudents.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smStudents.CheckedState.Image = global::SchoolManagement.Properties.Resources.reading_book__1_;
            this.smStudents.CheckedState.Parent = this.smStudents;
            this.smStudents.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.smStudents.CustomImages.Parent = this.smStudents;
            this.smStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.smStudents.FillColor = System.Drawing.Color.White;
            this.smStudents.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smStudents.ForeColor = System.Drawing.Color.Black;
            this.smStudents.HoveredState.Parent = this.smStudents;
            this.smStudents.Image = global::SchoolManagement.Properties.Resources.reading_book;
            this.smStudents.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smStudents.ImageOffset = new System.Drawing.Point(14, 0);
            this.smStudents.ImageSize = new System.Drawing.Size(18, 18);
            this.smStudents.Location = new System.Drawing.Point(4, 0);
            this.smStudents.Name = "smStudents";
            this.smStudents.ShadowDecoration.Parent = this.smStudents;
            this.smStudents.Size = new System.Drawing.Size(179, 37);
            this.smStudents.TabIndex = 12;
            this.smStudents.Text = "Students";
            this.smStudents.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smStudents.TextOffset = new System.Drawing.Point(22, 0);
            // 
            // sbmInformations
            // 
            this.sbmInformations.BackColor = System.Drawing.Color.White;
            this.sbmInformations.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.sbmInformations.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbmInformations.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sbmInformations.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbmInformations.CheckedState.Image = global::SchoolManagement.Properties.Resources.information__1_;
            this.sbmInformations.CheckedState.Parent = this.sbmInformations;
            this.sbmInformations.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.sbmInformations.CustomImages.Parent = this.sbmInformations;
            this.sbmInformations.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbmInformations.FillColor = System.Drawing.Color.White;
            this.sbmInformations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbmInformations.ForeColor = System.Drawing.Color.Black;
            this.sbmInformations.HoveredState.Parent = this.sbmInformations;
            this.sbmInformations.Image = global::SchoolManagement.Properties.Resources.information;
            this.sbmInformations.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbmInformations.ImageOffset = new System.Drawing.Point(14, 0);
            this.sbmInformations.ImageSize = new System.Drawing.Size(18, 18);
            this.sbmInformations.Location = new System.Drawing.Point(0, 259);
            this.sbmInformations.Name = "sbmInformations";
            this.sbmInformations.ShadowDecoration.Parent = this.sbmInformations;
            this.sbmInformations.Size = new System.Drawing.Size(183, 37);
            this.sbmInformations.TabIndex = 26;
            this.sbmInformations.Text = "Informations";
            this.sbmInformations.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbmInformations.TextOffset = new System.Drawing.Point(22, 0);
            this.sbmInformations.Click += new System.EventHandler(this.sbmInformations_Click);
            // 
            // sbmTransactions
            // 
            this.sbmTransactions.BackColor = System.Drawing.Color.White;
            this.sbmTransactions.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.sbmTransactions.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbmTransactions.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.sbmTransactions.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbmTransactions.CheckedState.Image = global::SchoolManagement.Properties.Resources.transaction__1_;
            this.sbmTransactions.CheckedState.Parent = this.sbmTransactions;
            this.sbmTransactions.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.sbmTransactions.CustomImages.Parent = this.sbmTransactions;
            this.sbmTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbmTransactions.FillColor = System.Drawing.Color.White;
            this.sbmTransactions.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbmTransactions.ForeColor = System.Drawing.Color.Black;
            this.sbmTransactions.HoveredState.Parent = this.sbmTransactions;
            this.sbmTransactions.Image = global::SchoolManagement.Properties.Resources.transaction;
            this.sbmTransactions.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbmTransactions.ImageOffset = new System.Drawing.Point(14, 0);
            this.sbmTransactions.ImageSize = new System.Drawing.Size(18, 18);
            this.sbmTransactions.Location = new System.Drawing.Point(0, 222);
            this.sbmTransactions.Name = "sbmTransactions";
            this.sbmTransactions.ShadowDecoration.Parent = this.sbmTransactions;
            this.sbmTransactions.Size = new System.Drawing.Size(183, 37);
            this.sbmTransactions.TabIndex = 21;
            this.sbmTransactions.Text = "Transactions";
            this.sbmTransactions.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbmTransactions.TextOffset = new System.Drawing.Point(22, 0);
            this.sbmTransactions.Click += new System.EventHandler(this.sbmTransactions_Click);
            // 
            // spSubAdministrator
            // 
            this.spSubAdministrator.AutoSize = true;
            this.spSubAdministrator.Controls.Add(this.smCourse);
            this.spSubAdministrator.Controls.Add(this.smClassroom);
            this.spSubAdministrator.Controls.Add(this.smTeacher);
            this.spSubAdministrator.Controls.Add(this.smUser);
            this.spSubAdministrator.Dock = System.Windows.Forms.DockStyle.Top;
            this.spSubAdministrator.Location = new System.Drawing.Point(0, 74);
            this.spSubAdministrator.Name = "spSubAdministrator";
            this.spSubAdministrator.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.spSubAdministrator.ShadowDecoration.Parent = this.spSubAdministrator;
            this.spSubAdministrator.Size = new System.Drawing.Size(183, 148);
            this.spSubAdministrator.TabIndex = 10;
            this.spSubAdministrator.Visible = false;
            this.spSubAdministrator.VisibleChanged += new System.EventHandler(this.spSubAdministrator_VisibleChanged);
            // 
            // smCourse
            // 
            this.smCourse.BackColor = System.Drawing.Color.White;
            this.smCourse.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.smCourse.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smCourse.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.smCourse.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smCourse.CheckedState.Image = global::SchoolManagement.Properties.Resources.online_learning__1_;
            this.smCourse.CheckedState.Parent = this.smCourse;
            this.smCourse.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.smCourse.CustomImages.Parent = this.smCourse;
            this.smCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.smCourse.FillColor = System.Drawing.Color.White;
            this.smCourse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smCourse.ForeColor = System.Drawing.Color.Black;
            this.smCourse.HoveredState.Parent = this.smCourse;
            this.smCourse.Image = global::SchoolManagement.Properties.Resources.online_learning;
            this.smCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smCourse.ImageOffset = new System.Drawing.Point(14, 0);
            this.smCourse.ImageSize = new System.Drawing.Size(16, 16);
            this.smCourse.Location = new System.Drawing.Point(4, 111);
            this.smCourse.Name = "smCourse";
            this.smCourse.ShadowDecoration.Parent = this.smCourse;
            this.smCourse.Size = new System.Drawing.Size(179, 37);
            this.smCourse.TabIndex = 15;
            this.smCourse.Text = "Courses";
            this.smCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smCourse.TextOffset = new System.Drawing.Point(22, 0);
            // 
            // smClassroom
            // 
            this.smClassroom.BackColor = System.Drawing.Color.White;
            this.smClassroom.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.smClassroom.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smClassroom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.smClassroom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smClassroom.CheckedState.Image = global::SchoolManagement.Properties.Resources.open_door__1_;
            this.smClassroom.CheckedState.Parent = this.smClassroom;
            this.smClassroom.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.smClassroom.CustomImages.Parent = this.smClassroom;
            this.smClassroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.smClassroom.FillColor = System.Drawing.Color.White;
            this.smClassroom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smClassroom.ForeColor = System.Drawing.Color.Black;
            this.smClassroom.HoveredState.Parent = this.smClassroom;
            this.smClassroom.Image = global::SchoolManagement.Properties.Resources.open_door;
            this.smClassroom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smClassroom.ImageOffset = new System.Drawing.Point(14, 0);
            this.smClassroom.ImageSize = new System.Drawing.Size(16, 16);
            this.smClassroom.Location = new System.Drawing.Point(4, 74);
            this.smClassroom.Name = "smClassroom";
            this.smClassroom.ShadowDecoration.Parent = this.smClassroom;
            this.smClassroom.Size = new System.Drawing.Size(179, 37);
            this.smClassroom.TabIndex = 14;
            this.smClassroom.Text = "Classrooms";
            this.smClassroom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smClassroom.TextOffset = new System.Drawing.Point(22, 0);
            // 
            // smTeacher
            // 
            this.smTeacher.BackColor = System.Drawing.Color.White;
            this.smTeacher.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.smTeacher.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smTeacher.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.smTeacher.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smTeacher.CheckedState.Image = global::SchoolManagement.Properties.Resources.teacher__1_;
            this.smTeacher.CheckedState.Parent = this.smTeacher;
            this.smTeacher.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.smTeacher.CustomImages.Parent = this.smTeacher;
            this.smTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.smTeacher.FillColor = System.Drawing.Color.White;
            this.smTeacher.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smTeacher.ForeColor = System.Drawing.Color.Black;
            this.smTeacher.HoveredState.Parent = this.smTeacher;
            this.smTeacher.Image = global::SchoolManagement.Properties.Resources.teacher;
            this.smTeacher.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smTeacher.ImageOffset = new System.Drawing.Point(14, 0);
            this.smTeacher.ImageSize = new System.Drawing.Size(16, 16);
            this.smTeacher.Location = new System.Drawing.Point(4, 37);
            this.smTeacher.Name = "smTeacher";
            this.smTeacher.ShadowDecoration.Parent = this.smTeacher;
            this.smTeacher.Size = new System.Drawing.Size(179, 37);
            this.smTeacher.TabIndex = 13;
            this.smTeacher.Text = "Teachers";
            this.smTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smTeacher.TextOffset = new System.Drawing.Point(22, 0);
            // 
            // smUser
            // 
            this.smUser.BackColor = System.Drawing.Color.White;
            this.smUser.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.smUser.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smUser.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.smUser.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.smUser.CheckedState.Image = global::SchoolManagement.Properties.Resources.group__1_;
            this.smUser.CheckedState.Parent = this.smUser;
            this.smUser.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.smUser.CustomImages.Parent = this.smUser;
            this.smUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.smUser.FillColor = System.Drawing.Color.White;
            this.smUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smUser.ForeColor = System.Drawing.Color.Black;
            this.smUser.HoveredState.Parent = this.smUser;
            this.smUser.Image = global::SchoolManagement.Properties.Resources.group;
            this.smUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smUser.ImageOffset = new System.Drawing.Point(14, 0);
            this.smUser.ImageSize = new System.Drawing.Size(18, 18);
            this.smUser.Location = new System.Drawing.Point(4, 0);
            this.smUser.Name = "smUser";
            this.smUser.ShadowDecoration.Parent = this.smUser;
            this.smUser.Size = new System.Drawing.Size(179, 37);
            this.smUser.TabIndex = 12;
            this.smUser.Text = "Users";
            this.smUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.smUser.TextOffset = new System.Drawing.Point(22, 0);
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
            this.sbmAdministrator.ImageOffset = new System.Drawing.Point(14, 0);
            this.sbmAdministrator.ImageSize = new System.Drawing.Size(16, 16);
            this.sbmAdministrator.Location = new System.Drawing.Point(0, 37);
            this.sbmAdministrator.Name = "sbmAdministrator";
            this.sbmAdministrator.ShadowDecoration.Parent = this.sbmAdministrator;
            this.sbmAdministrator.Size = new System.Drawing.Size(183, 37);
            this.sbmAdministrator.TabIndex = 9;
            this.sbmAdministrator.Text = "Administrator";
            this.sbmAdministrator.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbmAdministrator.TextOffset = new System.Drawing.Point(22, 0);
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
            this.sbmDashboard.ImageOffset = new System.Drawing.Point(14, 0);
            this.sbmDashboard.ImageSize = new System.Drawing.Size(16, 16);
            this.sbmDashboard.Location = new System.Drawing.Point(0, 0);
            this.sbmDashboard.Name = "sbmDashboard";
            this.sbmDashboard.ShadowDecoration.Parent = this.sbmDashboard;
            this.sbmDashboard.Size = new System.Drawing.Size(183, 37);
            this.sbmDashboard.TabIndex = 8;
            this.sbmDashboard.Text = "Dashboard";
            this.sbmDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sbmDashboard.TextOffset = new System.Drawing.Point(22, 0);
            this.sbmDashboard.Click += new System.EventHandler(this.sbmDashboard_Click);
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
            this.siticonePanel2.Size = new System.Drawing.Size(758, 29);
            this.siticonePanel2.TabIndex = 1;
            // 
            // siticoneControlBox3
            // 
            this.siticoneControlBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.siticoneControlBox3.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneControlBox3.FillColor = System.Drawing.Color.White;
            this.siticoneControlBox3.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.siticoneControlBox3.HoveredState.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox3.Location = new System.Drawing.Point(623, 0);
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox3.TabIndex = 2;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.siticoneControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.White;
            this.siticoneControlBox2.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox2.Location = new System.Drawing.Point(668, 0);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 1;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox1.Location = new System.Drawing.Point(713, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.siticonePanel2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.ucTransaction1);
            this.panel3.Controls.Add(this.ucDashboard1);
            this.panel3.Location = new System.Drawing.Point(206, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(758, 522);
            this.panel3.TabIndex = 2;
            // 
            // ucTransaction1
            // 
            this.ucTransaction1.BackColor = System.Drawing.Color.White;
            this.ucTransaction1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTransaction1.Location = new System.Drawing.Point(0, 0);
            this.ucTransaction1.Margin = new System.Windows.Forms.Padding(482, 16678, 482, 16678);
            this.ucTransaction1.Name = "ucTransaction1";
            this.ucTransaction1.Size = new System.Drawing.Size(758, 522);
            this.ucTransaction1.TabIndex = 2;
            // 
            // ucDashboard1
            // 
            this.ucDashboard1.BackColor = System.Drawing.Color.White;
            this.ucDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDashboard1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ucDashboard1.Location = new System.Drawing.Point(0, 0);
            this.ucDashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.ucDashboard1.Name = "ucDashboard1";
            this.ucDashboard1.Size = new System.Drawing.Size(758, 522);
            this.ucDashboard1.TabIndex = 1;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.BackColor = System.Drawing.Color.Transparent;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(223, 34);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(129, 32);
            this.lbHeader.TabIndex = 3;
            this.lbHeader.Text = "Dashboard";
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 596);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.panel3);
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
            this.spMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.spSubExaminations.ResumeLayout(false);
            this.spSubInformations.ResumeLayout(false);
            this.spSubAdministrator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spbSlide)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Siticone.UI.WinForms.SiticoneButton smTeacher;
        private Siticone.UI.WinForms.SiticoneButton smUser;
        private Siticone.UI.WinForms.SiticoneButton smCourse;
        private Siticone.UI.WinForms.SiticoneButton smClassroom;
        private System.Windows.Forms.Panel panel2;
        private Siticone.UI.WinForms.SiticoneButton sbmTransactions;
        private Siticone.UI.WinForms.SiticoneButton sbmSettings;
        private Siticone.UI.WinForms.SiticoneButton sbmLogout;
        private Siticone.UI.WinForms.SiticonePanel spSubExaminations;
        private Siticone.UI.WinForms.SiticoneButton smResults;
        private Siticone.UI.WinForms.SiticoneButton smTimeTables;
        private Siticone.UI.WinForms.SiticoneButton sbmExam;
        private Siticone.UI.WinForms.SiticonePanel spSubInformations;
        private Siticone.UI.WinForms.SiticoneButton smClasses;
        private Siticone.UI.WinForms.SiticoneButton smStudents;
        private Siticone.UI.WinForms.SiticoneButton sbmInformations;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel3;
        private Controls.UCTransaction ucTransaction1;
        private Controls.UCDashboard ucDashboard1;
        private System.Windows.Forms.Label lbHeader;
    }
}


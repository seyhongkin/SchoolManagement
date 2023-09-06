namespace SchoolManagement.Controls
{
    partial class UCClassroom
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
            this.sbAllCRoom = new Siticone.UI.WinForms.SiticoneButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.succRoomCreate1 = new SchoolManagement.Controls.SUCCRoomCreate();
            this.succRoomDis1 = new SchoolManagement.Controls.SUCCRoomDis(this.sbRegister);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sbRegister);
            this.panel2.Controls.Add(this.sbAllCRoom);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 35);
            this.panel2.TabIndex = 5;
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
            this.sbRegister.Text = "Create / Update";
            this.sbRegister.CheckedChanged += new System.EventHandler(this.sbRegister_CheckedChanged);
            this.sbRegister.Click += new System.EventHandler(this.sbRegister_Click);
            // 
            // sbAllCRoom
            // 
            this.sbAllCRoom.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.sbAllCRoom.Checked = true;
            this.sbAllCRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbAllCRoom.CheckedState.ForeColor = System.Drawing.Color.White;
            this.sbAllCRoom.CheckedState.Parent = this.sbAllCRoom;
            this.sbAllCRoom.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(101)))), ((int)(((byte)(212)))));
            this.sbAllCRoom.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.sbAllCRoom.CustomImages.Parent = this.sbAllCRoom;
            this.sbAllCRoom.Dock = System.Windows.Forms.DockStyle.Left;
            this.sbAllCRoom.FillColor = System.Drawing.Color.White;
            this.sbAllCRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.sbAllCRoom.ForeColor = System.Drawing.Color.Black;
            this.sbAllCRoom.HoveredState.Parent = this.sbAllCRoom;
            this.sbAllCRoom.Location = new System.Drawing.Point(0, 0);
            this.sbAllCRoom.Name = "sbAllCRoom";
            this.sbAllCRoom.ShadowDecoration.Parent = this.sbAllCRoom;
            this.sbAllCRoom.Size = new System.Drawing.Size(169, 35);
            this.sbAllCRoom.TabIndex = 0;
            this.sbAllCRoom.Text = "All Classrooms";
            this.sbAllCRoom.Click += new System.EventHandler(this.sbAllCRoom_Click);
            this.sbAllCRoom.DoubleClick += new System.EventHandler(this.sbAllCRoom_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.succRoomDis1);
            this.panel1.Controls.Add(this.succRoomCreate1);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 478);
            this.panel1.TabIndex = 6;
            // 
            // succRoomCreate1
            // 
            this.succRoomCreate1.BackColor = System.Drawing.Color.White;
            this.succRoomCreate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.succRoomCreate1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.succRoomCreate1.Location = new System.Drawing.Point(0, 0);
            this.succRoomCreate1.Margin = new System.Windows.Forms.Padding(4);
            this.succRoomCreate1.Name = "succRoomCreate1";
            this.succRoomCreate1.Size = new System.Drawing.Size(746, 478);
            this.succRoomCreate1.TabIndex = 1;
            this.succRoomCreate1.Load += new System.EventHandler(this.succRoomCreate1_Load);
            // 
            // succRoomDis1
            // 
            this.succRoomDis1.BackColor = System.Drawing.Color.White;
            this.succRoomDis1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.succRoomDis1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.succRoomDis1.Location = new System.Drawing.Point(0, 0);
            this.succRoomDis1.Margin = new System.Windows.Forms.Padding(4);
            this.succRoomDis1.Name = "succRoomDis1";
            this.succRoomDis1.Size = new System.Drawing.Size(746, 478);
            this.succRoomDis1.TabIndex = 2;
            // 
            // UCClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCClassroom";
            this.Size = new System.Drawing.Size(746, 522);
            this.Load += new System.EventHandler(this.UCClassroom_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        public Siticone.UI.WinForms.SiticoneButton sbRegister;
        private Siticone.UI.WinForms.SiticoneButton sbAllCRoom;
        private System.Windows.Forms.Panel panel1;
        private SUCCRoomCreate succRoomCreate1;
        private SUCCRoomDis succRoomDis1;
    }
}

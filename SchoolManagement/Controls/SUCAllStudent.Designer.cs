namespace SchoolManagement.Controls
{
    partial class SUCAllStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sdgvDis = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.TID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eng_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kh_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sdgvDis)).BeginInit();
            this.SuspendLayout();
            // 
            // sdgvDis
            // 
            this.sdgvDis.AllowUserToAddRows = false;
            this.sdgvDis.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.sdgvDis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sdgvDis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sdgvDis.BackgroundColor = System.Drawing.Color.White;
            this.sdgvDis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sdgvDis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sdgvDis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sdgvDis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sdgvDis.ColumnHeadersHeight = 36;
            this.sdgvDis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TID,
            this.Eng_Name,
            this.Kh_Name,
            this.Gender,
            this.Dob,
            this.Phone,
            this.Email});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sdgvDis.DefaultCellStyle = dataGridViewCellStyle3;
            this.sdgvDis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdgvDis.EnableHeadersVisualStyles = false;
            this.sdgvDis.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sdgvDis.Location = new System.Drawing.Point(0, 0);
            this.sdgvDis.Name = "sdgvDis";
            this.sdgvDis.ReadOnly = true;
            this.sdgvDis.RowHeadersVisible = false;
            this.sdgvDis.RowTemplate.Height = 28;
            this.sdgvDis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sdgvDis.Size = new System.Drawing.Size(743, 471);
            this.sdgvDis.TabIndex = 2;
            this.sdgvDis.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.sdgvDis.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.sdgvDis.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.sdgvDis.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.sdgvDis.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.sdgvDis.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.sdgvDis.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.sdgvDis.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sdgvDis.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sdgvDis.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sdgvDis.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sdgvDis.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.sdgvDis.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.sdgvDis.ThemeStyle.HeaderStyle.Height = 36;
            this.sdgvDis.ThemeStyle.ReadOnly = true;
            this.sdgvDis.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.sdgvDis.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sdgvDis.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.sdgvDis.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.sdgvDis.ThemeStyle.RowsStyle.Height = 28;
            this.sdgvDis.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sdgvDis.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.sdgvDis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sdgvDis_CellDoubleClick);
            // 
            // TID
            // 
            this.TID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TID.HeaderText = "TID";
            this.TID.Name = "TID";
            this.TID.ReadOnly = true;
            this.TID.Width = 50;
            // 
            // Eng_Name
            // 
            this.Eng_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eng_Name.HeaderText = "English Name";
            this.Eng_Name.Name = "Eng_Name";
            this.Eng_Name.ReadOnly = true;
            this.Eng_Name.Width = 102;
            // 
            // Kh_Name
            // 
            this.Kh_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Kh_Name.HeaderText = "Khmer Name";
            this.Kh_Name.Name = "Kh_Name";
            this.Kh_Name.ReadOnly = true;
            this.Kh_Name.Width = 99;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Dob
            // 
            this.Dob.HeaderText = "DOB";
            this.Dob.Name = "Dob";
            this.Dob.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone Number";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 62;
            // 
            // SUCAllStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sdgvDis);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SUCAllStudent";
            this.Size = new System.Drawing.Size(743, 471);
            ((System.ComponentModel.ISupportInitialize)(this.sdgvDis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Siticone.UI.WinForms.SiticoneDataGridView sdgvDis;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eng_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kh_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

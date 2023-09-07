using SchoolManagement.DTO;
using SchoolManagement.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Controls
{
    public partial class SUCCreateClass : UserControl
    {
        private long _cid = -1;
        private long _tid = -1;
        private string _rid = string.Empty;
        public bool updated = false;
        private ClassService classService = new ClassService();
        public SUCCreateClass()
        {
            InitializeComponent();
        }

        private void sbDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want delete this information?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;
            try
            {
                //try to delete
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void scbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cid = long.Parse(scbCourse.SelectedItem.ToString().Split('-')[0]);
        }

        private void scbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tid = long.Parse(scbTeacher.SelectedItem.ToString().Split('-')[0]);
        }

        private void scbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            _rid = scbRoom.SelectedItem.ToString().Split('-')[0];
        }

        private void ClearForm()
        {
            scbCourse.SelectedIndex = 0;
            scbTeacher.SelectedIndex = 0;
            scbRoom.SelectedIndex = 0;
            sdtStart.Text = "";
            sdtEnd.Text = "";
            lbMsg.Text = "";
            sbDelete.Visible = false;
            stxtSection.Clear();
        }

        private void sbConfirm_Click(object sender, EventArgs e)
        {
            TeachClass tclass = new TeachClass();
            tclass.Cid = _cid;
            tclass.Clrid = _rid;
            tclass.Tid = _tid;
            tclass.Section = stxtSection.Text.Trim();
            tclass.StartDate = DateTime.Parse(sdtStart.Text);
            tclass.EndDate = DateTime.Parse(sdtEnd.Text);

            if (classService.Create(tclass) > 0)
            {
                lbMsg.Text = "Created successfully!";
                lbMsg.ForeColor = Color.DarkGreen;
                ClearForm();
            }
        }

        private void sbClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}

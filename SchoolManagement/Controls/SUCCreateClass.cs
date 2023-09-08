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
        public long _clid = -1;
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
                if(classService.Remove(_clid) > 0)
                {
                    lbMsg.Text = "Deleted successfully!";
                    lbMsg.ForeColor = Color.DarkGreen;
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void scbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (scbCourse.SelectedIndex == -1) return;
            _cid = long.Parse(scbCourse.SelectedItem.ToString().Split('-')[0]);
        }

        private void scbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (scbTeacher.SelectedIndex == -1) return;
            _tid = long.Parse(scbTeacher.SelectedItem.ToString().Split('-')[0]);
        }

        private void scbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (scbRoom.SelectedIndex == -1) return;
            _rid = scbRoom.SelectedItem.ToString().Split('-')[0];
        }

        private void ClearForm()
        {
            scbCourse.SelectedIndex = -1;
            scbTeacher.SelectedIndex = -1;
            scbRoom.SelectedIndex = -1;
            sdtStart.Text = "";
            sdtEnd.Text = "";
            _clid = -1;
            updated = false;
            sbDelete.Visible = false;

            sbDelete.Visible = false;
            stxtSection.Clear();
        }

        private void sbConfirm_Click(object sender, EventArgs e)
        {
            TeachClass tclass = new TeachClass();
            tclass.Id = _clid;
            tclass.Cid = _cid;
            tclass.Clrid = _rid;
            tclass.Tid = _tid;
            tclass.Section = stxtSection.Text.Trim();
            tclass.StartDate = DateTime.Parse(sdtStart.Text);
            tclass.EndDate = DateTime.Parse(sdtEnd.Text);

            if (tclass.Section == String.Empty)
            {
                lbMsg.Text = "Section is required!";
                lbMsg.ForeColor = Color.Red;
                return;
            }

            if (updated)
            {
                if (classService.Update(tclass) > 0)
                {
                    lbMsg.Text = "Updated successfully!";
                    lbMsg.ForeColor = Color.DarkGreen;
                    ClearForm();
                }
                return;
            }

            if (classService.Create(tclass) > 0)
            {
                lbMsg.Text = "Created successfully!";
                lbMsg.ForeColor = Color.DarkGreen;
                ClearForm();
            }
        }

        private void sbClear_Click(object sender, EventArgs e)
        {
            lbMsg.Text = "";
            ClearForm();
        }
    }
}

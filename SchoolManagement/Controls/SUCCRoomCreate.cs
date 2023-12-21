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
    public partial class SUCCRoomCreate : UserControl
    {
        private ClassroomService classroomService = new ClassroomService();
        public bool updated = false;
        public string prevNum = string.Empty;
        public SUCCRoomCreate()
        {
            InitializeComponent();
        }

        private void SUCCRoomCreate_Load(object sender, EventArgs e)
        {
            scbType.SelectedIndex = 0;
        }

        private void ClearForm()
        {
            sbDelete.Visible = false;
            prevNum = String.Empty;
            updated = false;
            stxtNumber.Clear();
            scbType.SelectedIndex = 0;
        }

        private void sbConfirm_Click(object sender, EventArgs e)
        {
            Classroom classroom = new Classroom();
            classroom.Number = stxtNumber.Text.Trim();
            classroom.Type = scbType.Text.Trim();
            if(classroom.Number.Length < 1)
            {
                lbMsg.Text = "Classroom number cannot be empty!";
                lbMsg.ForeColor = Color.Red;
                return;
            }
            if (updated)
            {
                if (classroomService.Update(prevNum, classroom) > 0)
                {
                    lbMsg.Text = "Created successfully!";
                    lbMsg.ForeColor = Color.DarkGreen;
                    ClearForm();
                }
                return;
            }
            if (classroomService.Create(classroom) > 0)
            {
                lbMsg.Text = "Created successfully!";
                lbMsg.ForeColor = Color.DarkGreen;
                ClearForm();
            }
        }

        private void sbClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            lbMsg.Text = "";
        }

        private void sbDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want delete this information?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;
            try
            {
                if(classroomService.Remove(prevNum) > 0)
                {
                    lbMsg.Text = "Remove this classroom successfully!";
                    lbMsg.ForeColor = Color.DarkGreen;
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}

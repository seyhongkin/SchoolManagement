using SchoolManagement.DTO;
using SchoolManagement.Service;
using SchoolManagement.Utils;
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
    public partial class UCTeacher : UserControl
    {
        private Dictionary<long, Teacher> teachers;
        public UCTeacher()
        {
            InitializeComponent();
        }

        private void sbRegister_Click(object sender, EventArgs e)
        {
            sucTeacherRegist1.BringToFront();
        }

        private void sbAllTeachers_Click(object sender, EventArgs e)
        {
            sucTeacherDis1.BringToFront();
        }

        private void UCTeacher_Load(object sender, EventArgs e)
        {
            TeacherService tService = new TeacherService();
            teachers = tService.getAll();

            sucTeacherDis1.sdgvDis.Rows.Clear();
            foreach (var t in teachers.Values)
            {
                sucTeacherDis1.sdgvDis.Rows.Add(t.Tid, t.NameEng, t.NameKh, t.Gender, t.Dob.ToShortDateString(), t.Phone,
                    t.Email.Contains("#") ? t.Email.Split('#')[0] : t.Email);
            }

            sbAllTeachers.Checked = true;
            sbAllTeachers_Click(null, null);
        }

        private void sbRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (sbAllTeachers.Checked) return;
            DataGridViewRow row = sucTeacherDis1.row;
            if (row != null)
            {
                    sucTeacherRegist1.spiLoading.BringToFront();
                long tid = long.Parse(row.Cells[0].Value.ToString());
                sucTeacherRegist1.sbDelete.Visible = true;

                sucTeacherRegist1.tid = tid;
                sucTeacherRegist1.stxtLNameEng.Text = row.Cells[1].Value.ToString().Split(' ')[0];
                sucTeacherRegist1.stxtFNameEng.Text = row.Cells[1].Value.ToString().Split(' ')[1];
                sucTeacherRegist1.stxtLNameKh.Text = row.Cells[2].Value.ToString().Split(' ')[0];
                sucTeacherRegist1.stxtFNameKh.Text = row.Cells[2].Value.ToString().Split(' ')[1];
                sucTeacherRegist1.scbGender.SelectedIndex = row.Cells[3].Value.ToString().ToLower() == "female" ? 0 : 1;
                sucTeacherRegist1.sdtDob.Text = row.Cells[4].Value.ToString();
                sucTeacherRegist1.stxtPhoneNum.Text = row.Cells[5].Value.ToString();
                sucTeacherRegist1.stxtEmailAdress.Text = row.Cells[6].Value.ToString();
                sucTeacherRegist1.lbMsg.Text = "";

                //load image
                try
                {
                    sucTeacherRegist1.lbFilePath.Text = teachers[tid].imgPath;
                    sucTeacherRegist1.pbImg.Image = teachers[tid].imgPath != "" ? Image.FromFile(FileUtil.GetImagePath() + teachers[tid].imgPath) : null;
                }
                catch (Exception ex)
                {
                    sucTeacherRegist1.pbImg.Image = null;
                    Console.WriteLine(ex.Message);
                }
                if (sucTeacherRegist1.pbImg.Image != null) sucTeacherRegist1.spiLoading.SendToBack();

                sucTeacherRegist1.BringToFront();
            }
        }

        private void sbAllTeachers_DoubleClick(object sender, EventArgs e)
        {
            UCTeacher_Load(null, null);
        }
    }
}

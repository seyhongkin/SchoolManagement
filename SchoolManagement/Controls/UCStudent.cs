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
    public partial class UCStudent : UserControl
    {
        private StudentService studentService = new StudentService();
        private Dictionary<long, Student> students = new Dictionary<long, Student>();
        
        public UCStudent()
        {
            InitializeComponent();
        }

        private void sbAllStudent_Click(object sender, EventArgs e)
        {
            sucAllStudent1.BringToFront();
        }

        private void sbRegister_Click(object sender, EventArgs e)
        {
            sucCreateStudent1.BringToFront();
        }

        private void LoadData()
        {
            students = studentService.GetAll();
            sucAllStudent1.sdgvDis.Rows.Clear();
            foreach (var s in students.Values)
            {
                sucAllStudent1.sdgvDis.Rows.Add(s.Sid, s.NameEng, s.NameKh, s.Gender, s.Dob.ToShortDateString(), s.Phone,
                    s.Email.Contains("#") ? s.Email.Split('#')[0] : s.Email);
            }
        }

        private void UCStudent_Load(object sender, EventArgs e)
        {
            LoadData();
            sbAllStudent_Click(null, null);
        }

        private void sbAllStudent_DoubleClick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void sbRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (sbAllStudent.Checked) return;
            long sid = sucAllStudent1.sid;
            if (sid == -1 || !students.ContainsKey(sid)) return;
            sucCreateStudent1.spiLoading.BringToFront();
            sucCreateStudent1.sbDelete.Visible = true;
            sucCreateStudent1.sid = sid;

            

            Console.WriteLine("sid from main: " + sid);
            sucCreateStudent1.stxtLNameEng.Text = students[sid].NameEng.Split(' ')[0].ToString();
            sucCreateStudent1.stxtFNameEng.Text = students[sid].NameEng.Split(' ')[1].ToString();
            sucCreateStudent1.stxtLNameKh.Text = students[sid].NameKh.Split(' ')[0].ToString();
            sucCreateStudent1.stxtFNameKh.Text = students[sid].NameKh.Split(' ')[1].ToString();
            sucCreateStudent1.scbGender.SelectedIndex = students[sid].Gender.ToLower() == "female" ? 0 : 1;
            sucCreateStudent1.sdtDob.Text = students[sid].Dob.ToShortDateString();
            sucCreateStudent1.stxtPhoneNum.Text = students[sid].Phone;
            sucCreateStudent1.stxtEmailAdress.Text =
                students[sid].Email.Contains("#") ? students[sid].Email.Split('#')[0] : students[sid].Email;
            sucCreateStudent1.lbMsg.Text = "";

            //load image
            try
            {
                sucCreateStudent1.lbFilePath.Text = students[sid].imgPath;
                sucCreateStudent1.pbImg.Image = students[sid].imgPath != "" ? Image.FromFile(FileUtil.GetImagePath() + students[sid].imgPath) : null;
            }
            catch (Exception ex)
            {
                sucCreateStudent1.pbImg.Image = null;
                Console.WriteLine(ex.Message);
            }
            if (sucCreateStudent1.pbImg.Image != null) sucCreateStudent1.spiLoading.SendToBack();

            sucCreateStudent1.BringToFront();

            //@NEED TO FIX THIS
            sucStudentClasses1.sid = sid;
            sucStudentClasses1.LoadDetail();
        }
    }
}

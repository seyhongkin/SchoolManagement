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
    public partial class SUCTeacherRegist : UserControl
    {
        private TeacherService teacherService = new TeacherService();
        public long tid = -1;
        public bool updated = false;
        public SUCTeacherRegist()
        {
            InitializeComponent();
        }

        private void SUCTeacherRegist_Load(object sender, EventArgs e)
        {
        }

        private void ClearForm()
        {
            stxtFNameEng.Clear();
            stxtLNameEng.Clear();
            stxtLNameKh.Clear();
            stxtFNameKh.Clear();
            scbGender.SelectedIndex = -1;
            stxtPhoneNum.Clear();
            stxtEmailAdress.Clear();
            sbDelete.Visible = false;

            sdtDob.Value = DateTime.Now;
            pbImg.Image = null;

            updated = false;
            tid = -1;
            lbFilePath.Text = "";
            spiLoading.SendToBack();
        }

        private void sbClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            lbMsg.Text = "";
        }

        private void sbUpload_Click(object sender, EventArgs e)
        {
            string imgPaths = Application.StartupPath + "//Images";
            if (!System.IO.Directory.Exists(imgPaths))
            {
                System.IO.Directory.CreateDirectory(imgPaths);
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Images | *.png;*.jpg;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbImg.Image = Image.FromFile(openFileDialog.FileName);
                    lbFilePath.Text = openFileDialog.FileName.Split('\\').Last();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            if (tid != 1)
            {
                updated = true;
                spiLoading.SendToBack();
            }
        }

        private string SaveImage()
        {
            if (pbImg.Image == null) return String.Empty;
            Image img = pbImg.Image;
            //if (pbImg.Image != null) pbImg.Image.Dispose();
            Random rand = new Random();
            int r = rand.Next(1, 99999);
            string imageFileName = $"{stxtLNameEng.Text.ToLower()}{stxtFNameEng.Text.ToLower()}{r}.{lbFilePath.Text.Split('.').Last()}";
            try
            {
                img.Save(FileUtil.GetImagePath() + imageFileName);
            }
            catch (Exception ex)
            {
                lbMsg.Text = "Failed! Please try again. " + ex.Message;
                lbMsg.ForeColor = Color.Red;
            }
            return imageFileName;
        }


        private void sbConfirm_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Tid = tid;
            t.NameEng = stxtLNameEng.Text.Trim() + " " + stxtFNameEng.Text.Trim();
            t.NameKh = stxtLNameKh.Text.Trim() + " " + stxtFNameKh.Text.Trim();
            t.Gender = scbGender.Text;
            t.Dob = DateTime.Parse(sdtDob.Text);
            t.Email = stxtEmailAdress.Text.Trim();
            t.Phone = stxtPhoneNum.Text.Trim();
            t.imgPath = SaveImage();

            if (t.NameKh.Trim() == "" && t.NameEng.Trim() == "")
            {
                lbMsg.Text = "Name are required!";
                lbMsg.ForeColor = Color.Red;
                return;
            }

            Console.WriteLine(tid.ToString());

            //register
            if (tid == -1)
            {
                if (teacherService.RegisterTeacher(t) > 0)
                {
                    lbMsg.Text = "Register successful";
                    lbMsg.ForeColor = Color.DarkGreen;
                    ClearForm();
                }
                return;
            }
            //update
            if (teacherService.UpdateTeacher(t) > 0)
            {
                lbMsg.Text = "Updated successfully";
                lbMsg.ForeColor = Color.DarkGreen;
                ClearForm();
            }
        }


        private void sbRemoveImg_Click(object sender, EventArgs e)
        {
            //from list
            if (tid != 1)
            {
                pbImg.Image = null;
                lbFilePath.Text = "";
                updated = true;
                return;
            }
            //not from list
            pbImg.Image = null;
            lbFilePath.Text = "";
        }

        private void DeleteTeacher()
        {
            if (teacherService.DeleteTeacher(tid) > 0)
            {
                lbMsg.Text = "This information got remove successfully";
                lbMsg.ForeColor = Color.Red;
                ClearForm();
            }
        }

        private void sbDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want delete this information?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;
            try
            {
                DeleteTeacher();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}

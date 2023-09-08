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
    public partial class SUCCreateStudent : UserControl
    {
        private StudentService studentService = new StudentService();
        public long sid = -1;
        public bool updated = false;
        public SUCCreateStudent()
        {
            InitializeComponent();
        }

        private void sbRemoveImg_Click(object sender, EventArgs e)
        {
            //from list
            if (sid != 1)
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
                    spiLoading.SendToBack();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            if (sid != 1)
            {
                updated = true;
                spiLoading.SendToBack();
            }
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
            sid = -1;
            lbFilePath.Text = "";
            spiLoading.SendToBack();
        }
        private void sbClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void sbDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want delete this information?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;
            try
            {
                if (studentService.Remove(sid) > 0)
                {
                    lbMsg.Text = "Deleted Successfully!";
                    lbMsg.ForeColor = Color.DarkGreen;
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
            Student s = new Student();
            s.Sid = sid;
            s.NameEng = stxtLNameEng.Text.Trim() + " " + stxtFNameEng.Text.Trim();
            s.NameKh = stxtLNameKh.Text.Trim() + " " + stxtFNameKh.Text.Trim();
            s.Gender = scbGender.Text;
            s.Dob = DateTime.Parse(sdtDob.Text);
            s.Email = stxtEmailAdress.Text.Trim();
            s.Phone = stxtPhoneNum.Text.Trim();
            s.imgPath = SaveImage();

            if (s.NameKh.Trim() == "" && s.NameEng.Trim() == "")
            {
                lbMsg.Text = "Name are required!";
                lbMsg.ForeColor = Color.Red;
                return;
            }

            Console.WriteLine(sid.ToString());

            //register
            if (sid == -1)
            {
                if (studentService.Create(s) > 0)
                {
                    lbMsg.Text = "Register successful";
                    lbMsg.ForeColor = Color.DarkGreen;
                    ClearForm();
                }
                return;
            }
            //update
            if (studentService.Update(s) > 0)
            {
                lbMsg.Text = "Updated successfully";
                lbMsg.ForeColor = Color.DarkGreen;
                ClearForm();
            }
        }

        private void sbClassDetail_Click(object sender, EventArgs e)
        {
            
        }
    }
}

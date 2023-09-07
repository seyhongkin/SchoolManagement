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
    public partial class SUCCreateCourse : UserControl
    {
        private CourseService courseService = new CourseService();
        public bool updated = false;
        public long cid = -1;
        public SUCCreateCourse()
        {
            InitializeComponent();
        }

        private void stxtPriceMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void stxtFullPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void stxtDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void SUCCreateCourse_Load(object sender, EventArgs e)
        {
            scbDiscount.SelectedIndex = 0;
        }

        private void ClearForm()
        {
            stxtTitle.Clear();
            stxtPriceMonth.Clear();
            stxtFullPrice.Clear();
            stxtDuration.Clear();
            stxtDescript.Clear();
            scbDiscount.SelectedIndex = 0;
            sbDelete.Visible = false;
        }

        private void sbConfirm_Click(object sender, EventArgs e)
        {
            if (stxtTitle.Text.Length == 0)
            {
                lbMsg.Text = "Title is required!";
                lbMsg.ForeColor = Color.Red;
                return;
            }

            Course course = new Course();
            course.Id = cid;
            course.Title = stxtTitle.Text;
            course.PriceMonth = double.Parse(stxtPriceMonth.Text);
            course.FullPrice = double.Parse(stxtFullPrice.Text);
            course.Duration = double.Parse(stxtDuration.Text);
            course.Description = stxtDescript.Text;
            course.Discount = int.Parse(scbDiscount.SelectedItem.ToString());

            //update
            if (updated)
            {
                if (courseService.Update(course) > 0)
                {
                    lbMsg.Text = "Course updated successfully!";
                    lbMsg.ForeColor = Color.DarkGreen;
                    ClearForm();
                }
                return;
            }

            //register
            if(courseService.Create(course) > 0)
            {
                lbMsg.Text = "Course created successfully!";
                lbMsg.ForeColor = Color.DarkGreen;
                ClearForm();
            }
        }

        private void sbClear_Click(object sender, EventArgs e)
        {
            ClearForm();

            lbMsg.Text = "";
            sbDelete.Visible = false;
        }

        private void sbDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want delete this information?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;
            try
            {
                if (courseService.Remove(cid) > 0)
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

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
    public partial class UCCourse : UserControl
    {
        private CourseService courseService = new CourseService();
        private Dictionary<long, Course> courses;
        public UCCourse()
        {
            InitializeComponent();
        }

        private void sbAllTeachers_Click(object sender, EventArgs e)
        {
            sucCourseDis1.BringToFront();
        }

        private void UCCourse_Load(object sender, EventArgs e)
        {
            sbAllTeachers_Click(null, null);
            courses = courseService.GetAll();

            sucCourseDis1.sdgvDis.Rows.Clear();
            foreach (var c in courses.Values)
            {
                sucCourseDis1.sdgvDis.Rows.Add(c.Id, c.Title, c.PriceMonth, c.FullPrice, c.Discount, c.Duration, c.Description);
            }
        }

        private void sbRegister_Click(object sender, EventArgs e)
        {
            sucCreateCourse1.BringToFront();
        }

        private void sbRegister_CheckedChanged(object sender, EventArgs e)
        {
            long cid = sucCourseDis1.cid;
            if (sbRegister.Checked) sucCreateCourse1.BringToFront();
            if (cid == -1) return;
            sucCreateCourse1.updated = true;
            sucCreateCourse1.cid = cid;
            sucCreateCourse1.stxtTitle.Text = courses[cid].Title;
            sucCreateCourse1.stxtPriceMonth.Text = courses[cid].PriceMonth.ToString();
            sucCreateCourse1.stxtFullPrice.Text = courses[cid].FullPrice.ToString();
            sucCreateCourse1.stxtDuration.Text = courses[cid].Duration.ToString();
            sucCreateCourse1.stxtDescript.Text = courses[cid].Description;
            sucCreateCourse1.scbDiscount.SelectedItem = courses[cid].Discount.ToString();
            sucCreateCourse1.sbDelete.Visible = true;
        }

        private void sbAllTeachers_DoubleClick(object sender, EventArgs e)
        {
            UCCourse_Load(null, null);
        }
    }
}

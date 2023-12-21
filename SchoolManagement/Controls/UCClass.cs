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
    public partial class UCClass : UserControl
    {
        private Dictionary<long, TeachClass> classes = new Dictionary<long, TeachClass>();
        private ClassService classService = new ClassService();
        public UCClass()
        {
            InitializeComponent();
        }

        private void LoadDetail()
        {
            CourseService courseService = new CourseService();
            ClassroomService classroomService = new ClassroomService();
            TeacherService teacherService = new TeacherService();

            Dictionary<long, DTO.Course> courses = courseService.GetAll();
            Dictionary<string, DTO.Classroom> clrooms = classroomService.GetAll();
            Dictionary<long, DTO.Teacher> teachers = teacherService.GetAll();

            sucCreateClass1.scbCourse.Items.Clear();
            foreach (var c in courses.Values)
            {
                sucCreateClass1.scbCourse.Items.Add(c.Id + "-" + c.Title);
            }

            sucCreateClass1.scbRoom.Items.Clear();
            foreach (var cl in clrooms.Values)
            {
                sucCreateClass1.scbRoom.Items.Add(cl.Number + "-" + cl.Type);
            }

            sucCreateClass1.scbTeacher.Items.Clear();
            foreach (var t in teachers.Values)
            {
                sucCreateClass1.scbTeacher.Items.Add(t.Tid + "-" + t.NameKh + " " + t.NameEng);
            }
        }

        private void UCClass_Load(object sender, EventArgs e)
        {
            classes = classService.GetAll();
            sucClassDis1.sdgvDis.Rows.Clear();

            foreach (var c in classes.Values)
            {
                sucClassDis1.sdgvDis.Rows.Add(c.Id, c.CTitle, c.Clrid, c.Section, c.TNameKh, c.TNameEng, c.StartDate.ToShortDateString(), c.EndDate.ToShortDateString());
            }
            sbAllTeachers_Click(null, null);


            LoadDetail();
        }

        private void sbAllTeachers_Click(object sender, EventArgs e)
        {
            sucClassDis1.BringToFront();
        }

        private void sbRegister_Click(object sender, EventArgs e)
        {
            sucCreateClass1.BringToFront();
        }

        private void sbRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (!sbRegister.Checked) return;

            long clid = sucClassDis1.clid;
            if (clid == -1 || !classes.ContainsKey(clid)) return;

            sucCreateClass1._clid = clid;
            sucCreateClass1.scbCourse.SelectedItem = classes[clid].Cid + "-" + classes[clid].CTitle;
            sucCreateClass1.scbTeacher.SelectedItem = classes[clid].Tid + "-" + classes[clid].TNameKh + " " + classes[clid].TNameEng;
            sucCreateClass1.scbRoom.SelectedItem = classes[clid].Clrid + "-" + classes[clid].ClrType;
            sucCreateClass1.stxtSection.Text = classes[clid].Section;
            sucCreateClass1.sdtStart.Value = classes[clid].StartDate;
            sucCreateClass1.sdtEnd.Value = classes[clid].EndDate;
            sucCreateClass1.updated = true;
            sucCreateClass1.sbDelete.Visible = true;
            sucCreateClass1.BringToFront();
        }

        private void sbRegister_DoubleClick(object sender, EventArgs e)
        {
            LoadDetail();
        }

        private void sbAllTeachers_DoubleClick(object sender, EventArgs e)
        {
            UCClass_Load(null, null);

        }
    }
}

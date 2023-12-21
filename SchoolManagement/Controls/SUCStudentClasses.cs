using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Controls
{
    public partial class SUCStudentClasses : UserControl
    {
        public long sid = -1;
        public SUCStudentClasses()
        {
            InitializeComponent();
        }



        public void LoadDetail()
        {
            if (sid == -1) return;
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            string sql = "SELECT tblcourses.title, tblclasses.c_section, tblclasses.start_date, tblteachers.lname_eng, tblteachers.fname_eng, tblteachers.lname_kh, tblteachers.fname_kh, tblteachers.gender, tblteachers.phone " +
                "FROM tblteachers INNER JOIN (tblstudents INNER JOIN (tblcourses INNER JOIN (tblclasses INNER JOIN tblstudent_class ON tblclasses.clid = tblstudent_class.clid) ON tblcourses.cid = tblclasses.course_id) ON tblstudents.sid = tblstudent_class.st_id) ON tblteachers.tid = tblclasses.tid " +
                $"WHERE tblstudents.sid = {sid};";
            cmd.CommandText = sql;
            OleDbDataReader reader = cmd.ExecuteReader();
            sdgvDis.Rows.Clear();
            int i = 1;
            while (reader.Read())
            {
                string title = reader["title"].ToString();
                string section = reader["c_section"].ToString();
                string startDate = DateTime.Parse(reader["start_date"].ToString()).ToShortDateString();
                string nameEng = reader["lname_eng"] + " " + reader["fname_eng"];
                string nameKh = reader["lname_kh"] + " " + reader["fname_kh"];
                string gender = reader["gender"].ToString();
                string phone = reader["phone"].ToString();
                sdgvDis.Rows.Add(i, title, section, startDate, nameKh, nameEng, gender, phone);
                i++;
            }
            this.BringToFront();
        }

        private void SUCStudentClasses_Load(object sender, EventArgs e)
        {
        }
    }
}

using SchoolManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Service
{
    internal class StudentService
    {
        public Dictionary<long, Student> GetAll()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tblstudents;", Program.connection);
            OleDbDataReader reader = cmd.ExecuteReader();
            Dictionary<long, Student> students = new Dictionary<long, Student>();
            while (reader.Read())
            {
                Student student = new Student();
                student.Sid = long.Parse(reader["sid"].ToString());
                student.NameEng = reader["lname_eng"] + " " + reader["fname_eng"];
                student.NameKh = reader["lname_kh"] + " " + reader["fname_kh"];
                student.Gender = reader["gender"].ToString();
                student.Dob = DateTime.Parse(reader["dob"].ToString());
                student.Phone = reader["phone"].ToString();
                student.Email = reader["email"].ToString();
                student.imgPath = reader["photo"].ToString();
                students.Add(student.Sid, student);
            }

            reader.Close();
            return students;
        }
        public int Create(Student s)
        {
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            string sql = "INSERT INTO tblstudents(lname_eng, fname_eng, lname_kh, fname_kh, gender, dob, phone, email, photo) " +
                $"VALUES('{s.NameEng.Split(' ')[0]}', '{s.NameEng.Split(' ')[0]}', '{s.NameKh.Split(' ')[0]}', '{s.NameKh.Split(' ')[1]}', '{s.Gender}', '{s.Dob.ToShortDateString()}', '{s.Phone}', '{s.Email}', '{s.imgPath}');";
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }

        public int Update(Student s)
        {
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            string sql = "UPDATE tblstudents " +
                $"SET lname_eng = '{s.NameEng.Split(' ')[0]}', fname_eng = '{s.NameEng.Split(' ')[1]}', lname_kh = '{s.NameKh.Split(' ')[0]}', fname_kh = '{s.NameKh.Split(' ')[1]}', gender = '{s.Gender}', dob = '{s.Dob.ToShortDateString()}', phone = '{s.Phone}', email = '{s.Email}', photo = '{s.imgPath}' " +
                $"WHERE sid = {s.Sid}";
            Console.Write(sql);
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }

        public int Remove(long sid)
        {
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            string sql = "DELETE FROM tblstudents " +
                $"WHERE sid = {sid};";
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }
    }

}

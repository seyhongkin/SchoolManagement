using SchoolManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Service
{
    internal class TeacherService
    {
        public Dictionary<long, Teacher> getAll()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tblteachers;", Program.connection);
            OleDbDataReader reader = cmd.ExecuteReader();

            Dictionary<long, Teacher> result = new Dictionary<long, Teacher>();
            while (reader.Read())
            {
                Teacher teacher = new Teacher();
                teacher.Tid = long.Parse(reader["tid"].ToString());
                teacher.NameEng = reader["lname_eng"].ToString() + " " + reader["fname_eng"].ToString();
                teacher.NameKh = reader["lname_kh"].ToString() + " " + reader["fname_kh"].ToString();
                teacher.Gender = reader["gender"].ToString();
                teacher.Dob = DateTime.Parse(reader["dob"].ToString());
                teacher.Phone = reader["phone"].ToString();
                teacher.Email = reader["email"].ToString();
                teacher.imgPath = reader["photo"].ToString();
                result.Add(teacher.Tid, teacher);
            }

            return result;
        }

        public long RegisterTeacher(Teacher t)
        {
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            cmd.CommandText = "INSERT INTO tblteachers(lname_eng, fname_eng, lname_kh, fname_kh, gender, dob, phone, email, photo) " +
                $" VALUES('{t.NameEng.Split(' ')[0]}', '{t.NameEng.Split(' ')[1]}', '{t.NameKh.Split(' ')[0]}', '{t.NameKh.Split(' ')[1]}', '{t.Gender}', '{t.Dob}', '{t.Phone}', '{t.Email}', '{t.imgPath}');";

            return cmd.ExecuteNonQuery();
        }

        public long UpdateTeacher(Teacher t)
        {
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            string sql = "UPDATE tblteachers " +
                $"SET lname_eng = '{t.NameEng.Split(' ')[0]}', fname_eng = '{t.NameEng.Split(' ')[1]}', lname_kh = '{t.NameKh.Split(' ')[0]}', fname_kh = '{t.NameKh.Split(' ')[1]}', gender = '{t.Gender}', dob = '{t.Dob.ToShortDateString()}', phone = '{t.Phone}', email = '{t.Email}', photo = '{t.imgPath}' " +
                $"WHERE tid = {t.Tid}";
            cmd.CommandText = sql;

            Console.WriteLine(sql);
            return cmd.ExecuteNonQuery();
        }

        public long DeleteTeacher(long tid)
        {
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            string sql = "DELETE FROM tblteachers " +
                $"WHERE tid = {tid};";
            cmd.CommandText = sql;

            Console.WriteLine(sql);
            return cmd.ExecuteNonQuery();
        }
    }
}

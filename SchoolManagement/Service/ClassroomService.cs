using SchoolManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Service
{
    internal class ClassroomService
    {
        public Dictionary<string, Classroom> GetAll()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tblclassrooms;", Program.connection);
            OleDbDataReader reader = cmd.ExecuteReader();

            Dictionary<string, Classroom> result = new Dictionary<string, Classroom>();
            while (reader.Read())
            {
                Classroom classroom = new Classroom();
                classroom.Number = reader["clrid"].ToString();
                classroom.Type = reader["type"].ToString();
                result.Add(classroom.Number, classroom);
            }

            return result;
        }
    
        public int Create(Classroom c)
        {
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            string sql = "INSERT INTO tblclassrooms(clrid, type) " +
                $"VALUES('{c.Number.ToUpper()}', '{c.Type}');";
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }

        public int Update(string prevNum, Classroom c)
        {
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            string sql = "UPDATE tblclassrooms " +
                $"SET clrid = '{c.Number}', type = '{c.Type}' " +
                $"WHERE clrid = '{prevNum}';";
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }

        public int Remove(string clrid)
        {
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            string sql = "DELETE FROM tblclassrooms " +
                $"WHERE clrid = '{clrid}';";
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }
    }
}

﻿using SchoolManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Service
{
    internal class ClassService
    {
        public Dictionary<long, TeachClass> GetAll()
        {
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            string sql = "SELECT tblclasses.clid, tblcourses.title, tblclasses.clr_id, tblclassrooms.type AS clr_type, tblclasses.c_section, tblteachers.lname_eng, tblteachers.fname_eng, tblteachers.lname_kh, tblteachers.fname_kh, tblclasses.start_date, tblclasses.end_date, tblcourses.cid, tblteachers.tid " +
                "FROM tblclassrooms INNER JOIN (tblteachers INNER JOIN (tblcourses INNER JOIN tblclasses ON tblcourses.cid = tblclasses.course_id) ON tblteachers.tid = tblclasses.tid) ON tblclassrooms.clrid = tblclasses.clr_id;";
            cmd.CommandText = sql;
            OleDbDataReader reader = cmd.ExecuteReader();
            Dictionary<long, TeachClass> result = new Dictionary<long, TeachClass>();
            while (reader.Read())
            {
                TeachClass teachClass = new TeachClass();
                teachClass.Id = long.Parse(reader["clid"].ToString());
                teachClass.CTitle = reader["title"].ToString();
                teachClass.Cid = long.Parse(reader["cid"].ToString());
                teachClass.Tid = long.Parse(reader["tid"].ToString());
                teachClass.Clrid = reader["clr_id"].ToString();
                teachClass.ClrType = reader["clr_type"].ToString();
                teachClass.Section = reader["c_section"].ToString();
                teachClass.TNameEng = reader["lname_eng"] + " " + reader["fname_eng"];
                teachClass.TNameKh = reader["lname_kh"] + " " + reader["fname_kh"];
                teachClass.StartDate = DateTime.Parse(reader["start_date"].ToString());
                teachClass.EndDate = DateTime.Parse(reader["end_date"].ToString());
                result.Add(teachClass.Id, teachClass);
            }
            reader.Close();
            return result;
        }

        public int Create(TeachClass tc)
        {
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            string sql = "INSERT INTO tblclasses(course_id, clr_id, c_section, tid, start_date, end_date) " +
                $"VALUES({tc.Cid}, '{tc.Clrid}', '{tc.Section}', '{tc.Tid}', '{tc.StartDate}', '{tc.EndDate}');";
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }

        public int Update(TeachClass tc)
        {
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            string sql = "UPDATE tblclasses " +
                $"SET course_id = {tc.Cid}, clr_id = '{tc.Clrid}', c_section = '{tc.Section}', tid = {tc.Tid}, start_date = '{tc.StartDate}', end_date = '{tc.EndDate}' " +
                $"WHERE clid = {tc.Id};";

            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }

        public int Remove(long clid)
        {
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            string sql = $"DELETE FROM tblclasses WHERE clid = {clid};";

            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }
    
    }
}

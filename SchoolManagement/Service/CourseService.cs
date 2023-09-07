using SchoolManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Service
{
    internal class CourseService
    {
        public Dictionary<long, Course> GetAll()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tblcourses;", Program.connection);
            OleDbDataReader reader = cmd.ExecuteReader();
            Dictionary<long, Course> courses = new Dictionary<long, Course>();
            while (reader.Read())
            {
                Course course = new Course();
                course.Id = long.Parse(reader["cid"].ToString());
                course.Title = reader["title"].ToString();
                course.PriceMonth = double.Parse(reader["price_month"].ToString());
                course.FullPrice = double.Parse(reader["full_price"].ToString());
                course.Discount = int.Parse(reader["discount"].ToString());
                course.Duration = double.Parse(reader["duration"].ToString());
                course.Description = reader["description"].ToString();
                Console.WriteLine(course.Description);
                courses.Add(course.Id, course);
            }
            reader.Close();
            return courses;
        }

        public int Update(Course c)
        {
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            string sql = "UPDATE tblcourses " +
                $"SET title = '{c.Title}', price_month = {c.PriceMonth}, full_price = {c.FullPrice}, discount = {c.Discount}, description = '{c.Description}', duration = {c.Duration} " +
                $"WHERE cid = {c.Id};";
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }

        public int Create(Course c)
        {
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            string sql = "INSERT INTO tblcourses(title, price_month, full_price, discount, description, duration) " +
                $"VALUES('{c.Title}', {c.PriceMonth}, {c.FullPrice}, {c.Discount}, '{c.Description}', {c.Duration});";
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }

        public int Remove(long cid)
        {
            OleDbCommand cmd = new OleDbCommand("", Program.connection);
            string sql = "DELETE FROM tblcourses " +
                $"WHERE cid = {cid};";
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }
    }
}

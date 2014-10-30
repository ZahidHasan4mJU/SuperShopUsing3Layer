using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasisPracticeUsing3Layer.DLL.DAO;

namespace BasisPracticeUsing3Layer.DLL.gateway
{
    class CourseGateway
    {
        private SqlConnection connection;
        private string Table_1;
        public CourseGateway()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["con"];
            string connectionString = "";
            Table_1 = "t_Product";
            if (settings != null)
                connectionString = settings.ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
        }
        public string Save(DAO.Course aCourse)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_course VALUES ('{0}','{1}','{2}')",
                           aCourse.Code, aCourse.CourseName, aCourse.CourseCredit);
            SqlCommand command = new SqlCommand(query, connection);
            int affectedRow = command.ExecuteNonQuery();
            connection.Close();

            if (affectedRow > 0)
            { return "inserted"; }
            return "failed";
        }

        public List<Course> getCourseName(Course aCourse)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_course");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            Course aCourse2;

            List<Course> courses = new List<Course>();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    aCourse2 = new Course();
                    aCourse2.Code = reader.GetValue(1).ToString();
                    aCourse2.CourseName = reader.GetValue(2).ToString();
                    aCourse2.CourseCredit = reader.GetValue(3).ToString();

                    courses.Add(aCourse2);
                }
               
            }
            connection.Close();
            return courses;
        }
    }
}

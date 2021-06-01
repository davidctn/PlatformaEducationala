using Dapper;
using PlatformaEducationala.Models.EntityLayer;
using PlatformaEducationala.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformaEducationala.Models.DataAccessLayer
{
    class CourseDAL
    {
        public CourseDAL()
        {

        }

            public ObservableCollection<Course> GetAllCourses()
            {
            ObservableCollection<Course> result = new ObservableCollection<Course>();
            using (IDbConnection myConnection = new System.Data.SqlClient.SqlConnection(DALHelper.ConnectionStringValue("PlatformDB")))
            {
                List<Course> tempList = new List<Course>();
                tempList = myConnection.Query<Course>("select * from Courses").ToList();
                for (int index = 0; index < tempList.Count(); index++)
                {
                    result.Add(tempList[index]);
                }
            }
            return result;
            }

            public void AddCourse(Course course)
            {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddCourse", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramCourseName = new SqlParameter("@coursename", course.CourseName);
                cmd.Parameters.Add(paramCourseName);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            }

            public void DeleteCourse(Course course)
            {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteCourse", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramIdCourse = new SqlParameter("@id", course.Id);
                cmd.Parameters.Add(paramIdCourse);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            }

            public void ModifyCourse(Course course)
            {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifyCourse", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@id", course.Id);
                SqlParameter paramCourseName = new SqlParameter("@coursename", course.CourseName);
                cmd.Parameters.Add(paramId);
                cmd.Parameters.Add(paramCourseName);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            }
        
    }
}

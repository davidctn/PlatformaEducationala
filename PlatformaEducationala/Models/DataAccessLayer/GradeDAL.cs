using Dapper;
using PlatformaEducationala.Models.EntityLayer;
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
    class GradeDAL
    {
        public GradeDAL()
        {

        }
  
            public ObservableCollection<Grade> GetAllGrades()
            {
                ObservableCollection<Grade> result = new ObservableCollection<Grade>();
                using (IDbConnection myConnection = new System.Data.SqlClient.SqlConnection(DALHelper.ConnectionStringValue("PlatformDB")))
                {
                    List<Grade> tempList = new List<Grade>();
                    tempList = myConnection.Query<Grade>("select * from Grades").ToList();
                    for (int index = 0; index < tempList.Count(); index++)
                    {
                        result.Add(tempList[index]);
                    }
                }
                return result;
            }

        public ObservableCollection<Grade> GetCurrentStudentGrades()
        {
            ObservableCollection<Grade> result = new ObservableCollection<Grade>();
            using (IDbConnection myConnection = new System.Data.SqlClient.SqlConnection(DALHelper.ConnectionStringValue("PlatformDB")))
            {
                List<Grade> tempList = new List<Grade>();
                tempList = myConnection.Query<Grade>($"select * from Grades where StudentId = {DALHelper.GetLogId()}").ToList();
                for (int index = 0; index < tempList.Count(); index++)
                {
                    result.Add(tempList[index]);
                }
            }
            return result;
        }

        public ObservableCollection<Average> GetCurrentStudentAverages()
        {
            List<string> distinctCourses = new List<string>();
            ObservableCollection<Average> averages = new ObservableCollection<Average>();

            for (int index = 0; index < GetCurrentStudentGrades().Count(); index++)
            {
                bool found = false;
                for (int jdex = 0; jdex < distinctCourses.Count(); jdex++)
                {
                    if (GetCurrentStudentGrades()[index].CourseName == distinctCourses[jdex])
                    {
                        found = true;
                    }
                }

                if (found == false)
                {
                    distinctCourses.Add(GetCurrentStudentGrades()[index].CourseName);
                }
            }

            int id = 1;
            for (int index = 0; index < distinctCourses.Count(); index++)
            {
                int sum = 0;
                int numberOfGrades = 0;
                int thesisValue = 0;
                for (int jdex = 0; jdex < GetCurrentStudentGrades().Count(); jdex++)
                {
                    if (GetCurrentStudentGrades()[jdex].CourseName == distinctCourses[index])
                    {
                        if (GetCurrentStudentGrades()[jdex].IsThesis == 0)
                        {
                            sum += GetCurrentStudentGrades()[jdex].Value;
                            numberOfGrades++;
                        }
                        else
                        {
                            thesisValue = GetCurrentStudentGrades()[jdex].Value;
                        }
                    }
                }

                if (thesisValue == 0)
                {
                    if (numberOfGrades > 0)
                    {
                        double averageValue = sum / numberOfGrades;
                        Average average = new Average(id, averageValue.ToString(), distinctCourses[index]);
                        averages.Add(average);
                        id++;
                    }

                    else
                    {
                        Average average = new Average(id, 1.ToString(), distinctCourses[index]);
                        averages.Add(average);
                        id++;
                    }
                }

                if (thesisValue != 0)
                {
                    if (numberOfGrades > 0)
                    {
                        double avgValue = sum / numberOfGrades;
                        double averageValue = (avgValue * 3 + thesisValue) / 4;
                        Average average = new Average(id, averageValue.ToString(), distinctCourses[index]);
                        averages.Add(average);
                        id++;
                    }

                    else
                    {
                        Average average = new Average(id, 1.ToString(), distinctCourses[index]);
                        averages.Add(average);
                        id++;
                    }
                }
            }

            for (int index = 0; index < averages.Count(); index++)
            {
                Console.Write($"{averages[index].CourseName}  {averages[index].Value} ");
                Console.WriteLine("");
            }
            return averages;
        }

        public void AddGrade(Grade grade)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddGrade", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramValue = new SqlParameter("@value", grade.Value);
                SqlParameter paramIsThesis = new SqlParameter("@isthesis", grade.IsThesis);
                SqlParameter paramStudentId = new SqlParameter("@studentid", grade.StudentId);
                cmd.Parameters.Add(paramValue);
                cmd.Parameters.Add(paramIsThesis);
                cmd.Parameters.Add(paramStudentId);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModifyGrade(Grade grade)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifyGrade", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@id", grade.Id);
                SqlParameter paramValue = new SqlParameter("@value", grade.Value);
                SqlParameter paramIsThesis = new SqlParameter("@isthesis", grade.IsThesis);
                SqlParameter paramStudentId = new SqlParameter("@studentid", grade.StudentId);
                cmd.Parameters.Add(paramId);
                cmd.Parameters.Add(paramValue);
                cmd.Parameters.Add(paramIsThesis);
                cmd.Parameters.Add(paramStudentId);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteGrade(Grade grade)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteGrade", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@id", grade.Id);
                cmd.Parameters.Add(paramId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

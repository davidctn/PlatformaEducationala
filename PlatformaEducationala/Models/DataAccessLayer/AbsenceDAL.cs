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
    class AbsenceDAL
    {
        public AbsenceDAL()
        {

        }

        public ObservableCollection<Absence> GetAllAbsences()
        {
            ObservableCollection<Absence> result = new ObservableCollection<Absence>();
            using (IDbConnection myConnection = new System.Data.SqlClient.SqlConnection(DALHelper.ConnectionStringValue("PlatformDB")))
            {
                List<Absence> tempList = new List<Absence>();
                tempList = myConnection.Query<Absence>("select * from Absences").ToList();
                for (int index = 0; index < tempList.Count(); index++)
                {
                    result.Add(tempList[index]);
                }
            }
            return result;
        }

        public ObservableCollection<Absence> GetCurrentStudentAbsences()
        {
            ObservableCollection<Absence> result = new ObservableCollection<Absence>();
            using (IDbConnection myConnection = new System.Data.SqlClient.SqlConnection(DALHelper.ConnectionStringValue("PlatformDB")))
            {
                List<Absence> tempList = new List<Absence>();
                tempList = myConnection.Query<Absence>($"select * from Absences where StudentId = {DALHelper.GetLogId()}").ToList();
                for (int index = 0; index < tempList.Count(); index++)
                {
                    result.Add(tempList[index]);
                }
            }
            return result;
        }

        public void AddAbsence(Absence absence)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddAbsence", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramCourseName = new SqlParameter("@coursename", absence.CourseName);
                SqlParameter paramDate = new SqlParameter("@datewhenadded", absence.DateWhenAdded);
                SqlParameter paramStudentId = new SqlParameter("@studentid", absence.Id);
                cmd.Parameters.Add(paramCourseName);
                cmd.Parameters.Add(paramDate);
                cmd.Parameters.Add(paramStudentId);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAbsence(Absence absence)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteAbsence", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@id", absence.Id);
                cmd.Parameters.Add(paramId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

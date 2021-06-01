using Dapper;
using PlatformaEducationala.Models.DataAccessLayer;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace PlatformaEducationala.Models.EntityLayer
{
    class PersonDAL
    {
        public PersonDAL()
        {

        }

        public ObservableCollection<Person> GetAllStudents()
        {
            ObservableCollection<Person> result = new ObservableCollection<Person>();
            using (IDbConnection myConnection = new System.Data.SqlClient.SqlConnection(DALHelper.ConnectionStringValue("PlatformDB")))
            {
                List<Person> tempList = new List<Person>();
                tempList = myConnection.Query<Person>("select * from Students").ToList();
                for (int index = 0; index < tempList.Count(); index++)
                {
                    result.Add(tempList[index]);
                }
            }
            return result;
        }

        public ObservableCollection<Person> GetAllTeachers()
        {
            ObservableCollection<Person> result = new ObservableCollection<Person>();
            using (IDbConnection myConnection = new System.Data.SqlClient.SqlConnection(DALHelper.ConnectionStringValue("PlatformDB")))
            {
                List<Person> tempList = new List<Person>();
                tempList = myConnection.Query<Person>("select * from Teachers").ToList();
                for (int index = 0; index < tempList.Count(); index++)
                {
                    result.Add(tempList[index]);
                }

            }
            return result;
        }

        public ObservableCollection<Person> GetAllAdmins()
        {
            ObservableCollection<Person> result = new ObservableCollection<Person>();
            using (IDbConnection myConnection = new System.Data.SqlClient.SqlConnection(DALHelper.ConnectionStringValue("PlatformDB")))
            {
                List<Person> tempList = new List<Person>();
                tempList = myConnection.Query<Person>("select * from Admins").ToList();
                for (int index = 0; index < tempList.Count(); index++)
                {
                    result.Add(tempList[index]);
                }
            }
            return result;
        }


        public void AddStudent(Person person)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramFirstName = new SqlParameter("@firstname", person.FirstName);
                SqlParameter paramLastName = new SqlParameter("@lastname", person.LastName);
                SqlParameter paramEmailAdress = new SqlParameter("@emailaddress", person.EmailAddress);
                SqlParameter paramPassword = new SqlParameter("@password", person.Password);
                SqlParameter paramClassName = new SqlParameter("@classname", person.ClassName);
                cmd.Parameters.Add(paramFirstName);
                cmd.Parameters.Add(paramLastName);
                cmd.Parameters.Add(paramEmailAdress);
                cmd.Parameters.Add(paramPassword);
                cmd.Parameters.Add(paramClassName);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModifyStudent(Person person)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifyStudent", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@id", person.Id);
                SqlParameter paramFirstName = new SqlParameter("@firstname", person.FirstName);
                SqlParameter paramLastName = new SqlParameter("@lastname", person.LastName);
                SqlParameter paramAdress = new SqlParameter("@emailaddress",person.EmailAddress);
                SqlParameter paramPassword = new SqlParameter("@password", person.Password);
                SqlParameter paramClassName = new SqlParameter("@classname", person.ClassName);
                cmd.Parameters.Add(paramId);
                cmd.Parameters.Add(paramFirstName);
                cmd.Parameters.Add(paramLastName);
                cmd.Parameters.Add(paramAdress);
                cmd.Parameters.Add(paramPassword);
                cmd.Parameters.Add(paramClassName);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(Person person)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramIdStudent = new SqlParameter("@id", person.Id);
                cmd.Parameters.Add(paramIdStudent);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void AddTeacher(Person person)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddTeacher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramFirstName = new SqlParameter("@firstname", person.FirstName);
                SqlParameter paramLastName = new SqlParameter("@lastname", person.LastName);
                SqlParameter paramEmailAdress = new SqlParameter("@emailaddress", person.EmailAddress);
                SqlParameter paramPassword = new SqlParameter("@password", person.Password);
                cmd.Parameters.Add(paramFirstName);
                cmd.Parameters.Add(paramLastName);
                cmd.Parameters.Add(paramEmailAdress);
                cmd.Parameters.Add(paramPassword);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModifyTeacher(Person person)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifyTeacher", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@id", person.Id);
                SqlParameter paramFirstName = new SqlParameter("@firstname", person.FirstName);
                SqlParameter paramLastName = new SqlParameter("@lastname", person.LastName);
                SqlParameter paramEmailAdress = new SqlParameter("@emailaddress", person.EmailAddress);
                SqlParameter paramPassword = new SqlParameter("@password", person.Password);
                cmd.Parameters.Add(paramId);
                cmd.Parameters.Add(paramFirstName);
                cmd.Parameters.Add(paramLastName);
                cmd.Parameters.Add(paramEmailAdress);
                cmd.Parameters.Add(paramPassword);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTeacher(Person person)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteTeacher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramIdTeacher = new SqlParameter("@id", person.Id);
                cmd.Parameters.Add(paramIdTeacher);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

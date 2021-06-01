using Dapper;
using PlatformaEducationala.Models.BusinessLogicLayer;
using PlatformaEducationala.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PlatformaEducationala.Models.DataAccessLayer
{
    class ClassDAL
    {

        private readonly List<string> classNames = new List<string>();

        public ClassDAL()
        {

        }

        public ObservableCollection<Class> GetClassesFromDB()
        {
            ObservableCollection<Class> result = new ObservableCollection<Class>();
            using (IDbConnection myConnection = new System.Data.SqlClient.SqlConnection(DALHelper.ConnectionStringValue("PlatformDB")))
            {
                List<Class> tempList = new List<Class>();
                tempList = myConnection.Query<Class>("select * from Classes").ToList();
                for (int index = 0; index<tempList.Count(); index++)
                {
                    result.Add(tempList[index]);
                }

            }
            return result;
        }

        //public ObservableCollection<Person> GetStudentsFromClass()
        //{
        //    ObservableCollection<Person> result = new ObservableCollection<Person>();
        //    using (IDbConnection myConnection = new System.Data.SqlClient.SqlConnection(DALHelper.ConnectionStringValue("PlatformDB")))
        //    {
        //        List<Person> tempList = new List<Person>();
        //        tempList = myConnection.Query<Person>($"select * from Students where ClassName = {DALHelper.GetCurrentClassName()} ").ToList();
        //        for (int index = 0; index < tempList.Count(); index++)
        //        {
        //            result.Add(tempList[index]);
        //        }
        //    }
        //    return result;
        //}

        //public ObservableCollection<Person> GetTeachersFromClass()
        //{
        //    ObservableCollection<Person> result = new ObservableCollection<Person>();
        //    using (IDbConnection myConnection = new System.Data.SqlClient.SqlConnection(DALHelper.ConnectionStringValue("PlatformDB")))
        //    {
                
        //    }
        //    return result;
        //}

        public void GetClassName(int index)
        {
            if(index==0 || index == 1 || index == 2)
            {
                DALHelper.SetClassName("class1");
            }

            if (index == 3 || index == 4 || index == 5)
            {
                DALHelper.SetClassName("class2");
            }

            if (index == 6 || index == 7 || index == 8)
            {
                DALHelper.SetClassName("class3");  
            }

            if (index == 9 || index == 10 || index == 11)
            {
                DALHelper.SetClassName("class4"); 
            }

            if (index == 12 || index == 13 || index == 14)
            {
                DALHelper.SetClassName("class5");
            }

            if (index == 15 || index == 16 || index == 17)
            {
                DALHelper.SetClassName("class6");
            }

            if (index == 18 || index == 19 || index == 20)
            {
                DALHelper.SetClassName("class7");
            }

            if (index == 21 || index == 22 || index == 23)
            {
                DALHelper.SetClassName("class8");
            }
        }//pt a stii ce window-uri sa deschid

        public void AddClassMaster(Class currentClass)
        {
            using (SqlConnection con = DALHelper.Connection)
            {

                SqlCommand cmd = new SqlCommand("AddClassMaster", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramClassName = new SqlParameter("@classname", currentClass.ClassName);
                SqlParameter paramId = new SqlParameter("@id", currentClass.Id);
                cmd.Parameters.Add(paramClassName);
                cmd.Parameters.Add(paramId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void AddSpecialization(Class currentClass)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddSpecialization", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramClassName = new SqlParameter("@classname", currentClass.ClassName);
                SqlParameter paramSpecialization = new SqlParameter("@specialization", currentClass.Specialization);
                cmd.Parameters.Add(paramClassName);
                cmd.Parameters.Add(paramSpecialization);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void AddClassToDB(Class currentclass)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddClassToDB", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramClassName = new SqlParameter("@classname", currentclass.ClassName);
                SqlParameter paramSpecialization = new SqlParameter("@specialization", currentclass.Specialization);
                SqlParameter paramClassMaster = new SqlParameter("@id", currentclass.Id);
                cmd.Parameters.Add(paramClassName);
                cmd.Parameters.Add(paramSpecialization);
                cmd.Parameters.Add(paramClassMaster);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

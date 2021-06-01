using PlatformaEducationala.Models.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformaEducationala.Models.DataAccessLayer
{
    static class DALHelper
    {
        private static string className;//pt a afisa clasele

        private static int? id;

        public static string ConnectionStringValue(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;

        public static SqlConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

        public static void SetClassName(string name)
        {
            className = name;
        }

        public static string GetClassName()
        {
            return className;
        }

        public static void SetLogId(int value)
        {
            id = value;
        }

        public static int? GetLogId()
        {
            return id;
        }

        public static string GetCurrentClassName()
        {
            ClassBLL classBLL = new ClassBLL();
            return classBLL.CurrentClassName;
        }

    }
}

using PlatformaEducationala.Models.DataAccessLayer;
using PlatformaEducationala.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformaEducationala.Models.BusinessLogicLayer
{
    class ClassBLL
    {
        private string currentClassName = "";

        private ClassDAL classDAL = new ClassDAL();

        public ClassBLL()
        {
          
        }

        public ObservableCollection<Class> ClassesListDB{ get; set; }

        public ObservableCollection<Person> StudentsList { get; set; }

        public ObservableCollection<Person> TeachersList { get; set; }

        public string CurrentClassName
        {
            get
            {
                return currentClassName;
            }
            set
            {
                currentClassName = value;
            }
        }

        public ObservableCollection<Class> GetAllClassesDB()
        {
            return classDAL.GetClassesFromDB();
        }

        //public ObservableCollection<Person> GetStudentsFromClass()
        //{
        //    return classDAL.GetStudentsFromClass();
        //}


        //public ObservableCollection<Person> GetTeachersFromClass()
        //{
        //    return classDAL.GetTeachersFromClass();
        //}

        public string GetCurrentClassName()
        {
            return currentClassName;
        }

        public void SetCurrentClassName(string name)
        {
            currentClassName= name;
        }

        public void SetClassMasterId(int id)
        {
            for (int index = 0; index <GetAllClassesDB().Count(); index++)
            {
                if (GetAllClassesDB()[index].ClassName == currentClassName)
                {
                    GetAllClassesDB()[index].Id = id;
                }
            }
        }

        public void AddClassMaster(Class currentClass)
        {
            for (int index = 0; index < GetAllClassesDB().Count(); index++)
            {
                if (GetAllClassesDB()[index].ClassName == currentClassName)
                {
                    classDAL.AddClassMaster(GetAllClassesDB()[index]);
                }
            }
        }

        public void AddSpecialization(Class currentClass)
        {
            for (int index = 0; index < GetAllClassesDB().Count(); index++)
            {
                if (GetAllClassesDB()[index].ClassName == currentClassName)
                {
                    classDAL.AddSpecialization(GetAllClassesDB()[index]);
                }
            }
        }

        public void AddClassesToDB()
        {
            for (int index = 0; index < GetAllClassesDB().Count(); index++)
            {
                classDAL.AddClassToDB(GetAllClassesDB()[index]);
            }
        }
    }
}

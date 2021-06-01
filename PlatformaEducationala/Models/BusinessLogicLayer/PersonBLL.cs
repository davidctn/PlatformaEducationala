using PlatformaEducationala.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformaEducationala.Models.BusinessLogicLayer
{
    class PersonBLL
    {
        private PersonDAL personDAL = new PersonDAL();

        public PersonBLL()
        {

        }

        public ObservableCollection<Person> StudentsList { get; set; }

        public ObservableCollection<Person> TeachersList { get; set; }

        public ObservableCollection<Person> AdminsList { get; set; }


        public ObservableCollection<Person> GetAllStudents()
        {
            return personDAL.GetAllStudents();
        }

        public ObservableCollection<Person> GetAllTeachers()
        {
            return personDAL.GetAllTeachers();
        }

        public ObservableCollection<Person> GetAllAdmins()
        {
            return personDAL.GetAllAdmins();
        }
         
        public void AddStudent(Person person)
        {
            personDAL.AddStudent(person);
            StudentsList.Add(person);
        }

        public void ModifyStudent(Person person)
        {
            personDAL.ModifyStudent(person);
        }

        public void DeleteStudent(Person person)
        {
            personDAL.DeleteStudent(person);
            StudentsList.Remove(person);
        }

        public void AddTeacher(Person person)
        {
            personDAL.AddTeacher(person);
            TeachersList.Add(person);
        }

        public void ModifyTeacher(Person person)
        {
            personDAL.ModifyTeacher(person);
        }

        public void DeleteTeacher(Person person)
        {
            personDAL.DeleteTeacher(person);
            TeachersList.Remove(person);
        }

       

    }
}

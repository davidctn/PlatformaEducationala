using PlatformaEducationala.Models.BusinessLogicLayer;
using PlatformaEducationala.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PlatformaEducationala.ViewModels
{
    class PersonVM
    {
        PersonBLL personBLL = new PersonBLL();
        public PersonVM()
        {
            StudentsList = personBLL.GetAllStudents();
            AdminsList = personBLL.GetAllAdmins();
            TeachersList = personBLL.GetAllTeachers();
        }

        #region Data Members

        public ObservableCollection<Person> StudentsList
        {
            get
            {
                return personBLL.StudentsList;
            }
            set
            {
                personBLL.StudentsList = value;
            }
        }


        public ObservableCollection<Person> TeachersList
        {
            get
            {
                return personBLL.TeachersList;
            }
            set
            {
                personBLL.TeachersList = value;
            }
        }

        public ObservableCollection<Person> AdminsList
        {
            get
            {
                return personBLL.AdminsList;
            }
            set
            {
                personBLL.AdminsList = value;
            }
        }

        #endregion

        #region Command Members

        private ICommand addStudentCommand;
        public ICommand AddStudentCommand
        {
            get
            {
                if (addStudentCommand == null)
                {
                    addStudentCommand = new RelayCommand<Person>(personBLL.AddStudent);
                }
                return addStudentCommand;
            }
        }

        private ICommand addTeacherCommand;
        public ICommand AddTeacherCommand
        {
            get
            {
                if (addTeacherCommand == null)
                {
                    addTeacherCommand = new RelayCommand<Person>(personBLL.AddTeacher);
                }
                return addTeacherCommand;
            }
        }

        private ICommand deleteStudentCommand;
        
        public ICommand DeleteStudentCommand
        {
            get
            {
                if (deleteStudentCommand == null)
                {
                    deleteStudentCommand = new RelayCommand<Person>(personBLL.DeleteStudent);
                }
                return deleteStudentCommand;
            }
        }

        private ICommand deleteTeacherCommand;

        public ICommand DeleteTeacherCommand
        {
            get
            {
                if (deleteTeacherCommand == null)
                {
                    deleteTeacherCommand = new RelayCommand<Person>(personBLL.DeleteTeacher);
                }
                return deleteTeacherCommand;
            }
        }

        private ICommand modifyStudentCommand;

        public ICommand ModifyStudentCommand
        {
            get
            {
                if (modifyStudentCommand == null)
                {
                    modifyStudentCommand = new RelayCommand<Person>(personBLL.ModifyStudent);
                }
                return modifyStudentCommand;
            }
        }

        private ICommand modifyTeacherCommand;
        public ICommand ModifyTeacherCommand
        {
            get
            {
                if (modifyTeacherCommand == null)
                {
                    modifyTeacherCommand = new RelayCommand<Person>(personBLL.ModifyTeacher);
                }
                return modifyTeacherCommand;
            }
        }

        #endregion

    }
}

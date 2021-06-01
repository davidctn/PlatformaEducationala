using PlatformaEducationala.Models.BusinessLogicLayer;
using PlatformaEducationala.Models.EntityLayer;
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
    class ClassVM
    {
        private ClassBLL classBLL = new ClassBLL();
        

        public ClassVM()
        {
            ClassesListDB = classBLL.GetAllClassesDB();
            //StudentsList = classBLL.GetStudentsFromClass();
            //TeachersList = classBLL.GetTeachersFromClass();
        }

        #region Data Members


        public ObservableCollection<Class> ClassesListDB
        {
            get
            {
                return classBLL.ClassesListDB;
            }
            set
            {
                classBLL.ClassesListDB = value;
            }
        }

        public ObservableCollection<Person> StudentsList
        {
            get
            {
                return classBLL.StudentsList;
            }
            set
            {
                classBLL.StudentsList = value;
            }
        }

        public ObservableCollection<Person> TeachersList
        {
            get
            {
                return classBLL.TeachersList;
            }
            set
            {
                classBLL.TeachersList = value;
            }
        }
        #endregion

        #region Command Members

        private ICommand addClassMasterCommand;
     
        public ICommand AddClassMasterCommand
        {
            get
            {
                if (addClassMasterCommand == null)
                {
                    addClassMasterCommand = new RelayCommand<Class>(classBLL.AddClassMaster);
                }
                return addClassMasterCommand;
            }
        }


        private ICommand addSpecializationCommand;

        public ICommand AddSpecializationCommand
        {
            get
            {
                if (addSpecializationCommand == null)
                {
                    addSpecializationCommand = new RelayCommand<Class>(classBLL.AddSpecialization);
                }
                return addSpecializationCommand;
            }
        }
        #endregion
    }
}

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
    class CourseVM
    {
        CourseBLL courseBLL = new CourseBLL();

        public CourseVM()
        {
            CoursesList = courseBLL.GetAllCourses();
        }

        #region Data Members
        public ObservableCollection<Course> CoursesList
        {
            get
            {
                return courseBLL.CoursesList;
            }
            set
            {
                courseBLL.CoursesList = value;
            }
        }

        #endregion

        #region Command Members

        private ICommand addCourseCommand;

        public ICommand AddCourseCommand
        {
            get
            {
                if (addCourseCommand == null)
                {
                    addCourseCommand = new RelayCommand<Course>(courseBLL.AddCourse);
                }
                return addCourseCommand;
            }
        }

        private ICommand modifyCourseCommand;

        public ICommand ModifyCourseCommand
        {
            get
            {
                if (modifyCourseCommand == null)
                {
                    modifyCourseCommand = new RelayCommand<Course>(courseBLL.ModifyCourse);
                }
                return modifyCourseCommand;
            }
        }

        private ICommand deleteCourseCommand;

        public ICommand DeleteCourseCommand
        {
            get
            {
                if (deleteCourseCommand == null)
                {
                    deleteCourseCommand = new RelayCommand<Course>(courseBLL.DeleteCourse);
                }
                return deleteCourseCommand;
            }
        }
        #endregion
    }
}

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
    class CourseBLL
    {
        private CourseDAL courseDAL = new CourseDAL();
        
        public CourseBLL()
        {
         
        }

        public ObservableCollection<Course> CoursesList { get; set; }

        public ObservableCollection<Course> GetAllCourses()
        {
            return courseDAL.GetAllCourses();
        }

        public void AddCourse(Course course)
        { 
            courseDAL.AddCourse(course);
    
        }

        public void DeleteCourse(Course course)
        {
            courseDAL.DeleteCourse(course);
            CoursesList.Remove(course);
        }

        public void ModifyCourse(Course course)
        {
            courseDAL.ModifyCourse(course);       
        }
    }
}

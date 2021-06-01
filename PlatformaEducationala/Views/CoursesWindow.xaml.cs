using PlatformaEducationala.Models.BusinessLogicLayer;
using PlatformaEducationala.Models.DataAccessLayer;
using PlatformaEducationala.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PlatformaEducationala.Views
{
    /// <summary>
    /// Interaction logic for CoursesWindow.xaml
    /// </summary>
    public partial class CoursesWindow : Window
    {
        private CourseBLL courseBLL = new CourseBLL();
        public CoursesWindow()
        {
            InitializeComponent();
        }

    

        private void DeleteCourseButton_Click(object sender, RoutedEventArgs e)
        {
  
        }

        private void ModifyCourseButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddCourseButton_Click(object sender, RoutedEventArgs e)
        {
            Course course = new Course();
            course.CourseName = CourseNameInput.Text;        
            courseBLL.AddCourse(course);
            courseBLL.CoursesList = courseBLL.GetAllCourses();
        }
    }
}

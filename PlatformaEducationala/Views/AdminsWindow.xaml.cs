using PlatformaEducationala.Models.DataAccessLayer;
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
    /// Interaction logic for AdminsWindow.xaml
    /// </summary>
    public partial class AdminsWindow : Window
    { 
        public AdminsWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            ModifyAndDeleteStudents changeStudentsWindow = new ModifyAndDeleteStudents();
            changeStudentsWindow.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            AddTeacherWindow addTeacherWindow = new AddTeacherWindow();
            addTeacherWindow.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            ModifyAndDeleteTeachers changeTeachersWindow = new ModifyAndDeleteTeachers();
            changeTeachersWindow.Show();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            CoursesWindow coursesWindow = new CoursesWindow();
            coursesWindow.Show();
        }

        private void MenuItem_Click_c1(object sender, RoutedEventArgs e)
        {
            DALHelper.SetClassName("class1");
            SelectClassWindow selectClassWindow = new SelectClassWindow();
            selectClassWindow.Show();
        }

        private void MenuItem_Click_c2(object sender, RoutedEventArgs e)
        {
            DALHelper.SetClassName("class2");
            SelectClassWindow selectClassWindow = new SelectClassWindow();
            selectClassWindow.Show();
        }
        private void MenuItem_Click_c3(object sender, RoutedEventArgs e)
        {
            DALHelper.SetClassName("class3");
            SelectClassWindow selectClassWindow = new SelectClassWindow();
            selectClassWindow.Show();
        }
        private void MenuItem_Click_c4(object sender, RoutedEventArgs e)
        {
            DALHelper.SetClassName("class4");
            SelectClassWindow selectClassWindow = new SelectClassWindow();
            selectClassWindow.Show();
        }
        private void MenuItem_Click_c5(object sender, RoutedEventArgs e)
        {
            DALHelper.SetClassName("class5");
            SelectClassWindow selectClassWindow = new SelectClassWindow();
            selectClassWindow.Show();
        }
        private void MenuItem_Click_c6(object sender, RoutedEventArgs e)
        {
            DALHelper.SetClassName("class6");
            SelectClassWindow selectClassWindow = new SelectClassWindow();
            selectClassWindow.Show();
        }
        private void MenuItem_Click_c7(object sender, RoutedEventArgs e)
        {
            DALHelper.SetClassName("class7");
            SelectClassWindow selectClassWindow = new SelectClassWindow();
            selectClassWindow.Show();
        }
        private void MenuItem_Click_c8(object sender, RoutedEventArgs e)
        {
            DALHelper.SetClassName("class8");
            SelectClassWindow selectClassWindow = new SelectClassWindow();
            selectClassWindow.Show();
        }

        private void MenuItem_Click_c9(object sender, RoutedEventArgs e)
        {
            ClassMasterAndSpecialization classMasterAndSpecialization = new ClassMasterAndSpecialization();
            classMasterAndSpecialization.Show();
        }

    }
}

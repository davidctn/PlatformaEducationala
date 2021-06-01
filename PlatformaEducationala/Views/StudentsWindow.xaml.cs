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
    /// Interaction logic for StudentsWindow.xaml
    /// </summary>
    public partial class StudentsWindow : Window
    {
        public StudentsWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            GradesWindow gradesWindow = new GradesWindow();
            gradesWindow.Show();
        }

        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {
            CoursesViewWindow coursesViewWindow = new CoursesViewWindow();
            coursesViewWindow.Show();
        }

        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {
            AbsencesWindow absencesWindow = new AbsencesWindow();
            absencesWindow.Show();
        }

        private void MenuItem_Click3(object sender, RoutedEventArgs e)
        {
            AveragesWindow averagesWindow = new AveragesWindow();
            averagesWindow.Show();
        }
    }
}

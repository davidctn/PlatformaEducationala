using PlatformaEducationala;
using PlatformaEducationala.Models.BusinessLogicLayer;
using PlatformaEducationala.Models.DataAccessLayer;
using PlatformaEducationala.Models.EntityLayer;
using PlatformaEducationala.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PlatformaEducationala
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PersonDAL personDAL=new PersonDAL();
   
        public MainWindow()
        {
            InitializeComponent();
        
        }


        private void DisplayMessage(string message,string boxTitle)
        {
            MessageBox.Show(message, boxTitle, MessageBoxButton.OK);
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameInput.Text;
            string password = PasswordInput.Text;
            bool foundStudent = false;
            bool foundTeacher = false;
            bool foundAdmin = false;
            for (int index = 0; index < personDAL.GetAllStudents().Count(); index++)
            {
                if (personDAL.GetAllStudents()[index].EmailAddress == username
                    && personDAL.GetAllStudents()[index].Password == password)
                {
                    DALHelper.SetLogId((int)personDAL.GetAllStudents()[index].Id);
                    DisplayMessage($"Bine ai venit, {personDAL.GetAllStudents()[index].FirstName} {personDAL.GetAllStudents()[index].LastName}","Autentificare reusita");
                    foundStudent = true;
                    StudentsWindow studentWindow = new StudentsWindow();
                    studentWindow.Show();
                    this.Close();
                }
            }

            for (int index = 0; index < personDAL.GetAllTeachers().Count(); index++)
            {
                if (personDAL.GetAllTeachers()[index].EmailAddress == username
                    && personDAL.GetAllTeachers()[index].Password == password)
                {
                    DALHelper.SetLogId((int)personDAL.GetAllTeachers()[index].Id);
                    DisplayMessage($"Bine ai venit, {personDAL.GetAllTeachers()[index].FirstName} {personDAL.GetAllTeachers()[index].LastName}", "Autentificare reusita");
                    foundTeacher = true;
                    TeachersWindow teacherWindow = new TeachersWindow();
                    teacherWindow.Show();
                    this.Close();
                }
            }

            for (int index = 0; index < personDAL.GetAllAdmins().Count(); index++)
            {
                if (personDAL.GetAllAdmins()[index].EmailAddress == username
                    && personDAL.GetAllAdmins()[index].Password == password)
                {
                    DALHelper.SetLogId((int)personDAL.GetAllAdmins()[index].Id);
                    DisplayMessage($"Bine ai venit, {personDAL.GetAllAdmins()[index].FirstName} {personDAL.GetAllAdmins()[index].LastName}", "Autentificare reusita");
                    foundAdmin = true;
                    AdminsWindow adminWindow = new AdminsWindow();
                    adminWindow.Show();
                    this.Close();
                }
            }

            if (foundStudent == false && foundTeacher == false && foundAdmin == false)
            {
                DisplayMessage("Adresa institutionala sau parola sunt gresite.", "Autentificare esuata");
            }
        }
    }
}

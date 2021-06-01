using PlatformaEducationala.Models.DataAccessLayer;
using PlatformaEducationala.Views.AllClasses;
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
    /// Interaction logic for SelectClassWindow.xaml
    /// </summary>
    public partial class SelectClassWindow : Window
    {
        public SelectClassWindow()
        {
            InitializeComponent();
        }

        private void ClassA_Click(object sender, RoutedEventArgs e)
        {
            if(DALHelper.GetClassName()=="class1")
            {
                Class1A class1A_Window = new Class1A();
                class1A_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class2")
            {
                Class2A class2A_Window = new Class2A();
                class2A_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class3")
            {
                Class3A class3A_Window = new Class3A();
                class3A_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class4")
            {
                Class4A class4A_Window = new Class4A();
                class4A_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class5")
            {
                Class5A class5A_Window = new Class5A();
                class5A_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class6")
            {
                Class6A class6A_Window = new Class6A();
                class6A_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class7")
            {
                Class7A class7A_Window = new Class7A();
                class7A_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class8")
            {
                Class8A class8A_Window = new Class8A();
                class8A_Window.Show();
                this.Close();
            }
        }

        private void ClassB_Click(object sender, RoutedEventArgs e)
        {
            if (DALHelper.GetClassName() == "class1")
            {
                Class1B class1B_Window = new Class1B();
                class1B_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class2")
            {
                Class2B class2B_Window = new Class2B();
                class2B_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class3")
            {
                Class3B class3B_Window = new Class3B();
                class3B_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class4")
            {
                Class4B class4B_Window = new Class4B();
                class4B_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class5")
            {
                Class5B class5B_Window = new Class5B();
                class5B_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class6")
            {
                Class6B class6B_Window = new Class6B();
                class6B_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class7")
            {
                Class7B class7B_Window = new Class7B();
                class7B_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class8")
            {
                Class8B class8B_Window = new Class8B();
                class8B_Window.Show();
                this.Close();
            }
        }

        private void ClassC_Click(object sender, RoutedEventArgs e)
        {
            if (DALHelper.GetClassName() == "class1")
            {
                Class1C class1C_Window = new Class1C();
                class1C_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class2")
            {
                Class2C class2C_Window = new Class2C();
                class2C_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class3")
            {
                Class3C class3C_Window = new Class3C();
                class3C_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class4")
            {
                Class4C class4C_Window = new Class4C();
                class4C_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class5")
            {
                Class5C class5C_Window = new Class5C();
                class5C_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class6")
            {
                Class6C class6C_Window = new Class6C();
                class6C_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class7")
            {
                Class7C class7C_Window = new Class7C();
                class7C_Window.Show();
                this.Close();
            }

            if (DALHelper.GetClassName() == "class8")
            {
                Class8C class8C_Window = new Class8C();
                class8C_Window.Show();
                this.Close();
            }
        }
    }
}

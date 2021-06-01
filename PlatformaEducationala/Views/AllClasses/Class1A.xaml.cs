using PlatformaEducationala.Models.BusinessLogicLayer;
using PlatformaEducationala.Models.DataAccessLayer;
using PlatformaEducationala.Models.EntityLayer;
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
using System.Windows.Shapes;

namespace PlatformaEducationala.Views.AllClasses
{
    /// <summary>
    /// Interaction logic for Class1A.xaml
    /// </summary>
    public partial class Class1A : Window
    {
        private ClassBLL classBLL = new ClassBLL();


        public Class1A()
        {
            InitializeComponent();
            classBLL.SetCurrentClassName("1A");
        }

        private void AddClassMasterButton_Click(object sender, RoutedEventArgs e)
        {
        
        }
    }
}

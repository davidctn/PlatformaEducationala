using PlatformaEducationala.Models.BusinessLogicLayer;
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

namespace PlatformaEducationala.Views.AllClasses
{
    /// <summary>
    /// Interaction logic for Class1B.xaml
    /// </summary>
    public partial class Class1B : Window
    {
        private ClassBLL classBLL = new ClassBLL();
        public Class1B()
        {
            InitializeComponent();
            classBLL.SetCurrentClassName("1B");
        }

        private void AddClassMasterButton_Click(object sender, RoutedEventArgs e)
        {
        
        }
    }
}

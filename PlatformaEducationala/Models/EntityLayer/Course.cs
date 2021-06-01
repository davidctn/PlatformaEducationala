using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformaEducationala.Models.EntityLayer
{
    class Course : INotifyPropertyChanged
    {
        private int? id;
        private string courseName;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public Course()
        {

        }

        public Course(int? id,string courseName)
        {
            this.id = id;
            this.courseName = courseName;
        }
        public int? Id
        {
            get
            {
                return this.id;
            }
            set
            {
                id = value;
                NotifyPropertyChanged("Id");
            }
        }

        public string CourseName
            {
            get
            {
                return this.courseName;
            }
            set
            {
                courseName = value;
                NotifyPropertyChanged("CourseName");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformaEducationala.Models.EntityLayer
{
    class Absence
    {
        private int? id;
        private string courseName;
        private string dateWhenAdded;
   

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public Absence()
        {

        }

        public Absence(int? id, string courseName, string dateWhenAdded)
        {
            this.id = id;
            this.courseName = courseName;
            this.dateWhenAdded = dateWhenAdded;
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


        public string DateWhenAdded
        {
            get
            {
                return this.dateWhenAdded;
            }
            set
            {
                dateWhenAdded = value;
                NotifyPropertyChanged("DateWhenAdded");
            }
        }
    }
}

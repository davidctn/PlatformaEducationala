using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformaEducationala.Models.EntityLayer
{
    class Average : INotifyPropertyChanged
    {
        private int? id;
        private string value;
        private string courseName;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public Average()
        {

        }

        public Average(int? id, string value,string courseName)
        {
            this.id = id;
            this.value = value;
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


        public string Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
                NotifyPropertyChanged("Value");
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


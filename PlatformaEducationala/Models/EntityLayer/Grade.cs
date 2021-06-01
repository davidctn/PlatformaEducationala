using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformaEducationala.Models.EntityLayer
{
    class Grade : INotifyPropertyChanged
    {
        private int? id;
        private int value;
        private int isThesis;
        private int studentId;
        private string courseName;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public Grade()
        {

        }

        public Grade(int?id, int value, int isThesis,int studentId,string courseName)
        {
            this.id = id;
            this.value = value;
            this.isThesis = isThesis;
            this.studentId = studentId;
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

        public int Value
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


        public int IsThesis
        {
            get
            {
                return this.isThesis;
            }
            set
            {
                isThesis = value;
                NotifyPropertyChanged("IsThesis");
            }
        }

        public int StudentId
        {
            get
            {
                return this.studentId;
            }
            set
            {
                studentId = value;
                NotifyPropertyChanged("StudentId");
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

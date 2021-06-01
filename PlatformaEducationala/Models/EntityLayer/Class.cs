using PlatformaEducationala.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformaEducationala.Models.EntityLayer
{
    class Class : INotifyPropertyChanged
    {
        private int? id;
        private string className;
        private string specialization;
        private int classMaster;
        private ObservableCollection<Person> teachers = new ObservableCollection<Person>();
        private ObservableCollection<Person> students = new ObservableCollection<Person>();


        public event PropertyChangedEventHandler PropertyChanged;

        public Class()
        {

        }

        public Class(int? id, string className, string specialization, int classMaster)
        {
            this.id = id;
            this.className = className;
            this.specialization = specialization;
            this.classMaster = classMaster;
        }

        public Class(int? id,string className,string specialization ,int classMaster, ObservableCollection<Person> teachers, ObservableCollection<Person> students)
        {
            this.id = id;
            this.className = className;
            this.specialization = specialization;
            this.classMaster = classMaster;
            this.teachers = teachers;
            this.students = students;
        }

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
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

        public string ClassName
        {
            get
            {
                return this.className;
            }
            set
            {
                className = value;
                NotifyPropertyChanged("ClassName");
            }
        }

        public string Specialization
        {
            get
            {
                return this.specialization;
            }
            set
            {
                specialization = value;
                NotifyPropertyChanged("Specialization");
            }
        }

        public int ClassMaster
        {
            get
            {
                return this.classMaster;
            }
            set
            {
                classMaster = value;
                NotifyPropertyChanged("ClassMaster");
            }
        }

        public ObservableCollection<Person> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                teachers = value;
                NotifyPropertyChanged("Teachers");
            }
        }

        public ObservableCollection<Person> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                students = value;
                NotifyPropertyChanged("Students");
            }
        }
    }
}
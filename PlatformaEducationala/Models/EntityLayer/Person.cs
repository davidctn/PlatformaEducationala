using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PlatformaEducationala
{

    class Person : INotifyPropertyChanged 
    {

        private int? id;
        private string firstName;
        private string lastName;
        private string emailAddress;
        private string password;
        private string className;

        public event PropertyChangedEventHandler PropertyChanged;

        public Person(int? id,string firstName, string lastName, string emailAddress, string password,string className)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.password = password;
            this.className = className;
        }

        public Person()
        {

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

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                firstName = value;
                NotifyPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                lastName = value;
                NotifyPropertyChanged("LastName");
            }
        }

        public string EmailAddress
        {
            get
            {
                return this.emailAddress;
            }
            set
            {
                emailAddress = value;
                NotifyPropertyChanged("EmailAddress");
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                password = value;
                NotifyPropertyChanged("Password");
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

        public string DisplayInfo
        {
            get
            {
                return $"  \n Informations \n First name : {firstName} \n Last name : {lastName} \n E-mail Address : {emailAddress} \n \n";

            }
        }
    }
}

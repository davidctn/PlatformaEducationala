using PlatformaEducationala.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PlatformaEducationala.ViewModels.Commands
{

        class RelayCommand<T> : ICommand
        {
            private Action<T> commandTask;
            private Predicate<T> canExecuteTask;
   
            public Action<Grade> AddGrade { get; }
        public Action<int> AddClassMaster { get; }
        public Action<string> AddSpecialization { get; }
        public Action AddClassMaster1 { get; }

        public RelayCommand(Action<T> workToDo)
                : this(workToDo, DefaultCanExecute)
            {
                commandTask = workToDo;
            }

            public RelayCommand(Action<T> workToDo, Predicate<T> canExecute)
            {
                commandTask = workToDo;
                canExecuteTask = canExecute;
            }

        public RelayCommand(Action<int> addClassMaster)
        {
            AddClassMaster = addClassMaster;
        }

        public RelayCommand(Action<string> addSpecialization)
        {
            AddSpecialization = addSpecialization;
        }

        public RelayCommand(Action addClassMaster)
        {
            AddClassMaster1 = addClassMaster;
        }

        //public RelayCommand(Action<Course> addCourse)
        //{
        //    this.addCourse = addCourse;
        //}

        //public RelayCommand(Action<Grade> addGrade)
        //{
        //    AddGrade = addGrade;
        //}



        private static bool DefaultCanExecute(T parameter)
            {
                return true;
            }

            public bool CanExecute(object parameter)
            {
                return canExecuteTask != null && canExecuteTask((T)parameter);
            }

            public event EventHandler CanExecuteChanged
            {
                add
                {
                    CommandManager.RequerySuggested += value;
                }

                remove
                {
                    CommandManager.RequerySuggested -= value;
                }
            }

            public void Execute(object parameter)
            {
                commandTask((T)parameter);
            }
        }
    }


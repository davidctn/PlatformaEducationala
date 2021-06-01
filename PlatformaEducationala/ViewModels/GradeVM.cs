using PlatformaEducationala.Models.BusinessLogicLayer;
using PlatformaEducationala.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PlatformaEducationala.ViewModels.Commands
{
    class GradeVM
    {
        GradeBLL gradeBLL = new GradeBLL();

        public GradeVM()
        {
            GradesList = gradeBLL.GetAllGrades();
            CurrentStudentGrades = gradeBLL.GetCurrentStudentGrades();
            CurrentStudentAverages = gradeBLL.GetCurrentStudentAverages();
        }

        #region Data Members
        public ObservableCollection<Grade> GradesList
        {
            get
            {
                return gradeBLL.GradesList;
            }
            set
            {
                gradeBLL.GradesList = value;
            }
        }

        public ObservableCollection<Grade> CurrentStudentGrades
        {
            get
            {
                return gradeBLL.CurrentStudentGrades;
            }
            set
            {
                gradeBLL.CurrentStudentGrades = value;
            }
        }

        public ObservableCollection<Average> CurrentStudentAverages
        {
            get
            {
                return gradeBLL.CurrentStudentAverages;
            }
            set
            {
                gradeBLL.CurrentStudentAverages = value;
            }
        }

        #endregion



        #region Command Members

        private ICommand addGradeCommand;
        public ICommand AddGradeCommand
        {
            get
            {
                if (addGradeCommand == null)
                {
                    addGradeCommand = new RelayCommand<Grade>(gradeBLL.AddGrade);
                }
                return addGradeCommand;
            }
        }


        private ICommand deleteGradeCommand;

        public ICommand DeleteGradeCommand
        {
            get
            {
                if (deleteGradeCommand == null)
                {
                    deleteGradeCommand = new RelayCommand<Grade>(gradeBLL.DeleteGrade);
                }
                return deleteGradeCommand;
            }
        }

        private ICommand modifyGradeCommand;

        public ICommand ModifyGradeCommand
        {
            get
            {
                if (modifyGradeCommand == null)
                {
                    modifyGradeCommand = new RelayCommand<Grade>(gradeBLL.ModifyGrade);
                }
                return modifyGradeCommand;
            }
        }
        #endregion

    }
}

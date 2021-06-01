using PlatformaEducationala.Models.BusinessLogicLayer;
using PlatformaEducationala.Models.EntityLayer;
using PlatformaEducationala.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PlatformaEducationala.ViewModels
{
    class AbsenceVM
    {
        AbsenceBLL absenceBLL = new AbsenceBLL();

        public AbsenceVM()
        {
            AbsencesList = absenceBLL.GetAllAbsences();
            CurrentStudentAbsences = absenceBLL.GetCurrentStudentAbsences();
        }

        #region Data Members
        public ObservableCollection<Absence> AbsencesList
        {
            get
            {
                return absenceBLL.AbsencesList;
            }
            set
            {
                absenceBLL.AbsencesList = value;
            }
        }

        public ObservableCollection<Absence> CurrentStudentAbsences
        {
            get
            {
                return absenceBLL.CurrentStudentAbsences;
            }
            set
            {
                absenceBLL.CurrentStudentAbsences = value;
            }
        }

        #endregion

        #region Command Members

        private ICommand addAbsenceCommand;
        public ICommand AddAbsenceCommand
        {
            get
            {
                if (addAbsenceCommand == null)
                {
                    addAbsenceCommand = new RelayCommand<Absence>(absenceBLL.AddAbsence);
                }
                return addAbsenceCommand;
            }
        }


        private ICommand deleteAbsenceCommand;

        public ICommand DeleteAbsenceCommand
        {
            get
            {
                if (deleteAbsenceCommand == null)
                {
                    deleteAbsenceCommand = new RelayCommand<Absence>(absenceBLL.DeleteAbsence);
                }
                return deleteAbsenceCommand;
            }
        }

        #endregion
    }
}

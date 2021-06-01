using PlatformaEducationala.Models.DataAccessLayer;
using PlatformaEducationala.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformaEducationala.Models.BusinessLogicLayer
{
    class AbsenceBLL
    {
        private AbsenceDAL absenceDAL = new AbsenceDAL();

        public AbsenceBLL()
        {

        }

        public ObservableCollection<Absence> AbsencesList { get; set; }

        public ObservableCollection<Absence> CurrentStudentAbsences { get; set; }

        public ObservableCollection<Absence> GetAllAbsences()
        {
            return absenceDAL.GetAllAbsences();
        }

        public ObservableCollection<Absence> GetCurrentStudentAbsences()
        {
            return absenceDAL.GetCurrentStudentAbsences();
        }

        public void AddAbsence(Absence absence)
        {
            absenceDAL.AddAbsence(absence);
            AbsencesList.Add(absence);
        }

        public void DeleteAbsence(Absence absence)
        {
            absenceDAL.DeleteAbsence(absence);
            AbsencesList.Remove(absence);
        }
    }
}

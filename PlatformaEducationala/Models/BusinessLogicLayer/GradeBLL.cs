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
    class GradeBLL
    {
        private GradeDAL gradeDAL = new GradeDAL();
        public GradeBLL()
        {

        }

        public ObservableCollection<Grade> GradesList { get; set; }

        public ObservableCollection<Grade> CurrentStudentGrades { get; set; }

        public ObservableCollection<Average> CurrentStudentAverages { get; set; }

        public ObservableCollection<Grade> GetAllGrades()
        {
            return gradeDAL.GetAllGrades();
        }

        public ObservableCollection<Grade> GetCurrentStudentGrades()
        {
            return gradeDAL.GetCurrentStudentGrades();
        }

        public ObservableCollection<Average> GetCurrentStudentAverages()
        {
            return gradeDAL.GetCurrentStudentAverages();
        }

        public void AddGrade(Grade grade)
        {
            gradeDAL.AddGrade(grade);
            GradesList.Add(grade);
        }

        public void ModifyGrade(Grade grade)
        {
            gradeDAL.ModifyGrade(grade);
        }

        public void DeleteGrade(Grade grade)
        {
            gradeDAL.DeleteGrade(grade);
            GradesList.Remove(grade);
        }

 
    }
}

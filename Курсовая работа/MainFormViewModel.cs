using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public class MainFormViewModel
    {
        public CurrentSession currentSession;
        
        public void DeleteWorker(string Login)
        {
            foreach (Worker worker in currentSession.Workers)
            {
                if (worker.credentials.Login == Login)
                {
                    try
                    {
                        currentSession.DeleteWorker(worker);
                        MessageBox.Show("Работник был успешно удален", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
            }
        }

        public string FormOrder(int fieldOfStudy, int budget, int contract, int minPoints)
        {
            List<Applicant> ResultList = new List<Applicant>();
            string ResultString;

            foreach (Applicant applicant in currentSession.Applicants)
            {
                if (applicant.fieldOfStudy == fieldOfStudy && applicant.documentsStatus.isStatementSigned &&
                    applicant.documentsStatus.isEnrollmentSigned && CountPoints(applicant) >= minPoints)
                {
                    ResultList.Add(applicant);
                }
            }
            ResultList.Sort(new CompareApplicantsByPoints());
            ResultString = (ResultList.Count() != 0 && budget != 0) ? "Зачислить на бюджетной основе:\r\n" : "";


            for (int i = 0; i < ResultList.Count(); i++)
            {
                if (i == budget + contract) break;
                if (i == budget) 
                    ResultString += "\r\nЗачислить на контрактной основе:\r\n";
                ResultString += $"{i + 1}. {ResultList[i].Surname} {ResultList[i].Name} {ResultList[i].MiddleName} — {CountPoints(ResultList[i])}\r\n";
            }
            return ResultString;
        }

        public int MaxID()
        {
            int maxID = 0;
            foreach (Applicant a in currentSession.Applicants) maxID = (maxID > a.ID) ? maxID : a.ID;
            return maxID;
        }

        private int CountPoints(Applicant a)
        {
            int points = 0, minPoints = 100;
            foreach (Exam exam in a.exams)
            {
                points += exam.Points;
                minPoints = (exam.Points < minPoints) ? exam.Points : minPoints;
            }
            if (a.exams.Count == 4) points -= minPoints;
            points += a.Achivements;
            return points;
        }

        public MainFormViewModel(Worker CurrentWorker)
        {
            currentSession = new CurrentSession(CurrentWorker);
            currentSession.Load();
        }
    }
}

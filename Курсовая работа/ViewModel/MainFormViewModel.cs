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
        
        // Удалить работника
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

        // Возвратить максимальный номер дела абитуриента
        public int MaxID()
        {
            int maxID = 0;
            foreach (Applicant a in currentSession.Applicants) maxID = (maxID > a.ID) ? maxID : a.ID;
            return maxID;
        }

        public string FormOrder(int fieldOfStudy, int budget, int contract, int minPoints)
        {
            return currentSession.FormOrder(fieldOfStudy, budget, contract, minPoints);
        }

        public MainFormViewModel(Worker CurrentWorker)
        {
            currentSession = new CurrentSession(CurrentWorker);
            currentSession.Load();
        }
    }
}

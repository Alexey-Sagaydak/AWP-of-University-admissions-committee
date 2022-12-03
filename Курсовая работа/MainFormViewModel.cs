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

        public MainFormViewModel(Worker CurrentWorker)
        {
            currentSession = new CurrentSession(CurrentWorker);
            currentSession.Load();
        }
    }
}

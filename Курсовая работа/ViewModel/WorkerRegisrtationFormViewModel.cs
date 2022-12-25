using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class WorkerRegisrtationFormViewModel
    {
        public ICurrentSession currentSession;

        // Добавить работника
        public void AddWorker(Worker worker)
        {
            currentSession.Load();
            currentSession.AddWorker(worker);
        }

        public WorkerRegisrtationFormViewModel(Worker CurrentWorker)
        {
            currentSession = new CurrentSession(CurrentWorker);
        }
    }
}

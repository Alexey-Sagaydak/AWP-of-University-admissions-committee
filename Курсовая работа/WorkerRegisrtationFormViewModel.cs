using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class WorkerRegisrtationFormViewModel
    {
        CurrentSession currentSession = new CurrentSession(ControlID.worker);

        public void AddWorker(Worker worker)
        {
            currentSession.Load();
            currentSession.AddWorker(worker);
        }

        public WorkerRegisrtationFormViewModel()
        {
            
        }
    }
}

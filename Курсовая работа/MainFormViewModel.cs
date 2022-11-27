using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class MainFormViewModel
    {
        public CurrentSession currentSession = new CurrentSession(ControlID.worker);

        public MainFormViewModel()
        {
            currentSession.Load();
        }
    }
}

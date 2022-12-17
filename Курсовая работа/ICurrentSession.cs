using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public interface ICurrentSession
    {
        void AddWorker(Worker worker);
        bool DeleteWorker(Worker worker);
        void AddApplicant(Applicant applicant);
        bool DeleteApplicant(int ID);
        Applicant GetApplicant(int ID);
        void Load();
    }
}

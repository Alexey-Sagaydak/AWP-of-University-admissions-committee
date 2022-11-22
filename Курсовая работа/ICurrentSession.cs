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
        bool DeleteWorker(int ID);
        void AddApplicant(Applicant applicant);
        bool DeleteApplicant(int ID);
        List<Applicant> FindApplicants(int ID);
        List<Applicant> FindApplicants(string name, string surname);
        List<Applicant> FindApplicants(FieldOfStudy fieldOfStudy);
    }
}

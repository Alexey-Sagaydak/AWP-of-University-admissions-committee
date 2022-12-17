using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public interface IApplicant : IHuman
    {
        int ID { get; set; }
        Passport passport { get; set; }
        SchoolDiploma schoolDiploma { get; set; }
        List<Exam> exams { get; set; }
        string additionalInformation { get; set; }
        DocumentsStatus documentsStatus { get; set; }
        int fieldOfStudy { get; set; }
        int Achivements { get; set; }
    }
}

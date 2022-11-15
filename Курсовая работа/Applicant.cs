using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public enum FieldOfStudy : int
    {
        [Description("01.03.01 - Математика")]
        Maths = 0,

        [Description("01.03.02 - Прикладная математика и информатика")]
        AppliedMathsAndIT = 1,

        [Description("01.03.04 - Прикладная математика")]
        AppliedMaths = 2,

        [Description("03.03.01 - Прикладные математика и физика")]
        AppliedMathsAndPhysics = 3,

        [Description("03.03.02 - Физика")]
        Physics = 4,

        [Description("04.03.01 - Химия")]
        Chemistry = 5,

        [Description("09.03.04 - Программная инженерия")]
        SoftwareEngineering = 6,

        [Description("10.03.01 - Информационная безопасность")]
        InformationSecurity = 7,

        [Description("11.03.01 - Радиотехника")]
        RadioEngineering = 8,

        [Description("41.03.03 - Востоковедение и африканистика")]
        OrientalAndAfricanStudies = 9
    };
    public class Applicant// : Human
    {
        public int Id { get; set; }
        public Passport passport;
        public SchoolDiploma schoolDiploma;
        public List<Exam> exams;
        public int achivements;
        public string additionalInformation;
        public DocumentsStatus documentsStatus;
        public FieldOfStudy fieldOfStudy;
    }
}

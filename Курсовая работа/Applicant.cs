using Newtonsoft.Json;
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
    public class Applicant : Human
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("passport")]
        public Passport passport { get; set; }

        [JsonProperty("school_diploma")]
        public SchoolDiploma schoolDiploma { get; set; }

        [JsonProperty("exams")]
        public List<Exam> exams { get; set; }

        private int achivements;

        [JsonProperty("additional_information")]
        public string additionalInformation { get; set; }

        [JsonProperty("documents_status")]
        public DocumentsStatus documentsStatus { get; set; }

        [JsonProperty("field_of_study")]
        public FieldOfStudy fieldOfStudy { get; set; }

        [JsonProperty("achivements")]
        public int Achivements
        {
            get { return achivements; }
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentException("Количество баллов за индивидуальные достижения должно быть в диапазоне от 1 до 10.");
                achivements = value;
            }
        }
        public Applicant(int _ID, string _name, string _surname, string _middleName, DateTime _dateOfBirth, Passport _passport,
            SchoolDiploma _schoolDiploma, List<Exam> _exams, int _achivements,
            string _additionalInformation, DocumentsStatus _documentsStatus, FieldOfStudy _fieldOfStudy) :
            base(_name, _surname, _middleName, _dateOfBirth)
        {
            ID = _ID;
            passport = _passport;
            schoolDiploma = _schoolDiploma;
            exams = _exams;
            Achivements = _achivements;
            additionalInformation = _additionalInformation;
            documentsStatus = _documentsStatus;
            fieldOfStudy = _fieldOfStudy;
        }
    }
}

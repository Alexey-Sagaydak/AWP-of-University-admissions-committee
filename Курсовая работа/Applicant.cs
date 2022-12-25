using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Курсовая_работа
{
    public class Applicant : Human, IApplicant
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
        public int fieldOfStudy { get; set; }

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

        // Список направлений подготовки
        public static List<string> FieldsOfStudy = new List<string>();

        public Applicant(int _ID, string _name, string _surname, string _middleName, DateTime _dateOfBirth, Passport _passport,
            SchoolDiploma _schoolDiploma, List<Exam> _exams, int _achivements,
            string _additionalInformation, DocumentsStatus _documentsStatus, int _fieldOfStudy) :
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
            FieldsOfStudy = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText("FieldsOfStudyData.json"));
        }
    }
}

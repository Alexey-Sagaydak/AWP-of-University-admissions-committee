using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class SchoolDiploma : ISchoolDiploma
    {
        private string series;
        private string number;
        private string educationalInstitution;

        private Regex fiveNumbers = new Regex(@"[0-9]{5}");
        private Regex nineNumbers = new Regex(@"[0-9]{9}");

        [JsonProperty("series")]
        public string Series
        {
            get { return series; }
            set
            {
                if (value != null && !fiveNumbers.IsMatch(value))
                    throw new ArgumentException("Серия аттестата должна состоять из 5-и цифр.");
                series = value;
            }
        }

        [JsonProperty("number")]
        public string Number
        {
            get { return number; }
            set
            {
                if (value != null && !nineNumbers.IsMatch(value))
                    throw new ArgumentException("Номер аттестата должен состоять из 9-и цифр.");
                number = value;
            }
        }

        [JsonProperty("educational_institution")]
        public string EducationalInstitution
        {
            get { return educationalInstitution; }
            set
            {
                if (value == "")
                    throw new ArgumentException("Название образовательной организации не должно являться пустой строкой.");
                educationalInstitution = value;
            }
        }

        public SchoolDiploma(string _series, string _number, string _educationalInstitution)
        {
            Series = _series;
            Number = _number;
            EducationalInstitution = _educationalInstitution;
        }
    }
}

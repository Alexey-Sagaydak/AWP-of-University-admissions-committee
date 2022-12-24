using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Курсовая_работа
{
    public class Human : IHuman
    {
        private string name;
        private string surname;
        private string middleName;
        
        [JsonProperty("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [JsonProperty("name")]
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                    throw new ArgumentException("Имя не должно являться пустой строкой.");
                name = value;
            }
        }

        [JsonProperty("surname")]
        public string Surname
        {
            get { return surname; }
            set
            {
                if (value == "")
                    throw new ArgumentException("Фамилия не должна являться пустой строкой.");
                surname = value;
            }
        }

        [JsonProperty("middle_name")]
        public string MiddleName
        {
            get { return middleName; }
            set
            {
                if (value == "")
                    throw new ArgumentException("Отчество не должно являться пустой строкой.");
                middleName = value;
            }
        }

        public Human (string _name, string _surname, string _middleName, DateTime _dateOfBirth)
        {
            Name= _name;
            Surname= _surname;
            MiddleName= _middleName;
            DateOfBirth = _dateOfBirth;
        }
    }
}

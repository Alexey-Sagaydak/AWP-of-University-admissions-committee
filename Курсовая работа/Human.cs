using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public abstract class Human
    {
        private string name;
        private string surname;
        private string middleName;
        DateTime DateOfBirth { get; set; }
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                    throw new ArgumentException("Имя не должно являться пустой строкой");
                name = value;
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (value == "")
                    throw new ArgumentException("Фамилия не должна являться пустой строкой");
                surname = value;
            }
        }
        public string MiddleName
        {
            get { return middleName; }
            set
            {
                if (value == "")
                    throw new ArgumentException("Отчество не должно являться пустой строкой");
                middleName = value;
            }
        }
        public Human (string _name, string _surname, string _middleName, DateTime _dateOfBirth)
        {
            Name= _name;
            Surname= _surname;
            MiddleName= _middleName;
            DateOfBirth= _dateOfBirth;
        }
    }
}

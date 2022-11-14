using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Курсовая_работа
{
    public class Passport
    {
        public string series;
        public string number;
        public string address;

        private Regex fourNumbers = new Regex(@"[0-9]{4}");
        private Regex sixNumbers = new Regex(@"[0-9]{6}");
        public string Series
        {
            get { return series; }
            set
            {
                if (!fourNumbers.IsMatch(value))
                    throw new ArgumentException("Серия паспорта должна состоять из 4-х цифр.");
                series = value;
            }
        }
        public string Number
        {
            get { return number; }
            set
            {
                if (!sixNumbers.IsMatch(value))
                    throw new ArgumentException("Номер паспорта должен состоять из 6-и цифр.");
                number = value;
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                if (value == "")
                    throw new ArgumentException("Адрес не должен являться пустой строкой");
                address = value;
            }
        }
        public Passport(string _series, string _number, string _address)
        {
            Series = _series;
            Number = _number;
            Address = _address;
        }
    }
}

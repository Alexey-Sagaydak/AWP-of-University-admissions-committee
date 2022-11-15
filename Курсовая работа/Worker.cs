using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Курсовая_работа
{
    public enum Status : byte
    {
        [Description("Worker can add, delete and find applicants")]
        Worker = 0,
        [Description("Admin can add, delete workers, add, delete and find applicants")]
        Admin = 1
    };
    public class Worker : Human
    {
        public Status Status { get; set; }
        public Credentials credentials;
        public Worker(string _name, string _surname, string _middleName, DateTime _dateOfBirth,
            string _login, string _password, Status _status) :
            base (_name, _surname, _middleName, _dateOfBirth)
        {
            credentials = new Credentials(_login, _password);
            Status = _status;
        }
    }
}

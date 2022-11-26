using Newtonsoft.Json;
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
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("credentials")]
        public Credentials credentials { get; set; }
        public Worker(int _ID, string _name, string _surname, string _middleName, DateTime _dateOfBirth,
            Credentials _credentials, Status _status) :
            base (_name, _surname, _middleName, _dateOfBirth)
        {
            ID = _ID;
            credentials = _credentials;
            Status = _status;
        }
        
    }
}

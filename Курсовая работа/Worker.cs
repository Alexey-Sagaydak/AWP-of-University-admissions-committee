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
        /// <summary>
        /// Status Worker allows worker to add, delete and find applicants
        /// </summary>
        Worker = 0,
        
        /// <summary>
        /// Status Admin allows worker to add, delete and find applicants and workers
        /// </summary>
        Admin = 1
    };

    public class Worker : Human, IWorker
    {
        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("credentials")]
        public Credentials credentials { get; set; }
        public Worker(string _name, string _surname, string _middleName, DateTime _dateOfBirth,
            Credentials _credentials, Status _status) :
            base (_name, _surname, _middleName, _dateOfBirth)
        {
            credentials = _credentials;
            Status = _status;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class WorkerForBinding
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Login { get; set; }
        public bool Admin { get; set; }
        public WorkerForBinding(string name, string surname, string middlename, string login, bool isAdmin)
        {
            Name = name;
            Surname = surname;
            MiddleName = middlename;
            Admin = isAdmin;
            Login = login;
        }
    }
}

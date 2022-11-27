using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class WorkerForBinding
    {
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string Логин { get; set; }
        public bool Администратор { get; set; }
        public WorkerForBinding(string name, string surname, string middlename, string login, bool isAdmin)
        {
            Имя = name;
            Фамилия = surname;
            Отчество = middlename;
            Администратор = isAdmin;
            Логин = login;
        }
    }
}

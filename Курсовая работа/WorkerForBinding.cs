using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class WorkerForBinding
    {
        public string Имя;
        public string Фамилия;
        public string Отчество;
        public string Логин;
        public bool Администратор;
        public WorkerForBinding(string name, string surname, string middlename, bool isAdmin)
        {
            Имя = name;
            Фамилия = surname;
            Отчество = middlename;
            Администратор = isAdmin;
        }
    }
}

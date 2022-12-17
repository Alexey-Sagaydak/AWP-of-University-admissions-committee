using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public interface IAuthorization
    {
        bool CheckWorker(string login, string password, out Worker a);
    }
}

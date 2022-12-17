using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public interface IPassport
    {
        string Series { get; set; }
        string Number { get; set; }
        string Address { get; set; }
    }
}

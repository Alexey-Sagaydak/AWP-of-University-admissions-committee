using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public interface IHuman
    {
        DateTime DateOfBirth { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string MiddleName { get; set; }
    }
}

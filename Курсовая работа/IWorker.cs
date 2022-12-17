using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public interface IWorker : IHuman
    {
        Status Status { get; set; }
    }
}

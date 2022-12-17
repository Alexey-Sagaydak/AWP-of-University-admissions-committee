using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public interface IDocumentStatus
    {
        bool isStatementSigned { get; set; }
        bool isEnrollmentSigned { get; set; }
        bool isEnrolled { get; set; }
    }
}

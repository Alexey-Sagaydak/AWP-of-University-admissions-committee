using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class DocumentsStatus
    {
        public bool isStatementSigned {get; set;}
        public bool isEnrollmentSigned { get; set;}
        public bool isEnrolled { get; set;}
        public DocumentsStatus(bool _isStatementSigned, bool _isEnrollmentSigned, bool _isEnrolled)
        {
            isStatementSigned = _isStatementSigned;
            isEnrollmentSigned = _isEnrollmentSigned;
            isEnrolled = _isEnrolled;
        }
    }
}

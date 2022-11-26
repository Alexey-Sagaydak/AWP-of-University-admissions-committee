using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class DocumentsStatus
    {
        [JsonProperty("is_statement_signed")]
        public bool isStatementSigned { get; set; }

        [JsonProperty("is_enrollment_signed")]
        public bool isEnrollmentSigned { get; set; }

        [JsonProperty("is_enrolled")]
        public bool isEnrolled { get; set; }

        public DocumentsStatus(bool _isStatementSigned, bool _isEnrollmentSigned, bool _isEnrolled)
        {
            isStatementSigned = _isStatementSigned;
            isEnrollmentSigned = _isEnrollmentSigned;
            isEnrolled = _isEnrolled;
        }
    }
}

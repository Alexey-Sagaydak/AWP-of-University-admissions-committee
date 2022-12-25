using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class CompareApplicantsByID : IComparer<Applicant>
    {
        // Реализация интерфейса IComparer
        public int Compare(Applicant a, Applicant b)
        {
            int flag = 1;
            if (a.ID == b.ID)
            {
                flag = 0;
            }
            else
            {
                if (a.ID < b.ID)
                {
                    flag = -1;
                }
            }
            return flag;
        }
    }
}

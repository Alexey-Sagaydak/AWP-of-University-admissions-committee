using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class CompareApplicantsByPoints : IComparer<Applicant>
    {
        private int CountPoints(Applicant a)
        {
            int points = 0, minPoints = 100;

            foreach (Exam exam in a.exams)
            {
                points += exam.Points;
                minPoints = (exam.Points < minPoints) ? exam.Points : minPoints;
            }
            if (a.exams.Count == 4)
            {
                points -= minPoints;
            }
            points += a.Achivements;

            return points;
        }
        public int Compare(Applicant a, Applicant b)
        {
            int flag = 1, countA = CountPoints(a), countB = CountPoints(b);

            if (countA == countB)
            {
                flag = 0;
            }
            else
            {
                if (countA > countB)
                {
                    flag = -1;
                }
            }
            return flag;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class ApplicantForBinding
    {
        public int Number { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string FieldOfStudy { get; set; }
        public string Subjects { get; set; }
        public int Points { get; set; }

        public string Add { get; set; }

        public ApplicantForBinding(int ID, string surname, string name, string middleName,
            int fieldOfStudy, List<Exam> exams, int addPoints, string add)
        {
            int minPoints = 100;

            Number = ID;
            Surname = surname;
            Name = name;
            MiddleName = middleName;
            FieldOfStudy = Applicant.FieldsOfStudy[fieldOfStudy];

            Subjects = "";
            Points = 0;
            foreach (Exam exam in exams)
            {
                Subjects += ", " + Exam.Subjects[exam.Subject];
                Points += exam.Points;
                minPoints = (exam.Points < minPoints) ? exam.Points : minPoints;
            }

            if (exams.Count == 4)
            {
                Points -= minPoints;
            }

            Points += addPoints;
            Subjects = Subjects.Remove(0, 2);

            Add = add;
        }
    }
}

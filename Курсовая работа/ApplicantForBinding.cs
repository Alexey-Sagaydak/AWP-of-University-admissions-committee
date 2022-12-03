using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class ApplicantForBinding
    {
        public int Номер { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string Направление { get; set; }
        public string Предметы { get; set; }
        public int Баллы { get; set; }

        public string Дополнительно { get; set; }

        public ApplicantForBinding(int ID, string surname, string name, string middleName,
            FieldOfStudy fieldOfStudy, List<Exam> exams, int addPoints, string add)
        {
            int minPoints = 100;

            Номер = ID;
            Фамилия = surname;
            Имя = name;
            Отчество = middleName;
            Направление = ControlID.fields[(int)fieldOfStudy];

            Предметы = "";
            Баллы = 0;
            foreach (Exam exam in exams)
            {
                Предметы += ", " + ControlID.subjects[(int)exam.Subject];
                Баллы += exam.Points;
                minPoints = (exam.Points < minPoints) ? exam.Points : minPoints;
            }

            if (exams.Count == 4)
            {
                Баллы -= minPoints;
            }

            Баллы += addPoints;
            Предметы = Предметы.Remove(0, 2);

            Дополнительно = add;
        }
    }
}

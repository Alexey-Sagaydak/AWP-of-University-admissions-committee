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

        private string[] fields = { "01.03.01 - Математика", "01.03.02 - Прикладная математика и информатика",
            "01.03.04 - Прикладная математика", "03.03.01 - Прикладные математика и физика", "03.03.02 - Физика",
            "04.03.01 - Химия", "09.03.04 - Программная инженерия", "10.03.01 - Информационная безопасность",
            "11.03.01 - Радиотехника", "41.03.03 - Востоковедение и африканистика" };

        private string[] subjects = { "Русский язык", "Профильная математика", "Информатика и ИКТ",
            "Английский язык", "Физика", "История", "Обществознание", "География", "Биология", "Химия" };

        public ApplicantForBinding(int ID, string surname, string name, string middleName,
            FieldOfStudy fieldOfStudy, List<Exam> exams)
        {
            Номер = ID;
            Фамилия = surname;
            Имя = name;
            Отчество = middleName;
            Направление = fields[(int)fieldOfStudy];

            Предметы = "";
            Баллы = 0;
            foreach (Exam exam in exams)
            {
                Предметы += ", " + subjects[(int)exam.Subject];
                Баллы += exam.Points;
            }
            Предметы = Предметы.Remove(0, 2);
        }
    }
}

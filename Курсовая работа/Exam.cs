using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая_работа;

namespace Курсовая_работа
{
    public enum Subject : int
    {
        [Description("Russian")]
        Russian = 0,
        [Description("Math")]
        Math = 1,
        [Description("IT")]
        IT = 2,
        [Description("English")]
        English = 3,
        [Description("Physics")]
        Physics = 4,
        [Description("History")]
        History = 5,
        [Description("Social studies")]
        SocialStudies = 6,
        [Description("Geography")]
        Geography = 7,
        [Description("Biology")]
        Biology = 8,
        [Description("Chemistry")]
        Chemistry = 9
    };

    public class Exam
    {
        public Subject Subject { get; set; }
        private int points;
        public int Points
        {
            get { return points; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Количество баллов должно быть в диапазоне от 1 до 100.");
                points = value;
            }
        }
        public Exam(Subject _subject, int _points)
        {
            Subject = _subject;
            Points = _points;
        }
    }
}

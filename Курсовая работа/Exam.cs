using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая_работа;

namespace Курсовая_работа
{
    public class Exam : IExam
    {
        [JsonProperty("subject")]
        public int Subject { get; set; }

        private int points;

        [JsonProperty("points")]
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

        public static List<string> Subjects = new List<string>();
        public Exam(int _subject, int _points)
        {
            Subject = _subject;
            Points = _points;
            Subjects = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText("SubjectsData.json"));
        }
    }
}

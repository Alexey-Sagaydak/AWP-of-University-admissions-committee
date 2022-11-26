using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Курсовая_работа
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// public InsertNames()
        [STAThread]

        // Не забыть убрать консоль
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());

            Exam e1 = new Exam(Subject.Chemistry, 100);

            List<Exam> Exams = new List<Exam>();
            Exams.Add(e1);
            List<Worker> workers = new List<Worker>();
            List<Applicant> applicants = new List<Applicant>();

            //obj = default(T);

            Worker worker1 = new Worker(1, "Admin", "Admin", "Admin", new DateTime(2003, 7, 23), new Credentials("Admin123", "Admin123"), Status.Admin);

            Worker worker2 = new Worker(2, "Петров", "Петр", "Петрович", new DateTime(1999, 2, 5), new Credentials("rrrrrr", "D1aaaa"), Status.Worker);

            //workers.Add(worker1);
            //workers.Add(worker2);
            //var textJson = JsonConvert.SerializeObject(worker1);
            //File.WriteAllText("WorkersData.json", textJson);

            //worker1 = null;
            //string text = File.ReadAllText("WorkersData.json");
            //Console.WriteLine(text);
            //Worker str = JsonConvert.DeserializeObject<Worker>(text);
            //Console.WriteLine(str.credentials.Password);

            //Passport pasport = new Passport("1234", "123456", "  ");

            //Console.WriteLine(Credentials.CompareHashes(worker1.credentials.Hash, worker2.credentials.Hash));

            Applicant applicant1 = new Applicant(10, "Максимов", "Максим", "Игоревич", new DateTime(2004, 3, 6),
                new Passport("1234", "123456", "dffwd"), new SchoolDiploma("12345", "123456789", "ef"),
                Exams, 10, "ed", new DocumentsStatus(true, false, false), FieldOfStudy.AppliedMaths);

            Applicant applicant2 = new Applicant(11, "Павлов", "Павел", "Павлович", new DateTime(2008, 3, 6),
                new Passport("1234", "123456", "dffwd"), new SchoolDiploma("12345", "123456789", "ef"),
                Exams, 10, "ed", new DocumentsStatus(true, false, false), FieldOfStudy.AppliedMaths);

            //applicants.Add(applicant1);
            //applicants.Add(applicant2);

            //CurrentSession currentSession = new CurrentSession(worker1);
            //currentSession.Load();

            //currentSession.AddWorker(worker1);
            /*currentSession.AddApplicant(applicant1);
            currentSession.AddWorker(worker2);
            currentSession.AddApplicant(applicant2);*/

            //currentSession.DeleteApplicant(10);
            //currentSession.DeleteWorker(2);

            //foreach (Worker worker in currentSession.Workers)
            //{
            //    Console.WriteLine($"{worker.credentials.Hash[0]}");
            //}

            //foreach (Applicant applicant in currentSession.Applicants)
            //{
            //    Console.WriteLine($"{applicant.exams[0].Points}");
            //}
            //DocumentsStatus docs = new DocumentsStatus(true, false, false);
            //SchoolDiploma schoolDiploma = new SchoolDiploma("12345", "123456789", "uygf");
            //Console.WriteLine($"{e1.Points} {e1.Subject}");
        }
        
    }
}

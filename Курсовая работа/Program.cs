using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
             //Application.EnableVisualStyles();
             //Application.SetCompatibleTextRenderingDefault(false);
             //Application.Run(new AuthorizationForm());
            
            //Exam e1 = new Exam(Subject.Chemistry, 100);
            List<Worker> workers = new List<Worker>();
            List<Applicant> applicants = new List<Applicant>();

            Worker worker1 = new Worker(1, "Иванов", "Иван", "Иванович", new DateTime(1999, 5, 6),
                new Credentials("ivanov", "123456A"), Status.Admin);

            Worker worker2 = new Worker(2, "Петров", "Петр", "Петрович", new DateTime(1999, 5, 6),
                new Credentials("petrov", "123456B"), Status.Worker);

            workers.Add(worker1);
            //workers.Add(worker2);
            //Passport pasport = new Passport("1234", "123456", "  ");
            
            //Console.WriteLine(Credentials.CompareHashes(worker1.credentials.Hash, worker2.credentials.Hash));

            Applicant applicant1 = new Applicant(10, "Максимов", "Максим","Игоревич", new DateTime(1999, 5, 6),
                new Passport("1234", "123456", "dffwd"),new SchoolDiploma("12345", "123456789", "ef"),
                null, 10, "ed", new DocumentsStatus(true, false, false), FieldOfStudy.AppliedMaths);

            Applicant applicant2 = new Applicant(11, "Павлов", "Павел", "Павлович", new DateTime(1999, 5, 6),
                new Passport("1234", "123456", "dffwd"), new SchoolDiploma("12345", "123456789", "ef"),
                null, 10, "ed", new DocumentsStatus(true, false, false), FieldOfStudy.AppliedMaths);

            applicants.Add(applicant1);
            //applicants.Add(applicant2);

            CurrentSession currentSession = new CurrentSession(workers, applicants, worker1);

            currentSession.AddWorker(worker2);
            currentSession.AddApplicant(applicant2);
            currentSession.DeleteApplicant(10);
            currentSession.DeleteWorker(1);

            foreach (Worker worker in currentSession.Workers)
            {
                Console.WriteLine($"{worker.Name}");
            }

            foreach (Applicant applicant in currentSession.Applicants)
            {
                Console.WriteLine($"{applicant.Name}");
            }
            //DocumentsStatus docs = new DocumentsStatus(true, false, false);
            //SchoolDiploma schoolDiploma = new SchoolDiploma("12345", "123456789", "uygf");
            //Console.WriteLine($"{e1.Points} {e1.Subject}");
        }
        
    }
}

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
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new AuthorizationForm());
            
            //Exam e1 = new Exam(Subject.Chemistry, 100);
            Worker worker1 = new Worker("I", "S", "0", new DateTime(1999, 5, 6), "vdаааа", "sddssS1a", Status.Admin);
            Worker worker2 = new Worker("I", "S", "0", new DateTime(1999, 5, 6), "vdаааа", "sddssS1a", Status.Admin);
            //Passport pasport = new Passport("1234", "123456", "  ");
            //Console.WriteLine(Credentials.CompareHashes(worker1.credentials.Hash, worker2.credentials.Hash));

            Applicant applicant = new Applicant(10, "dfd", "dds","ssdsd", new DateTime(1999, 5, 6),
                new Passport("1234", "123456", "dffwd"),new SchoolDiploma("12345", "123456789", "ef"),
                null, 10, "ed", new DocumentsStatus(true, false, false), FieldOfStudy.AppliedMaths);
            //DocumentsStatus docs = new DocumentsStatus(true, false, false);
            //SchoolDiploma schoolDiploma = new SchoolDiploma("12345", "123456789", "uygf");
            //Console.WriteLine($"{e1.Points} {e1.Subject}");
            
        }
        
    }
}

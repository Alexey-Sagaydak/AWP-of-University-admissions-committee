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
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new AuthorizationForm());
            
            DateTime dateOfBirth = new DateTime(1999, 5, 6);
            Exam e1 = new Exam(Subject.Chemistry, 100);
            Worker worker1 = new Worker("I", "S", "0", dateOfBirth, "vdаааа", "sddssS1a", Status.Admin);
            Worker worker2 = new Worker("I", "S", "0", dateOfBirth, "vdаааа", "sddssS1a", Status.Admin);
            Passport pasport = new Passport("1234", "123456", "");
            Console.WriteLine(worker1.CompareHashes(worker2.Hash));
            //Console.WriteLine($"{e1.Points} {e1.Subject}");
            
        }
        
    }
}

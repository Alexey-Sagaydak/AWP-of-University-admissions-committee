using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public class AuthorizationFormViewModel
    {
        public IAuthorization authorization;

        // Проверка наличия работника в базе
        public bool CheckWorker(string login, string password, out Worker worker)
        {
            return authorization.CheckWorker(login, password, out worker);
        }

        public AuthorizationFormViewModel()
        {
            try
            {
                authorization = new Authorization();
            }
            catch (FileNotFoundException ex) {

                MessageBox.Show(ex.Message, "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationFormViewModel ViewModel = new AuthorizationFormViewModel();

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ViewModel.CheckWorker(loginTextBox.Text, passwordTextBox.Text))
            {
                Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Не удалось найти работника с такими учетными данными.",
                    "Ошибка авторизации!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}

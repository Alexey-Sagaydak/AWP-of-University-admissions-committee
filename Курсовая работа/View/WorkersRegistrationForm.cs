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
    public partial class WorkersRegistrationForm : Form
    {
        public WorkerRegisrtationFormViewModel ViewModel;

        public WorkersRegistrationForm(Worker CurrentWorker)
        {
            InitializeComponent();
            ViewModel = new WorkerRegisrtationFormViewModel(CurrentWorker);
            DialogResult = DialogResult.None;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                ViewModel.AddWorker(new Worker(nameTextBox.Text, surnameTextBox.Text, middleNameTextBox.Text,
                    dateTimePicker.Value, new Credentials(loginTextBox.Text, passTextBox.Text),
                    admRadioButton.Checked ? Status.Admin : Status.Worker));
                this.Close();
                MessageBox.Show("Работник был успешно добавлен.", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

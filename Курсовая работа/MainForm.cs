using System;
using System.Collections;
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
    public partial class MainForm : Form
    {
        public MainFormViewModel ViewModel = new MainFormViewModel();

        public MainForm()
        {
            InitializeComponent();
            if (ViewModel.currentSession.CurrentWorker.Status == Status.Worker)
            {
                добавитьСотрудникаToolStripMenuItem.Enabled = false;
                списокСотрудниковToolStripMenuItem.Enabled = false;
                сформироватьПриказОЗачисленииToolStripMenuItem.Enabled = false;
            }

            this.Text = $"Приемная кампания (сотрудник: {ViewModel.currentSession.CurrentWorker.Surname} {ViewModel.currentSession.CurrentWorker.Name} {ViewModel.currentSession.CurrentWorker.MiddleName})";

            workersDataGridView.DataSource = workerForBindingBindingSource;
            foreach (Worker worker in ViewModel.currentSession.Workers)
            {
                workerForBindingBindingSource.Add(new WorkerForBinding(worker.Name,
                    worker.Surname, worker.MiddleName, worker.credentials.Login,
                    (worker.Status == Status.Admin) ? true : false ));
            }
            
            applicantsDataGridView.DataSource = applicantForBindingBindingSource;
            ViewModel.currentSession.Applicants.Sort(new CompareApplicants());
            foreach (Applicant applicant in ViewModel.currentSession.Applicants)
            {
                applicantForBindingBindingSource.Add(new ApplicantForBinding(applicant.ID, applicant.Surname,
                    applicant.Name, applicant.MiddleName, applicant.fieldOfStudy, applicant.exams));
            }
            sortOptionToolStripComboBox.SelectedIndex = 0;
            applicantPanel.Visible = false;
            dataBasePanel.Visible = true;
            workersPanel.Visible = false;
        }

        //private void MainForm_Load

        private void завершитьСеансToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void бакалавриатспециалитетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applicantPanel.Visible = true;
            dataBasePanel.Visible = false;
            workersPanel.Visible = false;
            //Hide();
            //Applicant applicantForm = new Applicant();
            //applicantForm.ShowDialog();
            //Close();
        }

        private void выйтиИОткрытьОкноАвторизацииToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void добавитьАбитуриентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!applicantPanel.Visible)
            {
                ApplicantTabControl.SelectedIndex = 0;
                surnameTextBox.Text = "";
                nameTextBox.Text = "";
                middleNameTextBox.Text = "";
                caseNumberTextBox.Text = "";
                passportNumberMaskedTextBox.Text = "";
                passportSeriesMaskedTextBox.Text = "";
                diplomaNumberMaskedTextBox.Text = "";
                diplomaSeriesMaskedTextBox.Text = "";
                addressTextBox.Text = "";
                additionalTextBox.Text = "";
                organizationTextBox.Text = "";
                dateTimePicker.Text = "01.01.2005";
                subject1CheckBox.Checked = true;
                subject2CheckBox.Checked = true;
                subject3CheckBox.Checked = true;
                subject4CheckBox.Checked = false;
                subject1ComboBox.SelectedIndex = 0;
                subject2ComboBox.SelectedIndex = 1;
                subject3ComboBox.SelectedIndex = 2;
                subject4ComboBox.SelectedIndex = 4;
                subject1numericUpDown.Value = 0;
                subject2numericUpDown.Value = 0;
                subject2numericUpDown.Value = 0;
                subject3numericUpDown.Value = 0;
                subject4numericUpDown.Value = 0;
                achivementsNumericUpDown.Value = 0;
                areasComboBox.SelectedIndex = 0;
                applicationCheckBox.Checked = false;
                agreementCheckBox.Checked = false;
                enrolledCheckBox.Checked = false;
            }
            applicantPanel.Visible = true;
            dataBasePanel.Visible = false;
            workersPanel.Visible = false;
        }

        private void списокАбитуриентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applicantPanel.Visible = false;
            dataBasePanel.Visible = true;
            workersPanel.Visible = false;
        }

        private void subject1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void applicantPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int ID;
            try
            {
                List<Exam> Exams = new List<Exam>();
                if (subject1CheckBox.Checked) Exams.Add(new Exam((Subject)Enum.ToObject(typeof(Subject),
                    subject1ComboBox.SelectedIndex), Convert.ToInt32(subject1numericUpDown.Value)));
                if (subject2CheckBox.Checked) Exams.Add(new Exam((Subject)Enum.ToObject(typeof(Subject),
                    subject2ComboBox.SelectedIndex), Convert.ToInt32(subject2numericUpDown.Value)));
                if (subject3CheckBox.Checked) Exams.Add(new Exam((Subject)Enum.ToObject(typeof(Subject),
                    subject3ComboBox.SelectedIndex), Convert.ToInt32(subject3numericUpDown.Value)));
                if (subject4CheckBox.Checked) Exams.Add(new Exam((Subject)Enum.ToObject(typeof(Subject),
                    subject4ComboBox.SelectedIndex), Convert.ToInt32(subject4numericUpDown.Value)));

                if (caseNumberTextBox.Text.All(char.IsDigit))
                {
                    ID = Convert.ToInt32(caseNumberTextBox.Text);
                } 
                else
                {
                    throw new ArgumentException("Номер дела должен быть целым числом.");
                }

                foreach (Applicant applicant in ViewModel.currentSession.Applicants)
                {
                    if (applicant.ID == ID)
                    {
                        throw new ArgumentException("Данный номер дела занят.");
                    }
                }

                ViewModel.currentSession.AddApplicant(new Applicant(ID, nameTextBox.Text, surnameTextBox.Text,
                    middleNameTextBox.Text, dateTimePicker.Value, new Passport(passportSeriesMaskedTextBox.Text,
                    passportNumberMaskedTextBox.Text, addressTextBox.Text), new SchoolDiploma(diplomaSeriesMaskedTextBox.Text,
                    diplomaNumberMaskedTextBox.Text, organizationTextBox.Text), Exams, Convert.ToInt32(achivementsNumericUpDown.Value),
                    additionalTextBox.Text, new DocumentsStatus(applicationCheckBox.Checked, agreementCheckBox.Checked,
                    enrolledCheckBox.Checked), (FieldOfStudy)Enum.ToObject(typeof(FieldOfStudy), areasComboBox.SelectedIndex)));

                MessageBox.Show("Абитуриент успешно добавлен.", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                applicantPanel.Visible = false;
                dataBasePanel.Visible = true;
                workersPanel.Visible = false;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            subject1ComboBox.SelectedIndex = 0;
            subject2ComboBox.SelectedIndex = 1;
            subject3ComboBox.SelectedIndex = 2;
            subject4ComboBox.SelectedIndex = 4;
            areasComboBox.SelectedIndex = 0;
        }

        private void areasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void добавитьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkersRegistrationForm workersRegistration = new WorkersRegistrationForm();
            workersRegistration.ShowDialog();
        }

        private void списокСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applicantPanel.Visible = false;
            dataBasePanel.Visible = false;
            workersPanel.Visible = true;
        }

        private void workersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteWorkerButton_Click(object sender, EventArgs e)
        {
            ViewModel.DeleteWorker(loginToDeleteTextBox.Text);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void loginToDeleteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ViewModel.currentSession.Load();
            workerForBindingBindingSource.Clear();
            foreach (Worker worker in ViewModel.currentSession.Workers)
            {
                workerForBindingBindingSource.Add(new WorkerForBinding(worker.Name,
                    worker.Surname, worker.MiddleName, worker.credentials.Login, (worker.Status == Status.Admin) ? true : false));
            }
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void applicantsPropertyGrid_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ViewModel.currentSession.Load();
            applicantForBindingBindingSource.Clear();
            ViewModel.currentSession.Applicants.Sort(new CompareApplicants());
            foreach (Applicant applicant in ViewModel.currentSession.Applicants)
            {
                applicantForBindingBindingSource.Add(new ApplicantForBinding(applicant.ID, applicant.Surname,
                    applicant.Name, applicant.MiddleName, applicant.fieldOfStudy, applicant.exams));
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
        public MainFormViewModel ViewModel;
        public Worker CurrentWorker;

        public MainForm(Worker currentWorker)
        {
            InitializeComponent();
            ViewModel = new MainFormViewModel(currentWorker);
            CurrentWorker = currentWorker;
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
            ViewModel.currentSession.Applicants.Sort(new CompareApplicantsByID());
            foreach (Applicant applicant in ViewModel.currentSession.Applicants)
            {
                applicantForBindingBindingSource.Add(new ApplicantForBinding(applicant.ID, applicant.Surname, applicant.Name,
                    applicant.MiddleName, applicant.fieldOfStudy, applicant.exams, applicant.Achivements, applicant.additionalInformation));
            }
            sortOptionToolStripComboBox.SelectedIndex = 0;
            fieldsComboBox.SelectedIndex = 0;
            applicantPanel.Visible = false;
            dataBasePanel.Visible = true;
            workersPanel.Visible = false;
            OrderOfEnrollmentPanel.Visible = false;
        }

        private void завершитьСеансToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void бакалавриатспециалитетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applicantPanel.Visible = true;
            dataBasePanel.Visible = false;
            workersPanel.Visible = false;
            OrderOfEnrollmentPanel.Visible = false;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void добавитьАбитуриентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!applicantPanel.Visible)
            {
                ApplicantTabControl.SelectedIndex = 0;
                surnameTextBox.Text = "";
                nameTextBox.Text = "";
                middleNameTextBox.Text = "";
                caseNumberTextBox.Text = Convert.ToString(ViewModel.MaxID() + 1);
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
            OrderOfEnrollmentPanel.Visible = false;
        }

        private void списокАбитуриентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applicantPanel.Visible = false;
            dataBasePanel.Visible = true;
            workersPanel.Visible = false;
            OrderOfEnrollmentPanel.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int ID;
            try
            {
                List<Exam> Exams = new List<Exam>();
                if (subject1CheckBox.Checked) Exams.Add(new Exam(subject1ComboBox.SelectedIndex,
                    Convert.ToInt32(subject1numericUpDown.Value)));
                if (subject2CheckBox.Checked) Exams.Add(new Exam(subject2ComboBox.SelectedIndex,
                    Convert.ToInt32(subject2numericUpDown.Value)));
                if (subject3CheckBox.Checked) Exams.Add(new Exam(subject3ComboBox.SelectedIndex,
                    Convert.ToInt32(subject3numericUpDown.Value)));
                if (subject4CheckBox.Checked) Exams.Add(new Exam(subject4ComboBox.SelectedIndex,
                    Convert.ToInt32(subject4numericUpDown.Value)));

                if (caseNumberTextBox.Text != "" && caseNumberTextBox.Text.All(char.IsDigit) &&
                        Convert.ToInt32(caseNumberTextBox.Text) > 0)
                {
                    ID = Convert.ToInt32(caseNumberTextBox.Text);
                } 
                else
                {
                    throw new ArgumentException("Номер дела должен быть целым положительным числом.");
                }

                foreach (Applicant applicant in ViewModel.currentSession.Applicants)
                {
                    if (applicant.ID == ID)
                    {
                        if (MessageBox.Show("Данный номер уже используется. Вы уверены, что хотите перезаписать данные абитуриента?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                        {
                            throw new ArgumentException("Введите другой номер дела.");
                        }
                    }
                }

                ViewModel.currentSession.AddApplicant(new Applicant(ID, nameTextBox.Text, surnameTextBox.Text,
                    middleNameTextBox.Text, dateTimePicker.Value, new Passport(passportSeriesMaskedTextBox.Text,
                    passportNumberMaskedTextBox.Text, addressTextBox.Text), new SchoolDiploma(diplomaSeriesMaskedTextBox.Text,
                    diplomaNumberMaskedTextBox.Text, organizationTextBox.Text), Exams, Convert.ToInt32(achivementsNumericUpDown.Value),
                    additionalTextBox.Text, new DocumentsStatus(applicationCheckBox.Checked, agreementCheckBox.Checked,
                    enrolledCheckBox.Checked), areasComboBox.SelectedIndex));

                MessageBox.Show("Успешно сохранено.", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void добавитьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkersRegistrationForm workersRegistration = new WorkersRegistrationForm(CurrentWorker);
            workersRegistration.ShowDialog();
        }

        private void списокСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applicantPanel.Visible = false;
            dataBasePanel.Visible = false;
            workersPanel.Visible = true;
            OrderOfEnrollmentPanel.Visible = false;
        }

        private void deleteWorkerButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить данного работника?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ViewModel.DeleteWorker(loginToDeleteTextBox.Text);
            }
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ViewModel.currentSession.Load();
            applicantForBindingBindingSource.Clear();

            switch (sortOptionToolStripComboBox.SelectedIndex)
            {
                case 0:
                    ViewModel.currentSession.Applicants.Sort(new CompareApplicantsByID());
                    break;
                case 1:
                    ViewModel.currentSession.Applicants.Sort((x, y) => String.Compare(x.Surname, y.Surname));
                    break;
                case 2:
                    ViewModel.currentSession.Applicants.Sort((x, y) => String.Compare(Applicant.FieldsOfStudy[x.fieldOfStudy],
                        Applicant.FieldsOfStudy[y.fieldOfStudy]));
                    break;
                default:
                    break;
            }

            foreach (Applicant applicant in ViewModel.currentSession.Applicants)
            {
                applicantForBindingBindingSource.Add(new ApplicantForBinding(applicant.ID, applicant.Surname, applicant.Name,
                    applicant.MiddleName, applicant.fieldOfStudy, applicant.exams, applicant.Achivements, applicant.additionalInformation));
            }
        }

        private void EditApplicantInfoButton_Click(object sender, EventArgs e)
        {
            Applicant a = null;
            if (editApplicantInfoTextBox.Text != "" && editApplicantInfoTextBox.Text.All(char.IsDigit) && (a = ViewModel.currentSession.GetApplicant(Convert.ToInt32(editApplicantInfoTextBox.Text))) != null)
            {
                ApplicantTabControl.SelectedIndex = 0;
                surnameTextBox.Text = a.Surname;
                nameTextBox.Text = a.Name;
                middleNameTextBox.Text = a.MiddleName;
                caseNumberTextBox.Text = a.ID.ToString();
                passportNumberMaskedTextBox.Text = a.passport.Number;
                passportSeriesMaskedTextBox.Text = a.passport.Series;
                diplomaNumberMaskedTextBox.Text = a.schoolDiploma.Number;
                diplomaSeriesMaskedTextBox.Text = a.schoolDiploma.Series;
                addressTextBox.Text = a.passport.Address;
                additionalTextBox.Text = a.additionalInformation;
                organizationTextBox.Text = a.schoolDiploma.EducationalInstitution;
                dateTimePicker.Text = a.DateOfBirth.ToString();

                subject1CheckBox.Checked = false;
                subject2CheckBox.Checked = false;
                subject3CheckBox.Checked = false;
                subject4CheckBox.Checked = false;
                subject1numericUpDown.Value = 0;
                subject2numericUpDown.Value = 0;
                subject3numericUpDown.Value = 0;
                subject4numericUpDown.Value = 0;

                if (a.exams.Count >= 1)
                {
                    subject1CheckBox.Checked = true;
                    subject1ComboBox.SelectedIndex = Convert.ToInt32(a.exams[0].Subject);
                    subject1numericUpDown.Value = a.exams[0].Points;
                }
                if (a.exams.Count >= 2)
                {
                    subject2CheckBox.Checked = true;
                    subject2ComboBox.SelectedIndex = Convert.ToInt32(a.exams[1].Subject);
                    subject2numericUpDown.Value = a.exams[1].Points;
                }
                if (a.exams.Count >= 3)
                {
                    subject3CheckBox.Checked = true;
                    subject3ComboBox.SelectedIndex = Convert.ToInt32(a.exams[2].Subject);
                    subject3numericUpDown.Value = a.exams[2].Points;
                }
                if (a.exams.Count >= 4)
                {
                    subject4CheckBox.Checked = true;
                    subject4ComboBox.SelectedIndex = Convert.ToInt32(a.exams[3].Subject);
                    subject4numericUpDown.Value = a.exams[3].Points;
                }

                achivementsNumericUpDown.Value = a.Achivements;
                areasComboBox.SelectedIndex = Convert.ToInt32(a.fieldOfStudy);
                applicationCheckBox.Checked = a.documentsStatus.isStatementSigned;
                agreementCheckBox.Checked = a.documentsStatus.isEnrollmentSigned;
                enrolledCheckBox.Checked = a.documentsStatus.isEnrolled;

                applicantPanel.Visible = true;
                dataBasePanel.Visible = false;
                workersPanel.Visible = false;
                OrderOfEnrollmentPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Номер дела не найден.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void editApplicantInfoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editApplicantInfoTextBox.Text != "" && MessageBox.Show("Вы уверены, что хотите удалить данного абитуриента? Это действие невозможно будет отменить.", "Внимание!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ViewModel.currentSession.DeleteApplicant(Convert.ToInt32(editApplicantInfoTextBox.Text));
            }
        }

        private void сформироватьПриказОЗачисленииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applicantPanel.Visible = false;
            dataBasePanel.Visible = false;
            workersPanel.Visible = false;
            OrderOfEnrollmentPanel.Visible = true;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            orderTextBox.Text = ViewModel.FormOrder(fieldsComboBox.SelectedIndex, Convert.ToInt32(budgetNumericUpDown.Value),
                Convert.ToInt32(contractNumericUpDown.Value), Convert.ToInt32(minSumNumericUpDown.Value));
        }

        private void copeButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(orderTextBox.Text);
            MessageBox.Show("Текст приказа успешно скопирован.", "Буфер обмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

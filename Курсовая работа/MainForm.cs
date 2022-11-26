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
    public partial class MainForm : Form
    {
        public MainFormViewModel ViewModel { get; }

        public MainForm()
        {
            InitializeComponent();
            applicantPanel.Visible = false;
            dataBasePanel.Visible = true;
            workersPanel.Visible = false;
        }


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
            WorkersRegistration workersRegistration = new WorkersRegistration();
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
    }
}

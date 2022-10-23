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
        public MainForm()
        {
            InitializeComponent();
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
            applicantPanel.Visible = true;
            dataBasePanel.Visible = false;
        }

        private void списокАбитуриентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applicantPanel.Visible = false;
            dataBasePanel.Visible = true;
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
    }
}

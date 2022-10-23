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
            //Hide();
            Applicant applicantForm = new Applicant();
            applicantForm.ShowDialog();
            //Close();
        }

        private void выйтиИОткрытьОкноАвторизацииToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

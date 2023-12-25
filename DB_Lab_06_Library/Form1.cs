using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lab_06_Library
{
    public partial class FormLibrary : Form
    {
        public FormLibrary()
        {
            InitializeComponent();
        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FBooks();
            f.Show();
        }

        private void читателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FReaders();
            f.Show();
        }

        private void должникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FDebtors();
            f.Show();
        }

        private void отчет1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report1 = new FastReport.Report();
            report1.Load("ReportOne.frx");
            report1.Show();
        }

        private void отчет2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report1 = new FastReport.Report();
            report1.Load("ReportTwo.frx");
            report1.Show();
        }

        private void отчет3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report1 = new FastReport.Report();
            report1.Load("ReportThree.frx");
            report1.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lab_06_Library
{
    public partial class FDebtors : Form
    {
        public FDebtors()
        {
            InitializeComponent();
        }

        private void FDebtors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.DEBTORS' table. You can move, or remove it, as needed.
            this.dEBTORSTableAdapter.Fill(this.libraryDataSet.DEBTORS);

        }
    }
}

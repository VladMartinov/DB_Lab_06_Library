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
    public partial class FReturn : Form
    {
        public FReturn()
        {
            InitializeComponent();
        }

        private void FReturn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.libraryDataSet.BOOKS);
            // TODO: This line of code loads data into the 'libraryDataSet.EXEMPLAR' table. You can move, or remove it, as needed.
            this.eXEMPLARTableAdapter.Fill(this.libraryDataSet.EXEMPLAR);
            // TODO: This line of code loads data into the 'libraryDataSet.Readers_List' table. You can move, or remove it, as needed.
            this.readers_ListTableAdapter.Fill(this.libraryDataSet.Readers_List);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.eXEMPLARTableAdapter.FillBy(this.libraryDataSet.EXEMPLAR, (short)comboBox1.SelectedValue);
        }

        private void FReturn_Shown(object sender, EventArgs e)
        {
            this.eXEMPLARTableAdapter.FillBy(this.libraryDataSet.EXEMPLAR, (short)comboBox1.SelectedValue);
        }

        private void FReturn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                this.Validate();
                this.eXEMPLARBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.libraryDataSet);
            }
        }
    }
}
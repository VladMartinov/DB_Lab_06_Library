﻿using System;
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
    public partial class FReaders : Form
    {
        public FReaders()
        {
            InitializeComponent();
        }

        private void rEADERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rEADERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void FReaders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.READERS' table. You can move, or remove it, as needed.
            this.rEADERSTableAdapter.Fill(this.libraryDataSet.READERS);

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Lab_06_Library
{
    public partial class FIssued : Form
    {
        public FIssued()
        {
            InitializeComponent();
        }

        private void FIssued_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Readers_List' table. You can move, or remove it, as needed.
            this.readers_ListTableAdapter.Fill(this.libraryDataSet.Readers_List);
            // TODO: This line of code loads data into the 'libraryDataSet.EXEMPLAR' table. You can move, or remove it, as needed.
            this.eXEMPLARTableAdapter.Fill(this.libraryDataSet.EXEMPLAR);
            // TODO: This line of code loads data into the 'libraryDataSet.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.libraryDataSet.BOOKS);
            this.eXEMPLARTableAdapter.FillBy2(this.libraryDataSet.EXEMPLAR, comboBox1.SelectedValue.ToString());
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(14);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.eXEMPLARTableAdapter.FillBy2(this.libraryDataSet.EXEMPLAR, comboBox1.SelectedValue.ToString());
        }

        private void FIssued_Shown(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(14);
            this.eXEMPLARTableAdapter.FillBy2(this.libraryDataSet.EXEMPLAR, comboBox1.SelectedValue.ToString());
        }

        private void FIssued_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                using (var conn = new SqlConnection(Properties.Settings.Default.libraryConnectionString))
                using (var cmd = new SqlCommand("NEW_INOUT", conn) { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.AddWithValue("@ID_EXEMPLAR", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@READER_ID", comboBox3.SelectedValue);
                    cmd.Parameters.AddWithValue("@DATA_IN", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@DATA_OUT", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@EXIST", "0");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                };
            }

        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;

namespace DB_Lab_06_Library
{
    public partial class FBooks : Form
    {
        public FBooks()
        {
            InitializeComponent();
        }

        private void FBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.exemplars' table. You can move, or remove it, as needed.
            this.exemplarsTableAdapter.Fill(this.libraryDataSet.exemplars);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FNewBook f = new FNewBook();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                this.exemplarsTableAdapter.Fill(this.libraryDataSet.exemplars);
            f.Dispose();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FIssued f = new FIssued();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                this.exemplarsTableAdapter.Fill(this.libraryDataSet.exemplars);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int pos = this.exemplarsBindingSource.Position;
            DataRowView currentRow = (DataRowView)this.exemplarsBindingSource.Current;
            string ISBN = currentRow["ISBN"].ToString();
            FNewBook f = new FNewBook(ISBN);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                this.exemplarsTableAdapter.Fill(this.libraryDataSet.exemplars);
                this.exemplarsBindingSource.Position = pos;
            }
            f.Dispose();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FReturn f = new FReturn();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                this.exemplarsTableAdapter.Fill(this.libraryDataSet.exemplars);
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB_Lab_06_Library
{
    public partial class FNewBook : Form
    {
        private string ISBNBook = null;

        public FNewBook()
        {
            InitializeComponent();
            this.Text = "Новое поступление";
        }

        public FNewBook(string ISBNBook)
        {
            InitializeComponent();
            this.Text = "Изменить книгу";
            this.ISBNBook = ISBNBook;
        }

        private void FNewBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                using (var conn = new SqlConnection(Properties.Settings.Default.libraryConnectionString))
                using (var cmd = new SqlCommand("NEW_BOOKS", conn) { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.AddWithValue("@ISBN", textBox1.Text);
                    cmd.Parameters.AddWithValue("@TITL", textBox2.Text);
                    cmd.Parameters.AddWithValue("@AUTOR", textBox3.Text);
                    cmd.Parameters.AddWithValue("@COAUTOR", Convert.IsDBNull(textBox4.Text) ? Convert.DBNull : textBox4.Text);
                    cmd.Parameters.AddWithValue("@YEARIZD", textBox5.Text);
                    cmd.Parameters.AddWithValue("@PUBLICH", textBox6.Text);
                    cmd.Parameters.AddWithValue("@PAGES", textBox7.Text);

                    if (ISBNBook == null) cmd.Parameters.AddWithValue("@NUM_EXEMPL", textBox8.Text);
                    else cmd.CommandText = "UPDATE_BOOKS";

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                };
            }
        }

        private void FNewBook_Load(object sender, EventArgs e)
        {
            if (ISBNBook == null) return;

            textBox1.Enabled = false;

            string cmdStr = "SELECT ISBN, TITLE, AUTOR, COAUTOR, YEAR_PUBL, PUBLICH, PAGES FROM BOOKS WHERE ISBN = @BOOK_ISBN";
            using (var conn = new SqlConnection(Properties.Settings.Default.libraryConnectionString))
            using (var cmd = new SqlCommand(cmdStr, conn))
            {
                cmd.Parameters.AddWithValue("@BOOK_ISBN", ISBNBook);
             
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                textBox1.Text = reader.GetString(0);
                textBox2.Text = reader.GetString(1);
                textBox3.Text = reader.GetString(2);
                textBox4.Text = reader.GetString(3);
                textBox5.Text = reader.GetInt16(4).ToString();
                textBox6.Text = reader.GetString(5);
                textBox7.Text = reader.GetInt16(6).ToString();

                label8.Visible = false;
                textBox8.Visible = false;

                reader.Close();
                conn.Close();
            };
        }
    }
}

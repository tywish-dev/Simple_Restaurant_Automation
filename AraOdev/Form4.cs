using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AraOdev
{
    public partial class Form4 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=AraOdev;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        string insert = "Insert into Customer (username, password) Values(@username, @password)";
                        cmd = new SqlCommand(insert, conn);
                        cmd.Parameters.AddWithValue("@username", textBox1.Text);
                        cmd.Parameters.AddWithValue("@password", textBox2.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Başarıyla Kayıt Oldunuz.");

                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Bir hata oluştu! " + error.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Şifreler Aynı Değil!");
            }
        }
    }
}

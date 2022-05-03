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
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=AraOdev;Integrated Security=True");
            conn.Open();
            
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Blue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = DefaultForeColor;
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
           
            cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "Select * From Customer where username='"+ username +"' AND password='"+password+"'";
            dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                if (username == "admin123" && password == "admin123")
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre!");
                dr.Close();
            }
        }
    }
}
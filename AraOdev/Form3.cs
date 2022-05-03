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
    public partial class Form3 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form3()
        {
            InitializeComponent();
        }
        public void getBurgers()
        {
            listView1.Items.Clear();
            string getBurgers = "Select foodName, price From Menu where category='Burger'";
            conn.Open();
            cmd = new SqlCommand(getBurgers,conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem listViewItem = new ListViewItem(dr["foodName"].ToString());
                listViewItem.SubItems.Add(dr["price"].ToString());
                listView1.Items.Add(listViewItem);
            }
            conn.Close();
        }
        public void getFries()
        {
            listView2.Items.Clear();
            string getFries = "Select foodName, price From Menu where category='Patates'";
            conn.Open();
            cmd = new SqlCommand(getFries, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem listViewItem = new ListViewItem(dr["foodName"].ToString());
                listViewItem.SubItems.Add(dr["price"].ToString());
                listView2.Items.Add(listViewItem);
            }
            conn.Close();
        }
        public void getDogs()
        {
            listView3.Items.Clear();
            string getDogs = "Select foodName, price From Menu where category='Sosisli'";
            conn.Open();
            cmd = new SqlCommand(getDogs, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem listViewItem = new ListViewItem(dr["foodName"].ToString());
                listViewItem.SubItems.Add(dr["price"].ToString());
                listView3.Items.Add(listViewItem);
            }
            conn.Close();
        }
        public void getSandwiches()
        {
            listView4.Items.Clear();
            string getSandwiches = "Select foodName, price From Menu where category='Sandviç'";
            conn.Open();
            cmd = new SqlCommand(getSandwiches, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem listViewItem = new ListViewItem(dr["foodName"].ToString());
                listViewItem.SubItems.Add(dr["price"].ToString());
                listView4.Items.Add(listViewItem);
            }
            conn.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=AraOdev;Integrated Security=True");

            getBurgers();
            getDogs();
            getFries();
            getSandwiches();
        }

        public int price = 0;
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            string fName = listView1.FocusedItem.Text;
            
            conn.Open();
            string getPrice = "Select price from Menu where foodName='" + fName + "' and category='Burger'";
            cmd = new SqlCommand(getPrice,conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                this.price += Convert.ToInt16(dr["price"].ToString());
            }

            listBox1.Items.Add(fName);
            label5.Text = "Toplam : " + this.price + " ₺";

            conn.Close();
        }

        private void listView2_ItemActivate(object sender, EventArgs e)
        {
            string fName = listView2.FocusedItem.Text;

            conn.Open();
            string getPrice = "Select price from Menu where foodName='" + fName + "' and category='Patates'";
            cmd = new SqlCommand(getPrice, conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                this.price += Convert.ToInt16(dr["price"].ToString());
            }

            listBox1.Items.Add(fName);
            label5.Text = "Toplam : " + this.price + " ₺";

            conn.Close();
        }

        private void listView3_ItemActivate(object sender, EventArgs e)
        {
            string fName = listView3.FocusedItem.Text;

            conn.Open();
            string getPrice = "Select price from Menu where foodName='" + fName + "' and category='Sosisli'";
            cmd = new SqlCommand(getPrice, conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                this.price += Convert.ToInt16(dr["price"].ToString());
            }

            listBox1.Items.Add(fName);
            label5.Text = "Toplam : " + this.price + " ₺";

            conn.Close();
        }

        private void listView4_ItemActivate(object sender, EventArgs e)
        {
            string fName = listView4.FocusedItem.Text;

            conn.Open();
            string getPrice = "Select price from Menu where foodName='" + fName + "' and category='Sandviç'";
            cmd = new SqlCommand(getPrice, conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                this.price += Convert.ToInt16(dr["price"].ToString());
            }

            listBox1.Items.Add(fName);
            label5.Text = "Toplam : " + this.price + " ₺";

            conn.Close();
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string fName = listBox1.Text;
                int minusPrice = 0;

                conn.Open();
                string getPrice = "Select price from Menu where foodName='" + fName + "'";
                cmd = new SqlCommand(getPrice, conn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    minusPrice = Convert.ToInt16(dr["price"].ToString());
                }

                listBox1.Items.Remove(fName);
                this.price -= minusPrice;
                label5.Text = "Toplam : " + this.price + " ₺";

                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz Başarıyla Alındı.");
            Environment.Exit(0);
        }
    }
}
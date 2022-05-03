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
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=AraOdev;Integrated Security=True");
        }

        private void menuInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string insert = "Insert into Menu (foodName, price, category) Values(@foodName, @price, @category)";
                    cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@foodName", menuFoodName.Text);
                    cmd.Parameters.AddWithValue("@price", menuPrice.Text);
                    cmd.Parameters.AddWithValue("@category", menuCategory.Text);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Bir hata oluştu! " + error.Message);
                throw;
            }
        }
        public void getMenu()
        {
            conn.Open();
            string getMenu = "Select id, foodName as 'Yemek Adı', price as 'Fiyat', category as 'Kategori' from Menu";

            cmd = new SqlCommand(getMenu, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            menuGridView.DataSource = dt;

            conn.Close();
        }
        private void menuList_Click(object sender, EventArgs e)
        {
            getMenu();
        }
        int j = 0;
        private void menuUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            string update = "Update Menu Set foodName=@foodName, price=@price, category=@category Where id=@id";
            cmd = new SqlCommand(update, conn);

            cmd.Parameters.AddWithValue("@foodName", menuFoodName.Text);
            cmd.Parameters.AddWithValue("@price", menuPrice.Text);
            cmd.Parameters.AddWithValue("@category", menuCategory.Text);
            cmd.Parameters.AddWithValue("@id", menuGridView.Rows[j].Cells[0].Value);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Başarıyla Güncellendi.");

            conn.Close();

            getMenu();
        }
        private void menuGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            j = e.RowIndex;
            menuFoodName.Text = menuGridView.Rows[j].Cells[1].Value.ToString();
            menuPrice.Text = menuGridView.Rows[j].Cells[2].Value.ToString();
            menuCategory.Text = menuGridView.Rows[j].Cells[3].Value.ToString();
        }
        public void deleteMenu(int id)
        {
            conn.Open();
            string delete = "Delete from Menu where id=@id";

            cmd = new SqlCommand(delete, conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        private void menuDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in menuGridView.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                deleteMenu(id);
                getMenu();
            }
        }
        private void customerInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string insert = "Insert into Customer (username, password) Values(@username, @password)";
                    cmd = new SqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("@username", customerUsername.Text);
                    cmd.Parameters.AddWithValue("@password", customerPassword.Text);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Bir hata oluştu! " + error.Message);
                throw;
            }
        }
        public void getCustomer()
        {
            conn.Open();
            string getCustomer = "Select id, username as 'Kullancı Adı', password as 'Şifre' from Customer";

            cmd = new SqlCommand(getCustomer, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            customerGridView.DataSource = dt;

            conn.Close();
        }
        private void customerList_Click(object sender, EventArgs e)
        {
            getCustomer();
        }
        int i = 0;
        private void customerUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            string update = "Update Customer Set username=@username, password=@password Where id=@id";
            cmd = new SqlCommand(update, conn);

            cmd.Parameters.AddWithValue("@username", customerUsername.Text);
            cmd.Parameters.AddWithValue("@password", customerPassword.Text);
            cmd.Parameters.AddWithValue("@id", customerGridView.Rows[i].Cells[0].Value);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Başarıyla Güncellendi.");

            conn.Close();

            getCustomer();
        }
        public void deleteCustomer(int id)
        {
            conn.Open();
            string delete = "Delete from Customer where id=@id";

            cmd = new SqlCommand(delete, conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        private void customerDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in customerGridView.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                deleteCustomer(id);
                getCustomer();
            }
        }
        private void customerGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            customerUsername.Text = customerGridView.Rows[i].Cells[1].Value.ToString();
            customerPassword.Text = customerGridView.Rows[i].Cells[2].Value.ToString();
        }
    }
}

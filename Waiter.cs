using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant_rdbms
{
    public partial class Waiter : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=LINDANIELLE04\\SQLEXPRESS;Initial Catalog=RDMS;Integrated Security=True;Encrypt=False");
        public Waiter()
        {
            InitializeComponent();
        }

        private void Waiter_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=LINDANIELLE04\\SQLEXPRESS;Initial Catalog=RDMS;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("Select * from Stafftab", Con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);


            DataTable table = new DataTable();
            da.Fill(table);

            dgvWaiter.DataSource = table;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cnn = new SqlCommand("insert into Stafftab(Name,Age) values(@Name, @Age)", Con);
            cnn.Parameters.AddWithValue("@Name", (txtFName.Text));
            cnn.Parameters.AddWithValue("@Age", (txtAge.Text));
            Convert.ToInt32(txtAge.Text);

            cnn.ExecuteNonQuery();


            Con.Close();

            MessageBox.Show("Data Added Successfully");



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cnn = new SqlCommand("Update Stafftab Set Name=@Name, Age=@Age, ", Con);

            cnn.Parameters.AddWithValue("@Name", (txtFName.Text));
            cnn.Parameters.AddWithValue("@Age", (txtAge.Text));

            cnn.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Data Updated Successfully");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            SqlCommand cnn = new SqlCommand("Delete Stafftab where Name=@Name ", Con);
            Con.Open();
            cnn.Parameters.AddWithValue("@Name", (txtFName.Text));
            cnn.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Data Deleted ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void dgvWaiter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

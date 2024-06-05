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
    public partial class Payment : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=LINDANIELLE04\\SQLEXPRESS;Initial Catalog=RDMS;Integrated Security=True;Encrypt=False");

        public Payment()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=LINDANIELLE04\\SQLEXPRESS;Initial Catalog=RDMS;Integrated Security=True;Encrypt=False");

            SqlCommand cnn = new SqlCommand("Select * from paymenttab", Con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);


            DataTable table = new DataTable();
            da.Fill(table);

            //dgvpayment.DataSource = table;

        }

        private void txtFPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cnn = new SqlCommand("insert into Paymenttab values(@name, @quantity, @paymentmethod, @total)", Con);

            cnn.Parameters.AddWithValue("@name", (txtFName.Text));
            cnn.Parameters.AddWithValue("@quantity", int.Parse(txtQ.Text));
            cnn.Parameters.AddWithValue("@paymentmethod", (txtFPayme.Text));
            cnn.Parameters.AddWithValue("@total", int.Parse(textTot.Text));

            cnn.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Data Added Successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cnn = new SqlCommand("Update paymenttab Set name=@name, food=@food,food1=@food1, paymentmethod=@paymentmethod where total=@total ", Con);

            cnn.Parameters.AddWithValue("@name", (txtFName.Text));

            cnn.Parameters.AddWithValue("@food", (txtFood.Text));

            cnn.Parameters.AddWithValue("@food1", (txtQ.Text));

            cnn.Parameters.AddWithValue("@paymentmethod", (txtFPayme.Text));

            cnn.Parameters.AddWithValue("@total", int.Parse(textTot.Text));

            cnn.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Data Updated Successfully");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cnn = new SqlCommand("Delete paymenttab where name=@name ", Con);

            cnn.Parameters.AddWithValue("@name", (txtFName.Text));
            cnn.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Data Deleted ");

        }

        private void dgvpayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }
    }
}

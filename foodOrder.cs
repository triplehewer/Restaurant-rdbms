using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Restaurant_rdbms
{
    public partial class foodOrder : Form
    {
        public foodOrder()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=LINDANIELLE04\\SQLEXPRESS;Initial Catalog=RDMS;Integrated Security=True;Encrypt=False");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void foodOrder_Load(object sender, EventArgs e)
        {
            SqlCommand cnn = new SqlCommand("Select * from Food", Con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);


            DataTable table = new DataTable();
            da.Fill(table);

            dgvFood.DataSource = table;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cnn = new SqlCommand("insert into Food values(@name, @food, @food1, @Fprice)", Con);
            
            cnn.Parameters.AddWithValue("@name", (txtFName.Text));
            cnn.Parameters.AddWithValue("@food", (txtFood.Text));
            cnn.Parameters.AddWithValue("@food1", (txtFood1.Text));
             cnn.Parameters.AddWithValue("@Fprice", int.Parse(txtFPrice.Text));
            cnn.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Data Added Successfully");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cnn = new SqlCommand("Update Food Set name=@name, food=@food,food1=@food1, Fprice=@Fprice ", Con);
           
            cnn.Parameters.AddWithValue("@name", (txtFName.Text));
            cnn.Parameters.AddWithValue("@food", (txtFood.Text));
            cnn.Parameters.AddWithValue("@food1", (txtFood1.Text));
            cnn.Parameters.AddWithValue("@Fprice", int.Parse(txtFPrice.Text));
            cnn.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Data Updated Successfully");


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cnn = new SqlCommand("Delete Food where name=@name ", Con);

            cnn.Parameters.AddWithValue("@name", (txtFName.Text));
            cnn.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Data Deleted ");

        }

        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtFName.Text = dgvFood.SelectedRows[0].Cells[1].Value.ToString();
            txtFood.Text = dgvFood.SelectedRows[0].Cells[2].Value.ToString();
            txtFood1.Text = dgvFood.SelectedRows[0].Cells[3].Value.ToString();
            txtFPrice.Text = dgvFood.SelectedRows[0].Cells[4].Value.ToString();
            Convert.ToInt32(dgvFood.SelectedRows[0].Cells[0].Value.ToString());
        }
    }
}

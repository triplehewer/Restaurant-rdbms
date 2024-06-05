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
    public partial class commandview : Form
    {
        public commandview()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=LINDANIELLE04\\SQLEXPRESS;Initial Catalog=RDMS;Integrated Security=True;Encrypt=False");
        
        private void dgvCommand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void commandview_Load(object sender, EventArgs e)
        {

            SqlCommand cnn = new SqlCommand("Select * from Paymenttab", Con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);


            DataTable table = new DataTable();
            da.Fill(table);

            dgvCommand.DataSource = table;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

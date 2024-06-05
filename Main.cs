using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_rdbms
{
    public partial class Main : Form
    {
        private string sql = @"Data Source=LINDANIELLE04\SQLEXPRESS;Initial Catalog=RDMS;Integrated Security=True;Trust Server Certificate=True";
        public Main()
        {
            InitializeComponent();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            Menu fd = new Menu();
            fd.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Payment paymentInfo = new Payment();
            paymentInfo.Show();
            

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Waiter selform = new Waiter();
            selform.Show();
            this.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                          
        }
    }
}

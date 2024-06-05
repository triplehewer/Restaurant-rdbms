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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=LINDANIELLE04\\SQLEXPRESS;Initial Catalog=RDMS;Integrated Security=True;Encrypt=False");

        private void addWaittresseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Waiter w = new Waiter();
            w.Show();
        }

        private void commandViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandview cv = new commandview();
            cv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }
    }
}

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
using System.Diagnostics.Eventing.Reader;

namespace Restaurant_rdbms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string sql = @"Data Source=LINDANIELLE04\\SQLEXPRESS;Initial Catalog=""RDMS"";Integrated Security=True;Encrypt=False";
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                MessageBox.Show("enter");
            }
            

            else if(textBoxUsername.Text =="user" && textBoxPassword.Text == "password")
            {
                MessageBox.Show("sucessfull");
            }
            AdminDashboard adb = new AdminDashboard();
            adb.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

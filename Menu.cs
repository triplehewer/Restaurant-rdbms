﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_rdbms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Payment py = new Payment();
            py.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Payment py = new Payment();
            py.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Payment py = new Payment();
            py.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Payment py = new Payment();
            py.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Payment py = new Payment();
            py.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Payment py = new Payment();
            py.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Payment py = new Payment();
            py.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Payment py = new Payment();
            py.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Waiter waiter = new Waiter();
            waiter.Show();
        }
    }
}

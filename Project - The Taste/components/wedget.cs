﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project___The_Taste.components
{
    public partial class wedget : UserControl
    {
        public wedget()
        {
            InitializeComponent();
        }
        public static int total = 0;
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
            total += Convert.ToInt32(label1.Text);
            Loading.form.guna2DataGridView1.Rows.Add(Ch.Text, 1, label1.Text+"$");
            Loading.form.label3.Text=total.ToString();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

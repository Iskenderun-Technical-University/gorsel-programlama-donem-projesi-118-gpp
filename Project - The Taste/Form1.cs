using Project___The_Taste.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project___The_Taste
{
    public partial class Form1 : Form
    {
        bool sidebarExpand=true;
        bool mealsCollapse=true;
        bool drinksCollapse = true;
        wedget wedgett = new wedget();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MealsTimer.Start();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sidebartimer_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false; 
                    Sidebartimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    Sidebartimer.Stop();
                }
            }

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Sidebartimer.Start();
        }

        private void MealsContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MealsTimer_Tick(object sender, EventArgs e)
        {
            if(mealsCollapse)
            {
                MealsContainer.Height += 10;
                if(MealsContainer.Height == MealsContainer.MaximumSize.Height)
                {
                    mealsCollapse = false;
                    MealsTimer.Stop();
                }
            }
            else
            {
                MealsContainer.Height -= 10;
                if(MealsContainer.Height == MealsContainer.MinimumSize.Height)
                {
                    mealsCollapse = true;
                    MealsTimer.Stop();
                }
            }
        }

        private void DrinksTimer_Tick(object sender, EventArgs e)
        {
            if (drinksCollapse)
            {
                DrinksContainer.Height += 10;
                if (DrinksContainer.Height == DrinksContainer.MaximumSize.Height)
                {
                    drinksCollapse = false;
                    DrinksTimer.Stop();
                }
            }
            else
            {
                DrinksContainer.Height -= 10;
                if (DrinksContainer.Height == DrinksContainer.MinimumSize.Height)
                {
                    drinksCollapse = true;
                    DrinksTimer.Stop();
                }
            }
        }

        private void DrinksButton_Click(object sender, EventArgs e)
        {
            DrinksTimer.Start();
        }

        private void DrinksContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wedget2_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            //chackenPanel.Visible=true;
            wedget1.guna2PictureBox1.Image = wedget1.List1.Images[0];
            wedget2.guna2PictureBox1.Image = wedget2.List1.Images[0];
            wedget3.guna2PictureBox1.Image = wedget3.List1.Images[0];
            wedget4.guna2PictureBox1.Image = wedget4.List1.Images[0];
            wedget5.guna2PictureBox1.Image = wedget5.List1.Images[0];
            wedget6.guna2PictureBox1.Image = wedget6.List1.Images[0];
            wedget7.guna2PictureBox1.Image = wedget7.List1.Images[0];
            wedget8.guna2PictureBox1.Image = wedget8.List1.Images[0];
            wedget9.guna2PictureBox1.Image = wedget9.List1.Images[0];
            wedget10.guna2PictureBox1.Image = wedget10.List1.Images[0];
        }

        private void wedget3_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            wedget1.guna2PictureBox1.Image = wedget1.List1.Images[1];
            wedget2.guna2PictureBox1.Image = wedget2.List1.Images[1];
            wedget3.guna2PictureBox1.Image = wedget3.List1.Images[1];
            wedget4.guna2PictureBox1.Image = wedget4.List1.Images[1];
            wedget5.guna2PictureBox1.Image = wedget5.List1.Images[1];
            wedget6.guna2PictureBox1.Image = wedget6.List1.Images[1];
            wedget7.guna2PictureBox1.Image = wedget7.List1.Images[1];
            wedget8.guna2PictureBox1.Image = wedget8.List1.Images[1];
            wedget9.guna2PictureBox1.Image = wedget9.List1.Images[1];
            wedget10.guna2PictureBox1.Image = wedget10.List1.Images[1];
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            wedget1.guna2PictureBox1.Image = wedget1.List1.Images[2];
            wedget2.guna2PictureBox1.Image = wedget2.List1.Images[2];
            wedget3.guna2PictureBox1.Image = wedget3.List1.Images[2];
            wedget4.guna2PictureBox1.Image = wedget4.List1.Images[2];
            wedget5.guna2PictureBox1.Image = wedget5.List1.Images[2];
            wedget6.guna2PictureBox1.Image = wedget6.List1.Images[2];
            wedget7.guna2PictureBox1.Image = wedget7.List1.Images[2];
            wedget8.guna2PictureBox1.Image = wedget8.List1.Images[2];
            wedget9.guna2PictureBox1.Image = wedget9.List1.Images[2];
            wedget10.guna2PictureBox1.Image = wedget10.List1.Images[2];
        }
    }
}

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
        bool sidebarExpand;
        bool mealsCollapse;
        bool drinksCollapse;
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
    }
}

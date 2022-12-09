using Project___The_Taste.components;
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

namespace Project___The_Taste
{
    public partial class Form1 : Form
    {
        bool sidebarExpand=true;
        bool mealsCollapse=true;
        bool drinksCollapse = true;
        wedget wedgett = new wedget();

        static string[] Chicken={ "Chicken Parmesan\nPasta", "Creamy Chicken\nStroganoff", "Broccoli Cheese\nQuesadilla with Chipotle\nSauce",
        "Chipotle Chicken\nTaquitos", "Air Fryer Chicken\nBreast","Air Fryer Parmesan\nCrusted Chicken with\nMayo","Blackened Chicken\nAlfredo",
        "Butter Chicken","Chicken and Avocado\nQuesadillas","Chicken Fajitas","Ayam geprek","ayam taliwang bakar\nteflon yscooking",
        "Chicken Afritada","Arroz con Pollo","saftiges backhendl","Barbecued Chicken"};
        static string[] Meat={ };
        static string[] fish= { "Masala Fried Pomfret", "Thai Fish Curry", "Gorton's Seafood", "Kerala Fish Fry", "Thai Steamed Fish with\nLime and Garlic", "Indian Omelet Masala\nEgg Curry",
        "Sticky Buttery Honey\nGarlic Shrimp","Baked Salmon with Garlic\nButter","Malabar Style Chemmeen\nCurry","Indian Style Fish and\nChips"};
        static string[] Hamburger = { };
        static string[] drinksCold = { };
        static string[] drinksHot = { };
        static string[] APPETIZER = { };
        static string[] DESSERTS = { };


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
            wedget2.guna2PictureBox1.Image = wedget2.List1.Images[12];
            wedget3.guna2PictureBox1.Image = wedget3.List1.Images[13];
            wedget4.guna2PictureBox1.Image = wedget4.List1.Images[14];
            wedget5.guna2PictureBox1.Image = wedget5.List1.Images[15];
            wedget6.guna2PictureBox1.Image = wedget6.List1.Images[16];
            wedget7.guna2PictureBox1.Image = wedget7.List1.Images[17];
            wedget8.guna2PictureBox1.Image = wedget8.List1.Images[18];
            wedget9.guna2PictureBox1.Image = wedget9.List1.Images[19];
            wedget10.guna2PictureBox1.Image = wedget10.List1.Images[20];
            wedget11.guna2PictureBox1.Image = wedget11.List1.Images[32];
            wedget12.guna2PictureBox1.Image = wedget12.List1.Images[33];
            wedget13.guna2PictureBox1.Image = wedget13.List1.Images[34];
            wedget14.guna2PictureBox1.Image = wedget14.List1.Images[35];
            wedget15.guna2PictureBox1.Image = wedget15.List1.Images[36];
            wedget16.guna2PictureBox1.Image = wedget16.List1.Images[37];
            wedget11.Visible = true;
            wedget12.Visible = true;
            wedget13.Visible = true;
            wedget14.Visible = true;
            wedget15.Visible = true;
            wedget16.Visible = true;

            wedget1.Ch.Text = Chicken[0];
            wedget2.Ch.Text = Chicken[1];
            wedget3.Ch.Text = Chicken[2];
            wedget4.Ch.Text = Chicken[3];
            wedget5.Ch.Text = Chicken[4];
            wedget6.Ch.Text = Chicken[5];
            wedget7.Ch.Text = Chicken[6];
            wedget8.Ch.Text = Chicken[7];
            wedget9.Ch.Text = Chicken[8];
            wedget10.Ch.Text = Chicken[9];
            wedget11.Ch.Text = Chicken[10];
            wedget12.Ch.Text = Chicken[11];
            wedget13.Ch.Text = Chicken[12];
            wedget14.Ch.Text = Chicken[13];
            wedget15.Ch.Text = Chicken[14];
            wedget16.Ch.Text = Chicken[15];

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
            wedget11.Visible= false;
            wedget12.Visible = false;
            wedget13.Visible = false;
            wedget14.Visible = false;
            wedget15.Visible = false;
            wedget16.Visible = false;


        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            wedget1.guna2PictureBox1.Image = wedget1.List1.Images[2];
            wedget2.guna2PictureBox1.Image = wedget2.List1.Images[3];
            wedget3.guna2PictureBox1.Image = wedget3.List1.Images[4];
            wedget4.guna2PictureBox1.Image = wedget4.List1.Images[5];
            wedget5.guna2PictureBox1.Image = wedget5.List1.Images[6];
            wedget6.guna2PictureBox1.Image = wedget6.List1.Images[7];
            wedget7.guna2PictureBox1.Image = wedget7.List1.Images[8];
            wedget8.guna2PictureBox1.Image = wedget8.List1.Images[9];
            wedget9.guna2PictureBox1.Image = wedget9.List1.Images[10];
            wedget10.guna2PictureBox1.Image = wedget10.List1.Images[11];
            wedget10.guna2PictureBox1.Image = wedget10.List1.Images[11];

            wedget11.Visible = true;
            wedget12.Visible = false;
            wedget13.Visible = false;
            wedget14.Visible = false;
            wedget15.Visible = false;
            wedget16.Visible = false;

            wedget1.Ch.Text = fish[0];
            wedget2.Ch.Text = fish[1];
            wedget3.Ch.Text = fish[2];
            wedget4.Ch.Text = fish[3];
            wedget5.Ch.Text = fish[4];
            wedget6.Ch.Text = fish[5];
            wedget7.Ch.Text = fish[6];
            wedget8.Ch.Text = fish[7];
            wedget9.Ch.Text = fish[8];
            wedget10.Ch.Text = fish[9];

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            wedget1.guna2PictureBox1.Image = wedget1.List1.Images[21];
            wedget2.guna2PictureBox1.Image = wedget2.List1.Images[22];
            wedget3.guna2PictureBox1.Image = wedget3.List1.Images[23];
            wedget4.guna2PictureBox1.Image = wedget4.List1.Images[24];
            wedget5.guna2PictureBox1.Image = wedget5.List1.Images[25];
            wedget6.guna2PictureBox1.Image = wedget6.List1.Images[26];
            wedget7.guna2PictureBox1.Image = wedget7.List1.Images[27];
            wedget8.guna2PictureBox1.Image = wedget8.List1.Images[28];
            wedget9.guna2PictureBox1.Image = wedget9.List1.Images[29];
            wedget10.guna2PictureBox1.Image = wedget10.List1.Images[30];
            
            wedget11.Visible = false;
            wedget12.Visible = false;
            wedget13.Visible = false;
            wedget14.Visible = false;
            wedget15.Visible = false;
            wedget16.Visible = false;


        }
    }
}

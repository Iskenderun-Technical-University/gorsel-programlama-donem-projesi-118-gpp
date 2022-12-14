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
using System.Windows.Forms.VisualStyles;
using static System.Collections.Specialized.BitVector32;

namespace Project___The_Taste
{
    public partial class Form1 : Form
    {
        bool sidebarExpand = true;
        bool mealsCollapse = true;
        bool drinksCollapse = true;
        wedget wedgett = new wedget();

        //the chicken menu names
        static string[] Chicken={ "Chicken Parmesan\nPasta", "Creamy Chicken\nStroganoff", "Broccoli Cheese\nQuesadilla with Chipotle\nSauce",
        "Chipotle Chicken\nTaquitos", "Air Fryer Chicken\nBreast","Air Fryer Parmesan\nCrusted Chicken with\nMayo","Blackened Chicken\nAlfredo",
        "Butter Chicken","Chicken and Avocado\nQuesadillas","Chicken Fajitas","Ayam geprek","ayam taliwang bakar\nteflon yscooking",
        "Chicken Afritada","Arroz con Pollo","saftiges backhendl","Barbecued Chicken"};

        //the meat menu names
        static string[] Meat = { "Beef Kaldereta", "Espetada", "Leberkäse", "Meat Pie", "Meatball Sub Recipe", "Paella Valenciana", "Pit Beef", "Şiş Tavuk", "Steak Marinade", "Sweet Sour Meat Balls"};

        //the fish menu names
        static string[] fish= { "Masala Fried Pomfret", "Thai Fish Curry", "Gorton's Seafood", "Kerala Fish Fry", "Thai Steamed Fish with\nLime and Garlic", "Indian Omelet Masala\nEgg Curry",
        "Sticky Buttery Honey\nGarlic Shrimp","Baked Salmon with Garlic\nButter","Malabar Style Chemmeen\nCurry","Indian Style Fish and\nChips"};
        
        //the hamburger menu names
        static string[] Hamburger = { "big burger", "cheese burger", "chicken burger", "classic burger", "crispy chicken burger", "double burge", "meat burger", "mushroom burger", "smokehouse burger", "steak burger" };
       
        //the colddrıinks menu names
        static string[] drinksCold = { "Orange juice", "Sprite", "Coca cola", "Pepsi", "Chocolate Milkshake", "Coffee Milkshake","Fanta", "Strawberry juice",
        "Sparkling Mineral\nWater","Ayran","Water"};

        //the hotdrinks menu names
        static string[] drinksHot = { "Mint Tea", "Black Tea", "Hot Chocolate", "coffee", "Caramel Latte", "Homemade Mocha", "Hot Lemon", "Masala Chai" };
        
        //the appetizer menu names
        static string[] APPETIZER = { "Chicken Fingers", "Çiğ Köfte", "Dakos", "Gravlax", "Haydari Blog Hero", "Kabak Mücveri", "Pajeon", "Perkedel", "Petit Four", "Pisto", "Rabas" };
        
        //the desserts mrnu names
        static string[] DESSERTS = { "Apple Pie", "Chocolate Coffee\nTruffle", "classic lemon tart", "Chocolate Mousse", "Fudgy Chewy Brownies", "gulab jamun", "honey cheesecake",
        "Souffle","Tiramisu"};

        public static Form1 form = new Form1();

        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MealsTimer.Start();
        }

        private void Sidebartimer_Tick(object sender, EventArgs e)
        {
            //for expand of the sidebar (open and close)
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

        private void MealsTimer_Tick(object sender, EventArgs e)
        {
            //for showing the side section inside the main section (meals)

            if (mealsCollapse)
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
            //for showing the side section inside the main section (drinks)

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

        //the chicken menu
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            //for showing the chicken menu photos
            MenuPanel.Visible=true;
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

            wedget9.Visible = true;
            wedget10.Visible = true;
            wedget11.Visible = true;
            wedget12.Visible = true;
            wedget13.Visible = true;
            wedget14.Visible = true;
            wedget15.Visible = true;
            wedget16.Visible = true;

            //for showing the chicken menu meals names useing the previous statik

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

        //the meat menu
        private void guna2Button6_Click(object sender, EventArgs e)
        {

            //for showing the meat menu photos

            MenuPanel.Visible = true;

            wedget1.guna2PictureBox1.Image = wedget1.List1.Images[46];
            wedget2.guna2PictureBox1.Image = wedget2.List1.Images[47];
            wedget3.guna2PictureBox1.Image = wedget3.List1.Images[48];
            wedget4.guna2PictureBox1.Image = wedget4.List1.Images[49];
            wedget5.guna2PictureBox1.Image = wedget5.List1.Images[50];
            wedget6.guna2PictureBox1.Image = wedget6.List1.Images[51];
            wedget7.guna2PictureBox1.Image = wedget7.List1.Images[52];
            wedget8.guna2PictureBox1.Image = wedget8.List1.Images[53];
            wedget9.guna2PictureBox1.Image = wedget9.List1.Images[54];
            wedget10.guna2PictureBox1.Image = wedget10.List1.Images[55];

            wedget9.Visible = true;
            wedget10.Visible = true;
            wedget11.Visible= false;
            wedget12.Visible = false;
            wedget13.Visible = false;
            wedget14.Visible = false;
            wedget15.Visible = false;
            wedget16.Visible = false;

            //for showing the meat menu meals names useing the previous statik


            wedget1.Ch.Text = Meat[0];
            wedget2.Ch.Text = Meat[1];
            wedget3.Ch.Text = Meat[2];
            wedget4.Ch.Text = Meat[3];
            wedget5.Ch.Text = Meat[4];
            wedget6.Ch.Text = Meat[5];
            wedget7.Ch.Text = Meat[6];
            wedget8.Ch.Text = Meat[7];
            wedget9.Ch.Text = Meat[8];
            wedget10.Ch.Text = Meat[9];


        }

        //the desserts menu
        private void guna2Button7_Click(object sender, EventArgs e)
        {

            //for showing the desserts menu photos

            MenuPanel.Visible = true;

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

            wedget9.Visible = true;
            wedget10.Visible = true;
            wedget11.Visible = true;
            wedget12.Visible = false;
            wedget13.Visible = false;
            wedget14.Visible = false;
            wedget15.Visible = false;
            wedget16.Visible = false;

            //for showing the desserts menu meals names useing the previous statik


            wedget1.Ch.Text = DESSERTS[0];
            wedget2.Ch.Text = DESSERTS[1];
            wedget3.Ch.Text = DESSERTS[2];
            wedget4.Ch.Text = DESSERTS[3];
            wedget5.Ch.Text = DESSERTS[4];
            wedget6.Ch.Text = DESSERTS[5];
            wedget7.Ch.Text = DESSERTS[6];
            wedget8.Ch.Text = DESSERTS[7];
            wedget9.Ch.Text = DESSERTS[8];
            

        }

        

        //the cold drinks menu
        private void guna2Button11_Click(object sender, EventArgs e)
        {
            //for showing the cold drinks menu photos

            MenuPanel.Visible = true;

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

            wedget9.Visible = true;
            wedget10.Visible = true;
            wedget11.Visible = false;
            wedget12.Visible = false;
            wedget13.Visible = false;
            wedget14.Visible = false;
            wedget15.Visible = false;
            wedget16.Visible = false;

            //for showing the cold drinks menu names useing the previous statik

            wedget1.Ch.Text = drinksCold[0];
            wedget2.Ch.Text = drinksCold[1];
            wedget3.Ch.Text = drinksCold[2];
            wedget4.Ch.Text = drinksCold[3];
            wedget5.Ch.Text = drinksCold[4];
            wedget6.Ch.Text = drinksCold[5];
            wedget7.Ch.Text = drinksCold[6];
            wedget8.Ch.Text = drinksCold[7];
            wedget9.Ch.Text = drinksCold[8];
            wedget10.Ch.Text = drinksCold[9];


        }

        //the hot drinks menu

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            //for showing the hot drinks menu photos

            MenuPanel.Visible = true;

            wedget1.guna2PictureBox1.Image = wedget1.List1.Images[38];
            wedget2.guna2PictureBox1.Image = wedget2.List1.Images[39];
            wedget3.guna2PictureBox1.Image = wedget3.List1.Images[40];
            wedget4.guna2PictureBox1.Image = wedget4.List1.Images[41];
            wedget5.guna2PictureBox1.Image = wedget5.List1.Images[42];
            wedget6.guna2PictureBox1.Image = wedget6.List1.Images[43];
            wedget7.guna2PictureBox1.Image = wedget7.List1.Images[44];
            wedget8.guna2PictureBox1.Image = wedget8.List1.Images[45];

            wedget9.Visible = false;
            wedget10.Visible = false;
            wedget11.Visible = false;
            wedget12.Visible = false;
            wedget13.Visible = false;
            wedget14.Visible = false;
            wedget15.Visible = false;
            wedget16.Visible = false;

            //for showing the hot drinks menu names useing the previous statik

            wedget1.Ch.Text = drinksHot[0];
            wedget2.Ch.Text = drinksHot[1];
            wedget3.Ch.Text = drinksHot[2];
            wedget4.Ch.Text = drinksHot[3];
            wedget5.Ch.Text = drinksHot[4];
            wedget6.Ch.Text = drinksHot[5];
            wedget7.Ch.Text = drinksHot[6];
            wedget8.Ch.Text = drinksHot[7];
        }

        //the appetizer menu names
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //for showing the appetizer menu photos

            MenuPanel.Visible = true;

            wedget1.guna2PictureBox1.Image = wedget1.List1.Images[56];
            wedget2.guna2PictureBox1.Image = wedget2.List1.Images[57];
            wedget3.guna2PictureBox1.Image = wedget3.List1.Images[58];
            wedget4.guna2PictureBox1.Image = wedget4.List1.Images[59];
            wedget5.guna2PictureBox1.Image = wedget5.List1.Images[60];
            wedget6.guna2PictureBox1.Image = wedget6.List1.Images[61];
            wedget7.guna2PictureBox1.Image = wedget7.List1.Images[62];
            wedget8.guna2PictureBox1.Image = wedget8.List1.Images[63];
            wedget9.guna2PictureBox1.Image = wedget9.List1.Images[64];
            wedget10.guna2PictureBox1.Image = wedget10.List1.Images[65];
            wedget11.guna2PictureBox1.Image = wedget11.List1.Images[66];

            wedget9.Visible = true;
            wedget10.Visible = true;
            wedget11.Visible = true;
            wedget12.Visible = false;
            wedget13.Visible = false;
            wedget14.Visible = false;
            wedget15.Visible = false;
            wedget16.Visible = false;

            //for showing the appetizer menu names useing the previous statik

            wedget1.Ch.Text = APPETIZER[0];
            wedget2.Ch.Text = APPETIZER[1];
            wedget3.Ch.Text = APPETIZER[2];
            wedget4.Ch.Text = APPETIZER[3];
            wedget5.Ch.Text = APPETIZER[4];
            wedget6.Ch.Text = APPETIZER[5];
            wedget7.Ch.Text = APPETIZER[6];
            wedget8.Ch.Text = APPETIZER[7];
            wedget9.Ch.Text = APPETIZER[8];
            wedget10.Ch.Text = APPETIZER[9];
            wedget11.Ch.Text = APPETIZER[10];
        }

        //the Hamburger menu
        private void guna2Button8_Click(object sender, EventArgs e)
        {
            //for showing the Hamburger menu photos

            MenuPanel.Visible = true;

            wedget1.guna2PictureBox1.Image = wedget1.List1.Images[67];
            wedget2.guna2PictureBox1.Image = wedget2.List1.Images[68];
            wedget3.guna2PictureBox1.Image = wedget3.List1.Images[69];
            wedget4.guna2PictureBox1.Image = wedget4.List1.Images[70];
            wedget5.guna2PictureBox1.Image = wedget5.List1.Images[71];
            wedget6.guna2PictureBox1.Image = wedget6.List1.Images[72];
            wedget7.guna2PictureBox1.Image = wedget7.List1.Images[73];
            wedget8.guna2PictureBox1.Image = wedget8.List1.Images[74];
            wedget9.guna2PictureBox1.Image = wedget9.List1.Images[75];
            wedget10.guna2PictureBox1.Image = wedget10.List1.Images[76];

            wedget9.Visible = true;
            wedget10.Visible = true;
            wedget11.Visible = false;
            wedget12.Visible = false;
            wedget13.Visible = false;
            wedget14.Visible = false;
            wedget15.Visible = false;
            wedget16.Visible = false;

            //for showing the Hamburger menu meals names useing the previous statik

            wedget1.Ch.Text = Hamburger[0];
            wedget2.Ch.Text = Hamburger[1];
            wedget3.Ch.Text = Hamburger[2];
            wedget4.Ch.Text = Hamburger[3];
            wedget5.Ch.Text = Hamburger[4];
            wedget6.Ch.Text = Hamburger[5];
            wedget7.Ch.Text = Hamburger[6];
            wedget8.Ch.Text = Hamburger[7];
            wedget9.Ch.Text = Hamburger[8];
            wedget10.Ch.Text = Hamburger[9];


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //for adding the prices of the meals or delete it
            try
            {
                string price = "";
                string temp = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
                for (int i = 0; i < temp.Length - 1; i++)
                {
                    price += temp[i];
                }
                wedget.total = wedget.total - Convert.ToInt32(price);
                price = (Convert.ToInt32(label3.Text) - Convert.ToInt32(price)).ToString();
                label3.Text = price;
                guna2DataGridView1.Rows.RemoveAt(guna2DataGridView1.CurrentRow.Index);
            }
            catch {
             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //showing a thank message aftre order

            if (guna2DataGridView1.Rows.Count == 0) MessageBox.Show("Please Add Somthing To Order And Try Again!!");
            else
            {
                MessageBox.Show("Thanks For Your Order!!", "Happy To Serve You.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label3.Text = "0";
                guna2DataGridView1.Rows.Clear();
                wedget.total = 0;
            
            }
        }
        //the fish menu
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //for showing the fish menu photos

            MenuPanel.Visible = true;

            wedget1.guna2PictureBox1.Image = wedget1.List1.Images[77];
            wedget2.guna2PictureBox1.Image = wedget2.List1.Images[78];
            wedget3.guna2PictureBox1.Image = wedget3.List1.Images[79];
            wedget4.guna2PictureBox1.Image = wedget4.List1.Images[80];
            wedget5.guna2PictureBox1.Image = wedget5.List1.Images[81];
            wedget6.guna2PictureBox1.Image = wedget6.List1.Images[82];
            wedget7.guna2PictureBox1.Image = wedget7.List1.Images[83];
            wedget8.guna2PictureBox1.Image = wedget8.List1.Images[84];
            wedget9.guna2PictureBox1.Image = wedget9.List1.Images[85];

            wedget9.Visible = true;
            wedget10.Visible = false;
            wedget11.Visible = false;
            wedget12.Visible = false;
            wedget13.Visible = false;
            wedget14.Visible = false;
            wedget15.Visible = false;
            wedget16.Visible = false;

            //for showing the fish menu meals names useing the previous statik

            wedget1.Ch.Text = fish[0];
            wedget2.Ch.Text = fish[1];
            wedget3.Ch.Text = fish[2];
            wedget4.Ch.Text = fish[3];
            wedget5.Ch.Text = fish[4];
            wedget6.Ch.Text = fish[5];
            wedget7.Ch.Text = fish[6];
            wedget8.Ch.Text = fish[7];
            wedget9.Ch.Text = fish[8];
        }


        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

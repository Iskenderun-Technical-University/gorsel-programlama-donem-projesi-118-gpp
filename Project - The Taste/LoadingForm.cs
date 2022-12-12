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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }
        public static Form1 form = new Form1();

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                form.Show();
            }
            guna2ProgressBar1.Value += 5;
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

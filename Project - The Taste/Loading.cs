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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {

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
    }
}

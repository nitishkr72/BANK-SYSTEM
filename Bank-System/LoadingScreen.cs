using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;

            if (progressBar1.Value >= 99)
            {
                Form1 m = new Form1();
                this.Hide();
                m.Show();

                timer1.Enabled = false;
                progressBar1.Value -= 1;
            }
        }

        private void loading_Click(object sender, EventArgs e)
        {

        }
    }
}

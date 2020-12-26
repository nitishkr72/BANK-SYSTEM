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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateAccount account = new CreateAccount();
            account.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            viewAccount review = new viewAccount();
            review.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Withdraw newWithdraw = new Withdraw();
            newWithdraw.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deposit newDeposit = new deposit();
            newDeposit.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loan newloanApplication = new loan();
            newloanApplication.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            acc2acc newTransfer = new acc2acc();
            newTransfer.Show();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

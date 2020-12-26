using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Bank_System
{
    public partial class viewAccount : Form
    {
        public viewAccount()
        {
            InitializeComponent();
        }
        SqliteConnection con = new SqliteConnection("Datasource = C:\\Users\\nitis\\Desktop\\Bank-System\\Bank-System\\CSB_BANK.db");

        private void viewAccount_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accID, custID;
            accID = textBox1.Text;
            custID = textBox2.Text;
            string query1 = "select * from customer where cust_id = '"+custID+"'";
            string query2 = "select * from account where account_id = '"+accID+"'";
            try
            {
                con.Open();
                SqliteCommand cmd1 = new SqliteCommand(query1, con);
                SqliteCommand cmd2 = new SqliteCommand(query2, con);
                cmd1.Connection = con;
                cmd2.Connection = con;

                SqliteDataReader rd1;
                SqliteDataReader rd2;

                rd1 = cmd1.ExecuteReader();
                rd2 = cmd2.ExecuteReader();

                if (rd1.Read() && rd2.Read())
                {
                    label20.Text = rd1[0].ToString();
                    label19.Text = rd1[1].ToString();
                    label18.Text = rd1[2].ToString();
                    label17.Text = rd1[3].ToString();
                    label16.Text = rd1[4].ToString();
                    label15.Text = rd1[5].ToString();
                    label14.Text = rd1[6].ToString();
                    label13.Text = rd1[7].ToString();
                    label12.Text = rd1[8].ToString();

                    label28.Text = rd2[0].ToString();
                    label27.Text = rd2[2].ToString();
                    label26.Text = rd2[3].ToString();
                    label25.Text = rd2[4].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

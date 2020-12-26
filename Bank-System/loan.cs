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
    public partial class loan : Form
    {
        public loan()
        {
            InitializeComponent();
        }


        SqliteConnection con = new SqliteConnection("Datasource = C:\\Users\\nitis\\Desktop\\Bank-System\\Bank-System\\CSB_BANK.db");

        public void loanid()
        {
            try
            {
                con.Open();
                string query = "select max(loan_ID) from Loan";
                SqliteCommand cmd = new SqliteCommand(query, con);
                SqliteDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string val = dr[0].ToString();
                    if(val == "")
                    {
                        label6.Text = "893743";
                    }
                    else
                    {
                        int a;
                        a = int.Parse(dr[0].ToString());
                        a = a + 1;
                        label6.Text = a.ToString();
                    }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            string accID, loanID, custID, date, loanAmt;

            accID = textBox1.Text;
            loanID = label6.Text;
            custID = textBox2.Text;
            date = dateTimePicker1.Text;
            loanAmt = textBox3.Text;

            SqliteCommand cmd = new SqliteCommand();
            cmd.Connection = con;

            try
            {
                cmd.CommandText = "insert into Loan (Account_id,loan_ID,cust_id,date,loan_amt) values('" + accID + "','" + loanID + "','" + custID + "','" + date + "','" + loanAmt + "')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Send for approval");
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

        private void loan_Load(object sender, EventArgs e)
        {
            loanid();
        }
    }
}

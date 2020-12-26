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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SqliteConnection con = new SqliteConnection("Datasource = C:\\Users\\nitis\\Desktop\\Bank-System\\Bank-System\\CSB_BANK.db");

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Withdraw_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "select * from account where account_id = '" + textBox1.Text + "'";
                SqliteCommand cmd = new SqliteCommand(str);
                cmd.Connection = con;

                SqliteDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    textBox2.Text = rd[4].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string acno, date;
            double balance, withdraw_amt;

            acno = textBox1.Text;
            date = dateTimePicker1.Text;
            balance = double.Parse(textBox2.Text);
            withdraw_amt = double.Parse(textBox3.Text);

            con.Open();
            SqliteCommand cmd = new SqliteCommand();
            SqliteTransaction trans;

            trans = con.BeginTransaction();

            cmd.Connection = con;

            cmd.Transaction = trans;

            try
            {
                cmd.CommandText =
                    "update account set balance = balance - '" + withdraw_amt + "' where account_id = '" + acno + "'";
                cmd.ExecuteNonQuery();

                cmd.CommandText =
                    "insert into transaction_(account_id, date, balance, deposit) " +
                    "values('" + acno + "', '" + date + "', '" + balance + "', '" + withdraw_amt + "')";
                cmd.ExecuteNonQuery();

                trans.Commit();
                MessageBox.Show("Withdraw sucessfull");

            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}

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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        SqliteConnection con = new SqliteConnection("Datasource = C:\\Users\\nitis\\Desktop\\Bank-System\\Bank-System\\CSB_BANK.db");

        public void custid()
        {
            con.Open();
            string query = "select max(cust_id) from customer ";
            SqliteCommand cmd = new SqliteCommand(query, con);
            SqliteDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    label14.Text = "10000";
                }
                else
                {
                    int a;
                    a = int.Parse(dr[0].ToString());
                    a = a + 1;
                    label14.Text = a.ToString();
                }
                con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            custid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cid, fname, lname, street, city, state, phone, date, email, acno, acctype, des, bal;
            cid = label14.Text;
            fname = textBox2.Text;
            lname = textBox3.Text;
            street = textBox4.Text;
            city = textBox5.Text;
            state = textBox6.Text;
            phone = textBox7.Text;
            date = dateTimePicker1.Text;
            email = textBox8.Text;
            acno = textBox9.Text;
            acctype = comboBox1.Text;
            des = textBox11.Text;
            bal = textBox12.Text;

            con.Open();
            SqliteCommand cmd = new SqliteCommand();
            SqliteTransaction trans;
            trans = con.BeginTransaction();
            cmd.Connection = con;
            cmd.Transaction = trans;

            try
            {
                cmd.CommandText = "insert into customer (cust_id,fname,lname,street,city,st,phone,dob,email) values('" + cid + "','" + fname + "','" + lname + "','" + street + "','" + city + "','" + state + "','" + phone + "','" + date + "','" + email + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into account (account_id,cust_id,acctype,descp,balance) values('" + acno + "','" + cid + "','" + acctype + "','" + des + "','" + bal + "')";
                cmd.ExecuteNonQuery();
                trans.Commit();
                MessageBox.Show("Record added......");
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

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

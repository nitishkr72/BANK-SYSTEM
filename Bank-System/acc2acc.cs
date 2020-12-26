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
    public partial class acc2acc : Form
    {
        public acc2acc()
        {
            InitializeComponent();
        }

        SqliteConnection con = new SqliteConnection("Datasource = C:\\Users\\nitis\\Desktop\\Bank-System\\Bank-System\\CSB_BANK.db");

        private void acc2acc_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string from_acc, to_acc, date;
            double amt;

            from_acc = textBox1.Text;
            to_acc = textBox2.Text;
            date = dateTimePicker1.Text;

            amt = double.Parse(textBox3.Text);

            con.Open();
            SqliteCommand cmd = new SqliteCommand();
            SqliteTransaction trans;

            trans = con.BeginTransaction();

            cmd.Connection = con;

            cmd.Transaction = trans;

            try
            {
                cmd.CommandText =
                    "update account set balance = balance - '" + amt + "' where account_id = '" + from_acc + "'";
                cmd.ExecuteNonQuery();

                cmd.CommandText =
                    "update account set balance = balance + '" + amt + "' where account_id = '" + to_acc + "'";
                cmd.ExecuteNonQuery();

                cmd.CommandText =
                    "insert into transfer(from_acc, to_acc, date, amt) " +
                    "values('" + from_acc + "', '" + to_acc + "', '" + date + "', '" + amt + "')";
                cmd.ExecuteNonQuery();

                trans.Commit();
                MessageBox.Show("Transfer sucessfull");

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        int count;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string user, passwd;

            user = loginID.Text;
            passwd = pass.Text;

			count = count + 1;
			if (count > 3)
			{
				MessageBox.Show("System has been blocked.......");
				Application.Exit();
			}
			if (user == "" && passwd == "")
			{
				warnMsg.Text = "Blank username and password not allowed";
			}
			else if (user.Length > 10 && passwd.Length > 10)
			{
				warnMsg.Text = "Only 10 chharacters allowed";
			}
			else
			{
				if (user == "Admin" && passwd == "Admin")
				{
					//label3.Text = "Logged in successfully";
					LoadingScreen pr = new LoadingScreen();
					this.Hide();
					pr.Show();
				}
				else
				{
					warnMsg.Text = "Incorrect USERNAME or PASSWORD";
					loginID.Clear();
					pass.Clear();
					loginID.Focus();
				}
			}
		}

        


        private void exitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void warnMsg_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            warnMsg.Text = "";
        }
    }
}

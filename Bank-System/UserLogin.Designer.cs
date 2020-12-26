
namespace Bank_System
{
    partial class UserLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.warnMsg = new System.Windows.Forms.Label();
            this.exitLogin = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.loginID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.warnMsg);
            this.groupBox1.Controls.Add(this.exitLogin);
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.loginID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(397, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // warnMsg
            // 
            this.warnMsg.AutoSize = true;
            this.warnMsg.Location = new System.Drawing.Point(104, 164);
            this.warnMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warnMsg.Name = "warnMsg";
            this.warnMsg.Size = new System.Drawing.Size(0, 13);
            this.warnMsg.TabIndex = 6;
            this.warnMsg.Click += new System.EventHandler(this.warnMsg_Click);
            // 
            // exitLogin
            // 
            this.exitLogin.Location = new System.Drawing.Point(273, 119);
            this.exitLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitLogin.Name = "exitLogin";
            this.exitLogin.Size = new System.Drawing.Size(86, 28);
            this.exitLogin.TabIndex = 5;
            this.exitLogin.Text = "Cancel";
            this.exitLogin.UseVisualStyleBackColor = true;
            this.exitLogin.Click += new System.EventHandler(this.exitLogin_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(166, 119);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(86, 28);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(106, 74);
            this.pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(128, 20);
            this.pass.TabIndex = 3;
            this.pass.PasswordChar = '*';
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // loginID
            // 
            this.loginID.Location = new System.Drawing.Point(106, 42);
            this.loginID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginID.Name = "loginID";
            this.loginID.Size = new System.Drawing.Size(128, 20);
            this.loginID.TabIndex = 2;
            this.loginID.TextChanged += new System.EventHandler(this.loginID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 222);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox loginID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitLogin;
        private System.Windows.Forms.Label warnMsg;
        private System.Windows.Forms.Timer timer1;
    }
}
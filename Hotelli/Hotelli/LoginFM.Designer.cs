namespace Hotelli
{
    partial class LoginFM
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
            this.loginGB = new System.Windows.Forms.GroupBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.usernameLB = new System.Windows.Forms.Label();
            this.passwordLB = new System.Windows.Forms.Label();
            this.loginLB = new System.Windows.Forms.Label();
            this.loginBT = new System.Windows.Forms.Button();
            this.loginGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginGB
            // 
            this.loginGB.Controls.Add(this.loginBT);
            this.loginGB.Controls.Add(this.passwordLB);
            this.loginGB.Controls.Add(this.usernameLB);
            this.loginGB.Controls.Add(this.passwordTB);
            this.loginGB.Controls.Add(this.usernameTB);
            this.loginGB.Location = new System.Drawing.Point(46, 241);
            this.loginGB.Name = "loginGB";
            this.loginGB.Size = new System.Drawing.Size(231, 145);
            this.loginGB.TabIndex = 0;
            this.loginGB.TabStop = false;
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(9, 32);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(100, 20);
            this.usernameTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(9, 80);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(100, 20);
            this.passwordTB.TabIndex = 1;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // usernameLB
            // 
            this.usernameLB.AutoSize = true;
            this.usernameLB.Location = new System.Drawing.Point(6, 16);
            this.usernameLB.Name = "usernameLB";
            this.usernameLB.Size = new System.Drawing.Size(63, 13);
            this.usernameLB.TabIndex = 2;
            this.usernameLB.Text = "Käyttäjänimi";
            // 
            // passwordLB
            // 
            this.passwordLB.AutoSize = true;
            this.passwordLB.Location = new System.Drawing.Point(6, 64);
            this.passwordLB.Name = "passwordLB";
            this.passwordLB.Size = new System.Drawing.Size(51, 13);
            this.passwordLB.TabIndex = 3;
            this.passwordLB.Text = "Salasana";
            // 
            // loginLB
            // 
            this.loginLB.AutoSize = true;
            this.loginLB.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLB.Location = new System.Drawing.Point(1, 195);
            this.loginLB.Name = "loginLB";
            this.loginLB.Size = new System.Drawing.Size(341, 26);
            this.loginLB.TabIndex = 1;
            this.loginLB.Text = "Kirjaudu sisään";
            // 
            // loginBT
            // 
            this.loginBT.Location = new System.Drawing.Point(62, 116);
            this.loginBT.Name = "loginBT";
            this.loginBT.Size = new System.Drawing.Size(103, 23);
            this.loginBT.TabIndex = 4;
            this.loginBT.Text = "Kirjaudu";
            this.loginBT.UseVisualStyleBackColor = true;
            this.loginBT.Click += new System.EventHandler(this.loginBT_Click);
            // 
            // LoginFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(337, 412);
            this.Controls.Add(this.loginLB);
            this.Controls.Add(this.loginGB);
            this.Name = "LoginFM";
            this.Text = "Log in";
            this.loginGB.ResumeLayout(false);
            this.loginGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox loginGB;
        private System.Windows.Forms.Label passwordLB;
        private System.Windows.Forms.Label usernameLB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label loginLB;
        private System.Windows.Forms.Button loginBT;
    }
}


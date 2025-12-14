namespace Taqtik
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_team = new System.Windows.Forms.Label();
            this.comboBox_team = new System.Windows.Forms.ComboBox();
            this.button_signup = new System.Windows.Forms.Button();
            this.checkBox_showpassword = new System.Windows.Forms.CheckBox();
            this.label_confirmpassword = new System.Windows.Forms.Label();
            this.textBox_confirmpassword = new System.Windows.Forms.TextBox();
            this.label_signup = new System.Windows.Forms.Label();
            this.label_passworddoesntmatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(827, 271);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(194, 40);
            this.label_password.TabIndex = 10;
            this.label_password.Text = "Password:";
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.White;
            this.textBox_password.Location = new System.Drawing.Point(1081, 271);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(262, 48);
            this.textBox_password.TabIndex = 9;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(827, 190);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(202, 40);
            this.label_username.TabIndex = 8;
            this.label_username.Text = "Username:";
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.Color.White;
            this.textBox_username.Location = new System.Drawing.Point(1081, 193);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(262, 48);
            this.textBox_username.TabIndex = 7;
            // 
            // label_team
            // 
            this.label_team.AutoSize = true;
            this.label_team.BackColor = System.Drawing.Color.Transparent;
            this.label_team.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_team.ForeColor = System.Drawing.Color.White;
            this.label_team.Location = new System.Drawing.Point(862, 434);
            this.label_team.Name = "label_team";
            this.label_team.Size = new System.Drawing.Size(124, 40);
            this.label_team.TabIndex = 12;
            this.label_team.Text = "Team:";
            // 
            // comboBox_team
            // 
            this.comboBox_team.FormattingEnabled = true;
            this.comboBox_team.Location = new System.Drawing.Point(1081, 431);
            this.comboBox_team.Name = "comboBox_team";
            this.comboBox_team.Size = new System.Drawing.Size(262, 48);
            this.comboBox_team.TabIndex = 14;
            // 
            // button_signup
            // 
            this.button_signup.ForeColor = System.Drawing.Color.Black;
            this.button_signup.Location = new System.Drawing.Point(1081, 561);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(189, 71);
            this.button_signup.TabIndex = 15;
            this.button_signup.Text = "SignUp";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // checkBox_showpassword
            // 
            this.checkBox_showpassword.AutoSize = true;
            this.checkBox_showpassword.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_showpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_showpassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_showpassword.Location = new System.Drawing.Point(1029, 498);
            this.checkBox_showpassword.Name = "checkBox_showpassword";
            this.checkBox_showpassword.Size = new System.Drawing.Size(314, 44);
            this.checkBox_showpassword.TabIndex = 16;
            this.checkBox_showpassword.Text = "Show Password";
            this.checkBox_showpassword.UseVisualStyleBackColor = false;
            this.checkBox_showpassword.CheckedChanged += new System.EventHandler(this.checkBox_showpassword_CheckedChanged);
            // 
            // label_confirmpassword
            // 
            this.label_confirmpassword.AutoSize = true;
            this.label_confirmpassword.BackColor = System.Drawing.Color.Transparent;
            this.label_confirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_confirmpassword.ForeColor = System.Drawing.Color.White;
            this.label_confirmpassword.Location = new System.Drawing.Point(737, 356);
            this.label_confirmpassword.Name = "label_confirmpassword";
            this.label_confirmpassword.Size = new System.Drawing.Size(338, 40);
            this.label_confirmpassword.TabIndex = 18;
            this.label_confirmpassword.Text = "Confirm Password:";
            // 
            // textBox_confirmpassword
            // 
            this.textBox_confirmpassword.BackColor = System.Drawing.Color.White;
            this.textBox_confirmpassword.Location = new System.Drawing.Point(1081, 353);
            this.textBox_confirmpassword.Name = "textBox_confirmpassword";
            this.textBox_confirmpassword.Size = new System.Drawing.Size(262, 48);
            this.textBox_confirmpassword.TabIndex = 17;
            this.textBox_confirmpassword.UseSystemPasswordChar = true;
            // 
            // label_signup
            // 
            this.label_signup.AutoSize = true;
            this.label_signup.BackColor = System.Drawing.Color.Transparent;
            this.label_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signup.Location = new System.Drawing.Point(1005, 99);
            this.label_signup.Name = "label_signup";
            this.label_signup.Size = new System.Drawing.Size(202, 59);
            this.label_signup.TabIndex = 19;
            this.label_signup.Text = "SignUp";
            // 
            // label_passworddoesntmatch
            // 
            this.label_passworddoesntmatch.AutoSize = true;
            this.label_passworddoesntmatch.BackColor = System.Drawing.Color.Transparent;
            this.label_passworddoesntmatch.ForeColor = System.Drawing.Color.Red;
            this.label_passworddoesntmatch.Location = new System.Drawing.Point(977, 657);
            this.label_passworddoesntmatch.Name = "label_passworddoesntmatch";
            this.label_passworddoesntmatch.Size = new System.Drawing.Size(418, 40);
            this.label_passworddoesntmatch.TabIndex = 20;
            this.label_passworddoesntmatch.Text = "Password doesn\'t match!";
            this.label_passworddoesntmatch.Visible = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 894);
            this.Controls.Add(this.label_passworddoesntmatch);
            this.Controls.Add(this.label_signup);
            this.Controls.Add(this.label_confirmpassword);
            this.Controls.Add(this.textBox_confirmpassword);
            this.Controls.Add(this.checkBox_showpassword);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.comboBox_team);
            this.Controls.Add(this.label_team);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox_username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_team;
        private System.Windows.Forms.ComboBox comboBox_team;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.CheckBox checkBox_showpassword;
        private System.Windows.Forms.Label label_confirmpassword;
        private System.Windows.Forms.TextBox textBox_confirmpassword;
        private System.Windows.Forms.Label label_signup;
        private System.Windows.Forms.Label label_passworddoesntmatch;
    }
}
namespace Taqtik
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label_taqtik = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.checkBox_showpassword = new System.Windows.Forms.CheckBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_signup = new System.Windows.Forms.Button();
            this.label_incorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_taqtik
            // 
            this.label_taqtik.AutoSize = true;
            this.label_taqtik.BackColor = System.Drawing.Color.Transparent;
            this.label_taqtik.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taqtik.ForeColor = System.Drawing.Color.White;
            this.label_taqtik.Location = new System.Drawing.Point(1008, 160);
            this.label_taqtik.Name = "label_taqtik";
            this.label_taqtik.Size = new System.Drawing.Size(318, 88);
            this.label_taqtik.TabIndex = 0;
            this.label_taqtik.Text = "TAQTIK";
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.Color.White;
            this.textBox_username.Location = new System.Drawing.Point(1101, 296);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(262, 48);
            this.textBox_username.TabIndex = 1;
            // 
            // checkBox_showpassword
            // 
            this.checkBox_showpassword.AutoSize = true;
            this.checkBox_showpassword.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_showpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_showpassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_showpassword.Location = new System.Drawing.Point(1101, 429);
            this.checkBox_showpassword.Name = "checkBox_showpassword";
            this.checkBox_showpassword.Size = new System.Drawing.Size(314, 44);
            this.checkBox_showpassword.TabIndex = 2;
            this.checkBox_showpassword.Text = "Show Password";
            this.checkBox_showpassword.UseVisualStyleBackColor = false;
            this.checkBox_showpassword.CheckedChanged += new System.EventHandler(this.checkBox_showpassword_CheckedChanged);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(959, 520);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(189, 71);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(893, 296);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(202, 40);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "Username:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(893, 363);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(194, 40);
            this.label_password.TabIndex = 6;
            this.label_password.Text = "Password:";
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.White;
            this.textBox_password.Location = new System.Drawing.Point(1101, 360);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(262, 48);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // button_signup
            // 
            this.button_signup.Location = new System.Drawing.Point(1204, 520);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(189, 71);
            this.button_signup.TabIndex = 7;
            this.button_signup.Text = "SignUp";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // label_incorrect
            // 
            this.label_incorrect.AutoSize = true;
            this.label_incorrect.BackColor = System.Drawing.Color.Transparent;
            this.label_incorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_incorrect.ForeColor = System.Drawing.Color.Red;
            this.label_incorrect.Location = new System.Drawing.Point(969, 634);
            this.label_incorrect.Name = "label_incorrect";
            this.label_incorrect.Size = new System.Drawing.Size(424, 32);
            this.label_incorrect.TabIndex = 8;
            this.label_incorrect.Text = "Incorrect username or password!";
            this.label_incorrect.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 894);
            this.Controls.Add(this.label_incorrect);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.checkBox_showpassword);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_taqtik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_taqtik;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.CheckBox checkBox_showpassword;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.Label label_incorrect;
    }
}


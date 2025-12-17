namespace Taqtik
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label_role = new System.Windows.Forms.Label();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_confirmpassword = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_confirmpassword = new System.Windows.Forms.TextBox();
            this.label_adduser = new System.Windows.Forms.Label();
            this.label_passworddoesntmatch = new System.Windows.Forms.Label();
            this.checkBox_showpassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(1042, 282);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(349, 48);
            this.textBox_password.TabIndex = 2;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.White;
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(966, 624);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(242, 79);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.BackColor = System.Drawing.Color.Transparent;
            this.label_role.Location = new System.Drawing.Point(867, 495);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(101, 40);
            this.label_role.TabIndex = 5;
            this.label_role.Text = "Role:";
            // 
            // comboBox_role
            // 
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Location = new System.Drawing.Point(1042, 492);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(349, 48);
            this.comboBox_role.TabIndex = 4;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Location = new System.Drawing.Point(783, 285);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(185, 40);
            this.label_password.TabIndex = 6;
            this.label_password.Text = "Password:";
            // 
            // label_confirmpassword
            // 
            this.label_confirmpassword.AutoSize = true;
            this.label_confirmpassword.BackColor = System.Drawing.Color.Transparent;
            this.label_confirmpassword.Location = new System.Drawing.Point(688, 364);
            this.label_confirmpassword.Name = "label_confirmpassword";
            this.label_confirmpassword.Size = new System.Drawing.Size(321, 40);
            this.label_confirmpassword.TabIndex = 8;
            this.label_confirmpassword.Text = "Confirm Password:";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(1042, 205);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(349, 48);
            this.textBox_username.TabIndex = 7;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Location = new System.Drawing.Point(783, 208);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(193, 40);
            this.label_username.TabIndex = 10;
            this.label_username.Text = "Username:";
            // 
            // textBox_confirmpassword
            // 
            this.textBox_confirmpassword.Location = new System.Drawing.Point(1042, 361);
            this.textBox_confirmpassword.Name = "textBox_confirmpassword";
            this.textBox_confirmpassword.Size = new System.Drawing.Size(349, 48);
            this.textBox_confirmpassword.TabIndex = 9;
            // 
            // label_adduser
            // 
            this.label_adduser.AutoSize = true;
            this.label_adduser.BackColor = System.Drawing.Color.Transparent;
            this.label_adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adduser.Location = new System.Drawing.Point(956, 98);
            this.label_adduser.Name = "label_adduser";
            this.label_adduser.Size = new System.Drawing.Size(233, 55);
            this.label_adduser.TabIndex = 11;
            this.label_adduser.Text = "Add User";
            // 
            // label_passworddoesntmatch
            // 
            this.label_passworddoesntmatch.AutoSize = true;
            this.label_passworddoesntmatch.BackColor = System.Drawing.Color.Transparent;
            this.label_passworddoesntmatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_passworddoesntmatch.ForeColor = System.Drawing.Color.Red;
            this.label_passworddoesntmatch.Location = new System.Drawing.Point(924, 573);
            this.label_passworddoesntmatch.Name = "label_passworddoesntmatch";
            this.label_passworddoesntmatch.Size = new System.Drawing.Size(328, 32);
            this.label_passworddoesntmatch.TabIndex = 12;
            this.label_passworddoesntmatch.Text = "Password doesn\'t match!";
            this.label_passworddoesntmatch.Visible = false;
            // 
            // checkBox_showpassword
            // 
            this.checkBox_showpassword.AutoSize = true;
            this.checkBox_showpassword.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_showpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_showpassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_showpassword.Location = new System.Drawing.Point(1042, 430);
            this.checkBox_showpassword.Name = "checkBox_showpassword";
            this.checkBox_showpassword.Size = new System.Drawing.Size(314, 44);
            this.checkBox_showpassword.TabIndex = 17;
            this.checkBox_showpassword.Text = "Show Password";
            this.checkBox_showpassword.UseVisualStyleBackColor = false;
            this.checkBox_showpassword.CheckedChanged += new System.EventHandler(this.checkBox_showpassword_CheckedChanged);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 894);
            this.Controls.Add(this.checkBox_showpassword);
            this.Controls.Add(this.label_passworddoesntmatch);
            this.Controls.Add(this.label_adduser);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox_confirmpassword);
            this.Controls.Add(this.label_confirmpassword);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.comboBox_role);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_password);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_confirmpassword;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_confirmpassword;
        private System.Windows.Forms.Label label_adduser;
        private System.Windows.Forms.Label label_passworddoesntmatch;
        private System.Windows.Forms.CheckBox checkBox_showpassword;
    }
}
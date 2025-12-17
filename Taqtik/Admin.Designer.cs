namespace Taqtik
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.comboBox_chooseteam = new System.Windows.Forms.ComboBox();
            this.label_chooseteam = new System.Windows.Forms.Label();
            this.button_adduser = new System.Windows.Forms.Button();
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.button_display = new System.Windows.Forms.Button();
            this.label_users = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_chooseteam
            // 
            this.comboBox_chooseteam.FormattingEnabled = true;
            this.comboBox_chooseteam.Location = new System.Drawing.Point(1042, 174);
            this.comboBox_chooseteam.Name = "comboBox_chooseteam";
            this.comboBox_chooseteam.Size = new System.Drawing.Size(302, 44);
            this.comboBox_chooseteam.TabIndex = 0;
            // 
            // label_chooseteam
            // 
            this.label_chooseteam.AutoSize = true;
            this.label_chooseteam.BackColor = System.Drawing.Color.Transparent;
            this.label_chooseteam.Location = new System.Drawing.Point(724, 177);
            this.label_chooseteam.Name = "label_chooseteam";
            this.label_chooseteam.Size = new System.Drawing.Size(207, 36);
            this.label_chooseteam.TabIndex = 1;
            this.label_chooseteam.Text = "Choose Team:";
            // 
            // button_adduser
            // 
            this.button_adduser.BackColor = System.Drawing.Color.White;
            this.button_adduser.ForeColor = System.Drawing.Color.Black;
            this.button_adduser.Location = new System.Drawing.Point(786, 284);
            this.button_adduser.Name = "button_adduser";
            this.button_adduser.Size = new System.Drawing.Size(192, 90);
            this.button_adduser.TabIndex = 2;
            this.button_adduser.Text = "Add User";
            this.button_adduser.UseVisualStyleBackColor = false;
            this.button_adduser.Click += new System.EventHandler(this.button_adduser_Click);
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.AllowUserToAddRows = false;
            this.dataGridView_users.AllowUserToDeleteRows = false;
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users.Location = new System.Drawing.Point(544, 453);
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.ReadOnly = true;
            this.dataGridView_users.RowHeadersWidth = 62;
            this.dataGridView_users.RowTemplate.Height = 28;
            this.dataGridView_users.Size = new System.Drawing.Size(896, 259);
            this.dataGridView_users.TabIndex = 3;
            this.dataGridView_users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_users_CellContentClick);
            // 
            // button_display
            // 
            this.button_display.BackColor = System.Drawing.Color.White;
            this.button_display.ForeColor = System.Drawing.Color.Black;
            this.button_display.Location = new System.Drawing.Point(1103, 284);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(192, 90);
            this.button_display.TabIndex = 4;
            this.button_display.Text = "Display";
            this.button_display.UseVisualStyleBackColor = false;
            // 
            // label_users
            // 
            this.label_users.AutoSize = true;
            this.label_users.BackColor = System.Drawing.Color.Transparent;
            this.label_users.Location = new System.Drawing.Point(537, 398);
            this.label_users.Name = "label_users";
            this.label_users.Size = new System.Drawing.Size(101, 36);
            this.label_users.TabIndex = 5;
            this.label_users.Text = "Users:";
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.BackColor = System.Drawing.Color.Transparent;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.Location = new System.Drawing.Point(795, 54);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(406, 52);
            this.label_welcome.TabIndex = 6;
            this.label_welcome.Text = "Welcome //Admin//";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 894);
            this.Controls.Add(this.label_welcome);
            this.Controls.Add(this.label_users);
            this.Controls.Add(this.button_display);
            this.Controls.Add(this.dataGridView_users);
            this.Controls.Add(this.button_adduser);
            this.Controls.Add(this.label_chooseteam);
            this.Controls.Add(this.comboBox_chooseteam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_chooseteam;
        private System.Windows.Forms.Label label_chooseteam;
        private System.Windows.Forms.Button button_adduser;
        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.Button button_display;
        private System.Windows.Forms.Label label_users;
        private System.Windows.Forms.Label label_welcome;
    }
}
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
            this.button_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_chooseteam
            // 
            this.comboBox_chooseteam.FormattingEnabled = true;
            this.comboBox_chooseteam.Location = new System.Drawing.Point(855, 145);
            this.comboBox_chooseteam.Name = "comboBox_chooseteam";
            this.comboBox_chooseteam.Size = new System.Drawing.Size(302, 48);
            this.comboBox_chooseteam.TabIndex = 0;
            // 
            // label_chooseteam
            // 
            this.label_chooseteam.AutoSize = true;
            this.label_chooseteam.BackColor = System.Drawing.Color.Transparent;
            this.label_chooseteam.ForeColor = System.Drawing.Color.White;
            this.label_chooseteam.Location = new System.Drawing.Point(596, 145);
            this.label_chooseteam.Name = "label_chooseteam";
            this.label_chooseteam.Size = new System.Drawing.Size(253, 40);
            this.label_chooseteam.TabIndex = 1;
            this.label_chooseteam.Text = "Choose Team:";
            // 
            // button_adduser
            // 
            this.button_adduser.BackColor = System.Drawing.Color.White;
            this.button_adduser.ForeColor = System.Drawing.Color.Black;
            this.button_adduser.Location = new System.Drawing.Point(949, 313);
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
            this.dataGridView_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_users.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users.GridColor = System.Drawing.Color.Black;
            this.dataGridView_users.Location = new System.Drawing.Point(544, 453);
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.ReadOnly = true;
            this.dataGridView_users.RowHeadersWidth = 62;
            this.dataGridView_users.RowTemplate.Height = 28;
            this.dataGridView_users.Size = new System.Drawing.Size(896, 259);
            this.dataGridView_users.TabIndex = 3;
            // 
            // button_display
            // 
            this.button_display.BackColor = System.Drawing.Color.White;
            this.button_display.ForeColor = System.Drawing.Color.Black;
            this.button_display.Location = new System.Drawing.Point(1207, 134);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(192, 68);
            this.button_display.TabIndex = 4;
            this.button_display.Text = "Display";
            this.button_display.UseVisualStyleBackColor = false;
            this.button_display.Click += new System.EventHandler(this.button_display_Click);
            // 
            // label_users
            // 
            this.label_users.AutoSize = true;
            this.label_users.BackColor = System.Drawing.Color.Transparent;
            this.label_users.ForeColor = System.Drawing.Color.White;
            this.label_users.Location = new System.Drawing.Point(537, 398);
            this.label_users.Name = "label_users";
            this.label_users.Size = new System.Drawing.Size(121, 40);
            this.label_users.TabIndex = 5;
            this.label_users.Text = "Users:";
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.BackColor = System.Drawing.Color.Transparent;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.ForeColor = System.Drawing.Color.White;
            this.label_welcome.Location = new System.Drawing.Point(795, 54);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(475, 59);
            this.label_welcome.TabIndex = 6;
            this.label_welcome.Text = "Welcome //Admin//";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.White;
            this.button_delete.ForeColor = System.Drawing.Color.Black;
            this.button_delete.Location = new System.Drawing.Point(1207, 224);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(192, 68);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(596, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Delete Team:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(855, 235);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(302, 48);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 894);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_welcome);
            this.Controls.Add(this.label_users);
            this.Controls.Add(this.button_display);
            this.Controls.Add(this.dataGridView_users);
            this.Controls.Add(this.button_adduser);
            this.Controls.Add(this.label_chooseteam);
            this.Controls.Add(this.comboBox_chooseteam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
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
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
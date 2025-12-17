namespace Taqtik
{
    partial class AddTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeam));
            this.label4 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(965, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 46);
            this.label4.TabIndex = 15;
            this.label4.Text = "Add Team";
            // 
            // button_add
            // 
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(1011, 578);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(163, 66);
            this.button_add.TabIndex = 14;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(1024, 444);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(236, 41);
            this.textBox_year.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(764, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Year Founded:";
            // 
            // textBox_country
            // 
            this.textBox_country.Location = new System.Drawing.Point(1024, 368);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(236, 41);
            this.textBox_country.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(854, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Country:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(1024, 287);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(236, 41);
            this.textBox_name.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(886, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 894);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "AddTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
    }
}
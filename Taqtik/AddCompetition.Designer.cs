namespace Taqtik
{
    partial class AddCompetition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCompetition));
            this.button_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.label_country = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(1045, 517);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(163, 66);
            this.button_add.TabIndex = 23;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(904, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 46);
            this.label4.TabIndex = 22;
            this.label4.Text = "Add Competition";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(1045, 322);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(236, 41);
            this.textBox_name.TabIndex = 21;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_year_TextChanged);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Location = new System.Drawing.Point(907, 325);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(100, 36);
            this.label_name.TabIndex = 20;
            this.label_name.Text = "Name:";
            this.label_name.Click += new System.EventHandler(this.label_name_Click);
            // 
            // textBox_country
            // 
            this.textBox_country.Location = new System.Drawing.Point(1045, 409);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(236, 41);
            this.textBox_country.TabIndex = 25;
            this.textBox_country.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.BackColor = System.Drawing.Color.Transparent;
            this.label_country.Location = new System.Drawing.Point(877, 412);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(128, 36);
            this.label_country.TabIndex = 24;
            this.label_country.Text = "Country:";
            this.label_country.Click += new System.EventHandler(this.label_country_Click);
            // 
            // AddCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 894);
            this.Controls.Add(this.textBox_country);
            this.Controls.Add(this.label_country);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "AddCompetition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCompetition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_country;
        private System.Windows.Forms.Label label_country;
    }
}
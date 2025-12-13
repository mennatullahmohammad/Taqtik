namespace Taqtik
{
    partial class Team
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Team));
            this.button_showteam = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_showmatch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_playerstats = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_teamstats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_showteam
            // 
            this.button_showteam.Location = new System.Drawing.Point(1237, 567);
            this.button_showteam.Name = "button_showteam";
            this.button_showteam.Size = new System.Drawing.Size(223, 66);
            this.button_showteam.TabIndex = 17;
            this.button_showteam.Text = "Show Team";
            this.button_showteam.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(837, 577);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(361, 48);
            this.comboBox2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(441, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 46);
            this.label3.TabIndex = 15;
            this.label3.Text = "Show another team:";
            // 
            // button_showmatch
            // 
            this.button_showmatch.Location = new System.Drawing.Point(1237, 452);
            this.button_showmatch.Name = "button_showmatch";
            this.button_showmatch.Size = new System.Drawing.Size(223, 66);
            this.button_showmatch.TabIndex = 14;
            this.button_showmatch.Text = "Show Match";
            this.button_showmatch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(437, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 46);
            this.label2.TabIndex = 13;
            this.label2.Text = "Match Stats against:";
            // 
            // button_playerstats
            // 
            this.button_playerstats.Location = new System.Drawing.Point(1164, 275);
            this.button_playerstats.Name = "button_playerstats";
            this.button_playerstats.Size = new System.Drawing.Size(238, 100);
            this.button_playerstats.TabIndex = 12;
            this.button_playerstats.Text = "Player Stats";
            this.button_playerstats.UseVisualStyleBackColor = true;
            this.button_playerstats.Click += new System.EventHandler(this.button_playerstats_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(837, 462);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(361, 48);
            this.comboBox1.TabIndex = 11;
            // 
            // button_teamstats
            // 
            this.button_teamstats.Location = new System.Drawing.Point(872, 275);
            this.button_teamstats.Name = "button_teamstats";
            this.button_teamstats.Size = new System.Drawing.Size(238, 100);
            this.button_teamstats.TabIndex = 10;
            this.button_teamstats.Text = "Team Stats";
            this.button_teamstats.UseVisualStyleBackColor = true;
            this.button_teamstats.Click += new System.EventHandler(this.button_teamstats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(827, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "//User team should appear hear//";
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 844);
            this.Controls.Add(this.button_showteam);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_showmatch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_playerstats);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_teamstats);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Team";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_showteam;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_showmatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_playerstats;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_teamstats;
        private System.Windows.Forms.Label label1;
    }
}
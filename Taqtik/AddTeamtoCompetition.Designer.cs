namespace Taqtik
{
    partial class AddTeamtoCompetition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeamtoCompetition));
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_competition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Season = new System.Windows.Forms.ComboBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.comboBox_team = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(793, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(496, 46);
            this.label4.TabIndex = 23;
            this.label4.Text = "Add Team to Competition";
            // 
            // comboBox_competition
            // 
            this.comboBox_competition.FormattingEnabled = true;
            this.comboBox_competition.Location = new System.Drawing.Point(1077, 408);
            this.comboBox_competition.Name = "comboBox_competition";
            this.comboBox_competition.Size = new System.Drawing.Size(285, 44);
            this.comboBox_competition.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(852, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 80;
            this.label1.Text = "Competition:";
            // 
            // comboBox_Season
            // 
            this.comboBox_Season.FormattingEnabled = true;
            this.comboBox_Season.Location = new System.Drawing.Point(1077, 321);
            this.comboBox_Season.Name = "comboBox_Season";
            this.comboBox_Season.Size = new System.Drawing.Size(285, 44);
            this.comboBox_Season.TabIndex = 79;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.BackColor = System.Drawing.Color.Transparent;
            this.label_1.Location = new System.Drawing.Point(899, 324);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(124, 36);
            this.label_1.TabIndex = 78;
            this.label_1.Text = "Season:";
            // 
            // comboBox_team
            // 
            this.comboBox_team.FormattingEnabled = true;
            this.comboBox_team.Location = new System.Drawing.Point(1077, 237);
            this.comboBox_team.Name = "comboBox_team";
            this.comboBox_team.Size = new System.Drawing.Size(285, 44);
            this.comboBox_team.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(899, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 36);
            this.label2.TabIndex = 82;
            this.label2.Text = "Team:";
            // 
            // button_add
            // 
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(1064, 487);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(163, 66);
            this.button_add.TabIndex = 84;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // AddTeamtoCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 894);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.comboBox_team);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_competition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Season);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "AddTeamtoCompetition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTeamtoCompetition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_competition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Season;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.ComboBox comboBox_team;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_add;
    }
}
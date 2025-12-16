namespace Taqtik
{
    partial class AddMatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMatch));
            this.label_gameweek = new System.Windows.Forms.Label();
            this.label_addMatch = new System.Windows.Forms.Label();
            this.comboBox_GW = new System.Windows.Forms.ComboBox();
            this.button_addMatch = new System.Windows.Forms.Button();
            this.comboBox_referee = new System.Windows.Forms.ComboBox();
            this.label_referee = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_HomeTeam = new System.Windows.Forms.Label();
            this.comboBoxhometeam = new System.Windows.Forms.ComboBox();
            this.comboBoxawayteam = new System.Windows.Forms.ComboBox();
            this.labelawayteam = new System.Windows.Forms.Label();
            this.SEASON = new System.Windows.Forms.Label();
            this.comboBoxseason = new System.Windows.Forms.ComboBox();
            this.labelCompetition = new System.Windows.Forms.Label();
            this.comboBoxcompetition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_gameweek
            // 
            this.label_gameweek.AutoSize = true;
            this.label_gameweek.BackColor = System.Drawing.Color.Transparent;
            this.label_gameweek.Location = new System.Drawing.Point(521, 499);
            this.label_gameweek.Name = "label_gameweek";
            this.label_gameweek.Size = new System.Drawing.Size(177, 36);
            this.label_gameweek.TabIndex = 64;
            this.label_gameweek.Text = "GameWeek:";
            // 
            // label_addMatch
            // 
            this.label_addMatch.AutoSize = true;
            this.label_addMatch.BackColor = System.Drawing.Color.Transparent;
            this.label_addMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addMatch.Location = new System.Drawing.Point(787, 58);
            this.label_addMatch.Name = "label_addMatch";
            this.label_addMatch.Size = new System.Drawing.Size(206, 42);
            this.label_addMatch.TabIndex = 60;
            this.label_addMatch.Text = "Add Match";
            // 
            // comboBox_GW
            // 
            this.comboBox_GW.FormattingEnabled = true;
            this.comboBox_GW.Location = new System.Drawing.Point(708, 496);
            this.comboBox_GW.Name = "comboBox_GW";
            this.comboBox_GW.Size = new System.Drawing.Size(128, 44);
            this.comboBox_GW.TabIndex = 67;
            // 
            // button_addMatch
            // 
            this.button_addMatch.BackColor = System.Drawing.Color.White;
            this.button_addMatch.ForeColor = System.Drawing.Color.Black;
            this.button_addMatch.Location = new System.Drawing.Point(920, 626);
            this.button_addMatch.Name = "button_addMatch";
            this.button_addMatch.Size = new System.Drawing.Size(243, 95);
            this.button_addMatch.TabIndex = 68;
            this.button_addMatch.Text = "Add Match";
            this.button_addMatch.UseVisualStyleBackColor = false;
            this.button_addMatch.Click += new System.EventHandler(this.button_addSubs_Click);
            // 
            // comboBox_referee
            // 
            this.comboBox_referee.FormattingEnabled = true;
            this.comboBox_referee.Location = new System.Drawing.Point(708, 558);
            this.comboBox_referee.Name = "comboBox_referee";
            this.comboBox_referee.Size = new System.Drawing.Size(128, 44);
            this.comboBox_referee.TabIndex = 70;
            this.comboBox_referee.SelectedIndexChanged += new System.EventHandler(this.comboBox_referee_SelectedIndexChanged);
            // 
            // label_referee
            // 
            this.label_referee.AutoSize = true;
            this.label_referee.BackColor = System.Drawing.Color.Transparent;
            this.label_referee.Location = new System.Drawing.Point(572, 561);
            this.label_referee.Name = "label_referee";
            this.label_referee.Size = new System.Drawing.Size(127, 36);
            this.label_referee.TabIndex = 69;
            this.label_referee.Text = "Referee:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(581, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 95);
            this.button1.TabIndex = 71;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_HomeTeam
            // 
            this.label_HomeTeam.AutoSize = true;
            this.label_HomeTeam.BackColor = System.Drawing.Color.Transparent;
            this.label_HomeTeam.Location = new System.Drawing.Point(521, 203);
            this.label_HomeTeam.Name = "label_HomeTeam";
            this.label_HomeTeam.Size = new System.Drawing.Size(181, 36);
            this.label_HomeTeam.TabIndex = 72;
            this.label_HomeTeam.Text = "Home Team:";
            // 
            // comboBoxhometeam
            // 
            this.comboBoxhometeam.FormattingEnabled = true;
            this.comboBoxhometeam.Location = new System.Drawing.Point(708, 203);
            this.comboBoxhometeam.Name = "comboBoxhometeam";
            this.comboBoxhometeam.Size = new System.Drawing.Size(128, 44);
            this.comboBoxhometeam.TabIndex = 73;
            this.comboBoxhometeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxhometeam_SelectedIndexChanged);
            // 
            // comboBoxawayteam
            // 
            this.comboBoxawayteam.FormattingEnabled = true;
            this.comboBoxawayteam.Location = new System.Drawing.Point(708, 279);
            this.comboBoxawayteam.Name = "comboBoxawayteam";
            this.comboBoxawayteam.Size = new System.Drawing.Size(128, 44);
            this.comboBoxawayteam.TabIndex = 74;
            // 
            // labelawayteam
            // 
            this.labelawayteam.AutoSize = true;
            this.labelawayteam.BackColor = System.Drawing.Color.Transparent;
            this.labelawayteam.Location = new System.Drawing.Point(521, 287);
            this.labelawayteam.Name = "labelawayteam";
            this.labelawayteam.Size = new System.Drawing.Size(178, 36);
            this.labelawayteam.TabIndex = 75;
            this.labelawayteam.Text = "Away Team:";
            // 
            // SEASON
            // 
            this.SEASON.AutoSize = true;
            this.SEASON.BackColor = System.Drawing.Color.Transparent;
            this.SEASON.Location = new System.Drawing.Point(578, 367);
            this.SEASON.Name = "SEASON";
            this.SEASON.Size = new System.Drawing.Size(124, 36);
            this.SEASON.TabIndex = 76;
            this.SEASON.Text = "Season:";
            // 
            // comboBoxseason
            // 
            this.comboBoxseason.FormattingEnabled = true;
            this.comboBoxseason.Location = new System.Drawing.Point(708, 364);
            this.comboBoxseason.Name = "comboBoxseason";
            this.comboBoxseason.Size = new System.Drawing.Size(128, 44);
            this.comboBoxseason.TabIndex = 77;
            // 
            // labelCompetition
            // 
            this.labelCompetition.AutoSize = true;
            this.labelCompetition.BackColor = System.Drawing.Color.Transparent;
            this.labelCompetition.Location = new System.Drawing.Point(521, 433);
            this.labelCompetition.Name = "labelCompetition";
            this.labelCompetition.Size = new System.Drawing.Size(181, 36);
            this.labelCompetition.TabIndex = 78;
            this.labelCompetition.Text = "Competition:";
            // 
            // comboBoxcompetition
            // 
            this.comboBoxcompetition.FormattingEnabled = true;
            this.comboBoxcompetition.Location = new System.Drawing.Point(708, 430);
            this.comboBoxcompetition.Name = "comboBoxcompetition";
            this.comboBoxcompetition.Size = new System.Drawing.Size(128, 44);
            this.comboBoxcompetition.TabIndex = 79;
            this.comboBoxcompetition.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 894);
            this.Controls.Add(this.comboBoxcompetition);
            this.Controls.Add(this.labelCompetition);
            this.Controls.Add(this.comboBoxseason);
            this.Controls.Add(this.SEASON);
            this.Controls.Add(this.labelawayteam);
            this.Controls.Add(this.comboBoxawayteam);
            this.Controls.Add(this.comboBoxhometeam);
            this.Controls.Add(this.label_HomeTeam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_referee);
            this.Controls.Add(this.label_referee);
            this.Controls.Add(this.button_addMatch);
            this.Controls.Add(this.comboBox_GW);
            this.Controls.Add(this.label_gameweek);
            this.Controls.Add(this.label_addMatch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "AddMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_gameweek;
        private System.Windows.Forms.Label label_addMatch;
        private System.Windows.Forms.ComboBox comboBox_GW;
        private System.Windows.Forms.Button button_addMatch;
        private System.Windows.Forms.ComboBox comboBox_referee;
        private System.Windows.Forms.Label label_referee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_HomeTeam;
        private System.Windows.Forms.ComboBox comboBoxhometeam;
        private System.Windows.Forms.ComboBox comboBoxawayteam;
        private System.Windows.Forms.Label labelawayteam;
        private System.Windows.Forms.Label SEASON;
        private System.Windows.Forms.ComboBox comboBoxseason;
        private System.Windows.Forms.Label labelCompetition;
        private System.Windows.Forms.ComboBox comboBoxcompetition;
    }
}
namespace Taqtik
{
    partial class DataEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEntry));
            this.label_welcome = new System.Windows.Forms.Label();
            this.button_addMatch = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.button_addEvent = new System.Windows.Forms.Button();
            this.button_addPlayer = new System.Windows.Forms.Button();
            this.buttonaddteam = new System.Windows.Forms.Button();
            this.buttonaddseason = new System.Windows.Forms.Button();
            this.buttoncompetition = new System.Windows.Forms.Button();
            this.buttonreferee = new System.Windows.Forms.Button();
            this.buttoncompinstance = new System.Windows.Forms.Button();
            this.button_addTeamToCompetition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.BackColor = System.Drawing.Color.Transparent;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.ForeColor = System.Drawing.Color.White;
            this.label_welcome.Location = new System.Drawing.Point(808, 32);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(180, 42);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Welcome";
            // 
            // button_addMatch
            // 
            this.button_addMatch.Location = new System.Drawing.Point(813, 172);
            this.button_addMatch.Name = "button_addMatch";
            this.button_addMatch.Size = new System.Drawing.Size(202, 68);
            this.button_addMatch.TabIndex = 1;
            this.button_addMatch.Text = "Add Match";
            this.button_addMatch.UseVisualStyleBackColor = true;
            this.button_addMatch.Click += new System.EventHandler(this.button_addMatch_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(1067, 32);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(236, 42);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "//username//";
            // 
            // button_addEvent
            // 
            this.button_addEvent.Location = new System.Drawing.Point(1111, 172);
            this.button_addEvent.Name = "button_addEvent";
            this.button_addEvent.Size = new System.Drawing.Size(202, 68);
            this.button_addEvent.TabIndex = 3;
            this.button_addEvent.Text = "Add Event";
            this.button_addEvent.UseVisualStyleBackColor = true;
            this.button_addEvent.Click += new System.EventHandler(this.button_addEvent_Click);
            // 
            // button_addPlayer
            // 
            this.button_addPlayer.Location = new System.Drawing.Point(813, 277);
            this.button_addPlayer.Name = "button_addPlayer";
            this.button_addPlayer.Size = new System.Drawing.Size(202, 94);
            this.button_addPlayer.TabIndex = 4;
            this.button_addPlayer.Text = "Add Player ";
            this.button_addPlayer.UseVisualStyleBackColor = true;
            this.button_addPlayer.Click += new System.EventHandler(this.button_addPlayer_Click);
            // 
            // buttonaddteam
            // 
            this.buttonaddteam.Location = new System.Drawing.Point(1111, 277);
            this.buttonaddteam.Name = "buttonaddteam";
            this.buttonaddteam.Size = new System.Drawing.Size(202, 94);
            this.buttonaddteam.TabIndex = 5;
            this.buttonaddteam.Text = "Add Team";
            this.buttonaddteam.UseVisualStyleBackColor = true;
            this.buttonaddteam.Click += new System.EventHandler(this.buttonaddteam_Click);
            // 
            // buttonaddseason
            // 
            this.buttonaddseason.Location = new System.Drawing.Point(813, 408);
            this.buttonaddseason.Name = "buttonaddseason";
            this.buttonaddseason.Size = new System.Drawing.Size(202, 94);
            this.buttonaddseason.TabIndex = 6;
            this.buttonaddseason.Text = "Add Season";
            this.buttonaddseason.UseVisualStyleBackColor = true;
            this.buttonaddseason.Click += new System.EventHandler(this.buttonaddseason_Click);
            // 
            // buttoncompetition
            // 
            this.buttoncompetition.Location = new System.Drawing.Point(1098, 408);
            this.buttoncompetition.Name = "buttoncompetition";
            this.buttoncompetition.Size = new System.Drawing.Size(232, 94);
            this.buttoncompetition.TabIndex = 7;
            this.buttoncompetition.Text = "Add Competition";
            this.buttoncompetition.UseVisualStyleBackColor = true;
            this.buttoncompetition.Click += new System.EventHandler(this.buttoncompetition_Click);
            // 
            // buttonreferee
            // 
            this.buttonreferee.Location = new System.Drawing.Point(813, 523);
            this.buttonreferee.Name = "buttonreferee";
            this.buttonreferee.Size = new System.Drawing.Size(202, 101);
            this.buttonreferee.TabIndex = 8;
            this.buttonreferee.Text = "Add Referee";
            this.buttonreferee.UseVisualStyleBackColor = true;
            this.buttonreferee.Click += new System.EventHandler(this.buttonreferee_Click);
            // 
            // buttoncompinstance
            // 
            this.buttoncompinstance.Location = new System.Drawing.Point(813, 654);
            this.buttoncompinstance.Name = "buttoncompinstance";
            this.buttoncompinstance.Size = new System.Drawing.Size(500, 101);
            this.buttoncompinstance.TabIndex = 9;
            this.buttoncompinstance.Text = "Add Competition Instance";
            this.buttoncompinstance.UseVisualStyleBackColor = true;
            this.buttoncompinstance.Click += new System.EventHandler(this.buttoncompinstance_Click_1);
            // 
            // button_addTeamToCompetition
            // 
            this.button_addTeamToCompetition.Location = new System.Drawing.Point(1098, 523);
            this.button_addTeamToCompetition.Name = "button_addTeamToCompetition";
            this.button_addTeamToCompetition.Size = new System.Drawing.Size(241, 101);
            this.button_addTeamToCompetition.TabIndex = 10;
            this.button_addTeamToCompetition.Text = "Add Team to Competition";
            this.button_addTeamToCompetition.UseVisualStyleBackColor = true;
            this.button_addTeamToCompetition.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 844);
            this.Controls.Add(this.button_addTeamToCompetition);
            this.Controls.Add(this.buttoncompinstance);
            this.Controls.Add(this.buttonreferee);
            this.Controls.Add(this.buttoncompetition);
            this.Controls.Add(this.buttonaddseason);
            this.Controls.Add(this.buttonaddteam);
            this.Controls.Add(this.button_addPlayer);
            this.Controls.Add(this.button_addEvent);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_addMatch);
            this.Controls.Add(this.label_welcome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "DataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataEntry";
            this.Load += new System.EventHandler(this.DataEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button_addMatch;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_addEvent;
        private System.Windows.Forms.Button button_addPlayer;
        private System.Windows.Forms.Button buttonaddteam;
        private System.Windows.Forms.Button buttonaddseason;
        private System.Windows.Forms.Button buttoncompetition;
        private System.Windows.Forms.Button buttonreferee;
        private System.Windows.Forms.Button buttoncompinstance;
        private System.Windows.Forms.Button button_addTeamToCompetition;
    }
}
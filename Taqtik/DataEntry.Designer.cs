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
            this.button_addPlayerStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.BackColor = System.Drawing.Color.Transparent;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.ForeColor = System.Drawing.Color.White;
            this.label_welcome.Location = new System.Drawing.Point(818, 93);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(212, 52);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Welcome";
            // 
            // button_addMatch
            // 
            this.button_addMatch.Location = new System.Drawing.Point(813, 243);
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
            this.label_username.Location = new System.Drawing.Point(1077, 93);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(276, 52);
            this.label_username.TabIndex = 2;
            this.label_username.Text = "//username//";
            // 
            // button_addEvent
            // 
            this.button_addEvent.Location = new System.Drawing.Point(1117, 243);
            this.button_addEvent.Name = "button_addEvent";
            this.button_addEvent.Size = new System.Drawing.Size(202, 68);
            this.button_addEvent.TabIndex = 3;
            this.button_addEvent.Text = "Add Event";
            this.button_addEvent.UseVisualStyleBackColor = true;
            // 
            // button_addPlayerStats
            // 
            this.button_addPlayerStats.Location = new System.Drawing.Point(813, 362);
            this.button_addPlayerStats.Name = "button_addPlayerStats";
            this.button_addPlayerStats.Size = new System.Drawing.Size(202, 101);
            this.button_addPlayerStats.TabIndex = 4;
            this.button_addPlayerStats.Text = "Add Player Stats";
            this.button_addPlayerStats.UseVisualStyleBackColor = true;
            // 
            // DataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 844);
            this.Controls.Add(this.button_addPlayerStats);
            this.Controls.Add(this.button_addEvent);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_addMatch);
            this.Controls.Add(this.label_welcome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "DataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button_addMatch;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_addEvent;
        private System.Windows.Forms.Button button_addPlayerStats;
    }
}
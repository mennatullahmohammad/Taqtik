namespace Taqtik
{
    partial class PlayerStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerStats));
            this.comboBox_players = new System.Windows.Forms.ComboBox();
            this.dataGridView_playerstats = new System.Windows.Forms.DataGridView();
            this.label_chooseplayer = new System.Windows.Forms.Label();
            this.label_playerstats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_playerstats)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_players
            // 
            this.comboBox_players.FormattingEnabled = true;
            this.comboBox_players.Location = new System.Drawing.Point(1024, 162);
            this.comboBox_players.Name = "comboBox_players";
            this.comboBox_players.Size = new System.Drawing.Size(340, 48);
            this.comboBox_players.TabIndex = 0;
            // 
            // dataGridView_playerstats
            // 
            this.dataGridView_playerstats.AllowUserToAddRows = false;
            this.dataGridView_playerstats.AllowUserToDeleteRows = false;
            this.dataGridView_playerstats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_playerstats.Location = new System.Drawing.Point(616, 280);
            this.dataGridView_playerstats.Name = "dataGridView_playerstats";
            this.dataGridView_playerstats.ReadOnly = true;
            this.dataGridView_playerstats.RowHeadersWidth = 62;
            this.dataGridView_playerstats.RowTemplate.Height = 28;
            this.dataGridView_playerstats.Size = new System.Drawing.Size(850, 384);
            this.dataGridView_playerstats.TabIndex = 1;
            // 
            // label_chooseplayer
            // 
            this.label_chooseplayer.AutoSize = true;
            this.label_chooseplayer.BackColor = System.Drawing.Color.Transparent;
            this.label_chooseplayer.ForeColor = System.Drawing.Color.White;
            this.label_chooseplayer.Location = new System.Drawing.Point(715, 165);
            this.label_chooseplayer.Name = "label_chooseplayer";
            this.label_chooseplayer.Size = new System.Drawing.Size(263, 40);
            this.label_chooseplayer.TabIndex = 2;
            this.label_chooseplayer.Text = "Choose Player:";
            // 
            // label_playerstats
            // 
            this.label_playerstats.AutoSize = true;
            this.label_playerstats.BackColor = System.Drawing.Color.Transparent;
            this.label_playerstats.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_playerstats.ForeColor = System.Drawing.Color.White;
            this.label_playerstats.Location = new System.Drawing.Point(912, 71);
            this.label_playerstats.Name = "label_playerstats";
            this.label_playerstats.Size = new System.Drawing.Size(343, 59);
            this.label_playerstats.TabIndex = 3;
            this.label_playerstats.Text = "Players Stats";
            // 
            // PlayerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 844);
            this.Controls.Add(this.label_playerstats);
            this.Controls.Add(this.label_chooseplayer);
            this.Controls.Add(this.dataGridView_playerstats);
            this.Controls.Add(this.comboBox_players);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "PlayerStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerStats";
            this.Load += new System.EventHandler(this.PlayerStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_playerstats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_players;
        private System.Windows.Forms.DataGridView dataGridView_playerstats;
        private System.Windows.Forms.Label label_chooseplayer;
        private System.Windows.Forms.Label label_playerstats;
    }
}
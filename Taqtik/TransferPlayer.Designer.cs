namespace Taqtik
{
    partial class TransferPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferPlayer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_player = new System.Windows.Forms.ComboBox();
            this.comboBox_toTeam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_transfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(934, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(824, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player:";
            // 
            // comboBox_player
            // 
            this.comboBox_player.FormattingEnabled = true;
            this.comboBox_player.Location = new System.Drawing.Point(1033, 250);
            this.comboBox_player.Name = "comboBox_player";
            this.comboBox_player.Size = new System.Drawing.Size(318, 44);
            this.comboBox_player.TabIndex = 2;
            // 
            // comboBox_toTeam
            // 
            this.comboBox_toTeam.FormattingEnabled = true;
            this.comboBox_toTeam.Location = new System.Drawing.Point(1033, 402);
            this.comboBox_toTeam.Name = "comboBox_toTeam";
            this.comboBox_toTeam.Size = new System.Drawing.Size(318, 44);
            this.comboBox_toTeam.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(806, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "To Team:";
            // 
            // button_transfer
            // 
            this.button_transfer.ForeColor = System.Drawing.Color.Black;
            this.button_transfer.Location = new System.Drawing.Point(1033, 551);
            this.button_transfer.Name = "button_transfer";
            this.button_transfer.Size = new System.Drawing.Size(213, 62);
            this.button_transfer.TabIndex = 5;
            this.button_transfer.Text = "Transfer";
            this.button_transfer.UseVisualStyleBackColor = true;
            this.button_transfer.Click += new System.EventHandler(this.button_transfer_Click);
            // 
            // TransferPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 894);
            this.Controls.Add(this.button_transfer);
            this.Controls.Add(this.comboBox_toTeam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_player);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "TransferPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransferPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_player;
        private System.Windows.Forms.ComboBox comboBox_toTeam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_transfer;
    }
}
namespace Taqtik
{
    partial class AddEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEvent));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_player = new System.Windows.Forms.ComboBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.comboBox_event = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_match = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.textBox_sec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(893, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player:";
            // 
            // comboBox_player
            // 
            this.comboBox_player.FormattingEnabled = true;
            this.comboBox_player.Location = new System.Drawing.Point(1046, 215);
            this.comboBox_player.Name = "comboBox_player";
            this.comboBox_player.Size = new System.Drawing.Size(293, 48);
            this.comboBox_player.TabIndex = 1;
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.Transparent;
            this.button_Add.ForeColor = System.Drawing.Color.Black;
            this.button_Add.Location = new System.Drawing.Point(1072, 568);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(192, 77);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            // 
            // comboBox_event
            // 
            this.comboBox_event.FormattingEnabled = true;
            this.comboBox_event.Location = new System.Drawing.Point(1046, 299);
            this.comboBox_event.Name = "comboBox_event";
            this.comboBox_event.Size = new System.Drawing.Size(293, 48);
            this.comboBox_event.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(893, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event:";
            // 
            // comboBox_match
            // 
            this.comboBox_match.FormattingEnabled = true;
            this.comboBox_match.Location = new System.Drawing.Point(1046, 381);
            this.comboBox_match.Name = "comboBox_match";
            this.comboBox_match.Size = new System.Drawing.Size(293, 48);
            this.comboBox_match.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(893, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Match:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(893, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "Min:";
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(1001, 466);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(100, 48);
            this.textBox_min.TabIndex = 8;
            // 
            // textBox_sec
            // 
            this.textBox_sec.Location = new System.Drawing.Point(1239, 469);
            this.textBox_sec.Name = "textBox_sec";
            this.textBox_sec.Size = new System.Drawing.Size(100, 48);
            this.textBox_sec.TabIndex = 10;
            this.textBox_sec.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1128, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sec:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1037, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 52);
            this.label6.TabIndex = 11;
            this.label6.Text = "Add Event";
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 894);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_sec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_match);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_event);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.comboBox_player);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "AddEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Event";
            this.Load += new System.EventHandler(this.Add_Event_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_player;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ComboBox comboBox_event;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_match;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.TextBox textBox_sec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
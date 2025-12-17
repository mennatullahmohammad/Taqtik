namespace Taqtik
{
    partial class TeamStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamStats));
            this.dataGridView_teamstats = new System.Windows.Forms.DataGridView();
            this.label_userteam = new System.Windows.Forms.Label();
            this.label_stats = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_teamstats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_teamstats
            // 
            this.dataGridView_teamstats.AllowUserToAddRows = false;
            this.dataGridView_teamstats.AllowUserToDeleteRows = false;
            this.dataGridView_teamstats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_teamstats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_teamstats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_teamstats.Location = new System.Drawing.Point(590, 178);
            this.dataGridView_teamstats.Name = "dataGridView_teamstats";
            this.dataGridView_teamstats.ReadOnly = true;
            this.dataGridView_teamstats.RowHeadersWidth = 62;
            this.dataGridView_teamstats.RowTemplate.Height = 28;
            this.dataGridView_teamstats.Size = new System.Drawing.Size(876, 557);
            this.dataGridView_teamstats.TabIndex = 0;
            this.dataGridView_teamstats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_teamstats_CellContentClick);
            // 
            // label_userteam
            // 
            this.label_userteam.AutoSize = true;
            this.label_userteam.BackColor = System.Drawing.Color.Transparent;
            this.label_userteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userteam.ForeColor = System.Drawing.Color.White;
            this.label_userteam.Location = new System.Drawing.Point(767, 74);
            this.label_userteam.Name = "label_userteam";
            this.label_userteam.Size = new System.Drawing.Size(309, 52);
            this.label_userteam.TabIndex = 1;
            this.label_userteam.Text = "//user\'s team//";
            this.label_userteam.Click += new System.EventHandler(this.label_userteam_Click);
            // 
            // label_stats
            // 
            this.label_stats.AutoSize = true;
            this.label_stats.BackColor = System.Drawing.Color.Transparent;
            this.label_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stats.ForeColor = System.Drawing.Color.White;
            this.label_stats.Location = new System.Drawing.Point(1175, 74);
            this.label_stats.Name = "label_stats";
            this.label_stats.Size = new System.Drawing.Size(139, 52);
            this.label_stats.TabIndex = 2;
            this.label_stats.Text = "Stats:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(32, 190);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(552, 338);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // TeamStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 894);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label_stats);
            this.Controls.Add(this.label_userteam);
            this.Controls.Add(this.dataGridView_teamstats);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "TeamStats";
            this.Text = "TeamStats";
            this.Load += new System.EventHandler(this.TeamStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_teamstats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_teamstats;
        private System.Windows.Forms.Label label_userteam;
        private System.Windows.Forms.Label label_stats;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
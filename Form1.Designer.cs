namespace MovieAPI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.AddWatchList_btn = new System.Windows.Forms.Button();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.WatchListBox = new System.Windows.Forms.ListBox();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.PosterPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ToggleModeButton = new System.Windows.Forms.Button();
            this.FavoritesListBox = new System.Windows.Forms.ListBox();
            this.AddFavorites_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.StaticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ShowStatsButton = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PosterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaticsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchTextBox.Location = new System.Drawing.Point(50, 135);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(174, 51);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(229, 129);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(68, 35);
            this.Search_btn.TabIndex = 1;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // AddWatchList_btn
            // 
            this.AddWatchList_btn.Location = new System.Drawing.Point(606, 180);
            this.AddWatchList_btn.Name = "AddWatchList_btn";
            this.AddWatchList_btn.Size = new System.Drawing.Size(195, 30);
            this.AddWatchList_btn.TabIndex = 2;
            this.AddWatchList_btn.Text = "Add to Watchlist -->";
            this.AddWatchList_btn.UseVisualStyleBackColor = true;
            this.AddWatchList_btn.Click += new System.EventHandler(this.AddWatchList_btn_Click);
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 25;
            this.MovieListBox.Location = new System.Drawing.Point(49, 231);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(248, 379);
            this.MovieListBox.TabIndex = 3;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // WatchListBox
            // 
            this.WatchListBox.FormattingEnabled = true;
            this.WatchListBox.ItemHeight = 25;
            this.WatchListBox.Location = new System.Drawing.Point(833, 131);
            this.WatchListBox.Name = "WatchListBox";
            this.WatchListBox.Size = new System.Drawing.Size(187, 129);
            this.WatchListBox.TabIndex = 4;
            this.WatchListBox.SelectedIndexChanged += new System.EventHandler(this.WatchListBox_SelectedIndexChanged);
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.DetailsLabel.Location = new System.Drawing.Point(324, 482);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(242, 138);
            this.DetailsLabel.TabIndex = 5;
            // 
            // PosterPictureBox
            // 
            this.PosterPictureBox.InitialImage = null;
            this.PosterPictureBox.Location = new System.Drawing.Point(324, 131);
            this.PosterPictureBox.Name = "PosterPictureBox";
            this.PosterPictureBox.Size = new System.Drawing.Size(242, 332);
            this.PosterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PosterPictureBox.TabIndex = 6;
            this.PosterPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // ToggleModeButton
            // 
            this.ToggleModeButton.Location = new System.Drawing.Point(910, 12);
            this.ToggleModeButton.Name = "ToggleModeButton";
            this.ToggleModeButton.Size = new System.Drawing.Size(132, 30);
            this.ToggleModeButton.TabIndex = 7;
            this.ToggleModeButton.Text = "Switch Theme";
            this.ToggleModeButton.UseVisualStyleBackColor = true;
            this.ToggleModeButton.Click += new System.EventHandler(this.ToggleModeButton_Click);
            // 
            // FavoritesListBox
            // 
            this.FavoritesListBox.FormattingEnabled = true;
            this.FavoritesListBox.ItemHeight = 25;
            this.FavoritesListBox.Location = new System.Drawing.Point(833, 294);
            this.FavoritesListBox.Name = "FavoritesListBox";
            this.FavoritesListBox.Size = new System.Drawing.Size(187, 129);
            this.FavoritesListBox.TabIndex = 8;
            this.FavoritesListBox.SelectedIndexChanged += new System.EventHandler(this.FavoritesListBox_SelectedIndexChanged);
            // 
            // AddFavorites_btn
            // 
            this.AddFavorites_btn.Location = new System.Drawing.Point(617, 345);
            this.AddFavorites_btn.Name = "AddFavorites_btn";
            this.AddFavorites_btn.Size = new System.Drawing.Size(195, 30);
            this.AddFavorites_btn.TabIndex = 9;
            this.AddFavorites_btn.Text = "Add to Favorites -->";
            this.AddFavorites_btn.UseVisualStyleBackColor = true;
            this.AddFavorites_btn.Click += new System.EventHandler(this.AddFavorites_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(402, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 60);
            this.label3.TabIndex = 10;
            this.label3.Text = "Movie Search App";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(830, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Watch List";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(841, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Favorites List";
            // 
            // SortComboBox
            // 
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Items.AddRange(new object[] {
            "Sort By...",
            "Year",
            "Title"});
            this.SortComboBox.Location = new System.Drawing.Point(49, 192);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(175, 33);
            this.SortComboBox.TabIndex = 13;
            // 
            // StaticsChart
            // 
            chartArea2.Name = "ChartArea1";
            this.StaticsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.StaticsChart.Legends.Add(legend2);
            this.StaticsChart.Location = new System.Drawing.Point(617, 504);
            this.StaticsChart.Name = "StaticsChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.StaticsChart.Series.Add(series2);
            this.StaticsChart.Size = new System.Drawing.Size(403, 218);
            this.StaticsChart.TabIndex = 14;
            this.StaticsChart.Text = "chart1";
            this.StaticsChart.Click += new System.EventHandler(this.StaticsChart_Click);
            // 
            // ShowStatsButton
            // 
            this.ShowStatsButton.Location = new System.Drawing.Point(50, 646);
            this.ShowStatsButton.Name = "ShowStatsButton";
            this.ShowStatsButton.Size = new System.Drawing.Size(247, 48);
            this.ShowStatsButton.TabIndex = 15;
            this.ShowStatsButton.Text = "Show Statics";
            this.ShowStatsButton.UseVisualStyleBackColor = true;
            this.ShowStatsButton.Click += new System.EventHandler(this.ShowStatsButton_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(637, 414);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(163, 48);
            this.Clear_btn.TabIndex = 16;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1499, 998);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.ShowStatsButton);
            this.Controls.Add(this.StaticsChart);
            this.Controls.Add(this.SortComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddFavorites_btn);
            this.Controls.Add(this.FavoritesListBox);
            this.Controls.Add(this.ToggleModeButton);
            this.Controls.Add(this.PosterPictureBox);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.WatchListBox);
            this.Controls.Add(this.MovieListBox);
            this.Controls.Add(this.AddWatchList_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.SearchTextBox);
            this.Name = "Form1";
            this.Text = "Movie API";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PosterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaticsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button AddWatchList_btn;
        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.ListBox WatchListBox;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.PictureBox PosterPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ToggleModeButton;
        private System.Windows.Forms.ListBox FavoritesListBox;
        private System.Windows.Forms.Button AddFavorites_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SortComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart StaticsChart;
        private System.Windows.Forms.Button ShowStatsButton;
        private System.Windows.Forms.Button Clear_btn;
    }
}

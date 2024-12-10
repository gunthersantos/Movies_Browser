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
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.PosterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchTextBox.Location = new System.Drawing.Point(49, 131);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(174, 35);
            this.SearchTextBox.TabIndex = 0;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(229, 131);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(68, 35);
            this.Search_btn.TabIndex = 1;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(606, 230);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(195, 30);
            this.Add_btn.TabIndex = 2;
            this.Add_btn.Text = "Add to Watchlist -->";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 15;
            this.MovieListBox.Location = new System.Drawing.Point(49, 181);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(248, 439);
            this.MovieListBox.TabIndex = 3;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // WatchListBox
            // 
            this.WatchListBox.FormattingEnabled = true;
            this.WatchListBox.ItemHeight = 15;
            this.WatchListBox.Location = new System.Drawing.Point(833, 131);
            this.WatchListBox.Name = "WatchListBox";
            this.WatchListBox.Size = new System.Drawing.Size(187, 229);
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
            this.FavoritesListBox.ItemHeight = 15;
            this.FavoritesListBox.Location = new System.Drawing.Point(833, 399);
            this.FavoritesListBox.Name = "FavoritesListBox";
            this.FavoritesListBox.Size = new System.Drawing.Size(187, 229);
            this.FavoritesListBox.TabIndex = 8;
            this.FavoritesListBox.SelectedIndexChanged += new System.EventHandler(this.FavoritesListBox_SelectedIndexChanged);
            // 
            // AddFavorites_btn
            // 
            this.AddFavorites_btn.Location = new System.Drawing.Point(606, 505);
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
            this.label3.Size = new System.Drawing.Size(321, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Movie Search App";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(830, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Watch List";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(833, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Favorites List";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1067, 672);
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
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.SearchTextBox);
            this.Name = "Form1";
            this.Text = "Movie API";
            ((System.ComponentModel.ISupportInitialize)(this.PosterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Add_btn;
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
    }
}

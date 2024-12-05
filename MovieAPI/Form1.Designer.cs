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
            ((System.ComponentModel.ISupportInitialize)(this.PosterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(50, 50);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(200, 22);
            this.SearchTextBox.TabIndex = 0;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(50, 90);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(100, 30);
            this.Search_btn.TabIndex = 1;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(350, 150);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(150, 30);
            this.Add_btn.TabIndex = 2;
            this.Add_btn.Text = "Add to Watchlist";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 16;
            this.MovieListBox.Location = new System.Drawing.Point(50, 130);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(200, 100);
            this.MovieListBox.TabIndex = 3;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // WatchListBox
            // 
            this.WatchListBox.FormattingEnabled = true;
            this.WatchListBox.ItemHeight = 16;
            this.WatchListBox.Location = new System.Drawing.Point(350, 50);
            this.WatchListBox.Name = "WatchListBox";
            this.WatchListBox.Size = new System.Drawing.Size(200, 68);
            this.WatchListBox.TabIndex = 4;
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DetailsLabel.Location = new System.Drawing.Point(50, 250);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(500, 100);
            this.DetailsLabel.TabIndex = 5;
            // 
            // PosterPictureBox
            // 
            this.PosterPictureBox.Location = new System.Drawing.Point(602, 50);
            this.PosterPictureBox.Name = "PosterPictureBox";
            this.PosterPictureBox.Size = new System.Drawing.Size(200, 300);
            this.PosterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PosterPictureBox.TabIndex = 6;
            this.PosterPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1290, 582);
            this.Controls.Add(this.PosterPictureBox);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.WatchListBox);
            this.Controls.Add(this.MovieListBox);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.SearchTextBox);
            this.Name = "Form1";
            this.Text = "Movie Browser";
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
    }
}

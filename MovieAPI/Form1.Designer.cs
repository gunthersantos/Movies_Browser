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
            ((System.ComponentModel.ISupportInitialize)(this.PosterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchTextBox.Location = new System.Drawing.Point(55, 113);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(197, 29);
            this.SearchTextBox.TabIndex = 0;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(258, 113);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(68, 30);
            this.Search_btn.TabIndex = 1;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(376, 573);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(234, 30);
            this.Add_btn.TabIndex = 2;
            this.Add_btn.Text = "Add to Watchlist -->";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 12;
            this.MovieListBox.Location = new System.Drawing.Point(55, 155);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(269, 448);
            this.MovieListBox.TabIndex = 3;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // WatchListBox
            // 
            this.WatchListBox.FormattingEnabled = true;
            this.WatchListBox.ItemHeight = 12;
            this.WatchListBox.Location = new System.Drawing.Point(659, 143);
            this.WatchListBox.Name = "WatchListBox";
            this.WatchListBox.Size = new System.Drawing.Size(200, 460);
            this.WatchListBox.TabIndex = 4;
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DetailsLabel.Location = new System.Drawing.Point(376, 454);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(234, 112);
            this.DetailsLabel.TabIndex = 5;
            // 
            // PosterPictureBox
            // 
            this.PosterPictureBox.Location = new System.Drawing.Point(376, 113);
            this.PosterPictureBox.Name = "PosterPictureBox";
            this.PosterPictureBox.Size = new System.Drawing.Size(234, 331);
            this.PosterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PosterPictureBox.TabIndex = 6;
            this.PosterPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(655, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Watch List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(331, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Movie Search App";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(923, 650);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization;
using System.Text.Json;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;

namespace MovieAPI
{
    public partial class Form1 : Form
    {
        private readonly MovieAPIService movieAPI = new MovieAPIService();
        private List<Movie> movies = new List<Movie>();
        private readonly List<string> watchlist = new List<string>();
        private readonly List<string> favorites = new List<string>();
        private bool isDarkMode = false;
        private int totalMoviesSearched = 0;
        private Dictionary<string, int> genreCounts = new Dictionary<string, int>();
        public System.Windows.Forms.DataVisualization.Charting.Chart StatisticsChart { get; private set; }
        private SaveList saveListManager = new SaveList();
        
        public Form1()
        {
            InitializeComponent();
            SortComboBox.SelectedIndex = 0;
            SortComboBox.SelectedIndexChanged += SortComboBox_SelectedIndexChanged;
        }


        public class Movie
        {
            public string Title { get; set; }
            public string Year { get; set; }
            public string ImdbID { get; set; }
            public string Poster { get; set; }
            public string Genre { get; set; }

        }

        public class SaveList
        {
            private readonly string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            public string WatchListFilePath => Path.Combine(AppDataPath, "WatchList.json");
            public string FavoritesListFilePath => Path.Combine(AppDataPath, "Favorites.json");
            public void SaveToFile<T>(string filePath, T data)
            {
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }          

            public List<Movie> LoadFromFile(string filePath)
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<List<Movie>>(json) ?? new List<Movie>();
                }
                return new List<Movie>();
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            var loadedWatchList = saveListManager.LoadFromFile(saveListManager.WatchListFilePath);
            foreach (var movie in loadedWatchList)
            {
                string movieEntry = $"{movie.Title} ({movie.Year})";
                if (!WatchListBox.Items.Contains(movieEntry))
                {
                    WatchListBox.Items.Add(movieEntry);
                }
            }

            var loadedFavorites = saveListManager.LoadFromFile(saveListManager.FavoritesListFilePath);
            foreach (var movie in loadedFavorites)
            {
                string movieEntry = $"{movie.Title} ({movie.Year})";
                if (!FavoritesListBox.Items.Contains(movieEntry))
                {
                    FavoritesListBox.Items.Add(movieEntry);
                }
            }
        }
        

        
        private List<Movie> ParseMovies(string result)
        {
            var json = JsonConvert.DeserializeObject<dynamic>(result);
            var movieList = new List<Movie>();

            if (json?.Search != null)
            {
                foreach (var item in json.Search)
                {
                    movieList.Add(new Movie
                    {
                        Title = item.Title,
                        Year = item.Year,
                        ImdbID = item.imdbID,
                        Poster = item.Poster,
                        Genre = item.Genre ?? "Unknown"


                    });
                }
            }

            return movieList;
        }

        private async void Search_btn_Click(object sender, EventArgs e)
        {
            string query = SearchTextBox.Text.Trim();

            try
            {
                string result = await movieAPI.SearchMoviesAsync(query);
                movies = ParseMovies(result);
                totalMoviesSearched++;
                MovieListBox.Items.Clear();


                foreach (var movie in movies)
                {
                    MovieListBox.Items.Add($"{movie.Title} ({movie.Year})");
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching movies: {ex.Message}");
            }
        }

        private void AddWatchList_btn_Click(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedIndex >= 0)
            {
                var selectedMovie = movies[MovieListBox.SelectedIndex];
                string movieEntry = $"{selectedMovie.Title} ({selectedMovie.Year})";

                if (!watchlist.Contains(movieEntry))
                {
                    watchlist.Add(movieEntry);
                    WatchListBox.Items.Add(movieEntry);

                    var movie = new Movie
                    {
                        Title = selectedMovie.Title,
                        Year = selectedMovie.Year,
                        ImdbID = selectedMovie.ImdbID,
                        Poster = selectedMovie.Poster,
                        Genre = selectedMovie.Genre
                    };                  

                    MessageBox.Show("Movie added to Favorites!");

                }
                else
                {
                    MessageBox.Show("Movie already in favorites!");
                }
            }
          
        }
        private void AddFavorites_btn_Click(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedIndex >= 0)
            {
                var selectedMovie = movies[MovieListBox.SelectedIndex];
                string movieEntry = $"{selectedMovie.Title} ({selectedMovie.Year})";

                if (!favorites.Contains(movieEntry))
                {
                    favorites.Add(movieEntry);
                    FavoritesListBox.Items.Add(movieEntry);

                    var movie = new Movie
                    {
                        Title = selectedMovie.Title,
                        Year = selectedMovie.Year,
                        ImdbID = selectedMovie.ImdbID,
                        Poster = selectedMovie.Poster,
                        Genre = selectedMovie.Genre
                    };                                    

                    MessageBox.Show("Movie added to Favorites!");

                }
                else
                {
                    MessageBox.Show("Movie already in favorites!");
                }
            }
        }

        private async void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedIndex >= 0)
            {
                var selectedMovie = movies[MovieListBox.SelectedIndex];
                try
                {
                    PosterPictureBox.Load(selectedMovie.Poster);
                }
                catch
                {
                    PosterPictureBox.Image = null;
                }
                string imdbId = selectedMovie.ImdbID;
                try
                {
                    string details = await movieAPI.GetMovieDetailsAsync(imdbId);
                    DisplayMovieDetails(details);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching movie details: {ex.Message}");
                }
            }
        }

        private void DisplayMovieDetails(string details)
        {
            var movieDetails = JsonConvert.DeserializeObject<dynamic>(details);

            if (movieDetails.Response == "True")
            {
                DetailsLabel.Text = $"Title: {movieDetails.Title}\n" +
                                    $"Year: {movieDetails.Year}\n" +
                                    $"Genre: {movieDetails.Genre}\n" +
                                    $"Plot: {movieDetails.Plot}";
            }
            else
            {
                MessageBox.Show($"Error: {movieDetails.Error}");
            }
        }
        private void ToggleModeButton_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            ApplyMode();
        }
        private void ApplyMode()
        {
            if (isDarkMode)
            {
                this.BackColor = Color.LightBlue;
                this.ForeColor = Color.LightBlue;
                SearchTextBox.BackColor = Color.LightPink;
                SearchTextBox.ForeColor = Color.White;
                MovieListBox.BackColor = Color.LightPink;
                MovieListBox.ForeColor = Color.White;
                WatchListBox.BackColor = Color.LightPink;
                WatchListBox.ForeColor = Color.White;
                FavoritesListBox.BackColor = Color.LightPink;
                FavoritesListBox.ForeColor = Color.White;
                DetailsLabel.BackColor = Color.LightPink;
                DetailsLabel.ForeColor = Color.White;
                label3.BackColor = Color.LightPink;
                label3.ForeColor = Color.White;
                label4.BackColor = Color.LightPink;
                label4.ForeColor = Color.White;
                label5.BackColor = Color.LightPink;
                label5.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                SearchTextBox.BackColor = Color.White;
                SearchTextBox.ForeColor = Color.Black;
                MovieListBox.BackColor = Color.White;
                MovieListBox.ForeColor = Color.Black;
                WatchListBox.BackColor = Color.White;
                WatchListBox.ForeColor = Color.Black;
                FavoritesListBox.BackColor = Color.White;
                FavoritesListBox.ForeColor = Color.Black;
                DetailsLabel.BackColor = Color.White;
                DetailsLabel.ForeColor = Color.Black;
                label3.BackColor = Color.White;
                label3.ForeColor = Color.Black;
                label4.BackColor = Color.White;
                label4.ForeColor = Color.Black;
                label5.BackColor = Color.White;
                label5.ForeColor = Color.Black;
            }
        }
        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedOption = SortComboBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(selectedOption)) return;

            switch (selectedOption)
            {
                case "Title":
                    movies.Sort((x, y) => string.Compare(x.Title, y.Title, StringComparison.OrdinalIgnoreCase));
                    break;
                case "Year":
                    movies.Sort((x, y) => string.Compare(x.Year, y.Year, StringComparison.OrdinalIgnoreCase));
                    break;
            }

            MovieListBox.Items.Clear();
            foreach (var movie in movies)
            {
                MovieListBox.Items.Add($"{movie.Title} ({movie.Year})");
            }
        }

        private void ShowStatsButton_Click(object sender, EventArgs e)
        {
           
            int watchListCount = watchlist.Count;
            int favoritesCount = favorites.Count;

           
            var watchlistGenres = watchlist
                .Select(movie => movies.FirstOrDefault(m => $"{m.Title} ({m.Year})" == movie)?.Genre)
                .Where(genre => !string.IsNullOrEmpty(genre))
                .Distinct();

            var favoritesGenres = favorites
                .Select(movie => movies.FirstOrDefault(m => $"{m.Title} ({m.Year})" == movie)?.Genre)
                .Where(genre => !string.IsNullOrEmpty(genre))
                .Distinct();

           
            StaticsChart.Series.Clear();

          
            var watchlistSeries = StaticsChart.Series.Add("WatchList");
            var favoritesSeries = StaticsChart.Series.Add("Favorites");

            watchlistSeries.Points.AddXY("WatchList", watchListCount);
            favoritesSeries.Points.AddXY("Favorites", favoritesCount);

            
            var watchlistGenresSeries = StaticsChart.Series.Add("WatchListGenres");
            watchlistGenresSeries.Points.AddXY("Genres", watchlistGenres.Count());

            var favoritesGenresSeries = StaticsChart.Series.Add("FavoritesGenres");
            favoritesGenresSeries.Points.AddXY("Genres", favoritesGenres.Count());

            StaticsChart.ChartAreas[0].AxisX.Title = "List Types";
            StaticsChart.ChartAreas[0].AxisY.Title = "Count";

            
            watchlistSeries.Color = Color.Blue;
            favoritesSeries.Color = Color.Green;
            watchlistGenresSeries.Color = Color.Orange;
            favoritesGenresSeries.Color = Color.Red;

           
            watchlistSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            favoritesSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            watchlistGenresSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            favoritesGenresSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

        }
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            
            WatchListBox.Items.Clear();
            FavoritesListBox.Items.Clear();

            watchlist.Clear();
            favorites.Clear();

            MessageBox.Show("Watchlist and Favorites have been cleared.");
        }
        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void FavoritesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WatchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }       

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StaticsChart_Click(object sender, EventArgs e)
        {

        }

       
    }
}


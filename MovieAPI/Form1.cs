using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MovieAPI
{
    public partial class Form1 : Form
    {
        private readonly MovieAPIService movieAPI = new MovieAPIService(); // Corrected instance
        private List<Movie> movies = new List<Movie>(); // List to store movies returned by the search
        private readonly List<string> watchlist = new List<string>(); // List to store movies added to the watchlist
        private List<string> favoriteMovies = new List<string>(); // List to store favorite movies

        public Form1()
        {
            InitializeComponent();
        }

        // Movie class to store movie information
        public class Movie
        {
            public string Title { get; set; }
            public string Year { get; set; }
            public string ImdbID { get; set; }
            public string Poster { get; set; } // URL of the movie poster
        }

        // Method to validate user input
        private bool ValidateInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Search query cannot be empty.");
                return false;
            }
            return true;
        }

        // Method to parse movies returned by the API
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
                        Poster = item.Poster
                    });
                }
            }

            return movieList;
        }

        // Event to search for movies
        private async void Search_btn_Click(object sender, EventArgs e)
        {
            string query = SearchTextBox.Text.Trim();
            if (!ValidateInput(query)) return;

            try
            {
                string result = await movieAPI.SearchMoviesAsync(query);
                movies = ParseMovies(result);

                MovieListBox.Items.Clear();

                if (movies.Count == 0)
                {
                    MessageBox.Show("No movies found for the given query.");
                    return;
                }

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

        // Event to display movie details and the poster
        private async void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedIndex < 0) return;

            var selectedMovie = movies[MovieListBox.SelectedIndex];

            try
            {
                LoadPoster(selectedMovie.Poster);

                string details = await movieAPI.GetMovieDetailsAsync(selectedMovie.ImdbID);
                DisplayMovieDetails(details);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching movie details: {ex.Message}");
            }
        }

        // Method to load the movie poster
        private void LoadPoster(string posterUrl)
        {
            try
            {
                PosterPictureBox.Load(posterUrl);
            }
            catch
            {
                PosterPictureBox.Image = null;
            }
        }

        // Method to display movie details in the user interface
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

        // Event to add a movie to the watchlist
        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedIndex < 0) return;

            var selectedMovie = movies[MovieListBox.SelectedIndex];
            string movieEntry = $"{selectedMovie.Title} ({selectedMovie.Year})";

            if (!watchlist.Contains(movieEntry))
            {
                watchlist.Add(movieEntry);
                WatchListBox.Items.Add(movieEntry);
            }
            else
            {
                MessageBox.Show("Movie already in watchlist!");
            }
        }

        // Method to update the favorites display
        private void UpdateFavoritesDisplay()
        {
            FavoritesListBox.Items.Clear();
            foreach (string movie in favoriteMovies)
            {
                FavoritesListBox.Items.Add(movie);
            }
        }

        /*
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize form components or states
        }
        */

        private void label1_Click(object sender, EventArgs e)
        {
            // Placeholder for label click event
        }
    }
}

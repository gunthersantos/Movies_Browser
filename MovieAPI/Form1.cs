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
        private readonly MovieAPIService movieAPI = new MovieAPIService(); // Instância corrigida
        private List<Movie> movies = new List<Movie>(); // Lista para armazenar os filmes retornados pela pesquisa
        private readonly List<string> watchlist = new List<string>(); // Lista para armazenar filmes adicionados à lista de observação

        public Form1()
        {
            InitializeComponent();
        }

        // Classe Movie para armazenar informações dos filmes
        public class Movie
        {
            public string Title { get; set; }
            public string Year { get; set; }
            public string ImdbID { get; set; }
            public string Poster { get; set; } // URL do encarte do filme
        }

        // Método para analisar os filmes retornados pela API
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
                        Poster = item.Poster // Captura o URL do encarte
                    });
                }
            }

            return movieList;
        }

        // Evento para pesquisar filmes
        private async void Search_btn_Click(object sender, EventArgs e)
        {
            string query = SearchTextBox.Text.Trim();
            try
            {
                string result = await movieAPI.SearchMoviesAsync(query);
                movies = ParseMovies(result); // Analisa o JSON em uma lista de objetos Movie
                MovieListBox.Items.Clear();

                // Adiciona os filmes à ListBox
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

        // Evento para exibir os detalhes do filme e o encarte
        private async void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedIndex >= 0) // Verifica se há um item selecionado
            {
                var selectedMovie = movies[MovieListBox.SelectedIndex]; // Obtém o filme da lista usando o índice

                // Exibe o encarte no PictureBox
                try
                {
                    PosterPictureBox.Load(selectedMovie.Poster);
                }
                catch
                {
                    PosterPictureBox.Image = null; // Caso a URL do encarte seja inválida
                }

                // Carrega os detalhes do filme
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

        // Método para exibir os detalhes do filme na interface do usuário
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

        // Evento para adicionar filme à watchlist
        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (MovieListBox.SelectedIndex >= 0)
            {
                var selectedMovie = movies[MovieListBox.SelectedIndex]; // Usa o índice para acessar o filme
                string movieEntry = $"{selectedMovie.Title} ({selectedMovie.Year})";

                if (!watchlist.Contains(movieEntry))
                {
                    watchlist.Add(movieEntry);
                    WatchListBox.Items.Add(movieEntry); // Adiciona o filme à ListBox de watchlist
                }
                else
                {
                    MessageBox.Show("Movie already in watchlist!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

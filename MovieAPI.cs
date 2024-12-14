using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieAPI
{
    public class MovieAPIService
    {
        private readonly string apiKey = "f64f081"; 
        private readonly HttpClient httpClient = new HttpClient();

        public async Task<string> SearchMoviesAsync(string query)
        {
            string url = $"http://www.omdbapi.com/?s={query}&apikey={apiKey}";
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetMovieDetailsAsync(string imdbID)
        {
            string url = $"http://www.omdbapi.com/?i={imdbID}&apikey={apiKey}";
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        //internal IEnumerable<object> GetMovieGenres(string imdbID)
        public async Task<IEnumerable<string>> GetMovieGenres1(string imdbID)
        {
            // return new List<object> {"Action", "Comedy", "Drama" };
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://api.example.com/movie/{imdbID}/genres";
                var response = await client.GetStringAsync(url);
                var genres = JsonConvert.DeserializeObject<List<string>>(response); // Deserialize JSON
                return genres;
            }
        }

        internal IEnumerable<object> GetMovieGenres(string imdbID)
        {
            return new List<object> {"Action", "Comedy", "Drama" };

        }
    }
}

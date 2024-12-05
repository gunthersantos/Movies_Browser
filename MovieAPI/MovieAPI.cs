using System.Net.Http;
using System.Threading.Tasks;

namespace MovieAPI
{
    public class MovieAPIService
    {
        private readonly string apiKey = "f64f081"; // Substitua pela sua chave válida
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
    }
}

using System.Text;
using ProjectMoviesDiasteros.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;

namespace ProjectMoviesDiasteros.Client.Services
{
    public class ServiceMovie : IServiceMovie
    {
        private readonly HttpClient httpClient;
        
        public ServiceMovie(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        private JsonSerializerOptions OptionsDefaultJSON => new JsonSerializerOptions(){PropertyNameCaseInsensitive = true};

        /* Método Cear */
        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T send)
        {
            var sendJSON = JsonSerializer.Serialize(send);
            var sendContent = new StringContent(sendJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, sendContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }
        public async Task<T> DeserializeResponse<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
        }

        public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T send)
        {
            var sendJSON = JsonSerializer.Serialize(send);
            var sendContent = new StringContent(sendJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, sendContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializeResponse<TResponse>(responseHttp, OptionsDefaultJSON);
                return new HttpResponseWrapper<TResponse>(response, false, responseHttp);
            }
            else
            {
                return new HttpResponseWrapper<TResponse>(default, true, responseHttp);
            }
        }

        /* Método Consultar */
        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var responseHTTP = await httpClient.GetAsync(url);
            if (responseHTTP.IsSuccessStatusCode)
            {
                var response = await DeserializeResponse<T>(responseHTTP, OptionsDefaultJSON);
                return new HttpResponseWrapper<T>(response, false, responseHTTP);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, true, responseHTTP);
            }           
        }

        /* Método Modificar */
        public async Task<HttpResponseWrapper<object>> Put<T>(string url, T send)
        {
            var sendJSON = JsonSerializer.Serialize(send);
            var sendContent = new StringContent(sendJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PutAsync(url, sendContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        /* Método Eliminar */
        public async Task<HttpResponseWrapper<object>> Delete(string url)
        {
            var responseHttp = await httpClient.DeleteAsync(url);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }
                 
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie(){Id=1, Name="Movie 1", Sinopsis="De que trata..", Poster="/Images/Movies/movie1.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=2, Name="Movie 2", Sinopsis="De que trata..", Poster="/Images/Movies/movie2.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=3, Name="Movie 3", Sinopsis="De que trata..", Poster="/Images/Movies/movie3.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=4, Name="Movie 4", Sinopsis="De que trata..", Poster="/Images/Movies/movie4.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=5, Name="Movie 5", Sinopsis="De que trata..", Poster="/Images/Movies/movie5.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=6, Name="Movie 6", Sinopsis="De que trata..", Poster="/Images/Movies/movie6.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=7, Name="Movie 7", Sinopsis="De que trata..", Poster="/Images/Movies/movie7.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=8, Name="Movie 8", Sinopsis="De que trata..", Poster="/Images/Movies/movie8.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=9, Name="Movie 9", Sinopsis="De que trata..", Poster="/Images/Movies/movie9.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=10, Name="Movie 10", Sinopsis="De que trata..", Poster="/Images/Movies/movie10.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=11, Name="Movie 11", Sinopsis="De que trata..", Poster="/Images/Movies/movie11.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=12, Name="Movie 12", Sinopsis="De que trata..", Poster="/Images/Movies/movie12.jpg", Premier= new DateTime(2021,09,01)}                
            };
        }
    }
}
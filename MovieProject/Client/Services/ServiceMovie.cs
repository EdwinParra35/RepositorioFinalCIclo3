using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MovieProject.Shared.Entity;

namespace MovieProject.Client.Services
{
    /* implementacion de una interfaz*/
    public class ServiceMovie : IServiceMovie
    {
        private readonly HttpClient httpClient;

        public ServiceMovie(HttpClient httpClient){
            this.httpClient = httpClient;

        }
        private JsonSerializerOptions OpcionesPorDefectoJSON =>new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        
/* METODOS CREAR */
        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }
/* Los siguientes dos métodos nos permitiran obtener el Id de la pelicula que acabo de crear */
        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
        }

      public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<TResponse>(responseHttp, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<TResponse>(response, false, responseHttp);
            }
            else
            {
                return new HttpResponseWrapper<TResponse>(default, true, responseHttp);
            }
        }

        /* METODO CONSULTAR */
     public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var responseHTTP = await httpClient.GetAsync(url);
            if (responseHTTP.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<T>(responseHTTP, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<T>(response, false, responseHTTP);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, true, responseHTTP);
            }
        }
        public async Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PutAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        

        public async Task<HttpResponseWrapper<object>> Delete(string url)
        {
            var responseHTTP = await httpClient.DeleteAsync(url);
            return new HttpResponseWrapper<object>(null, !responseHTTP.IsSuccessStatusCode, responseHTTP);
        }


        public List<Movie> GetMovies(){
            return new List<Movie>{
                new Movie(){Moviename="Together",MovieImage="/Images/movie_1.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Kathapulta",MovieImage="/Images/movie_2.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="El Escuadron Suicida",MovieImage="/Images/movie_3.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Joker",MovieImage="/Images/movie_4.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Venom",MovieImage="/Images/movie_5.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Nuevas leyendas",MovieImage="/Images/movie_6.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Luca",MovieImage="/Images/movie_7.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Free Guy",MovieImage="/Images/movie_8.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Jungle Cruise",MovieImage="/Images/movie_9.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Moviename="Kate",MovieImage="/Images/movie_10.jpg",Sinopsis="Un esposo y una esposa se ven obligados a reevaluarse a sí mismos y a su relación a través de la realidad del bloqueo de Covid19",Score=100,Premier=new DateTime(2021,09,24)}
            };
        }
    }
}
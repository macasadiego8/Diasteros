using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Globalization;
using ProjectMovies5.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjectMovies5.Client.Services
{
    public class ServiceMovie : IServiceMovie
    {
        private readonly HttpClient httpClient;

        public ServiceMovie(HttpClient httpClient)
        {
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

        public List<Movie>GetMovies()
        {
            return new List<Movie>()
            {
                new Movie(){Id=0,Name="El Escuadrón Suicida.",EnCartelera=true, Sinopsis="Un grupo de super villanos se encuentran encerrados en Belle Reve, una prisión de alta seguridad con la tasa de mortalidad más alta de Estados Unidos. Para salir de allí harán cualquier cosa, incluso unirse al grupo Task Force X, dedicado a llevar a cabo misiones suicidas bajo las órdenes de Amanda Waller. Fuertemente armados son enviados a la isla Corto Maltese, una jungla repleta de enemigos.", Poster="/Images/Movies/movie1.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Id=1,Name="Free Guy 2.",EnCartelera=true, Sinopsis="Guy (Ryan Reynolds) trabaja como cajero de un banco, y es un tipo alegre y solitario al que nada la amarga el día. Incluso si le utilizan como rehén durante un atraco a su banco, él sigue sonriendo como si nada. Pero un día se da cuenta de que Free City no es exactamente la ciudad que él creía. Guy va a descubrir que en realidad es un personaje no jugable dentro de un brutal videojuego.", Poster="/Images/Movies/movie2.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Id=2,Name="Viuda Negra.",EnCartelera=true, Sinopsis="En el trepidante thriller de espías Viuda Negra, de Marvel Studios, Natasha Romanoff, alias Viuda Negra, se enfrenta a las partes más oscuras de su historia cuando surge una peligrosa conspiración con vínculos con su pasado. Perseguida por una fuerza que no se detendrá ante nada para acabar con ella, Natasha debe enfrentarse a su historia como espía y a las relaciones rotas que dejó a su paso mucho antes de convertirse en una Vengadora.", Poster="/Images/Movies/movie3.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Id=3,Name="La Patrulla Canina.",EnCartelera=true, Sinopsis="Protagonizada por 6 heroicos cachorros: Chase, Marshall, Rocky, Zuma, Rubble y Skye, que son entrenados y dirigidos por Ryder, un niño de 10 años que los rescató y les enseñó a utilizar sus habilidades para ayudar a los demás, formando la patrulla canina.", Poster="/Images/Movies/movie4.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Id=4,Name="Un Jefe en Pañales.",EnCartelera=true, Sinopsis="En la secuela de la comedia animada Un Jefe en Pañales 2: Negocios de Familia de Dreamworks nominada al Oscar, los hermanos Templeton - Tim (James Marsden, de la franquicia de X-Men) y su hermanito Ted (Alec Baldwin) - se han convertido en adultos que se han alejado el uno del otro. Tim es ahora un padre de familia. Ted es un líder y CEO. Pero una nueva jefa en pañales, con un liderazgo nato está a punto de unirlos nuevamente… e inspirar un nuevo negocio familiar.", Poster="/Images/Movies/movie5.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Id=5,Name="Luca.",EnCartelera=true, Sinopsis="Ambientada en un bonito pueblo costero de la Riviera italiana, Luca, una película original de Disney y Pixar, narra el paso a la madurez de un muchacho durante un verano inolvidable en el que abundan el helado, la pasta e interminables excursiones en escúter. Luca (voz de Jacob Tremblay) comparte esas aventuras con su nuevo mejor amigo, Alberto (voz de Jack Dylan Grazer), pero la diversión se ve amenazada por un gran secreto: son monstruos marinos originarios de un mundo que se oculta bajo el agua.", Poster="/Images/Movies/movie6.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Id=6,Name="Kenshin, El  Guerrero Samurái.",EnCartelera=true, Sinopsis="Kenshin, el guerrero samurái cuenta la historia de Kenshin Himura, un extraordinario guerrero samurái que vive en medio de una sociedad en la que los guerreros se perdieran en el olvido. Japón entra en la era del reinado del emperador Meiji, en pleno cambio a la industrialización y la modernidad, cuando Japón está a punto de convertirse en una potencia mundial.", Poster="/Images/Movies/movie7.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Id=7,Name="Escape Room 2.",EnCartelera=true, Sinopsis="Zoey y Ben han resultado ser los únicos supervivientes del maquiavélico juego puesto en marcha por la compañía Minos. Sin embargo, el peligro no ha acabado para ellos.", Poster="/Images/Movies/movie8.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Id=8,Name="No Respires 2.",EnCartelera=true, Sinopsis="En esta secuela del filme de terror No respires (2016), el ex militar ciego que causó estragos en la primera entrega, volverá a verse envuelto en problemas. En aquella ocasión el hombre consiguió acabar de manera violenta con algunos de los jóvenes que tratan de entrar a robar a su hogar. Ahora, parece que un grupo de amigos ha entrado en su casa, pero con intenciones bien diferentes: van a tratar de tomarse venganza por sus malogrados colegas, en el asalto tiempo atrás.", Poster="/Images/Movies/movie9.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Id=9,Name="After. Almas Perdidas.",EnCartelera=true, Sinopsis="Cuando Tessa (Josephine Langford) toma la decisión más importante de su vida, todo cambia. Los secretos que salen a la luz sobre su familia y la de Hardin (Hero Finnes-Tiffin) ponen en peligro su relación y su futuro juntos. La vida de Tessa empieza a romperse en pedazos y ya nada será como antes. Aunque sabe que Hardin la quiere, estas dos almas perdidas están rodeadas de celos, odio... y perdón. Hasta ahora, el amor era suficiente para mantener su relación a flote, pero ¿de verdad sigue mereciendo la pena?", Poster="/Images/Movies/movie10.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Id=10,Name="Mortal Kombat.",EnCartelera=true, Sinopsis="Mortal Kombat es la nueva adaptación cinematográfica de la famosa saga de videojuegos. La acción sigue a Cole Young, un luchador de MMA acostumbrado a pelear a cambio de dinero, y quien desconoce su importante ascendencia y la valiosa herencia que está a punto de recibir. Este hecho hará que el emperador Shang Tsung de Outworld envíe a su letal guerrero Sub-Zero, un criomante capaz de controlar el hielo para darle caza.", Poster="/Images/Movies/movie11.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Id=11,Name="Expediente Warren.",EnCartelera=true, Sinopsis="Basada en una historia real, Expediente Warren: The Conjuring cuenta la escalofriante historia de cómo Ed y Lorraine Warren, investigadores renombrados en todo el mundo de los fenómenos paranormales, son llamados por una familia aterrorizada por una presencia oscura en una granja aislada.", Poster="/Images/Movies/movie12.jpg", Premier= new DateTime(2021,09,01), },

            };
        }
    }
}

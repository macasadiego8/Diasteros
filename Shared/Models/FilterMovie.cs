using System.Collections.Generic;
using ProjectMoviesDiasteros.Shared.Entity;

namespace ProjectMoviesdiasteros.Shared.Models
{
    public class FilterMovie
    {
        public List<Movie> PeliculasEnCartelera {get; set;}
        public List<Movie> ProximosEstrenos {get; set;}
    }
}
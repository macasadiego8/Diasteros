using System.Collections.Generic;

namespace ProjectMovies5.Shared.Entity
{
    public class FilterMovie
    {
        public List<Movie> PeliculasEnCartelera {get;set;}
        public List<Movie> ProximosEstrenos {get;set;}
       
    }
}
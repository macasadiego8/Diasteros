using System.Collections.Generic;
using ProjectMoviesDiasteros.Shared.Entity;

namespace ProjectMoviesDiasteros.Shared.Models
{
    public class PutMovie
    {
        public Movie Movie {get;set;}
        public List <Actor> Actors {get;set;}
        public List <Category> CategoriasSeleccionadas {get;set;}
        public List <Category> CategoriasNoSeleccionadas {get;set;}        
    }
}
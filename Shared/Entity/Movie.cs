using System;
using ProjectMoviesDiasteros.Shared.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectMoviesDiasteros.Shared.Entity
{
    public class Movie
    {
        public int Id{get;set;}

        [Required(ErrorMessage = "El campo {Name} es requerido")]
        [Display(Name="Nombre de la película")]
        public string Name{get;set;}
        public bool OnBoard{get;set;}

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Sinopsis{get;set;}
        public string Poster{get;set;}

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime? Premier{get;set;}

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Trailer{get;set;}

        public List<CategoryMovie> CategoriesMovies{get;set;} = new List<CategoryMovie>();
        public string ShortName
        {get
            {
            if (string.IsNullOrWhiteSpace(Name))
            {
                return null;
            }
            if (Name.Length > 60)
            {
                return Name.Substring(0,60) + "...";
            }
            else
            {
                return Name;
            }
        }
        
        }
    }
}
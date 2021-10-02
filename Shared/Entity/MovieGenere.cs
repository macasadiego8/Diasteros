using System;
using System.ComponentModel.DataAnnotations;


namespace ProjectMovies5.Shared.Entity
{
    public class MovieGenre
    {
        public int Id{get;set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        public string Name{get;set;}        
    }
}
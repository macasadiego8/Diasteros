using System.IO;
using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ProjectMovies5.Shared.Entity
{
    public class MovieGenre
    {
        public int Id{get;set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        public string Name{get;set;}
        public List <Movie> Movies {get;set;}        
    }
}
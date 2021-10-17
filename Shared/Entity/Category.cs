using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMoviesDiasteros.Shared.Entity
{
    public class Category
    {
        
        public int Id{get;set;}
        
        /* [Display(Name="nombre")] */
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Name{get;set;}
        public List<CategoryMovie> CategoriesMovie{get; set;}        
    }
}

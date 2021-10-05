using System.ComponentModel.DataAnnotations;
using System;
namespace ProjectMovies5.Shared.Entity
{
    public class Actor
    {
        public int Id {get;set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        [StringLength(85, MinimumLength = 2,ErrorMessage = "Elnombre debe tener mínimo 2 caracteres y máximo 85 caracteres")]
        public string Name{get;set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        public DateTime? BirthDate{get;set;}
        [StringLength(85, MinimumLength = 2,ErrorMessage = "la foto debe tener mínimo 2 caracteres y máximo 50 caracteres")]
        public string Photo{get;set;}
        public int KnowCredits {get;set;}
        public string Biography {get;set;}
        public string Nominations {get;set;}
    }
}
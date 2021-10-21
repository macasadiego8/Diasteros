using System;
using System.Text;
using System.Collections.Generic;
using ProjectMoviesDiasteros.Shared.Entity;
using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMoviesDiasteros.Shared.Entity
{
    public class Actor
    {
        public int Id{get;set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        public string Name{get;set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        public DateTime? BirthDate{get;set;}
        public string Photo{get;set;}        
        public int KnowCredits{get;set;}
        public string Biography{get;set;}
        public string Awards{get;set;}
        public string MoviesPerform{get;set;}
        public List<MovieActor> MoviesActor{get; set;}

        public override bool Equals(object obj)
        {
            if (obj is Actor actor2)
            {
                return Id == actor2.Id;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }    
    }             
}
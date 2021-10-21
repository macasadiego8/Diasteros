using System.Collections.Generic;
using ProjectMoviesDiasteros.Shared.Entity;

namespace ProjectMoviesDiasteros.Shared.Models
{
    public class ViewMovie
    {
        public ViewMovie Movie{get;set;}
        public List<Category> Categories{get;set;}
        public List<Actor> Actors{get;set;}
        public int UserVote{get;set;}
        public double AvgVote{get;set;}
    }
}
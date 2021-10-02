using System;

namespace ProjectMovies5.Shared.Entity
{
    public class Movie
    {
        public string Title{get; set;}
        public string Synopsis{get; set;}
        public DateTime ReleaseDate{get; set;}
        public string UriImage{get; set;}
        public string UriTrailer{get; set;}
        public string Runtime{get; set;}
        public string Genre{get; set;}
        public string Cast{get; set;}
        public double Rating{get; set;}
        public bool IsNowPlating{get; set;}
        
    }
}
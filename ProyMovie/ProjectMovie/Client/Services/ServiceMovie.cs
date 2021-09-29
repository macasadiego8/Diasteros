using ProjectMovie.Shared.Entity;
using System;
using System.Collections.Generic;

namespace ProjectMovie.Client.Services
{
    public class ServiceMovie : IServiceMovie
    {
        public List<Movie>GetMovies()
        {
            return new List<Movie>()
            {
                new Movie(){Name="Movie 1", Sinopsis="De que trata..", Image="/Images/Movies/movie1.jpg", Premier= new DateTime(2021,09,01), Category="Terror", Casting="Actor1"},
                new Movie(){Name="Movie 2", Sinopsis="De que trata..", Image="/Images/Movies/movie2.jpg", Premier= new DateTime(2021,09,01), Category="Terror", Casting="Actor1"},
                new Movie(){Name="Movie 3", Sinopsis="De que trata..", Image="/Images/Movies/movie3.jpg", Premier= new DateTime(2021,09,01), Category="Terror", Casting="Actor1"},
                new Movie(){Name="Movie 4", Sinopsis="De que trata..", Image="/Images/Movies/movie4.jpg", Premier= new DateTime(2021,09,01), Category="Terror", Casting="Actor1"},
                new Movie(){Name="Movie 5", Sinopsis="De que trata..", Image="/Images/Movies/movie5.jpg", Premier= new DateTime(2021,09,01), Category="Terror", Casting="Actor1"},
                new Movie(){Name="Movie 6", Sinopsis="De que trata..", Image="/Images/Movies/movie6.jpg", Premier= new DateTime(2021,09,01), Category="Terror", Casting="Actor1"},
                new Movie(){Name="Movie 7", Sinopsis="De que trata..", Image="/Images/Movies/movie7.jpg", Premier= new DateTime(2021,09,01), Category="Terror", Casting="Actor1"},
                new Movie(){Name="Movie 8", Sinopsis="De que trata..", Image="/Images/Movies/movie8.jpg", Premier= new DateTime(2021,09,01), Category="Terror", Casting="Actor1"},
                new Movie(){Name="Movie 9", Sinopsis="De que trata..", Image="/Images/Movies/movie9.jpg", Premier= new DateTime(2021,09,01), Category="Terror", Casting="Actor1"},
                new Movie(){Name="Movie 10", Sinopsis="De que trata..", Image="/Images/Movies/movie10.jpg", Premier= new DateTime(2021,09,01), Category="Terror", Casting="Actor1"},
                new Movie(){Name="Movie 11", Sinopsis="De que trata..", Image="/Images/Movies/movie11.jpg", Premier= new DateTime(2021,09,01), Category="Terror", Casting="Actor1"},
                new Movie(){Name="Movie 12", Sinopsis="De que trata..", Image="/Images/Movies/movie12.jpg", Premier= new DateTime(2021,09,01), Category="Terror", Casting="Actor1"},
                new Movie(){Name="Movie 13", Sinopsis="De que trata..", Image="/Images/Movies/movie13.jpg", Premier= new DateTime(2021,09,01), Category="Terror", Casting="Actor1"},
                new Movie(){Name="Movie 14", Sinopsis="De que trata..", Image="/Images/Movies/movie14.jpg", Premier= new DateTime(2021,09,01), Category="Terror", Casting="Actor1"}

            };
        }
    }
}
using ProjectMoviesDiasteros.Shared.Entity;
using System;
using System.Collections.Generic;

namespace ProjectMoviesDiasteros.Client.Services
{
    public class ServiceMovie : IServiceMovie
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie(){Id=1, Name="Movie 1", Sinopsis="De que trata..", Poster="/Images/Movies/movie1.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=2, Name="Movie 2", Sinopsis="De que trata..", Poster="/Images/Movies/movie2.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=3, Name="Movie 3", Sinopsis="De que trata..", Poster="/Images/Movies/movie3.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=4, Name="Movie 4", Sinopsis="De que trata..", Poster="/Images/Movies/movie4.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=5, Name="Movie 5", Sinopsis="De que trata..", Poster="/Images/Movies/movie5.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=6, Name="Movie 6", Sinopsis="De que trata..", Poster="/Images/Movies/movie6.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=7, Name="Movie 7", Sinopsis="De que trata..", Poster="/Images/Movies/movie7.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=8, Name="Movie 8", Sinopsis="De que trata..", Poster="/Images/Movies/movie8.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=9, Name="Movie 9", Sinopsis="De que trata..", Poster="/Images/Movies/movie9.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=10, Name="Movie 10", Sinopsis="De que trata..", Poster="/Images/Movies/movie10.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=11, Name="Movie 11", Sinopsis="De que trata..", Poster="/Images/Movies/movie11.jpg", Premier= new DateTime(2021,09,01)},
                new Movie(){Id=12, Name="Movie 12", Sinopsis="De que trata..", Poster="/Images/Movies/movie12.jpg", Premier= new DateTime(2021,09,01)}                
            };
        }
    }
}
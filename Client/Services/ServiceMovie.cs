using ProjectMovies5.Shared.Entity;
using System;
using System.Collections.Generic;

namespace ProjectMovies5.Client.Services
{
    public class ServiceMovie : IServiceMovie
    {
        public List<Movie>GetMovies()
        {
            return new List<Movie>()
            {
                new Movie(){Title="Movie 1", Synopsis="De que trata..", UriImage="/Images/Movies/movie1.jpg", ReleaseDate= new DateTime(2021,09,01), Genre="Terror", Cast="Actor1"},
                new Movie(){Title="Movie 2", Synopsis="De que trata..", UriImage="/Images/Movies/movie2.jpg", ReleaseDate= new DateTime(2021,09,01), Genre="Terror", Cast="Actor1"},
                new Movie(){Title="Movie 3", Synopsis="De que trata..", UriImage="/Images/Movies/movie3.jpg", ReleaseDate= new DateTime(2021,09,01), Genre="Terror", Cast="Actor1"},
                new Movie(){Title="Movie 4", Synopsis="De que trata..", UriImage="/Images/Movies/movie4.jpg", ReleaseDate= new DateTime(2021,09,01), Genre="Terror", Cast="Actor1"},
                new Movie(){Title="Movie 5", Synopsis="De que trata..", UriImage="/Images/Movies/movie5.jpg", ReleaseDate= new DateTime(2021,09,01), Genre="Terror", Cast="Actor1"},
                new Movie(){Title="Movie 6", Synopsis="De que trata..", UriImage="/Images/Movies/movie6.jpg", ReleaseDate= new DateTime(2021,09,01), Genre="Terror", Cast="Actor1"},
                new Movie(){Title="Movie 7", Synopsis="De que trata..", UriImage="/Images/Movies/movie7.jpg", ReleaseDate= new DateTime(2021,09,01), Genre="Terror", Cast="Actor1"},
                new Movie(){Title="Movie 8", Synopsis="De que trata..", UriImage="/Images/Movies/movie8.jpg", ReleaseDate= new DateTime(2021,09,01), Genre="Terror", Cast="Actor1"},
                new Movie(){Title="Movie 9", Synopsis="De que trata..", UriImage="/Images/Movies/movie9.jpg", ReleaseDate= new DateTime(2021,09,01), Genre="Terror", Cast="Actor1"},
                new Movie(){Title="Movie 10", Synopsis="De que trata..", UriImage="/Images/Movies/movie10.jpg", ReleaseDate= new DateTime(2021,09,01), Genre="Terror", Cast="Actor1"},
                new Movie(){Title="Movie 11", Synopsis="De que trata..", UriImage="/Images/Movies/movie11.jpg", ReleaseDate= new DateTime(2021,09,01), Genre="Terror", Cast="Actor1"},
                new Movie(){Title="Movie 12", Synopsis="De que trata..", UriImage="/Images/Movies/movie12.jpg", ReleaseDate= new DateTime(2021,09,01), Genre="Terror", Cast="Actor1"},
                new Movie(){Title="Movie 13", Synopsis="De que trata..", UriImage="/Images/Movies/movie13.jpg", ReleaseDate= new DateTime(2021,09,01), Genre="Terror", Cast="Actor1"},
                new Movie(){Title="Movie 14", Synopsis="De que trata..", UriImage="/Images/Movies/movie14.jpg", ReleaseDate= new DateTime(2021,09,01), Genre="Terror", Cast="Actor1"}

            };
        }
    }
}
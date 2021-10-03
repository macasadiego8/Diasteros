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
                new Movie(){Name="Movie 1",EnCartelera=true, Sinopsis="De que trata..", Poster="/Images/Movies/movie1.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Name="Movie 2",EnCartelera=true, Sinopsis="De que trata..", Poster="/Images/Movies/movie2.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Name="Movie 3",EnCartelera=true, Sinopsis="De que trata..", Poster="/Images/Movies/movie3.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Name="Movie 4",EnCartelera=true, Sinopsis="De que trata..", Poster="/Images/Movies/movie4.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Name="Movie 5",EnCartelera=true, Sinopsis="De que trata..", Poster="/Images/Movies/movie5.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Name="Movie 6",EnCartelera=true, Sinopsis="De que trata..", Poster="/Images/Movies/movie6.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Name="Movie 7",EnCartelera=true, Sinopsis="De que trata..", Poster="/Images/Movies/movie7.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Name="Movie 8",EnCartelera=true, Sinopsis="De que trata..", Poster="/Images/Movies/movie8.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Name="Movie 9",EnCartelera=true, Sinopsis="De que trata..", Poster="/Images/Movies/movie9.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Name="Movie 10",EnCartelera=true, Sinopsis="De que trata..", Poster="/Images/Movies/movie10.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Name="Movie 11",EnCartelera=true, Sinopsis="De que trata..", Poster="/Images/Movies/movie11.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Name="Movie 12",EnCartelera=true, Sinopsis="De que trata..", Poster="/Images/Movies/movie12.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Name="Movie 13",EnCartelera=true, Sinopsis="De que trata..", Poster="/Images/Movies/movie13.jpg", Premier= new DateTime(2021,09,01), },
                new Movie(){Name="Movie 14",EnCartelera=true, Sinopsis="De que trata..", Poster="/Images/Movies/movie14.jpg", Premier= new DateTime(2021,09,01), }

            };
        }
    }
}
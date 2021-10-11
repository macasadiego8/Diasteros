using ProjectMoviesDiasteros.Shared.Entity;
using System.Collections.Generic;

namespace ProjectMoviesDiasteros.Client.Services
{
    public interface IServiceMovie
    {
        List<Movie> GetMovies();         
    }
}
using ProjectMovie.Shared.Entity;
using System.Collections.Generic;

namespace ProjectMovie.Client.Services
{
    public interface IServiceMovie
    {
        List<Movie> GetMovies();         
    }
}
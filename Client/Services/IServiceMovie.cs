using ProjectMovies5.Shared.Entity;
using System.Collections.Generic;

namespace ProjectMovies5.Client.Services
{
    /* Las interfaces son abstractas, no implementan los métodos */
    public interface IServiceMovie
    {
        List<Movie> GetMovies();
    }
}
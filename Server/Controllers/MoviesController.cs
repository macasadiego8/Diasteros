using System.Threading;
using ProjectMovies5.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMovies5.Server.Storage;


namespace ProjectMovies5.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFilesStorageClass FilesStorage;
        /*se crea para el almacenamiento local de multimedia*/
        private readonly string carpeta = "movies";


        public MoviesController(ApplicationDbContext context,IFilesStorageClass filesStorage){
            this.context = context;
            this.FilesStorage = filesStorage;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie){
            if (!string.IsNullOrWhiteSpace(movie.Poster))
            {
                var movie_poster = Convert.FromBase64String(movie.Poster);
                movie.Poster = await FilesStorage.SaveFile(movie_poster,".jpg", carpeta);
            }
            context.Add(movie);
            await context.SaveChangesAsync();
            return movie.Id;
        }

        /* Paginacion o cantidad de peliculas*/

        [HttpGet]
        public async Task<ActionResult>Get(){            
           var peliculas = await context.Movies.ToListAsync();
           return Ok(peliculas);
        }

/*         [HttpGet]
        public async Task<ActionResult<FilterMovie>>Get(){            
            var limit = 10;
            var peliculasEnCartelera = await context.Movies.Where(x=>x.EnCartelera).Take(limit).OrderByDescending(x=>x.Premier).ToListAsync();
            var currentDate=DateTime.Today;
            var proximosEstrenos = await context.Movies.Where(x=> x.Premier> currentDate).OrderBy(x=>x.Premier).Take(limit).ToListAsync();
            var response = new FilterMovie(){
                PeliculasEnCartelera = peliculasEnCartelera,
                ProximosEstrenos =proximosEstrenos
            };
            return response;
        } */

        /* consultar por id*/
          /*   [HttpGet("{id}")]
            public async Task<ActionResult>Get(int id){
                var movie = await context.Movies.Where(x=>x.Id ==id)
                .Include(x=>MovieGenres).ThenInclude(x=> x.Genre)
                .Include(x=>Actors).ThenInclude(x=> x.Actor).FirstOrDefaultAsync();

                if (movie == null) {return NotFound();}
                return NoContent();
            }  */


     
    }
}
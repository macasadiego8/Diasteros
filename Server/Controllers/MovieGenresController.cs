using ProjectMovies5.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProjectMovies5.Server.Controllers
{
    [ApiController]
    /* El [controller] tomara el nombre del controlador, en este caso CategoryController */
    [Route("api/[controller]")]

    public class MovieGenresController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        /* Para crear el registro en la base de datos, debemos inyectar el DbContext en el controlador */
        public MovieGenresController(ApplicationDbContext context){
            this.context = context;
        }

        [HttpPost]

        /* La tarea retorna un int correspondiente al Id de la categoría creada */
        public async Task<ActionResult<int>> Post(MovieGenre moviegenre){
            /* Con el mètodo add agregamos el registro en la BD */
            context.Add(moviegenre);
            /* Aplicamos los cambios en la BD, para guardar cambios de forma asincrona con el await */
            await context.SaveChangesAsync();
            return moviegenre.Id;
        }
    }
}
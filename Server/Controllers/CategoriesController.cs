using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMoviesDiasteros.Shared.Entity;

namespace ProjectMoviesDiasteros.Server.Controllers
{
    /* Creación de API */
    [ApiController]
    [Route("api/[controller]")]

    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        /* Contructor del controller */
        public CategoriesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        /* Método para crear registro en BD */
        [HttpPost]
        public async Task<ActionResult<int>> Post(Category category)
        {
            context.Add(category);
            await context.SaveChangesAsync();
            return category.Id;
        }

        /* Método para consultar todos los registros en la BD */
        [HttpGet]
        public async Task<ActionResult<List<Category>>> Get()
        {
            return await context.Categories.ToListAsync();
        }
        
        /* Método para consultar un registro específico */
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> Get(int id)
        {
            return await context.Categories.FirstOrDefaultAsync(x=>x.Id == id);
        }

        /* Método para actualizar información de determinado registro */
        [HttpPut]
        public async Task<ActionResult> Put(Category category)
        {
            context.Attach(category).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        /* Método para eliminar un registro  */
        [HttpDelete("{id}")]
        public async Task <ActionResult> Delete(int id)
        {
            var exists = await context.Categories.AnyAsync(x=>x.Id == id);
            if(!exists) {return NotFound();}
            context.Remove(new Category {Id = id});
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
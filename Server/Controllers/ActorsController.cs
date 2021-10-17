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
    public class ActorsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFilesStorageClass FilesStorage;
        private readonly string carpeta = "actors";


        public ActorsController(ApplicationDbContext context,IFilesStorageClass filesStorage){
            this.context = context;
            this.FilesStorage = filesStorage;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Actor actor){
            if (!string.IsNullOrWhiteSpace(actor.Photo))
            {
                var actor_photo = Convert.FromBase64String(actor.Photo);
                actor.Photo = await FilesStorage.SaveFile(actor_photo,".jpg", carpeta);
            }
            context.Add(actor);
            await context.SaveChangesAsync();
            return actor.Id;
        }
     [HttpGet]
        public async Task<ActionResult>Get(){            
           var actores = await context.Actors.ToListAsync();
           return Ok(actores);
        }
        

        [HttpGet("{id}")]
        public async Task<ActionResult<Actor>> Get (int id){
        var actor = await context.Actors.FirstOrDefaultAsync(x=>x.Id == id);
        if (actor == null)
        {
        return NotFound();
        }
        return actor;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Actor actor){
        var actorDB = await context.Actors.FirstOrDefaultAsync(x=>x.Id == actor.Id);
        if (actorDB == null)
        {
        return NotFound();
        }
        /* actorDB =mapper.Map(actor, actorDB); */
        if (!string.IsNullOrWhiteSpace(actor.Photo))
        {
        var newPhotoActor = Convert.FromBase64String(actor.Photo);
        actorDB.Photo = await FilesStorage.EditFile(newPhotoActor, "jpg","actors",
        actorDB.Photo);
        }
        await context.SaveChangesAsync();
        return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete (int id){
        var actorExist = await context.Actors.AnyAsync(x=>x.Id == id);
        if (!actorExist)
        {
        return NotFound();
        }
        context.Remove(new Actor{Id = id});
        await context.SaveChangesAsync();
        return NoContent();

    }
}
}
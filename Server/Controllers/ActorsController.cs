using System.Net;
using System.ComponentModel.Design.Serialization;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMoviesDiasteros.Shared.Entity;
using ProjectMoviesDiasteros.Server.Storage;
using ProjectMoviesDiasteros.Shared.Models;
using ProjectMoviesDiasteros.Client.Pages.Components;


namespace ProjectMoviesDiasteros.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ActorsController : ControllerBase
    {
        private readonly ApplicationDbContext Context;
        private readonly IFilesStorageClass FilesStorage;

        /* Contructor del controller */
        public ActorsController(ApplicationDbContext context, IFilesStorageClass filesStorage)
        {
            this.Context = context;
            this.FilesStorage = filesStorage;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Actor actor)
        {
            if(!string.IsNullOrWhiteSpace(actor.Photo))
            {
                var actorPhoto = Convert.FromBase64String(actor.Photo);
                actor.Photo = await FilesStorage.SaveFile(actorPhoto,"jpg","actors");
            }
            Context.Add(actor);
            await Context.SaveChangesAsync();
            return actor.Id;
        }

        [HttpGet]
        public async Task<ActionResult<List<Actor>>> Get([FromQuery] Pagination pagination)
        {
            var queryable = Context.Actors.AsQueryable();
            /* await HttpContext.ActorsPerPage(queryable,pagination.CountRegisters); */
            return await queryable.Paginar(pagination).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Actor>> Get(int id)
        {
            var actor = await Context.Actors.FirstOrDefaultAsync(x=>x.Id == id);
            if (actor == null)
            {
                return NotFound();
            }
            return actor;            
        }

        [HttpGet("search/{text]")]
        public async Task<ActionResult<List<Actor>>> Get(string text)
        {
            if(string.IsNullOrWhiteSpace(text))
            {
                return new List<Actor>();
            }
            text = text.ToLower();
            return await Context.Actors.Where(x=>x.Name.ToLower().Contains(text)).ToListAsync();
        }

        [HttpPut]
        public async Task<ActionResult> Put(Actor actor)
        {
            var actorDB = await Context.Actors.FirstOrDefaultAsync(x=>x.Id == actor.Id);
            if (actorDB == null)
            {
                return NotFound();
            }
            if(!string.IsNullOrWhiteSpace(actor.Photo))
            {
                var newPhotoActor = Convert.FromBase64String(actor.Photo);
                actorDB.Photo = await FilesStorage.EditFile(newPhotoActor,"jpg",actorDB.Photo);
            }
            await Context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var actorExist = await Context.Actors.AnyAsync(x=>x.Id == id);
            if (!actorExist){return NotFound();}
            Context.Remove(new Actor{Id = id});
            await Context.SaveChangesAsync();
            return NoContent();
        }
        
    }
}
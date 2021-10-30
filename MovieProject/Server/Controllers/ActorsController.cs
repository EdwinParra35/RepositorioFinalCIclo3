using System.Globalization;
using System.Net.Mime;
using MovieProject.Shared.Entity;
using System.Threading;
using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieProject.Server.Storage;
using MovieProject.Shared.Models;

namespace MovieProject.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActorsController : ControllerBase
    {
        /* Todas las instancias que se creen en el controlador, deben ser private readonly */
        private readonly ApplicationDbContext Context;
        private readonly IFilesStorageClass FilesStorage;
        /* private readonly IMapper mapper; */

        /* Constructor del controlador */

        public ActorsController(ApplicationDbContext context, IFilesStorageClass filesStorage){
            this.Context = context;
            this.FilesStorage = filesStorage;
        }
        /* Los únicos métodos que reciben como parametro la entidad son:
                [HttpPost] => POST(context.Add) => Crear registro
                [HttpPut] => PUT (Attach) => Actualizar registro   */
        /* El método que no recibe parametro es:
                [HttpGet] => GET(ToListAsync) => Consultar historial de registros  */
        /* Los métodos que reciben como paramétro el Id son:
                [HttpDelete("{id}")] => DELETE (Remove) => Eliminar registro
                [HttpGet("{id}")] => GET[{id}] (FirstOrDefaultAsync) => Consultar por un registro específico*/
        [HttpPost]
        public async Task<ActionResult<int>> Post (Actor actor){
            if (!string.IsNullOrWhiteSpace(actor.Photo))
            {
                var photo = Convert.FromBase64String(actor.Photo);
                actor.Photo = await FilesStorage.SaveFile(photo,"jpg","actors");
            }
            Context.Add(actor);
            await Context.SaveChangesAsync();
            return actor.Id;
        }

        [HttpGet]
        public async Task<ActionResult<List<Actor>>> Get ([FromQuery] Pagination pagination){
            var queryable = Context.Actors.AsQueryable();
            /* await HttpContext.ActoresPorPagina(queryable,pagination.CantidadRegistros); */
            return await queryable.Paginar(pagination).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Actor>> Get (int id){
            var actor = await Context.Actors.FirstOrDefaultAsync(x=>x.Id == id);
            if (actor == null)
            {
                return NotFound();
            }
            return actor;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Actor actor){
            var actorDB = await Context.Actors.FirstOrDefaultAsync(x=>x.Id == actor.Id);
            if (actorDB == null)
            {
                return NotFound();
            }
            /* actorDB =mapper.Map(actor, actorDB); */
            if (!string.IsNullOrWhiteSpace(actor.Photo))
            {
               var newPhotoActor = Convert.FromBase64String(actor.Photo);
               actorDB.Photo = await  FilesStorage.EditFile(newPhotoActor, "jpg","actors", actorDB.Photo);
            }
            await Context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete (int id){
            var actorExist = await Context.Actors.AnyAsync(x=>x.Id == id);
            if (!actorExist)
            {
                return NotFound();
            }
            Context.Remove(new Actor{Id = id});
            await Context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet("search/{text}")]
        public async Task<ActionResult<List<Actor>>> Get(string text){
            if(string.IsNullOrWhiteSpace(text)){
                return new List<Actor>();
            }
            text = text.ToLower();
            return await Context.Actors.Where(x=>x.ActorName.ToLower().Contains(text)).ToListAsync();
        }

        
    }    
}
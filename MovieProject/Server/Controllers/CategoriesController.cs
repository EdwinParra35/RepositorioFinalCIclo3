using System.Threading;
using MovieProject.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MovieProject.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController: ControllerBase
    {
        /*Inicializamos el apicationDbcontext*/
        private readonly ApplicationDbContext context;
        public CategoriesController(ApplicationDbContext context){
            this.context = context;
        }

        /* Tipo de solicitud del cliente: POST*/
        [HttpPost]
        /*La tarea retorna un int correspondiente al id de la categoria creada*/
        public async Task<ActionResult<int>> Post(Category category){
            /* con el metodo add agregamos el registro en la BD*/
            context.Add(category);
            /*Aplicamos los cambios en la BD, para guardar cambios de forma asincrona con el await*/
            await context.SaveChangesAsync();
            return category.Id;
        }

        /* Consultar registros en la base de datos (Lista TODOS los registros)*/
        [HttpGet]
        public async Task<ActionResult<List<Category>>> Get(){
            return await context.Categories.ToListAsync();
        }

        /* Consultar la información de determinado recurso */
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> Get(int id){
            return await context.Categories.FirstOrDefaultAsync(x => x.Id == id);
        }

        /* Actualizar información de determinado registro */
        [HttpPut]
        public async Task<ActionResult> Put(Category category){
            context.Attach(category).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task <ActionResult> Delete (int id){
            var exists = await context.Categories.AnyAsync(x => x.Id == id);
            /* Si no existe un registro con ese Id */
            if(!exists){return NotFound();}
            context.Remove(new Category {Id = id});
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
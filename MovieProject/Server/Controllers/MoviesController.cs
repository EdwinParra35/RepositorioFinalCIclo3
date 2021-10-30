using System.Threading;
using MovieProject.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieProject.Server.Storage;
using MovieProject.Shared.Models;
using AutoMapper;

namespace MovieProject.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFilesStorageClass FilesStorage;
        /* Dicha carpeta se crea para el almacenamiento local de multimedia */
        private readonly string carpeta = "movies";
        private readonly IMapper Mapper;


        public MoviesController(ApplicationDbContext context, IFilesStorageClass filesStorage, IMapper mapper)
        {
            this.context = context;
            this.FilesStorage = filesStorage;
            this.Mapper = mapper;
        }

        /* Almacenar información de pelicula */
        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie)
        {
            if (!string.IsNullOrWhiteSpace(movie.MovieImage))
            {
                var movie_poster = Convert.FromBase64String(movie.MovieImage);
                movie.MovieImage = await FilesStorage.SaveFile(movie_poster, ".jpg", carpeta);
            }
            if (movie.MoviesActor != null)
            {
                for(int i = 0; i<movie.MoviesActor.Count;i++){
                            movie.MoviesActor[i].OrderCredits = i +1;
                        }
            }
           
            context.Add(movie);
            await context.SaveChangesAsync();
            return movie.id;
        }

        /* Listar peliculas por filtro de
        Peliculas en cartelera y próximos estrenos*/
        [HttpGet]
        public async Task<ActionResult<FilterMovie>> Get()
        {
            /* Paginación => datatable o cantidad de peliculas => cards*/
            var limit = 10;
            var peliculasEnCartelera = await context.Movies
                .Where(x => x.EnCartelera).Take(limit)
                .OrderByDescending(x => x.Premier)
                .ToListAsync();

            var currentDate = DateTime.Today;
            /* Los próximos lanzamientos deben ser mayores a la fecha actual */
            var proximosEstrenos = await context.Movies
                .Where(x => x.Premier > currentDate)
                .OrderBy(x => x.Premier).Take(limit)
                .ToListAsync();

            var response = new FilterMovie()
            {
                PeliculasEncartelera = peliculasEnCartelera,
                ProximosEstrenos = proximosEstrenos
            };
            return response;
        }

        /* Consultar por un registro determinado */
        [HttpGet("{id}")]
        public async Task<ActionResult<ShowMovieDB>> Get(int id)
        {
            var movie = await context.Movies.Where(x => x.id == id)
                .Include(x => x.CategoriesMovie).ThenInclude(x => x.Category)
                .Include(x => x.MoviesActor).ThenInclude(x => x.Actor)
                .FirstOrDefaultAsync();

            if (movie == null) { return NotFound(); }
            var avgVote = 5;
            var votoUser = 5;
            movie.MoviesActor = movie.MoviesActor.OrderBy(x => x.OrderCredits).ToList();
            var model = new ShowMovieDB();
            model.Movie = movie;
            model.Categories = movie.CategoriesMovie.Select(x=> x.Category).ToList();
            model.Actors = movie.MoviesActor.Select(x=>new Actor{
                ActorName = x.Actor.ActorName,
                Photo = x.Actor.Photo,
                Character = x.Character,
                Id = x.ActorId
            }).ToList();

            model.AvgVote = avgVote;
            model.UserVote = votoUser;
            return model;
        }

         public class ParametrosBusqueda
        {
            public int Pagina { get; set; } = 1;
            public int CantidadRegistros { get; set; } = 10;
            public Pagination Pagination
            {
                get { return new Pagination() { Pagina = Pagina, CantidadRegistros = CantidadRegistros }; }
            }
            public string Name { get; set; }
            public int CategoryId { get; set; }
            public bool EnCartelera { get; set; }
            public bool MasVotadas { get; set; }
        }
     [HttpGet("searchMovie")]
    public async Task<ActionResult<List<Movie>>> Get([FromQuery] ParametrosBusqueda parametrosBusqueda){
        var movieQuery = context.Movies.AsQueryable();
        if (!string.IsNullOrWhiteSpace(parametrosBusqueda.Name))
        {
            movieQuery= movieQuery.Where(x=>x.Moviename.ToLower().Contains(parametrosBusqueda.Name.ToLower()));
        }
        if (parametrosBusqueda.EnCartelera)
        {
            movieQuery =movieQuery.Where(x=>x.EnCartelera);
        }

        if (parametrosBusqueda.CategoryId !=0)
        {
            movieQuery = movieQuery.Where(x => x.CategoriesMovie.Select(y=>y.CategoryId)
                                    .Contains(parametrosBusqueda.CategoryId));
        }
        var movies = await movieQuery.Paginar(parametrosBusqueda.Pagination).ToListAsync();
        return movies;
    }

    [HttpPut]
    public async Task<ActionResult> Put (Movie movie){
        var movieDB = await context.Movies.FirstOrDefaultAsync(x=>x.id == movie.id);
        if (movieDB == null)
        {
            return NotFound();
        }
        movieDB = Mapper.Map(movie, movieDB);
        if (!string.IsNullOrWhiteSpace(movie.MovieImage))
        {
            var posterM = Convert.FromBase64String(movie.MovieImage);
            movieDB.MovieImage = await FilesStorage.EditFile(posterM,"jpg","movies",movieDB.MovieImage);
        }
    await context.Database.ExecuteSqlInterpolatedAsync($"delete from CategoriesMovie WHERE MovieId = {movie.id}; delete from MoviesActor where MovieId = {movie.id}");
    if (movie.MoviesActor != null)
    {
        for(int i = 0; i < movie.MoviesActor.Count; i++){
            movie.MoviesActor[i].OrderCredits = i+1;
        }
    }
    movieDB.MoviesActor = movie.MoviesActor;
    movieDB.CategoriesMovie = movie.CategoriesMovie;
    await context.SaveChangesAsync();
    return NoContent();
    }


[HttpGet("edit/{id}")]
        public async Task<ActionResult<PutMovie>> PutGet(int id)
        {
            var peliculaActionResult = await Get(id);
            if (peliculaActionResult.Result is NotFoundResult) { return NotFound(); }

            var peliculaVisualizarDTO = peliculaActionResult.Value;
            var generosSeleccionadosIds = peliculaVisualizarDTO.Categories.Select(x => x.Id).ToList();
            var generosNoSeleccionados = await context.Categories
                .Where(x => !generosSeleccionadosIds.Contains(x.Id))
                .ToListAsync();

            var model = new PutMovie();
            model.Movie = peliculaVisualizarDTO.Movie;
            model.CategoriasNoSeleccionadas = generosNoSeleccionados;
            model.CategoriasSeleccionadas = peliculaVisualizarDTO.Categories;
            model.Actors = peliculaVisualizarDTO.Actors;
            return model;
        }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete (int id){
        var exist_movie = await context.Movies.AnyAsync(x => x.id == id);
        if (!exist_movie){
            return NotFound();
        }
        context.Remove(new Movie{id = id});
        await context.SaveChangesAsync();
        return NoContent();
    }
    }
}
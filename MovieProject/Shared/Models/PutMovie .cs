using System.Collections.Generic;
using MovieProject.Shared.Entity;

namespace MovieProject.Shared.Models
{
    public class PutMovie 
    {
        public Movie Movie {get;set;}
        public List <Actor> Actors {get;set;}
        public List <Category> CategoriasSeleccionadas {get;set;}
        public List <Category> CategoriasNoSeleccionadas {get;set;}

    }
}
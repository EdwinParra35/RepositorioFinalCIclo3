using System.Collections.Generic;
using MovieProject.Shared.Entity;

namespace MovieProject.Shared.Models
{
    public class FilterMovie
    {
        public List<Movie> PeliculasEncartelera{get;set;}
        public List<Movie> ProximosEstrenos{get;set;}
    }
}
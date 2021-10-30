using System.Collections.Generic;
using MovieProject.Shared.Entity;
namespace MovieProject.Shared.Models
{
    public class ShowMovieDB
    {
        public Movie Movie {get;set;}
        public List<Category> Categories {get;set;}
        public List <Actor> Actors {get;set;}
        public int UserVote {get;set;}
        public double AvgVote {get;set;}
    }
}
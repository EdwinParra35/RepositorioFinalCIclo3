using MovieProject.Shared.Entity;
using System.Collections.Generic;

namespace MovieProject.Client.Services
{
    public interface IServiceActor
    {
         List<Actor> GetActors();
    }
}
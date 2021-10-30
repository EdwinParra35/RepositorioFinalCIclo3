using MovieProject.Shared.Entity;
using System.Collections.Generic;
using System;
namespace MovieProject.Client.Services
{
    public class ServiceActor: IServiceActor
    {
        public List <Actor> GetActors(){
            return new List<Actor>{
                new Actor(){ActorName = "Robert Downey Jr.", BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){ActorName = "Scarlett Johansson", BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/actor2.jpg"},
                new Actor(){ActorName = "Brie Larson",BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor3.jpg"},
                new Actor(){ActorName = "Evangeline Lilly", BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor4.jpg"},
                new Actor(){ActorName = "Elizabeth Olsen", BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor5.jpg"},
                new Actor(){ActorName = "Don Cheadle", BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor6.jpg"},
                new Actor(){ActorName = "Mark Ruffalo", BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor7.jpg"},
                new Actor(){ActorName = "Jon Favreau", BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor8.jpg"},
                new Actor(){ActorName = "Natalie Portman", BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor9.jpg"},
                new Actor(){ActorName = "Bradley Cooper", BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor10.jpg"}
            };
        }
    }
}
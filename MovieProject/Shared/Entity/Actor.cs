using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace MovieProject.Shared.Entity
{
    public class Actor
    {
        public int Id {get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string ActorName{get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public DateTime? BirthDate{get;set;}
        public string Photo {get;set;}
        public int KnowCredits {get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Biography {get;set;}
        public int Nominations {get;set;}
        /* Relacion de muchos a muchos */
        /* Campo que no se va almacenar en ningun tabla de la bd */
        [NotMapped]
        public string Character{get;set;}
        public List<MovieActor> MoviesActor {get;set;}
    }
}
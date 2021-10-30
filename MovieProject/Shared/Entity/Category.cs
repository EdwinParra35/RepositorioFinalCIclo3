using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace MovieProject.Shared.Entity
{
    public class Category
    {
       public int Id{get;set;}
        /* Validamos que el campo nombre es requerido */
        [Required(ErrorMessage ="El campo es requerido")]
        public string Name{get;set;}
        public List <CategoryMovie> CategoriesMovie{get;set;}
    }
}
using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.ViewModels
{
    public class CourseViewModels
    {
        

        [Required(ErrorMessage ="Este campo es requerido")]
        public int CourseId { get; set; }

        [Display(Name = "Titulo de la carrera")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Title { get; set; }

        [Display(Name = "nivel de credito")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Credits { get; set; }


        public CourseViewModels(Course course)
        {
            this.Title = course.Title;

            this.Credits = course.Credits;
        }

        public CourseViewModels()
        {

        }

    }

}

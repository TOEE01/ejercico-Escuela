using Escuela.Dominio;
using Escuela.Models;
using Escuela.Servicios;
using Escuela.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICourse icouse;

        public HomeController(ILogger<HomeController> logger, ICourse icourses)
        {
            this.icouse = icourses;
            _logger = logger;
        }

        public IActionResult Index()
        {
            Course course = new Course();

            //course.Title = "Poo";
            //course.Credits = 100;
            //icouse.Insertar(course);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult RegistroCurso(CourseViewModels courseView)
        {
            

            return View();
        }
    }
}

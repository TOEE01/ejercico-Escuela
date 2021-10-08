using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Repositorio
{
    public class CourseRepository : ICourse
    {
        private ApplicationDBContext app;

        public CourseRepository(ApplicationDBContext apps)
        {
            this.app = apps;
        }
       

        public void Insertar(Course c)
        {
            app.Add(c);
            app.SaveChanges();
        }
        //El servicio solo es para decirle al repositorio como va a trabajar

    }
}

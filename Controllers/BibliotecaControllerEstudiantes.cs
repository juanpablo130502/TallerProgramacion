using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BibliotecaControllerEstudiantes : ControllerBase
    {
        //Propiedad publica
        public string PropiedadBiblioteca { get; set; }

        public BibliotecaControllerEstudiantes()
        {
            //constructor
        }
        [HttpGet]
        public string ObtenerEstudiantes()
        {
            return "Encontraste a los estudiantes";
        }
        [HttpPost]
        public string AgregarEstudiantes()
        {
            return "Agregaste un nuevo estudiante";
        }
        [HttpPut]
        public string ActualizarEstudiantes()
        {
            return "Acabas de actualizar el listado de estudiantes";
        }

    }
}

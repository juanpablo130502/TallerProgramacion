using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{


    [ApiController]
    [Route("[controller]/[action]")]
    public class BibliotecaController : ControllerBase
    {
        //Propiedad publica
        public string PropiedadBiblioteca { get; set; }

        public BibliotecaController()
        {
            //constructor
        }
        [HttpGet]
        public string ObtenerLibro()
        {
            return "Obtuviste el libro";
        }
        [HttpPost]
        public string AgregarLibro()
        {
            return "Agregaste un nuevo libro";
        }
        [HttpPut]
        public string ActualizarLibro()
        {
            return "Actualizaste el libro";
        }

    }
}

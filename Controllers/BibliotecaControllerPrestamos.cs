using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BibliotecaControllerPrestamos : ControllerBase
    {
        //Propiedad publica
        public string PropiedadBiblioteca { get; set; }

        public BibliotecaControllerPrestamos()
        {
            //constructor
        }
        [HttpGet]
        public string ObtenerPrestamos()
        {
            return "Obtener";
        }
        [HttpPost]
        public string AgregarPrestamos()
        {
            return "Agregar";
        }
        [HttpPut]
        public string ActualizarPrestamos()
        {
            return "Actualizar";
        }

    }
}

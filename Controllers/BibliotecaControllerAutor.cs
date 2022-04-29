using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BibliotecaControllerAutor : ControllerBase
    {
        //Propiedad publica
        public string PropiedadBiblioteca { get; set; }

        public BibliotecaControllerAutor()
        {
            //constructor
        }
        [HttpGet]
        public string ObtenerAutor()
        {
            return "Ya encontraste tu Autor";
        }
        [HttpPost]
        public string AgregarAutor()
        {
            return "Acabas de agregar un nuevo Autor";
        }
        [HttpPut]
        public string ActualizarAutor()
        {
            return "Acabas de actualizar";
        }

    }

}

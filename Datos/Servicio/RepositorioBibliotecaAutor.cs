using Microsoft.EntityFrameworkCore;
using WebApplication2.Datos.Modelo;

namespace WebApplication2.Datos.Servicio
{
    public class RepositorioBibliotecaAutor : DbContext
    {
        public RepositorioBibliotecaAutor(DbContextOptions<RepositorioBibliotecaAutor> options) : base(options)
        {

        }
        public DbSet<Autor> Autores { get; set; }
    }
}

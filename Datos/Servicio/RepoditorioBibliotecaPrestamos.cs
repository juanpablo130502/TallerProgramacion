using Microsoft.EntityFrameworkCore;
using WebApplication2.Datos.Modelo;

namespace WebApplication2.Datos.Servicio
{
    public class RepositorioBibliotecaPrestamos : DbContext
    {
        public RepositorioBibliotecaPrestamos(DbContextOptions<RepositorioBibliotecaPrestamos> options) : base(options)
        {

        }
        public DbSet<Prestamos> Prestamos { get; set; }
    }
}

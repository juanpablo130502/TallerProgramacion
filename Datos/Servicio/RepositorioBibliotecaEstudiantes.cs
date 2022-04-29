using Microsoft.EntityFrameworkCore;
using WebApplication2.Datos.Modelo;

namespace WebApplication2.Datos.Servicio
{
    public class RepositorioBibliotecaEstudiantes : DbContext
    {
        public RepositorioBibliotecaEstudiantes(DbContextOptions<RepositorioBibliotecaEstudiantes> options) : base(options)
        {

        }
        public DbSet<Estudiantes> Estudiante { get; set; }
    }
}

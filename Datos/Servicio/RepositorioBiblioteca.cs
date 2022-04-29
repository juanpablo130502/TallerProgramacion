using Microsoft.EntityFrameworkCore;
using WebApplication2.Datos.Modelo;

namespace WebApplication2.Datos.Servicio
{
        public class RepositorioBiblioteca : DbContext
        {
            public RepositorioBiblioteca(DbContextOptions<RepositorioBiblioteca> options) :base(options)
            {

            }
            public DbSet<Libro> Libros { get; set; }
            //Crear otras 3 propiedades restantes (Autor, Estudiante, Préstamo)
            
        }
    }

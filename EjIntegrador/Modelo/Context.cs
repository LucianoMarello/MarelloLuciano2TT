using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Context : DbContext
    {
        private string conexion = "Data Source=ASUS-MARELLO\\SQLEXPRESS;Initial Catalog=BibliotecaDB;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False";

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }

        //buscar en la pagina de entity
        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlServer(conexion);

        //HERRAMIENTAS > ADM PAQUETES NUGET > CONSOLA
        //add-migration primera
        //update-database

        //drop-database para eliminar la bbdd si la hice mal xd
    }
}

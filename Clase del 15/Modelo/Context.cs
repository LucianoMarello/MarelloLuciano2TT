using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Context : DbContext
    {
        private string conexion = "Data Source=ASUS-MARELLO\\SQLEXPRESS;Initial Catalog=Torneos Ajedrez;Integrated Security=True;Persist Security Info=False;Encrypt=False;";

        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Partida> Partidas{ get; set; } //con el dbset se transforman en tabla (?)

        //buscar en la pagina de entity
        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlServer(conexion);

        //HERRAMIENTAS > ADM PAQUETES NUGET > CONSOLA
        //add-migration primera
        //update-database
    }
}

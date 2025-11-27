using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Context : DbContext
    {
        private string connection = "Data Source=ASUS-MARELLO\\SQLEXPRESS;Initial Catalog=Parcial_2;Integrated Security=True;Encrypt=False";

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaCorriente> CuentasCorrientes { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlServer(connection);
    } 
}

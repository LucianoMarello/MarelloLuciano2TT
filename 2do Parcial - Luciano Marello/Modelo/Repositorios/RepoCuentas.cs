using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorios
{
    public class RepoCuentas
    {
        public IReadOnlyCollection<CuentaCorriente> Listar()
        {
            using var context = new Context();
            return context.CuentasCorrientes
                .Include("Cliente")
                .Include("Movimientos")
                .ToList()
                .AsReadOnly();
        }

        public CuentaCorriente ObtenerCuenta(int cuentaId)
        {
            using var context = new Context();
            var cuenta = context.CuentasCorrientes
                .Include("Movimientos")
                .FirstOrDefault(c => c.CuentaCorrienteId == cuentaId);

            if (cuenta == null) throw new Exception("Cuenta no encontrada");

            return cuenta;
        }

        public string Agregar(CuentaCorriente cuenta)
        {
            try
            {
                using var context = new Context();
                context.CuentasCorrientes.Add(cuenta);
                context.SaveChanges();
                return "Cuenta registrado con exito";
            }
            catch (Exception ex)
            {
                return $"Error al conectar con la BBDD: {ex.Message}";
            }
        }
    }
}

using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorios
{
    public class RepoMovimientos
    {
        public IReadOnlyCollection<Movimiento> Listar()
        {
            using var context = new Context();
            return context.Movimientos.ToList().AsReadOnly();
        }

        public string Agregar(Movimiento movimiento)
        {
            try
            {
                using var context = new Context();

                var cuenta = context.CuentasCorrientes.FirstOrDefault(c => c.CuentaCorrienteId == movimiento.CuentaCorrienteId);
                if (cuenta == null) return "Error. No se encontro la cuenta corriente.";

                cuenta.Movimientos.Add(movimiento);
                context.Movimientos.Add(movimiento);
                context.SaveChanges();
                return "Movimiento registrado con exito";
            }
            catch
            {
                return "Error al conectar con la BBDD.";
            }
        }
    }
}

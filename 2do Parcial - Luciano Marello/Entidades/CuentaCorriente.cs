using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaCorriente
    {
        public int CuentaCorrienteId { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<Movimiento> Movimientos { get; set; } = new List<Movimiento>();

        public decimal CalcularSaldo()
        {
            return Movimientos.Sum(m => m.Tipo == TipoMovimiento.Credito ? m.Monto : -m.Monto);
        }
    }

    public class ResumenCuenta
    {
        public decimal TotalDebitos { get; set; }
        public decimal TotalCreditos { get; set; }
        public decimal SaldoActual { get; set; }
        public int CantidadMovimientos { get; set; }
    }
}

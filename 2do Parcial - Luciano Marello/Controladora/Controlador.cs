using Entidades;
using Modelo.Repositorios;

namespace Controladora
{
    public sealed class Controlador
    {
        private static Controlador? _instance;
        private Controlador()
        {
            _repoClientes = new RepoClientes();
            _repoCuentas = new RepoCuentas();
            _repoMovimientos = new RepoMovimientos();
        }
        public static Controlador GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Controlador();
            }
            return _instance;
        }

        private readonly RepoClientes _repoClientes;
        private readonly RepoCuentas _repoCuentas;
        private readonly RepoMovimientos _repoMovimientos;

        //Metodos para Clientes
        public List<Cliente> ListarClientes()
        {
            return _repoClientes.Listar();
        }

        public string AgregarCliente(string nombre, string apellido, string dni, string telefono)
        {
            Cliente cliente = new Cliente
            {
                Nombre = nombre.Trim(),
                Apellido = apellido.Trim(),
                DNI = dni.Trim(),
                Telefono = telefono.Trim(),
                Cuentas = new List<CuentaCorriente>()
            };
            return _repoClientes.Agregar(cliente);
        }

        public string ModificarCliente(int clienteId, string nombre, string apellido, string dni, string telefono)
        {
            Cliente cliente = new Cliente
            {
                ClienteId = clienteId,
                Nombre = nombre.Trim(),
                Apellido = apellido.Trim(),
                DNI = dni.Trim(),
                Telefono = telefono.Trim()
            };
            return _repoClientes.Modificar(cliente);
        }

        public string EliminarCliente(int id)
        {
            return _repoClientes.Eliminar(id);
        }
        
        //Metodos para Cuentas
        public IReadOnlyCollection<CuentaCorriente> ListarCuentas()
        {
            return _repoCuentas.Listar();
        }

        public ResumenCuenta ObtenerResumen(int cuentaId)
        {
            var cuenta = _repoCuentas.ObtenerCuenta(cuentaId);
            return new ResumenCuenta
            {
                TotalDebitos = cuenta.Movimientos.Where(m => m.Tipo == TipoMovimiento.Debito).Sum(m => m.Monto),
                TotalCreditos = cuenta.Movimientos.Where(m => m.Tipo == TipoMovimiento.Credito).Sum(m => m.Monto),
                SaldoActual = cuenta.CalcularSaldo(),
                CantidadMovimientos = cuenta.Movimientos.Count
            };
        }

        public string AgregarCuenta(int clienteId)
        {
            CuentaCorriente cuenta = new CuentaCorriente
            {
                ClienteId = clienteId,
            };
            return _repoCuentas.Agregar(cuenta);
        }

        //Metodos para Movimientos
        public IReadOnlyCollection<Movimiento> ListarMovimientos()
        {
            return _repoMovimientos.Listar();
        }
        public string AgregarMovimiento(string descripcion, decimal monto, TipoMovimiento tipo, int cuentaId)
        {
            var cuenta = ListarCuentas().FirstOrDefault(c => c.CuentaCorrienteId == cuentaId);
            if (cuenta == null) return "Error. No existe la cuenta corriente asociada al movimiento.";

            Movimiento movimiento = new Movimiento
            {
                Fecha = DateTime.Now,
                Descripcion = descripcion.Trim(),
                Monto = monto,
                Tipo = tipo,
                CuentaCorrienteId = cuentaId,
            };
            return _repoMovimientos.Agregar(movimiento);
        }
    }
}

using Controladora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2do_Parcial
{
    public partial class FormCuentas : Form
    {
        private Controlador controlador = Controlador.GetInstance();

        public FormCuentas()
        {
            InitializeComponent();
            ConfigurarDgvCliente();
            ConfigurarDgvCuenta();
            CargarClientes();
            CargarCuentas();
        }

        public void ConfigurarDgvCuenta()
        {
            dgvCuentas.AutoGenerateColumns = false;
            dgvCuentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCuentas.MultiSelect = false;
            dgvCuentas.ReadOnly = true;
            dgvCuentas.AllowUserToAddRows = false;
            dgvCuentas.Columns.Clear();
            dgvCuentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CuentaCorrienteId",
                HeaderText = "ID",
                Width = 50
            });
            dgvCuentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ClienteNombre",
                HeaderText = "Nombre Cliente",
                Width = 140
            });
            dgvCuentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ClienteApellido",
                HeaderText = "Apellido Cliente",
                Width = 140
            });
            dgvCuentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Saldo",
                HeaderText = "Saldo",
                Width = 140
            });
        }

        public void ConfigurarDgvCliente()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
            dgvClientes.ReadOnly = true;
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.Columns.Clear();

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ClienteId",
                HeaderText = "ID",
                Width = 50
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 110
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Apellido",
                HeaderText = "Apellido",
                Width = 110
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DNI",
                HeaderText = "DNI",
                Width = 110
            });
        }

        public void CargarClientes()
        {
            try
            {
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = controlador.ListarClientes();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}");
            }
        }

        public void CargarCuentas()
        {
            try
            {
                var cuentas = controlador.ListarCuentas();

                if (dgvClientes.SelectedRows.Count > 0)
                {
                    int clienteId = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value);
                    cuentas = cuentas.Where(c => c.ClienteId == clienteId).ToList();
                }

                var cuentasParaMostrar = cuentas.Select(c => new
                {
                    CuentaCorrienteId = c.CuentaCorrienteId,
                    ClienteNombre = c.Cliente.Nombre,
                    ClienteApellido = c.Cliente.Apellido,
                    ClienteDNI = c.Cliente.DNI,
                    Saldo = c.CalcularSaldo(),
                    CantidadMovimientos = c.Movimientos != null ? c.Movimientos.Count : 0
                }).ToList();

                dgvCuentas.DataSource = null;
                dgvCuentas.DataSource = cuentasParaMostrar;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cuentas: {ex.Message}");
            }
        }

        public void Limpiar()
        {
            dgvClientes.ClearSelection();
            dgvCuentas.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value);
            string mensaje = controlador.AgregarCuenta(id);

            MessageBox.Show(mensaje, "Agregar Cuenta", MessageBoxButtons.OK);
            CargarCuentas();
            return;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Limpiar();
            CargarCuentas();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvClientes.SelectedRows.Count > 0)
            {
                btnAgregar.Enabled = true;
                CargarCuentas();
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }
    }
}

using Controladora;
using Entidades;
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
    public partial class FormMovimientos : Form
    {
        private Controlador controlador = Controlador.GetInstance();

        public FormMovimientos()
        {
            InitializeComponent();
            CargarClientes();
            CargarTipos();

        }


        public void LimpiarCampos()
        {
            cmbCliente.SelectedIndex = -1;
            cmbCuenta.DataSource = null;
            cmbTipo.SelectedIndex = -1;
            txtMonto.Clear();
            txtDescripcion.Clear();
            LimpiarGrilla();
            LimpiarResumen();
        }

        private void LimpiarResumen()
        {
            lblTotalCreditos.Text = "Total Creditos: $0.00";
            lblTotalDebitos.Text = "Total Debitos: $0.00";
            lblSaldoActual.Text = "Saldo Actual: $0.00";
            lblCantidadMovimientos.Text = "Cantidad de Movimientos: 0";
            lblEstado.Text = "Estado: ";
        }

        private void LimpiarGrilla()
        {
            dgvMovimientos.DataSource = null;
        }

        public void CargarClientes()
        {
            try
            {
                var clientes = controlador.ListarClientes();

                cmbCliente.DataSource = null;
                cmbCliente.DataSource = clientes;
                cmbCliente.DisplayMember = "DNI";
                cmbCliente.ValueMember = "ClienteId";
                cmbCliente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarTipos()
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Crédito (Haber)");
            cmbTipo.Items.Add("Débito (Debe)");
            cmbTipo.SelectedIndex = 0;
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == -1)
            {
                cmbCuenta.DataSource = null;
                LimpiarGrilla();
                LimpiarResumen();
                return;
            }
            if (cmbCliente.SelectedIndex != -1) CargarCuentasDelCliente();
        }

        private void CargarCuentasDelCliente()
        {
            try
            {
                int clienteId = (int)cmbCliente.SelectedValue;
                var cuentas = controlador.ListarCuentas().Where(c => c.ClienteId == clienteId).ToList();

                if (cuentas.Count == 0)
                {
                    MessageBox.Show("El cliente no tiene cuentas activas.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbCuenta.DataSource = null;
                    LimpiarGrilla();
                    LimpiarResumen();
                    return;
                }

                var cuentasDisplay = cuentas.Select(c => new
                {
                    c.CuentaCorrienteId,
                    Descripcion = $"Cuenta #{c.CuentaCorrienteId} - Saldo: {c.CalcularSaldo():C2}"
                }).ToList();

                cmbCuenta.DataSource = null;
                cmbCuenta.DataSource = cuentasDisplay;
                cmbCuenta.DisplayMember = "Descripcion";
                cmbCuenta.ValueMember = "CuentaCorrienteId";
                cmbCuenta.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cuentas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCuenta.SelectedIndex == -1)
            {
                LimpiarGrilla();
                LimpiarResumen();
                return;
            }

            CargarMovimientos();
            CargarResumen();
        }

        public void CargarMovimientos()
        {
            try
            {
                if (cmbCuenta.SelectedIndex == -1) return;

                int cuentaId = (int)cmbCuenta.SelectedValue;
                var movimientos = controlador.ListarMovimientos().Where(m => m.CuentaCorrienteId == cuentaId).ToList();

                var movimientosDisplay = movimientos.Select(m => new
                {
                    m.MovimientoId,
                    Fecha = m.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    m.Descripcion,
                    TipoTexto = m.Tipo == TipoMovimiento.Credito ? "Crédito" : "Débito",
                    m.Monto,
                    m.Tipo
                }).ToList();

                dgvMovimientos.DataSource = null;
                dgvMovimientos.DataSource = movimientosDisplay;

                // Configurar columnas
                if (dgvMovimientos.Columns.Count > 0)
                {
                    dgvMovimientos.Columns["MovimientoId"].HeaderText = "ID";
                    dgvMovimientos.Columns["MovimientoId"].Width = 50;

                    dgvMovimientos.Columns["Fecha"].Width = 130;

                    dgvMovimientos.Columns["Descripcion"].Width = 250;
                    dgvMovimientos.Columns["Descripcion"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    dgvMovimientos.Columns["Tipo"].HeaderText = "Tipo";
                    dgvMovimientos.Columns["Tipo"].Width = 80;

                    dgvMovimientos.Columns["Monto"].Width = 100;
                    dgvMovimientos.Columns["Monto"].DefaultCellStyle.Format = "C2";

                    dgvMovimientos.Columns["Tipo"].Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar movimientos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarResumen()
        {
            try
            {
                if (cmbCuenta.SelectedValue == null) return;

                int cuentaId = (int)cmbCuenta.SelectedValue;
                var resumen = controlador.ObtenerResumen(cuentaId);

                lblTotalCreditos.Text = $"Total Creditos: {resumen.TotalCreditos.ToString("C2")}";
                lblTotalDebitos.Text = $"Total Debitos: {resumen.TotalDebitos.ToString("C2")}";
                lblSaldoActual.Text = $"Saldo Actual: {resumen.SaldoActual.ToString("C2")}";
                lblCantidadMovimientos.Text = $"Cantidad de Movimientos: {resumen.CantidadMovimientos.ToString()}";

                if (resumen.SaldoActual < 0) lblEstado.Text = "DEUDA PENDIENTE";
                else if (resumen.SaldoActual > 0) lblEstado.Text = "CRÉDITO A FAVOR";
                else lblEstado.Text = "CUENTA SALDADA";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar resumen: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                int cuentaId = (int)cmbCuenta.SelectedValue;
                string descripcion = txtDescripcion.Text.Trim();
                decimal monto = decimal.Parse(txtMonto.Text);
                TipoMovimiento tipo = cmbTipo.SelectedIndex == 0 ? TipoMovimiento.Credito : TipoMovimiento.Debito;


                string mensaje = controlador.AgregarMovimiento(descripcion, monto, tipo, cuentaId);
                MessageBox.Show(mensaje, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarMovimientos();

                // Actualizar el combo de cuentas para mostrar el nuevo saldo
                int clienteIdActual = (int)cmbCliente.SelectedValue;
                int cuentaIdActual = (int)cmbCuenta.SelectedValue;
                CargarCuentasDelCliente();
                cmbCuenta.SelectedValue = cuentaIdActual;

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //VALIDACIONES
        private bool ValidarCampos()
        {
            if (cmbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCliente.Focus();
                return false;
            }

            if (cmbCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una cuenta", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCuenta.Focus();
                return false;
            }

            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de movimiento", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción es requerida", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }

            if (decimal.Parse(txtMonto.Text) <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a cero", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return false;
            }

            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}

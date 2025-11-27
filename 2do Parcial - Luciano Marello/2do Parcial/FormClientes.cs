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
    public partial class FormClientes : Form
    {
        private Controlador controlador = Controlador.GetInstance();
        public FormClientes()
        {
            InitializeComponent();
            ConfigurarDGV();
            CargarClientes();
        }

        public void ConfigurarDGV()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
            dgvClientes.ReadOnly = true;
            dgvClientes.AllowUserToAddRows = false;

            // Definir columnas manualmente para mejor control
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
                Width = 140
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Apellido",
                HeaderText = "Apellido",
                Width = 140
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DNI",
                HeaderText = "DNI",
                Width = 150
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Telefono",
                HeaderText = "Telefono",
                Width = 150
            });
        }

        public void CargarClientes()
        {
            try
            {
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = controlador.ListarClientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}");
            }
        }

        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            dgvClientes.ClearSelection();
            txtNombre.Focus();
        }

        //Validaciones
        public bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo Apellido es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("El campo DNI es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El campo Telefono es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            return true;
        }

        //Eventos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            string mensaje = controlador.AgregarCliente(
                txtNombre.Text,
                txtApellido.Text,
                txtDni.Text,
                txtTelefono.Text
            );

            MessageBox.Show(mensaje, "Agregar Cliente", MessageBoxButtons.OK);
            CargarClientes();
            return;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para modificar.", "Modificar Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje = controlador.ModificarCliente(
                Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value),
                txtNombre.Text,
                txtApellido.Text,
                txtDni.Text,
                txtTelefono.Text
            );

            MessageBox.Show(mensaje, "Modificar Cliente", MessageBoxButtons.OK);
            CargarClientes();
            return;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Eliminar Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro que desea eliminar el libro seleccionado?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            string mensaje = controlador.EliminarCliente(
                Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value)
            );

            MessageBox.Show(mensaje, "Eliminar Libro", MessageBoxButtons.OK);
            CargarClientes();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                txtNombre.Text = dgvClientes.SelectedRows[0].Cells[1].Value.ToString();
                txtApellido.Text = dgvClientes.SelectedRows[0].Cells[2].Value.ToString();
                txtDni.Text = dgvClientes.SelectedRows[0].Cells[3].Value.ToString();
                txtTelefono.Text = dgvClientes.SelectedRows[0].Cells[4].Value.ToString();
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else if (dgvClientes.SelectedRows.Count == 0)
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }
    }
}

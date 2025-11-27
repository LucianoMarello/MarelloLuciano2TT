using Controladora;
using System.Text.RegularExpressions;

namespace EjIntegrador
{
    public partial class FormLibros : Form
    {
        private BibliotecaControlador controlador = BibliotecaControlador.GetInstance();

        public FormLibros()
        {
            InitializeComponent();
            ConfigurarDGV();
            CargarLibros();
            dgvLibros.ClearSelection();
        }

        public void ConfigurarDGV()
        {
            dgvLibros.AutoGenerateColumns = false;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.MultiSelect = false;
            dgvLibros.ReadOnly = true;
            dgvLibros.AllowUserToAddRows = false;

            // Definir columnas manualmente para mejor control
            dgvLibros.Columns.Clear();

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LibroId",
                HeaderText = "ID",
                Width = 50
            });

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ISBN",
                HeaderText = "ISBN",
                Width = 150
            });

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Titulo",
                HeaderText = "Título",
                Width = 250
            });

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Autor",
                HeaderText = "Autor",
                Width = 200
            });

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado",
                Width = 100
            });
        }

        public void CargarLibros()
        {
            try
            {
                var libros = controlador.ListarLibros();
                dgvLibros.DataSource = libros.ToList();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar libros: {ex.Message}");
            }
        }

        public void LimpiarCampos()
        {
            dgvLibros.ClearSelection();
            txtIsbnLibro.Clear();
            txtTituloLibro.Clear();
            txtAutorLibro.Clear();
            chkDisponible.Checked = true;
            txtIsbnLibro.Focus();
        }

        //----------Validaciones----------
        private bool ValidarISBN(string isbn)
        {
            //robado de la ia
            string patron = @"^\d{3}-\d{1}-\d{2}-\d{6}-\d{1}$";
            return Regex.IsMatch(isbn, patron);
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtIsbnLibro.Text))
            {
                MessageBox.Show("El campo ISBN es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIsbnLibro.Focus();
                return false;
            }

            if (!ValidarISBN(txtIsbnLibro.Text))
            {
                MessageBox.Show("El formato del ISBN es inválido. Debe ser 'XXX-X-XX-XXXXXX-X'.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIsbnLibro.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTituloLibro.Text))
            {
                MessageBox.Show("El campo Título es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTituloLibro.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAutorLibro.Text))
            {
                MessageBox.Show("El campo Autor es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAutorLibro.Focus();
                return false;
            }

            return true;
        }

        //----------Eventos----------
        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            string mensaje = controlador.AgregarLibro(
                txtIsbnLibro.Text,
                txtTituloLibro.Text,
                txtAutorLibro.Text,
                chkDisponible.Checked
            );

            MessageBox.Show(mensaje, "Agregar Libro", MessageBoxButtons.OK);
            CargarLibros();
            return;
        }

        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            if (dgvLibros.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un libro para modificar.", "Modificar Libro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje = controlador.ModificarLibro(
                Convert.ToInt32(dgvLibros.CurrentRow.Cells[0].Value),
                txtIsbnLibro.Text,
                txtTituloLibro.Text,
                txtAutorLibro.Text,
                chkDisponible.Checked
            );

            MessageBox.Show(mensaje, "Modificar Libro", MessageBoxButtons.OK);
            CargarLibros();
            return;
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un libro para eliminar.", "Eliminar Libro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro que desea eliminar el libro seleccionado?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            string mensaje = controlador.EliminarLibro(
                Convert.ToInt32(dgvLibros.CurrentRow.Cells[0].Value)
            );

            MessageBox.Show(mensaje, "Eliminar Libro", MessageBoxButtons.OK);
            CargarLibros();
            return;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                txtIsbnLibro.Text = dgvLibros.SelectedRows[0].Cells[1].Value.ToString();
                txtTituloLibro.Text = dgvLibros.SelectedRows[0].Cells[2].Value.ToString();
                txtAutorLibro.Text = dgvLibros.SelectedRows[0].Cells[3].Value.ToString();
                chkDisponible.Checked = Convert.ToBoolean(dgvLibros.SelectedRows[0].Cells[4].Value);
                btnModificarLibro.Enabled = true;
                btnEliminarLibro.Enabled = true;
            }
            else if (dgvLibros.SelectedRows.Count == 0)
            {
                btnModificarLibro.Enabled = false;
                btnEliminarLibro.Enabled = false;
            }
        }
    }
}

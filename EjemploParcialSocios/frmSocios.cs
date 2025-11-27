namespace EjemploParcialSocios
{
    public partial class frmSocios : Form
    {
        private RepositorioSocios repo;
        public frmSocios()
        {
            InitializeComponent();
            string connectionString = "Data Source = .\\SQLEXPRESS; Initial Catalog = club; Integrated Security = True; Encrypt = False";
            repo = new RepositorioSocios(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarLista();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void CargarLista()
        {
            var lista = repo.ListarSocios();
            dgvSocios.DataSource = null;
            dgvSocios.DataSource = lista;
            LimpiarDatos();
        }

        private void LimpiarDatos()
        {
            dgvSocios.ClearSelection();
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtNumSocio.Text = "";
            chbCuota.Checked = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacio.");
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("El apellido no puede estar vacio.");
                return false;
            }
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("DNI invalido.");
                return false;
            }
            if (string.IsNullOrEmpty(txtNumSocio.Text))
            {
                MessageBox.Show("Numero de Socio invalido.");
                return false;
            }
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            int numSocio = int.Parse(txtNumSocio.Text);
            bool cuota = chbCuota.Checked;

            repo.AgregarSocio(nombre, apellido, dni, fecha, numSocio, cuota);
            CargarLista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSocios.SelectedRows.Count != 1) return;
                if (!ValidarCampos()) return;

                int id = (int)dgvSocios.SelectedRows[0].Cells[0].Value;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string dni = txtDni.Text;
                DateTime fecha = dtpFechaNacimiento.Value;
                int numSocio = int.Parse(txtNumSocio.Text);
                bool cuota = chbCuota.Checked;

                repo.ModificarSocio(id, nombre, apellido, dni, fecha, numSocio, cuota);
                CargarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar. " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSocios.SelectedRows.Count != 1) return;

            int id = (int)dgvSocios.SelectedRows[0].Cells[0].Value;

            repo.EliminarSocio(id);
            CargarLista();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void dgvSocios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSocios.CurrentRow != null)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                txtNombre.Text = dgvSocios.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dgvSocios.CurrentRow.Cells[2].Value.ToString();
                txtDni.Text = dgvSocios.CurrentRow.Cells[3].Value.ToString();
                dtpFechaNacimiento.Value = (DateTime)dgvSocios.CurrentRow.Cells[4].Value;
                txtNumSocio.Text = dgvSocios.CurrentRow.Cells[5].Value.ToString();
                chbCuota.Checked = (bool)dgvSocios.CurrentRow.Cells[6].Value;

                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnCantCuota_Click(object sender, EventArgs e)
        {
            int cant = repo.CuotaAlDia();
            MessageBox.Show("Cantidad de socios con la cuota al dia: " + cant);
        }
    }
}

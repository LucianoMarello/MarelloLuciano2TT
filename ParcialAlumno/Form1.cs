using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialAlumno
{
    public partial class frmAlumnos : Form
    {
        private RepositorioAlumnos repo;

        public frmAlumnos()
        {
            InitializeComponent();
            string connectionString = "Data Source = .\\SQLEXPRESS; Initial Catalog = Alumno; Integrated Security = True";
            repo = new RepositorioAlumnos(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void CargarAlumnos()
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = repo.ListarAlumnos();
        }

        private void LimpiarCampos()
        {
            dgvAlumnos.ClearSelection();
            txtNombre.Text = "";
            nudEdad.Value = 0;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            string nombre = txtNombre.Text;
            int edad = (int)nudEdad.Value;
            repo.CrearAlumno(nombre, edad);
            CargarAlumnos();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count != 1) return;
            if (!ValidarCampos()) return;

            int id = (int)dgvAlumnos.SelectedRows[0].Cells[0].Value;

            string nombre = txtNombre.Text;
            int edad = (int)nudEdad.Value;

            repo.ModificarAlumno(id, nombre, edad);
            CargarAlumnos();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count != 1) return;

            int id = (int)dgvAlumnos.SelectedRows[0].Cells[0].Value;

            repo.EliminarAlumno(id);
            CargarAlumnos();
            LimpiarCampos();
        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvAlumnos.CurrentRow != null)
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                txtNombre.Text = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
                nudEdad.Value = (int)dgvAlumnos.CurrentRow.Cells[2].Value;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacio.");
                return false;
            }
            if (nudEdad.Value < 1)
            {
                MessageBox.Show("Ingrese una edad valida.");
                return false;
            }
            return true;
        }
    }
}

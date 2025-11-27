using Controladora;
using EjIntegrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormPrincipal : Form
    {
        private BibliotecaControlador controlador = BibliotecaControlador.GetInstance();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            FormLibros frmLibros = new FormLibros();
            frmLibros.ShowDialog();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            FormSocios formSocios = new FormSocios();
            formSocios.ShowDialog();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            FormPrestamos formPrestamos = new FormPrestamos();
            formPrestamos.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

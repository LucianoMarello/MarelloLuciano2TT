using Controladora;

namespace _2do_Parcial
{
    public partial class FormPrincipal : Form
    {
        private Controladora.Controlador controlador = Controladora.Controlador.GetInstance();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnFormClientes_Click(object sender, EventArgs e)
        {
            FormClientes frmClientes = new FormClientes();
            frmClientes.ShowDialog();
        }

        private void btnFormCuentas_Click(object sender, EventArgs e)
        {
            FormCuentas frmCuentas = new FormCuentas();
            frmCuentas.ShowDialog();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            FormMovimientos frmMovimientos = new FormMovimientos();
            frmMovimientos.ShowDialog();
        }
    }
}

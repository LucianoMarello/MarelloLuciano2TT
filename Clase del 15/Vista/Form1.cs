namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RellenarGrilla()
        {
            dgvJugadores.DataSource = null;
            dgvJugadores.DataSource = Controladora.Controladora.Instancia.Listar();
        }

        private void btnAgregarPartida_Click(object sender, EventArgs e)
        {

        }
    }
}

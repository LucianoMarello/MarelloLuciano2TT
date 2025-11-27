namespace ProyectoADO
{
    public partial class Form1 : Form
    {
        RepositorioMaterias repositorioMaterias;
        public Form1()
        {
            InitializeComponent();
            repositorioMaterias = new RepositorioMaterias();
        }
        private void Listar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repositorioMaterias.Listar();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia();
            materia.Nombre = textBox1.Text;
            materia.CantidadHoras = int.Parse(textBox2.Text);
            string msj = repositorioMaterias.Agregar(materia);
            MessageBox.Show(msj);
            Listar();
        }
    }
}

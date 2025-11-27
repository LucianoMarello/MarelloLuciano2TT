using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_WindowsForms_AdoNet
{
    public partial class FrmNuevo : Form
    {
        private int? Id;
        public FrmNuevo(int? Id = null)
        {
            InitializeComponent();
            this.Id = Id;
            if (this.Id != null)
                LoadData();
        }

        private void LoadData()
        {
            PeopleDB oPeopleDB = new PeopleDB();
            People oPeople = oPeopleDB.Get(Id);
            textBox1.Text = oPeople.Name;
            textBox2.Text = oPeople.age.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PeopleDB oPeobleDb = new PeopleDB();
            try
            {
                oPeobleDb.Agregar(textBox1.Text, int.Parse(textBox2.Text));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al guardar: " + ex.Message);
            }
        }
    }
}

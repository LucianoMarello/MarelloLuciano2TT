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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            PeopleDB oPeopleDB = new PeopleDB();
            dataGridView1.DataSource = oPeopleDB.Get();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmNuevo frm = new FrmNuevo();
            frm.ShowDialog();
            Actualizar();
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                MessageBox.Show("ERROR");
                return null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                FrmNuevo frm = new FrmNuevo(Id);
                frm.ShowDialog();
                Actualizar();
            }
        }
    }
}

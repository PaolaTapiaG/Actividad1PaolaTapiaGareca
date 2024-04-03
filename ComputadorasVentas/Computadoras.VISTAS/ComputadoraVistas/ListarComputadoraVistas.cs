using Computadoras.BSS;
using Computadoras.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computadoras.VISTAS.ComputadoraVistas
{
    public partial class ListarComputadoraVistas : Form
    {
        public ListarComputadoraVistas()
        {
            InitializeComponent();
        }
        ComputadorasBss bss = new ComputadorasBss();
        private void ListarComputadoraVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarComputadoraBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarComputadoraVistas fr = new InsertarComputadoraVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarComputadoraBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdComputadoraSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EditarComputadoraVistas fr = new EditarComputadoraVistas(IdComputadoraSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarComputadoraBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdComputadoraSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Desea eliminar estos datos?", "Los datos se estan eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarComputadoraBss(IdComputadoraSeleccionada);
                dataGridView1.DataSource = bss.ListarComputadoraBss();
            }
        }
    }
}

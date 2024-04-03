using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Computadoras.BSS;
using Computadoras.MODELOS;

namespace Computadoras.VISTAS.ComputadoraVistas
{
    public partial class EditarComputadoraVistas : Form
    {
        int idc = 0;
        Computador computadora = new Computador();
        ComputadorasBss bss = new ComputadorasBss();
        public EditarComputadoraVistas(int idx)
        {
            idc = idx;
            InitializeComponent();
        }

        private void EditarComputadoraVistas_Load(object sender, EventArgs e)
        {
            computadora = bss.ObtenerComputadoraIdBss(idc);

            textBox1.Text = computadora.Nombre;
            textBox2.Text = computadora.Descripcion;
            textBox3.Text = computadora.Precio.ToString();
            dateTimePicker1.Value = computadora.FechaFabricacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            computadora.Nombre = textBox1.Text;
            computadora.Descripcion = textBox2.Text;
            computadora.Precio = Convert.ToDecimal(textBox3.Text);
            computadora.FechaFabricacion = dateTimePicker1.Value;

            bss.EditarComputadoraBss(computadora);
            MessageBox.Show("Se actualizaron los datos");
        }
    }
}

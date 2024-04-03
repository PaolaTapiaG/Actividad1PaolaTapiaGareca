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
    public partial class InsertarComputadoraVistas : Form
    {
        public InsertarComputadoraVistas()
        {
            InitializeComponent();
        }
        ComputadorasBss bss = new ComputadorasBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Computador computadora = new Computador();

            computadora.Nombre = textBox1.Text;
            computadora.Descripcion = textBox2.Text;
            computadora.Precio = Convert.ToDecimal(textBox3.Text);
            computadora.FechaFabricacion = dateTimePicker1.Value;

            bss.InsertarComputadoraBss(computadora);
            MessageBox.Show("Se guardo correctamente :)");
        }
    }
}

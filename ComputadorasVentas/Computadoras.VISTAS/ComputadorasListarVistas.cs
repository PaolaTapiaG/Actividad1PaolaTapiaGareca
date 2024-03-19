using System;
using Computadoras.BSS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computadoras.VISTAS
{
    public partial class ComputadorasListarVistas : Form
    {
       

        public ComputadorasListarVistas()
        {
            InitializeComponent();
        }

        private void ComputadorasListarVistas_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = bss.ListarComputadorasBss();
        }
    }
}

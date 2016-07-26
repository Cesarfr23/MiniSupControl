using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupControl
{
    public partial class MiniSupControl : Form
    {
        public MiniSupControl()
        {
            InitializeComponent();
        }

        private void usuarioDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.UsuarioSistema usuario = new Registros.UsuarioSistema();
            usuario.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.Cliente cliente = new Registros.Cliente();
            cliente.ShowDialog();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.Proveedor proveedor = new Registros.Proveedor();
            proveedor.ShowDialog();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.Productos productos = new Registros.Productos();
            productos.ShowDialog();
        }
    }
}

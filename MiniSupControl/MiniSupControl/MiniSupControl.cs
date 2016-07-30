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
            Registros.rUsuarioSistema usuario = new Registros.rUsuarioSistema();
            usuario.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rCliente cliente = new Registros.rCliente();
            cliente.ShowDialog();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rProveedor proveedor = new Registros.rProveedor();
            proveedor.ShowDialog();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rProductos productos = new Registros.rProductos();
            productos.ShowDialog();
        }
    }
}

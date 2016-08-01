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
        public string UsuarioId = "";
        public string Nombre = "";
        public string Apellido = "";
        public string Acceso = "";

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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Esta Seguro que Desea Salir?", "MiniSup Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cerrarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void presentacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rCategoria categoria = new Registros.rCategoria();
            categoria.ShowDialog();

        }

        private void presentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rPresentacion presentacion = new Registros.rPresentacion();
            presentacion.ShowDialog();
        }

        private void categoriaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Reportes.ReporteCategorias reporteCategorias = new Reportes.ReporteCategorias();
            reporteCategorias.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteClientes reporteClientes = new Reportes.ReporteClientes();
            reporteClientes.ShowDialog();
        }

        private void usuariosDelSistemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.ReporteUsuarios reporteUsuarios = new Reportes.ReporteUsuarios();
            reporteUsuarios.ShowDialog();
        }

        private void proveedorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Reportes.ReporteProveedores reporteProveedores = new Reportes.ReporteProveedores();
            reporteProveedores.ShowDialog();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.ReorteProductos reporteProductos = new Reportes.ReorteProductos();
            reporteProductos.ShowDialog();
        }

        private void presentacionToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Reportes.Reporte_Presentacion reportePresentacion = new Reportes.Reporte_Presentacion();
            reportePresentacion.ShowDialog();
        }
    }
}

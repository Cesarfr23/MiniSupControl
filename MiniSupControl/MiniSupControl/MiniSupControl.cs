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

        }

        private void presentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void categoriaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ReporteCategorias reporteCategorias = new ReporteCategorias();
            reporteCategorias.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteClientes reporteClientes = new ReporteClientes();
            reporteClientes.ShowDialog();
        }

        private void usuariosDelSistemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteUsuarios reporteUsuarios = new ReporteUsuarios();
            reporteUsuarios.ShowDialog();
        }

        private void proveedorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReporteProveedores reporteProveedores = new ReporteProveedores();
            reporteProveedores.ShowDialog();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteProductos reporteProductos = new ReporteProductos();
            reporteProductos.ShowDialog();
        }

        private void presentacionToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ReportesPresentacion reportePresentacion = new ReportesPresentacion();
            reportePresentacion.ShowDialog();
        }

        private void categoriaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void usuariosDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultarUsuarios consultaUsuario = new Consultas.ConsultarUsuarios();
            consultaUsuario.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultarClientes consultaClientes = new Consultas.ConsultarClientes();
            consultaClientes.ShowDialog();
        }

        private void proveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultarProveedor consultaProveedor = new Consultas.ConsultarProveedor();
            consultaProveedor.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaProductos consultaProductos = new Consultas.ConsultaProductos();
            consultaProductos.ShowDialog();
        }

        private void presentacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
          
        }

        private void MiniSupControl_Load(object sender, EventArgs e)
        {

        }
    }
}

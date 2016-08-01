using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupControl.Registros
{
    public partial class rProveedor : Form
    {
        Proveedor proveedor = new Proveedor();
        public rProveedor()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            try
            {
                LlenaCampos(ProveedorBll.Buscar(StringToInt(ProveedorIdTextBox.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Limpiar()
        {
            ProveedorIdTextBox.Clear();
            EmpresaTextBox.Clear();
            DireccionTextBox.Clear();
            TelefonoTextBox.Clear();
            CorreoTextBox.Clear();
            WebTextBox.Clear();
        }

        private void LlenaCampos(Proveedor proveedor)
        {
            ProveedorIdTextBox.Text = proveedor.ProveedorId.ToString();
            EmpresaTextBox.Text = proveedor.Empresa;
            DireccionTextBox.Text = proveedor.Direccion;
            TelefonoTextBox.Text = proveedor.Telefono;
            CorreoTextBox.Text = proveedor.Correo;
            WebTextBox.Text = proveedor.Web;
        }

        private void LlenarClase(Proveedor proveedor)
        {
            proveedor.ProveedorId = StringToInt(ProveedorIdTextBox.Text);
            proveedor.Empresa = EmpresaTextBox.Text;
            proveedor.Direccion = DireccionTextBox.Text;
            proveedor.Telefono = TelefonoTextBox.Text;
            proveedor.Correo = CorreoTextBox.Text;
            proveedor.Web = WebTextBox.Text;
       
        }

        public int StringToInt(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            LlenarClase(proveedor);
            ProveedorBll.Insertar(proveedor);
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            LlenarClase(proveedor);
            ProveedorBll.Modificar(StringToInt(ProveedorIdTextBox.Text), EmpresaTextBox.Text, DireccionTextBox.Text,
                TelefonoTextBox.Text, CorreoTextBox.Text, WebTextBox.Text);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            ProveedorBll.Eliminar(StringToInt(ProveedorIdTextBox.Text));
            Limpiar();
        }
    }
}

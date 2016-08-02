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
    public partial class rProductos : Form
    {
        Producto producto = new Producto();
        ProductoCategoria productaCategoria = new ProductoCategoria();
        public rProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Validar("Favor Inserte el Id") && ValidarBuscar())
            {
                LlenaCampos(ProductoBll.Buscar(StringToInt(ProductoIdTextBox.Text)));
            }  
            
        }
        private void Limpiar()
        {
            ProductoIdTextBox.Clear();
            NombreTextBox.Clear();
            DescripcionTextBox.Clear();
            CantidadTextBox.Clear();
            CategoriaIdComboBox.SelectedValue = 1;
            PresentacionIdComboBox.SelectedValue = 1;
            CategoriaDataGridView.DataSource = null;
            PresentacionDataGridView.DataSource = null;
        }

        private void LlenaCampos(Producto producto)
        {
            ProductoIdTextBox.Text = producto.ProductoId.ToString();
            NombreTextBox.Text = producto.Nombre;
            DescripcionTextBox.Text = producto.Descripcion;
            CantidadTextBox.Text = producto.Cantidad.ToString();
            CategoriaDataGridView.DataSource = producto.Categoria;
            PresentacionDataGridView.DataSource = producto.Presentacion;
        }

        private void LlenarClase(Producto producto)
        {
            producto.ProductoId = StringToInt(ProductoIdTextBox.Text);
            producto.Nombre = NombreTextBox.Text;
            producto.Descripcion = DescripcionTextBox.Text;
            producto.Cantidad = StringToInt(CantidadTextBox.Text);
        }

        public int StringToInt(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }
        private bool ValidarBuscar()
        {
            if (UsuarioBll.Buscar(StringToInt(ProductoIdTextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }
            return true;

        }
        private bool Validar(string message)
        {
            if (string.IsNullOrEmpty(ProductoIdTextBox.Text))
            {
                ErrorProvider.ReferenceEquals(ProductoIdTextBox, "Ingresar el ID");
                MessageBox.Show(message);
                return false;
            }
            else
            {

                return true;
            }
        }
        private bool ValidarProducto()
        {
            if (string.IsNullOrEmpty(NombreTextBox.Text) && string.IsNullOrEmpty(DescripcionTextBox.Text) && string.IsNullOrEmpty(CantidadTextBox.Text))
            {
                ErrorProvider.Equals(NombreTextBox, "Favor ingresar el nombre de Usuario");
                ErrorProvider.Equals(DescripcionTextBox, "Favor ingresar la contraseña");
                ErrorProvider.Equals(CantidadTextBox, "Favor confirmar comtraseña");
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(NombreTextBox.Text))
            {
                ErrorProvider.Equals(NombreTextBox, "Favor ingresar el nombre de Usuario");
                return false;
            }

            if (string.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                ErrorProvider.Equals(DescripcionTextBox, "Favor ingresar la contraseña del usuario");
                return false;
            }
            if (string.IsNullOrEmpty(CantidadTextBox.Text))
            {
                ErrorProvider.Equals(CantidadTextBox, "Favor confirmar comtraseña");
                return false;
            }
            return true;
        }
        private void rProductos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            CategoriaIdComboBox.DataSource = CategoriaBll.GetLista();
            CategoriaIdComboBox.ValueMember = "CategoriaId";
            CategoriaIdComboBox.DisplayMember = "Descripcion";

            PresentacionIdComboBox.DataSource = PresentacionBll.GetLista();
            PresentacionIdComboBox.ValueMember = "PresentacionId";
            PresentacionIdComboBox.DisplayMember = "Descripcion";
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            LlenarClase(producto);
            if(ValidarProducto())
            {
                ProductoBll.Insertar(producto);
                Limpiar();
                MessageBox.Show("Guardado con exito");
            }
            
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            if(Validar("Intrudusca Id") && ValidarProducto())
            {
                LlenarClase(producto);
                ProductoBll.Modificar(StringToInt(ProductoIdTextBox.Text), NombreTextBox.Text, DescripcionTextBox.Text,
                    StringToInt(CantidadTextBox.Text));
                Limpiar();
                MessageBox.Show("Modificado con exito");
            }
           
        }
        private void CategoriaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            producto.Categoria.Add(new Categoria((int)CategoriaIdComboBox.SelectedValue, CategoriaIdComboBox.Text));
            CategoriaDataGridView.AutoGenerateColumns = false;
            CategoriaDataGridView.DataSource = null;
            CategoriaDataGridView.DataSource = producto.Categoria;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            producto.Presentacion.Add(new Presentacion((int)PresentacionIdComboBox.SelectedValue, PresentacionIdComboBox.Text));
            PresentacionDataGridView.AutoGenerateColumns = false;
            PresentacionDataGridView.DataSource = null;
            PresentacionDataGridView.DataSource = producto.Presentacion;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (Validar("Intrudusca Id") && ValidarProducto())
            {
                ProductoBll.Eliminar(StringToInt(ProductoIdTextBox.Text));
                Limpiar();
                MessageBox.Show("Eliminado con Exito");
            }
            
        }
    }
}

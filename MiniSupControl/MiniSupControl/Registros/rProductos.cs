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
        public rProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LlenaCampos(ProductoBll.Buscar(StringToInt(ProductoIdTextBox.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Limpiar()
        {
            ProductoIdTextBox.Clear();
            NombreTextBox.Clear();
            DescripcionTextBox.Clear();
            CantidadTextBox.Clear();
            PresentacionComboBox.SelectedIndex = 0;
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

        private void rProductos_Load(object sender, EventArgs e)
        {
            PresentacionComboBox.DataSource = CategoriaBll.GetLista();
            PresentacionComboBox.ValueMember = "CategoriaId";
            PresentacionComboBox.DisplayMember = "Descripcion";

            PresentacionComboBox.DataSource = PresentacionBll.GetLista();
            PresentacionComboBox.ValueMember = "PresentacionId";
            PresentacionComboBox.DisplayMember = "Descripcion";
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            LlenarClase(producto);
            ProductoBll.Insertar(producto);
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            LlenarClase(producto);
            ProductoBll.Modificar(StringToInt(ProductoIdTextBox.Text), NombreTextBox.Text, DescripcionTextBox.Text,
                StringToInt(CantidadTextBox.Text), StringToInt(PresentacionComboBox.Text));
        }
        private void CategoriaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            producto.Categoria.Add(new Categoria((int)CategoriaIdComboBox.SelectedValue, CategoriaIdComboBox.Text));
            CategoriaDataGridView.AutoGenerateColumns = false;
            CategoriaDataGridView.DataSource = producto.Categoria;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            producto.Presentacion.Add(new Presentacion((int)PresentacionIdComboBox.SelectedValue, PresentacionIdComboBox.Text));
            CategoriaDataGridView.AutoGenerateColumns = false;
            CategoriaDataGridView.DataSource = producto.Presentacion;
        }
    }
}

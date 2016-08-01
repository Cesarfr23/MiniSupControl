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
    public partial class rCategoria : Form
    {
        Categoria categoria = new Categoria();
        public rCategoria()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            try
            {
                LlenaCampos(CategoriaBll.Buscar(StringToInt(CategoriaIdTextBox.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpiar()
        {
            CategoriaIdTextBox.Clear();
            DescripcionTextBox.Clear();
        }

        private void LlenaCampos(Categoria categoria)
        {
            CategoriaIdTextBox.Text = categoria.CategoriaId.ToString();
            DescripcionTextBox.Text = categoria.Descripcion;

        }

        private void LlenarClase(Categoria categoria)
        {
            categoria.CategoriaId = StringToInt(CategoriaIdTextBox.Text);
            categoria.Descripcion = DescripcionTextBox.Text;
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
            LlenarClase(categoria);
            CategoriaBll.Insertar(categoria);
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            LlenarClase(categoria);
            CategoriaBll.Modificar(StringToInt(CategoriaIdTextBox.Text), DescripcionTextBox.Text);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            CategoriaBll.Eliminar(StringToInt(CategoriaIdTextBox.Text));
            Limpiar();
        }
    }
   
}

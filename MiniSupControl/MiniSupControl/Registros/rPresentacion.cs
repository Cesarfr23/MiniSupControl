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
    public partial class rPresentacion : Form
    {
        Presentacion presentacion = new Presentacion();
        public rPresentacion()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            try
            {
                LlenaCampos(PresentacionBll.Buscar(StringToInt(PresentacionIdTextBox.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Limpiar()
        {
            PresentacionIdTextBox.Clear();
            DescripcionTextBox.Clear();
        }

        private void LlenaCampos(Presentacion presentacion)
        {
            PresentacionIdTextBox.Text = presentacion.PresentacionId.ToString();
            DescripcionTextBox.Text = presentacion.Descripcion;

        }

        private void LlenarClase(Presentacion presentacion)
        {
            presentacion.PresentacionId = StringToInt(PresentacionIdTextBox.Text);
            presentacion.Descripcion = DescripcionTextBox.Text;
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
            LlenarClase(presentacion);
            PresentacionBll.Insertar(presentacion);
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            LlenarClase(presentacion);
            PresentacionBll.Modificar(StringToInt(PresentacionIdTextBox.Text), DescripcionTextBox.Text);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            PresentacionBll.Eliminar(StringToInt(PresentacionIdTextBox.Text));
            Limpiar();
        }
    }
}

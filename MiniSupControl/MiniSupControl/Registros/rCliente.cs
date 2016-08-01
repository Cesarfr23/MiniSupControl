using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace MiniSupControl.Registros
{
    public partial class rCliente : Form
    {
        Cliente cliente = new Cliente();
        public rCliente()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            try
            {
               LlenaCampos(ClienteBll.Buscar(StringToInt(ClienteIdTextBox.Text)));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpiar()
        {
            ClienteIdTextBox.Clear();
            NombreTextBox.Clear();
            ApellidoTextBox.Clear();
            DireccionTextBox.Clear();
            TelefonoMaskedTextBox.Clear();
            DeudaTextBox.Clear();
        }

        private void LlenaCampos(Cliente cliente)
        {
            ClienteIdTextBox.Text = cliente.ClienteId.ToString();
            NombreTextBox.Text = cliente.Nombre;
            ApellidoTextBox.Text = cliente.Apellido;
            DireccionTextBox.Text = cliente.Direccion;
            TelefonoMaskedTextBox.Text = cliente.Telefono;
            DeudaTextBox.Text = cliente.Deuda.ToString();
        }

        private void LlenarClase(Cliente cliente)
        {
            cliente.ClienteId = StringToInt(ClienteIdTextBox.Text);
            cliente.Nombre = NombreTextBox.Text;
            cliente.Apellido = ApellidoTextBox.Text;
            cliente.Direccion = DireccionTextBox.Text;
            cliente.Telefono = TelefonoMaskedTextBox.Text;
            cliente.Deuda = StringToInt(DeudaTextBox.Text);
        }

        public int StringToInt(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            LlenarClase(cliente);
            ClienteBll.Insertar(cliente);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            LlenarClase(cliente);
            ClienteBll.Modificar(StringToInt(ClienteIdTextBox.Text), NombreTextBox.Text, ApellidoTextBox.Text, 
                DireccionTextBox.Text, TelefonoMaskedTextBox.Text, StringToInt(DeudaTextBox.Text));
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            ClienteBll.Eliminar(StringToInt(ClienteIdTextBox.Text));
            Limpiar();
        }
    }
}

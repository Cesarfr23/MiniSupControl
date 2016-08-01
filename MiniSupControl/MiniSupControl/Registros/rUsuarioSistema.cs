using MiniSupControl.Registros;
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
    public partial class rUsuarioSistema : Form
    {
        Usuario usuario = new Usuario();
        public rUsuarioSistema()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            try
            {
                LlenaCampos(UsuarioBll.Buscar(StringToInt(UsuarioIdTextBox.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpiar()
        {
            UsuarioIdTextBox.Clear();
            NombreTextBox.Clear();
            ApellidoTextBox.Clear();
            SexoComboBox.SelectedIndex = 0;
            CorreoTextBox.Clear();
            AccesoComboBox.SelectedIndex = 0;
            UsuarioTextBox.Clear();
            PassTextBox.Clear();
            ConfiPassTextBox.Clear();
        }

        private void LlenaCampos(Usuario usuario)
        {
            UsuarioIdTextBox.Text = usuario.UsuarioId.ToString();
            NombreTextBox.Text = usuario.Nombre;
            ApellidoTextBox.Text = usuario.Apellido;
            SexoComboBox.Text = usuario.Sexo;
            CorreoTextBox.Text = usuario.Correo;
            AccesoComboBox.Text = usuario.Acceso;
            UsuarioTextBox.Text = usuario.UseName;
            PassTextBox.Text = usuario.Clave;
            ConfiPassTextBox.Text = usuario.ConfirmarClave;

        }

        private void LlenarClase(Usuario usuario)
        {
            usuario.UsuarioId = StringToInt(UsuarioIdTextBox.Text);
            usuario.Nombre = NombreTextBox.Text;
            usuario.Apellido = ApellidoTextBox.Text;
            usuario.Sexo = SexoComboBox.Text;
            usuario.Fecha_Nacimiento = FechaDataTimePicker.Text;
            usuario.Correo = CorreoTextBox.Text;
            usuario.Acceso = AccesoComboBox.Text;
            usuario.UseName = UsuarioTextBox.Text;
            usuario.Clave = PassTextBox.Text;
            usuario.ConfirmarClave = ConfiPassTextBox.Text;
        }

        public int StringToInt(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            LlenarClase(usuario);
            UsuarioBll.Insertar(usuario);
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            LlenarClase(usuario);
            UsuarioBll.Modificar(StringToInt(UsuarioIdTextBox.Text), NombreTextBox.Text, ApellidoTextBox.Text,
                SexoComboBox.Text, FechaDataTimePicker.Text, CorreoTextBox.Text, AccesoComboBox.Text, UsuarioTextBox.Text,
                PassTextBox.Text, ConfiPassTextBox.Text);

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            UsuarioBll.Eliminar(StringToInt(UsuarioIdTextBox.Text));
            Limpiar();
        }
    }
}

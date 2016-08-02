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
            if (Validar("Favor Inserte el Id") && ValidarBuscar())
            {
                LlenaCampos(UsuarioBll.Buscar(StringToInt(UsuarioIdTextBox.Text)));
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
        private bool Validar(string message)
        {
            if (string.IsNullOrEmpty(UsuarioIdTextBox.Text))
            {
                ErrorProvider.ReferenceEquals(UsuarioIdTextBox, "Ingresar el ID");
                MessageBox.Show(message);
                return false;
            }
            else
            {

                return true;
            }
        }
        public int StringToInt(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }

        private bool ValidarBuscar()
        {
            if (UsuarioBll.Buscar(StringToInt(UsuarioIdTextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }
            return true;

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
            if (ValidarUsuario())
            {
                UsuarioBll.Insertar(usuario);
                Limpiar();
                MessageBox.Show("Guardado con exito");
            }

        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            if(Validar("Intrudusca Id") && ValidarUsuario())
            {
                LlenarClase(usuario);
                UsuarioBll.Modificar(StringToInt(UsuarioIdTextBox.Text), NombreTextBox.Text, ApellidoTextBox.Text,
                    SexoComboBox.Text, FechaDataTimePicker.Text, CorreoTextBox.Text, AccesoComboBox.Text, UsuarioTextBox.Text,
                    PassTextBox.Text, ConfiPassTextBox.Text);
                Limpiar();
                MessageBox.Show("Modificado con exito");
            }

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            UsuarioBll.Eliminar(StringToInt(UsuarioIdTextBox.Text));
            Limpiar();
            MessageBox.Show("Eliminado con Exito");
        }

        private bool ValidarUsuario()
        {
            if (string.IsNullOrEmpty(UsuarioTextBox.Text) && string.IsNullOrEmpty(PassTextBox.Text) && string.IsNullOrEmpty(ConfiPassTextBox.Text))
            {
                ErrorProvider.Equals(UsuarioTextBox, "Favor ingresar el nombre de Usuario");
                ErrorProvider.Equals(PassTextBox, "Favor ingresar la contraseña");
                ErrorProvider.Equals(ConfiPassTextBox, "Favor confirmar comtraseña");
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(UsuarioTextBox.Text))
            {
                ErrorProvider.Equals(UsuarioTextBox, "Favor ingresar el nombre de Usuario");
                return false;
            }

            if (string.IsNullOrEmpty(PassTextBox.Text))
            {
                ErrorProvider.Equals(PassTextBox, "Favor ingresar la contraseña del usuario");
                return false;
            }
            if (string.IsNullOrEmpty(ConfiPassTextBox.Text))
            {
                ErrorProvider.Equals(ConfiPassTextBox, "Favor confirmar comtraseña");
                return false;
            }

            if (ConfiPassTextBox.Text != PassTextBox.Text)
            {

                ErrorProvider.Equals(ConfiPassTextBox, "La contraseña no coincide");
                return false;
            }
            return true;

    }
}
}

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

namespace MiniSupControl
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        public int StringToInt(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {

            MiniSupControl miniSupControl = new MiniSupControl();
            var db = new Usuario();
           
            if (db!= null)
            {
                miniSupControl.Show();
            }
            else
                MessageBox.Show("Usuario Invalido");
            
                this.Hide();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

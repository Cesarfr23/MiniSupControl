using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupControl.Reportes
{
    public partial class ReorteProductos : Form
    {
        public ReorteProductos()
        {
            InitializeComponent();
        }

        private void ReorteProductos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}

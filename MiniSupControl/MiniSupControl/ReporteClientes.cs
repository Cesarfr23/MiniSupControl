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
    public partial class ReporteClientes : Form
    {
        public ReporteClientes()
        {
            InitializeComponent();
        }

        private void ReporteClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MiniSubControlDbDataSet.Clientes' table. You can move, or remove it, as needed.
            this.ClientesTableAdapter.Fill(this.MiniSubControlDbDataSet.Clientes);

            this.reportViewer1.RefreshReport();
        }
    }
}

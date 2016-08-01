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
    public partial class ReporteProveedores : Form
    {
        public ReporteProveedores()
        {
            InitializeComponent();
        }

        private void ReporteProveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MiniSubControlDbDataSet.Proveedors' table. You can move, or remove it, as needed.
            this.ProveedorsTableAdapter.Fill(this.MiniSubControlDbDataSet.Proveedors);

            this.reportViewer1.RefreshReport();
        }
    }
}

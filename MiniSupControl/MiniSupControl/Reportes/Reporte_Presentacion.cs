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
    public partial class Reporte_Presentacion : Form
    {
        public Reporte_Presentacion()
        {
            InitializeComponent();
        }

        private void Reporte_Presentacion_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}

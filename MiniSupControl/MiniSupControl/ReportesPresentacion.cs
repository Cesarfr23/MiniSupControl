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
    public partial class ReportesPresentacion : Form
    {
        public ReportesPresentacion()
        {
            InitializeComponent();
        }

        private void ReportesPresentacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MiniSubControlDbDataSet.Presentacions' table. You can move, or remove it, as needed.
            this.PresentacionsTableAdapter.Fill(this.MiniSubControlDbDataSet.Presentacions);

            this.reportViewer1.RefreshReport();
        }
    }
}

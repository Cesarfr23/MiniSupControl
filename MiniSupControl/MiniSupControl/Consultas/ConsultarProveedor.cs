using BLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupControl.Consultas
{
    public partial class ConsultarProveedor : Form
    {
        public ConsultarProveedor()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            ProveedorDataGridView.DataSource = ProveedorBll.GetLista();
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            ReportingViewer viewer = new ReportingViewer();
            viewer.reportViewer1.Reset();
            viewer.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.reportViewer1.LocalReport.ReportPath = @"Reportes\Listado_Proveedores.rdlc";

            viewer.reportViewer1.LocalReport.DataSources.Clear();

            viewer.reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("Proveedor",
                ProveedorBll.GetLista()));

            viewer.reportViewer1.LocalReport.Refresh();
            viewer.Show();
        }
    }
}

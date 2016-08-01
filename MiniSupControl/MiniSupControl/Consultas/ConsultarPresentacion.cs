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
    public partial class ConsultarPresentacion : Form
    {
        public ConsultarPresentacion()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
           PresentacionDataGridView.DataSource = PresentacionBll.GetLista();
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            ReportingViewer viewer = new ReportingViewer();
            viewer.reportViewer1.Reset();
            viewer.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.reportViewer1.LocalReport.ReportPath = @"Reportes\Listado_Presentacion.rdlc";

            viewer.reportViewer1.LocalReport.DataSources.Clear();

            viewer.reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("Presentacion",
                PresentacionBll.GetLista()));

            viewer.reportViewer1.LocalReport.Refresh();
            viewer.Show();
        }
    }
}

﻿using BLL;
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
    public partial class ConsultarCategorias : Form
    {
        public ConsultarCategorias()
        {
            InitializeComponent();
        }

        private void ConsultarCategorias_Load(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            CategoriaDataGridView.DataSource = CategoriaBll.GetLista();
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            ReportingViewer viewer = new ReportingViewer();
            viewer.reportViewer1.Reset();
            viewer.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.reportViewer1.LocalReport.ReportPath = @"Reportes\ListadoCategorias.rdlc";

            viewer.reportViewer1.LocalReport.DataSources.Clear();

            viewer.reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("Categorias",
                CategoriaBll.GetLista()));

            viewer.reportViewer1.LocalReport.Refresh();
            viewer.Show();
        }

        private void FiltrarTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CategoriaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

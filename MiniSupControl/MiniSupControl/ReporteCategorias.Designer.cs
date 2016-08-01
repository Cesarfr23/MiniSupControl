namespace MiniSupControl
{
    partial class ReporteCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CategoriaReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MiniSubControlDbDataSet = new MiniSubControlDbDataSet();
            this.CategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoriasTableAdapter = new MiniSubControlDbDataSetTableAdapters.CategoriasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MiniSubControlDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriaReportViewer
            // 
            this.CategoriaReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Categorias";
            reportDataSource1.Value = this.CategoriasBindingSource;
            this.CategoriaReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.CategoriaReportViewer.LocalReport.ReportEmbeddedResource = "MiniSupControl.Reportes.Listado_Categorias.rdlc";
            this.CategoriaReportViewer.Location = new System.Drawing.Point(0, 0);
            this.CategoriaReportViewer.Name = "CategoriaReportViewer";
            this.CategoriaReportViewer.Size = new System.Drawing.Size(656, 375);
            this.CategoriaReportViewer.TabIndex = 0;
            // 
            // MiniSubControlDbDataSet
            // 
            this.MiniSubControlDbDataSet.DataSetName = "MiniSubControlDbDataSet";
            this.MiniSubControlDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CategoriasBindingSource
            // 
            this.CategoriasBindingSource.DataMember = "Categorias";
            this.CategoriasBindingSource.DataSource = this.MiniSubControlDbDataSet;
            // 
            // CategoriasTableAdapter
            // 
            this.CategoriasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 375);
            this.Controls.Add(this.CategoriaReportViewer);
            this.Name = "ReporteCategorias";
            this.Text = "ReporteCategorias";
            this.Load += new System.EventHandler(this.ReporteCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MiniSubControlDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer CategoriaReportViewer;
        private System.Windows.Forms.BindingSource CategoriasBindingSource;
        private MiniSubControlDbDataSet MiniSubControlDbDataSet;
        private MiniSubControlDbDataSetTableAdapters.CategoriasTableAdapter CategoriasTableAdapter;
    }
}
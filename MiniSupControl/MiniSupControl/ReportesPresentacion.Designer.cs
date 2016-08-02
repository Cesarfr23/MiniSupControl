namespace MiniSupControl
{
    partial class ReportesPresentacion
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MiniSubControlDbDataSet = new MiniSubControlDbDataSet();
            this.PresentacionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PresentacionsTableAdapter = new MiniSubControlDbDataSetTableAdapters.PresentacionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MiniSubControlDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresentacionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Presentacion";
            reportDataSource1.Value = this.PresentacionsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MiniSupControl.Reportes.Listado_Presentacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(696, 308);
            this.reportViewer1.TabIndex = 0;
            // 
            // MiniSubControlDbDataSet
            // 
            this.MiniSubControlDbDataSet.DataSetName = "MiniSubControlDbDataSet";
            this.MiniSubControlDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PresentacionsBindingSource
            // 
            this.PresentacionsBindingSource.DataMember = "Presentacions";
            this.PresentacionsBindingSource.DataSource = this.MiniSubControlDbDataSet;
            // 
            // PresentacionsTableAdapter
            // 
            this.PresentacionsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportesPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 308);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportesPresentacion";
            this.Text = "ReportesPresentacion";
            this.Load += new System.EventHandler(this.ReportesPresentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MiniSubControlDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresentacionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MiniSubControlDbDataSet MiniSubControlDbDataSet;
        private System.Windows.Forms.BindingSource PresentacionsBindingSource;
        private MiniSubControlDbDataSetTableAdapters.PresentacionsTableAdapter PresentacionsTableAdapter;
    }
}
namespace MiniSupControl
{
    partial class ReporteProveedores
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
            this.ProveedorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProveedorsTableAdapter = new MiniSubControlDbDataSetTableAdapters.ProveedorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MiniSubControlDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Proveedores";
            reportDataSource1.Value = this.ProveedorsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MiniSupControl.Reportes.Listado_Proveedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(656, 339);
            this.reportViewer1.TabIndex = 0;
            // 
            // MiniSubControlDbDataSet
            // 
            this.MiniSubControlDbDataSet.DataSetName = "MiniSubControlDbDataSet";
            this.MiniSubControlDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProveedorsBindingSource
            // 
            this.ProveedorsBindingSource.DataMember = "Proveedors";
            this.ProveedorsBindingSource.DataSource = this.MiniSubControlDbDataSet;
            // 
            // ProveedorsTableAdapter
            // 
            this.ProveedorsTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 339);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteProveedores";
            this.Text = "ReporteProveedores";
            this.Load += new System.EventHandler(this.ReporteProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MiniSubControlDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MiniSubControlDbDataSet miniSubControlDbDataSet;
        private System.Windows.Forms.BindingSource miniSubControlDbDataSetBindingSource;
        private System.Windows.Forms.BindingSource ProveedorsBindingSource;
        private MiniSubControlDbDataSet MiniSubControlDbDataSet;
        private MiniSubControlDbDataSetTableAdapters.ProveedorsTableAdapter ProveedorsTableAdapter;
    }
}
namespace MiniSupControl.Consultas
{
    partial class ConsultarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarProveedor));
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.FiltrarTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProveedorDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.BackColor = System.Drawing.Color.White;
            this.ImprimirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimirButton.Image")));
            this.ImprimirButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ImprimirButton.Location = new System.Drawing.Point(56, 326);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(75, 61);
            this.ImprimirButton.TabIndex = 9;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ImprimirButton.UseVisualStyleBackColor = false;
            this.ImprimirButton.Click += new System.EventHandler(this.ImprimirButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackColor = System.Drawing.Color.White;
            this.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(268, 36);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(103, 46);
            this.BuscarButton.TabIndex = 8;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarButton.UseVisualStyleBackColor = false;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // FiltrarTextBox
            // 
            this.FiltrarTextBox.Location = new System.Drawing.Point(107, 66);
            this.FiltrarTextBox.Name = "FiltrarTextBox";
            this.FiltrarTextBox.Size = new System.Drawing.Size(100, 20);
            this.FiltrarTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtrar";
            // 
            // ProveedorDataGridView
            // 
            this.ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProveedorDataGridView.Location = new System.Drawing.Point(56, 109);
            this.ProveedorDataGridView.Name = "ProveedorDataGridView";
            this.ProveedorDataGridView.Size = new System.Drawing.Size(568, 211);
            this.ProveedorDataGridView.TabIndex = 5;
            // 
            // ConsultarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(676, 423);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.FiltrarTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProveedorDataGridView);
            this.Name = "ConsultarProveedor";
            this.Text = "ConsultarProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox FiltrarTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProveedorDataGridView;
    }
}
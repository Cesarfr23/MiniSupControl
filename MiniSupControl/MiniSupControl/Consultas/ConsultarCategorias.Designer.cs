namespace MiniSupControl.Consultas
{
    partial class ConsultarCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCategorias));
            this.CategoriaDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrarTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ImprimirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriaDataGridView
            // 
            this.CategoriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriaDataGridView.Location = new System.Drawing.Point(31, 99);
            this.CategoriaDataGridView.Name = "CategoriaDataGridView";
            this.CategoriaDataGridView.Size = new System.Drawing.Size(568, 211);
            this.CategoriaDataGridView.TabIndex = 0;
            this.CategoriaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriaDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FiltrarTextBox
            // 
            this.FiltrarTextBox.Location = new System.Drawing.Point(82, 56);
            this.FiltrarTextBox.Name = "FiltrarTextBox";
            this.FiltrarTextBox.Size = new System.Drawing.Size(100, 20);
            this.FiltrarTextBox.TabIndex = 2;
            this.FiltrarTextBox.TextChanged += new System.EventHandler(this.FiltrarTextBox_TextChanged);
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackColor = System.Drawing.Color.White;
            this.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(243, 26);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(103, 46);
            this.BuscarButton.TabIndex = 3;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarButton.UseVisualStyleBackColor = false;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.BackColor = System.Drawing.Color.White;
            this.ImprimirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimirButton.Image")));
            this.ImprimirButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ImprimirButton.Location = new System.Drawing.Point(31, 316);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(75, 61);
            this.ImprimirButton.TabIndex = 4;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ImprimirButton.UseVisualStyleBackColor = false;
            this.ImprimirButton.Click += new System.EventHandler(this.ImprimirButton_Click);
            // 
            // ConsultarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(628, 396);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.FiltrarTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoriaDataGridView);
            this.Name = "ConsultarCategorias";
            this.Text = "ConsultarCategorias";
            this.Load += new System.EventHandler(this.ConsultarCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoriaDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FiltrarTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button ImprimirButton;
    }
}
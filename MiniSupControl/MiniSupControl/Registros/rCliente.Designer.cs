﻿namespace MiniSupControl.Registros
{
    partial class rCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.DeudaTextBox = new System.Windows.Forms.TextBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.ClienteIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TelefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.TelefonoMaskedTextBox);
            this.groupBox1.Controls.Add(this.BuscarButton);
            this.groupBox1.Controls.Add(this.DeudaTextBox);
            this.groupBox1.Controls.Add(this.DireccionTextBox);
            this.groupBox1.Controls.Add(this.ApellidoTextBox);
            this.groupBox1.Controls.Add(this.NombreTextBox);
            this.groupBox1.Controls.Add(this.ClienteIdTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Cliente";
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackColor = System.Drawing.Color.White;
            this.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(385, 19);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(96, 46);
            this.BuscarButton.TabIndex = 12;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarButton.UseVisualStyleBackColor = false;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // DeudaTextBox
            // 
            this.DeudaTextBox.Location = new System.Drawing.Point(88, 209);
            this.DeudaTextBox.Name = "DeudaTextBox";
            this.DeudaTextBox.Size = new System.Drawing.Size(146, 20);
            this.DeudaTextBox.TabIndex = 10;
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(88, 141);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(432, 20);
            this.DireccionTextBox.TabIndex = 9;
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(88, 105);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(432, 20);
            this.ApellidoTextBox.TabIndex = 8;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(88, 69);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(432, 20);
            this.NombreTextBox.TabIndex = 7;
            // 
            // ClienteIdTextBox
            // 
            this.ClienteIdTextBox.Location = new System.Drawing.Point(88, 33);
            this.ClienteIdTextBox.Name = "ClienteIdTextBox";
            this.ClienteIdTextBox.Size = new System.Drawing.Size(278, 20);
            this.ClienteIdTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Deuda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ClienteId";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NuevoButton.BackColor = System.Drawing.Color.White;
            this.NuevoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(35, 329);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 61);
            this.NuevoButton.TabIndex = 1;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = false;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GuardarButton.BackColor = System.Drawing.Color.White;
            this.GuardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(194, 329);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 61);
            this.GuardarButton.TabIndex = 2;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = false;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModificarButton.BackColor = System.Drawing.Color.White;
            this.ModificarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.Image = ((System.Drawing.Image)(resources.GetObject("ModificarButton.Image")));
            this.ModificarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ModificarButton.Location = new System.Drawing.Point(356, 329);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 61);
            this.ModificarButton.TabIndex = 3;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ModificarButton.UseVisualStyleBackColor = false;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EliminarButton.BackColor = System.Drawing.Color.White;
            this.EliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(515, 329);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 61);
            this.EliminarButton.TabIndex = 4;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = false;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cliente";
            // 
            // TelefonoMaskedTextBox
            // 
            this.TelefonoMaskedTextBox.Location = new System.Drawing.Point(88, 177);
            this.TelefonoMaskedTextBox.Mask = "000-000-0000";
            this.TelefonoMaskedTextBox.Name = "TelefonoMaskedTextBox";
            this.TelefonoMaskedTextBox.Size = new System.Drawing.Size(75, 20);
            this.TelefonoMaskedTextBox.TabIndex = 13;
            // 
            // rCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(626, 419);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(642, 458);
            this.Name = "rCliente";
            this.Text = "Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox DeudaTextBox;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox ClienteIdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox TelefonoMaskedTextBox;
    }
}
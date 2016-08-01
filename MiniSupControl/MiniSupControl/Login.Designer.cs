namespace MiniSupControl
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PassTextBox
            // 
            this.PassTextBox.AllowDrop = true;
            this.PassTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTextBox.Location = new System.Drawing.Point(252, 196);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(221, 26);
            this.PassTextBox.TabIndex = 11;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.AllowDrop = true;
            this.UsuarioTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.Location = new System.Drawing.Point(252, 145);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(221, 26);
            this.UsuarioTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(143, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(143, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario";
            // 
            // CancelarButton
            // 
            this.CancelarButton.AllowDrop = true;
            this.CancelarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelarButton.BackColor = System.Drawing.Color.White;
            this.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.ForeColor = System.Drawing.Color.MediumBlue;
            this.CancelarButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelarButton.Image")));
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.Location = new System.Drawing.Point(401, 292);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(127, 46);
            this.CancelarButton.TabIndex = 7;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AceptarButton.BackColor = System.Drawing.Color.White;
            this.AceptarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AceptarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarButton.ForeColor = System.Drawing.Color.MediumBlue;
            this.AceptarButton.Image = ((System.Drawing.Image)(resources.GetObject("AceptarButton.Image")));
            this.AceptarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarButton.Location = new System.Drawing.Point(105, 292);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(124, 46);
            this.AceptarButton.TabIndex = 6;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AceptarButton.UseVisualStyleBackColor = false;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 396);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.MinimumSize = new System.Drawing.Size(652, 435);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button AceptarButton;
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupControl.Reportes
{
    public partial class ReporteProveedores : Form
    {
        public ReporteProveedores()
        {
            InitializeComponent();
        }

        private void ReporteProveedores_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}

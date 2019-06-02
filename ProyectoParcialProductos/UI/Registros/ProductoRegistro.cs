﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoParcialProductos.DAL;
using ProyectoParcialProductos.BLL;
using ProyectoParcialProductos.Entidades;

namespace ProyectoParcialProductos.UI.Registros
{
    public partial class ProductoRegistro : Form
    {
        public ProductoRegistro()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            ExistencianumericUpDow.Value = 0;
            CostonumericUpDown.Value = 0;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

     
    }
}

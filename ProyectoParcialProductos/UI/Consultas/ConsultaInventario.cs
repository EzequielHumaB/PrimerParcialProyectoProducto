using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoParcialProductos.UI.Registros;
using ProyectoParcialProductos.Entidades;

namespace ProyectoParcialProductos.UI.Consultas
{
    public partial class ConsultaInventario : Form
    {
        public ConsultaInventario()
        {
            InitializeComponent();
        }

        private void Refrescarbutton_Click(object sender, EventArgs e)
        {
            ProductoRegistro productoRegistro = new ProductoRegistro();
            Productos productos = new Productos();
            decimal total = productos.costo * productos.existencia;

            TotalInventarioConsultatextBox.Text = total.ToString();
        }
    }
}

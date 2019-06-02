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
using ProyectoParcialProductos.UI.Consultas;

namespace ProyectoParcialProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RegistrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoRegistro productoRegistro = new ProductoRegistro();
            productoRegistro.StartPosition = FormStartPosition.CenterScreen;
            productoRegistro.Show();
        }

        private void ConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaInventario consultaInventario = new ConsultaInventario();
            consultaInventario.StartPosition = FormStartPosition.CenterScreen;
            consultaInventario.Show();
        }
    }
}

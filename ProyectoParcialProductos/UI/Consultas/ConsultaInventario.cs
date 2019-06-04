using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoParcialProductos.BLL;
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

        public decimal Consulta()
        {
            decimal resultado = 0;
            List<Productos> productos1 = new List<Productos>();
            productos1 = ProductosClase.GetList(p => true);

            foreach (var valore in productos1)
            {
                resultado += valore.ValorInventario;
            }
            return resultado;
        }

    
        private void Igualar()
        {
            TotalInventarios totalInventario = new TotalInventarios();
            totalInventario.ProductoId = (int)IDnumericUpDown.Value;
        }

     

        public bool Guardar()
        {
            bool paso = false;
            Igualar();
            TotalInventarios totalInventario = new TotalInventarios();
            if (IDnumericUpDown.Value == 0 )
            {
                paso = TotalInventariosClase.Guardar(totalInventario);
            } else
            {
                paso = TotalInventariosClase.Modificar(totalInventario);           
            }

            return paso;
        }

        private void Refrescarbutton_Click(object sender, EventArgs e)
        {
            Guardar();
            TotalInventarioConsultatextBox.Text = Consulta().ToString();
            TotalInventarios total = new TotalInventarios();
            total.InventarioTotal = Convert.ToDecimal(TotalInventarioConsultatextBox.Text);
        }
    }
}

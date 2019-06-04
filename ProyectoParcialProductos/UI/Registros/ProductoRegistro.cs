using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoParcialProductos.DAL;
using ProyectoParcialProductos.UI.Registros;
using ProyectoParcialProductos.BLL;
using ProyectoParcialProductos.Entidades;
using ProyectoParcialProductos.UI.Consultas;
using System.Collections;

namespace ProyectoParcialProductos.UI.Registros
{
    public partial class ProductoRegistro : Form
    {
        public ProductoRegistro()
        {
            InitializeComponent();

            LlenarComboBox();
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


        private Productos LlenarClase()
        {
            Productos productos = new Productos();
            try
            {
                productos.ProductoId = (int)IDnumericUpDown.Value;
                productos.Descripcion = DescripciontextBox.Text.Trim();
                productos.costo = CostonumericUpDown.Value;
                productos.existencia = (int)ExistencianumericUpDow.Value;
                TotalnumericUpDown.Value = CostonumericUpDown.Value * ExistencianumericUpDow.Value;
                productos.ValorInventario = TotalnumericUpDown.Value;
            }
            catch(Exception)
            {
                MessageBox.Show("Valor no admitido");
            }
            return productos;
        }
        private void LlenarCampo(Productos productos)
        {
            try
            {
                IDnumericUpDown.Value = productos.ProductoId;
                DescripciontextBox.Text = productos.Descripcion;
                ExistencianumericUpDow.Value = productos.existencia;
                CostonumericUpDown.Value = productos.costo;
                TotalnumericUpDown.Value = CostonumericUpDown.Value * ExistencianumericUpDow.Value;
                productos.ValorInventario = TotalnumericUpDown.Value;
            }
            catch(Exception)
            {
                MessageBox.Show("Valor no admitido");
            }
        }

        public bool Validar()
        {
            bool paso = true;
            if (String.IsNullOrEmpty(DescripciontextBox.Text))
            {
                MessageBox.Show("La descripcion no puede estar vacia");
                DescripciontextBox.Focus();
                paso = false;
            }
         
            if (CostonumericUpDown.Value == 0)
            {
                MessageBox.Show("El costo no puede estar vacio");
                CostonumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Productos productos = ProductosClase.Buscar((int)IDnumericUpDown.Value);
            return (productos != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
       { 

        Productos producto;
        bool paso = false;

            if (!Validar())
                return;

            producto = LlenarClase();

            if (IDnumericUpDown.Value == 0)
            {
                paso = ProductosClase.Guardar(producto);
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(IDnumericUpDown.Value);
                producto = ProductosClase.Buscar(id);

                if (producto != null)
                {
                    paso = ProductosClase.Modificar(LlenarClase());
                    MessageBox.Show("Modificado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Id no existe", "Falló",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (paso)
            {
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            id = (int)IDnumericUpDown.Value;
            Limpiar();
            try
            {
                if (ProductosClase.Eliminar(id))
                {
                    MessageBox.Show("Eliminado correctamente");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No se pudo eliminar");
            }
          
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = (int)IDnumericUpDown.Value;
            try
            {
                Productos productos = ProductosClase.Buscar(id);
                if (productos != null)
                {
                    MessageBox.Show("Producto encontrado");
                    LlenarCampo(productos);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                    Limpiar();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No existe el producto");
            }

        }

        private void CostonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TotalnumericUpDown.Value = CostonumericUpDown.Value * ExistencianumericUpDow.Value;
        }

        private void ExistencianumericUpDow_ValueChanged(object sender, EventArgs e)
        {
            TotalnumericUpDown.Value = CostonumericUpDown.Value * ExistencianumericUpDow.Value;
        }

        private void Ubicacionesbutton_Click(object sender, EventArgs e)
        {
            UbicacionesRegistro ubicacionesRegistro = new UbicacionesRegistro();
            ubicacionesRegistro.StartPosition = FormStartPosition.CenterScreen;
            ubicacionesRegistro.Show();
        }

        private void LlenarComboBox()
        {
            var listado = new List<Ubicaciones>();
            listado = UbicacionesClase.getList(p => true);
            UbicacioncomboBox.DataSource = listado;
            UbicacioncomboBox.DisplayMember = "Descripcion";
            UbicacioncomboBox.ValueMember = "UbicacionId";
        }
    }
}

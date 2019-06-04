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
using ProyectoParcialProductos.DAL;
using ProyectoParcialProductos.Entidades;

namespace ProyectoParcialProductos.UI.Registros
{
    public partial class UbicacionesRegistro : Form
    {
        public UbicacionesRegistro()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
        }

        public bool validacion()  //Esta funcion aun no es optima, por eso todavia no la utilizo 
        {
            bool paso = true;
            List<Ubicaciones> ubicaciones = new List<Ubicaciones>();
            Ubicaciones ubicaciones1 = new Ubicaciones();
            foreach(var valor in ubicaciones)
            {
                if (valor.Descripcion == DescripciontextBox.Text)
                {
                    paso = false;
                }
            }
            return paso;
        }

        private Ubicaciones LlenarClase()
        {
            Ubicaciones ubicaciones = new Ubicaciones();
            ubicaciones.UbicacionID = (int)IDnumericUpDown.Value;
            ubicaciones.Descripcion = DescripciontextBox.Text;
            return ubicaciones;
        }

        private void LlenarCampo(Ubicaciones ubicaciones)
        {
           
            IDnumericUpDown.Value = ubicaciones.UbicacionID;
            DescripciontextBox.Text = ubicaciones.Descripcion;
        }

        private bool Validar()
        {
            bool paso = true;
            if(DescripciontextBox.Text == string.Empty)
            {
                MessageBox.Show("La descripcion no puede estar vacia");
                DescripciontextBox.Focus();
                paso = false;
            }
            if (!validacion())
            {
                MessageBox.Show("Los nombre no pueden ser iguales");
                DescripciontextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Ubicaciones ubicaciones = UbicacionesClase.Buscar((int)IDnumericUpDown.Value);
            return (ubicaciones != null);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Ubicaciones ubicaciones;
            bool paso = false;

            if (!Validar())
            {
                return;
            }
            ubicaciones = LlenarClase();
            if (IDnumericUpDown.Value == 0)
            {
                paso = UbicacionesClase.Guardar(ubicaciones);
                MessageBox.Show("Guardado correctamente");
            }
            else
            {
              int id = Convert.ToInt32(IDnumericUpDown.Value);
              ubicaciones = UbicacionesClase.Buscar(id);

             if (ubicaciones != null)
             {
               paso = UbicacionesClase.Modificar(LlenarClase());
               MessageBox.Show("Modificado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
                  MessageBox.Show("Id no existe", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
             if (paso)
             {
               Limpiar();
             }
              else
              MessageBox.Show("No se pudo guardar!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            id = (int)IDnumericUpDown.Value;
            try
            {
                if(UbicacionesClase.Eliminar(id))
                {
                    MessageBox.Show("Eliminado correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar");
                    Limpiar();
                }

            }catch(Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            id = (int)IDnumericUpDown.Value;
            try
            {
                Ubicaciones ubicaciones = UbicacionesClase.Buscar(id);
                if (ubicaciones!=null)
                {
                    MessageBox.Show("Producto encontrado");
                    LlenarCampo(ubicaciones);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                    Limpiar();
                }
            }catch(Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }
    }
}

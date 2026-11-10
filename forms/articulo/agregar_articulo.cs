using PrimeSystems_2._2_.forms.articulo;
using PrimeSystems_2._2_.forms.proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeSystems_2._2_.pruebas
{
    public partial class agregar_articulo : Form
    {
        public agregar_articulo()
        {
            InitializeComponent();
        }

        private void agregar_articulo_Load(object sender, EventArgs e)
        {
            btn_actualizar_producto.Visible = false;
        }

        private void btn_agregar_proveedor_Click(object sender, EventArgs e)
        {
            
            alta_proveedor_popup proveedor = new alta_proveedor_popup();
            proveedor.Show();

        }

        private void btn_agregar_categoria_Click(object sender, EventArgs e)
        {
            alta_categorias altacat = new alta_categorias();
            altacat.Show();
            //agregar form alta categoria
        }

        private void btn_modificar_producto_Click(object sender, EventArgs e)
        {
            //if no seleccionaron nada= mensaje de que seleccione. 
            //selecciono
            //deshabilito
            btn_eliminar_producto.Enabled = false;
            btn_agregar_producto.Enabled = false;
            btn_agregar_producto.Visible = false;
            //muestro
            btn_actualizar_producto.Visible = true;
        }

        private void btn_cerrar_pestana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_actualizar_producto_Click(object sender, EventArgs e)
        {
            //consulta update procuto
            btn_actualizar_producto.Visible = false;
            btn_agregar_producto.Visible = true;
            btn_agregar_producto.Enabled = true;
            btn_eliminar_producto.Enabled = true;
        }

        private void btn_eliminar_producto_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que quiere borrar este articulo?", "confirmacion", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            { //update cambio de estado }
            }
        }
    }
}

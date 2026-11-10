using PrimeSystems_2._2_.BD;
using PrimeSystems_2._2_.forms.MODULOS;
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
    public partial class ventas_interfaz : Form
    {
        public ventas_interfaz()
        {
            InitializeComponent();
        }




        private void ventas_interfaz_Load(object sender, EventArgs e)
        {
            //comienza en invisible
            gb_DetalleVenta.Visible = false;
            dgv_carrito_venta.Visible = false;
            pnl_SubTotal.Visible = false;

            //comienza inhabilitado
            btn_cancelar_venta.Enabled = false;
        }

        private void btn_nueva_venta_Click(object sender, EventArgs e)
        {
            //inhabilito
            btn_borrar_venta.Enabled = false;
            btn_modificar_venta.Enabled = false;

            //habilito
            btn_cancelar_venta.Enabled = true;

            //muestro
            gb_DetalleVenta.Visible = true;
            dgv_carrito_venta.Visible = true;
            pnl_SubTotal.Visible = true;

            // oculto
            dgv_ventas_h.Visible = false;
            pnl_filtro.Visible=false;

        }

        private void btn_cancelar_venta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("seguro que quiere cancelar la operacion?", "cancelar operacion", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
               
                //ocultar
                gb_DetalleVenta.Visible = false;
                dgv_carrito_venta.Visible = false;
                pnl_SubTotal.Visible = false;
                //mostar
                dgv_ventas_h.Visible = true;
                pnl_filtro.Visible = true;
                //habilitar
                btn_modificar_venta.Enabled = true;
                btn_borrar_venta.Enabled = true;
                btn_nueva_venta.Enabled = true;
                //inhgabilotar
                btn_cancelar_venta.Enabled = false;
            }
        }

        private void btn_proc_pago_Click(object sender, EventArgs e)
        {
            
            //habilitar
            btn_borrar_venta.Enabled = true;
            btn_modificar_venta.Enabled = true;
            btn_cancelar_venta.Enabled = false; 

            //ocultar
            gb_DetalleVenta.Visible = false;
            dgv_carrito_venta.Visible = false;
            pnl_SubTotal.Visible = false;

            //mostrar
            dgv_ventas_h.Visible = true;
            pnl_filtro.Visible = true;           
        }
        

        private void btn_crear_producto_Click(object sender, EventArgs e)
        {

            agregar_articulo art = new agregar_articulo();
            art.ShowDialog();
        }

        private void btn_filtro_todos_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void dgv_articulos_h_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void CargarGrilla()
        {
            string consulta = @"select id_usuario AS ID, nombre AS Nombre, apellido AS Apellido,
                        DNI, tel AS Telefono, mail AS Mail, username AS Username, activo AS Estado
                        from Usuario where activo = 1";  //  cambiar a consulta de venta sjasnjsn
            consultas.traer_datos_sql(consulta, dgv_ventas_h);
        }

        private void btn_modificar_venta_Click(object sender, EventArgs e)
        {
            //habilitar
            btn_cancelar_venta.Enabled = true;
            //inhabilitar
            btn_nueva_venta.Enabled = false;
            btn_borrar_venta.Enabled = false;

        }


        private void btn_add_art_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_quitar_art_Click(object sender, EventArgs e)
        {
            
        }
       

    }
}

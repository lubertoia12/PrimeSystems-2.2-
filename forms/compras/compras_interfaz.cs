using PrimeSystems_2._2_.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeSystems_2._2_.forms.compras
{
    public partial class compras_interfaz : Form
    {
        public compras_interfaz()
        {
            InitializeComponent();
        }


        private void cargaEncabezadosCompras()
        {
            string consultaCompras = @"select hc.id_h_compra AS ID, hc.fecha_hora AS Fecha,
            p.proveedor AS Proveedor, u.username AS Comprador,
            hc.sub_total AS Subtotal, hc.descuento AS Descuento, hc.total AS Total
            from H_Compras hc
            inner join Proveedor p on p.id_proveedor = hc.id_proveedor
            inner join Usuario u on u.id_usuario = hc.id_usuario
            where 1 = 0";

            consultas.traer_datos_sql(consultaCompras, dgv_compras_h);
        }



        private void AltaCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            panelcont.Controls.Clear();          // saca el alta del panel
            dgv_compras_h.Visible = true;        // vuelve a mostrar el historial
            CargarGrillaCompras();               // lo recarga con la compra nueva
        }

        public void CargarGrillaCompras()
        {
            string consultaCompras = @"select hc.id_h_compra AS ID, hc.fecha_hora AS Fecha,
            p.proveedor AS Proveedor, u.username AS Comprador,
            hc.sub_total AS Subtotal, hc.descuento AS Descuento, hc.total AS Total
            from H_Compras hc
            inner join Proveedor p on p.id_proveedor = hc.id_proveedor
            inner join Usuario u on u.id_usuario = hc.id_usuario
            order by hc.fecha_hora desc";

            consultas.traer_datos_sql(consultaCompras, dgv_compras_h);
        }

        private void btn_nueva_compra_Click(object sender, EventArgs e)
        {
            dgv_compras_h.Visible = false;
            panelcont.Controls.Clear();

            alta_compra com = new alta_compra();
            com.TopLevel = false;
            com.FormBorderStyle = FormBorderStyle.None;
            com.Dock = DockStyle.Fill;

            com.FormClosed += AltaCompra_FormClosed;
            panelcont.Controls.Add(com);
            com.Show();
        }

        private void btn_filtro_todos_Click(object sender, EventArgs e)
        {
            CargarGrillaCompras();
        }

        private void btn_filtro_activas_Click(object sender, EventArgs e)
        {

        }

        private void btn_filtro_inactivas_Click(object sender, EventArgs e)
        {

        }

        private void compras_interfaz_Load(object sender, EventArgs e)
        {
            cargaEncabezadosCompras();
        }
    }
}

using PrimeSystems_2._2_.BD;
using PrimeSystems_2._2_.forms.MODULOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            // se carga
            cargaEncabezados();

            // arranca en 0 
            lbl_descuento.Text = "0,00";
            lbl_precio_unitario.Text = "0,00";
            lbl_precio_total.Text = "0,00";
            lbl_SUBTOTAL.Text = "0,00";
            lbl_TOTAL_FINAL.Text = "0,00";

            //comienza en invisible
            gb_DetalleVenta.Visible = false;
            dgv_carrito_venta.Visible = false;
            pnl_SubTotal.Visible = false;

            //comienza inhabilitado
            btn_cancelar_venta.Enabled = false;

            // campos de griilla
            dgv_carrito_venta.Columns.Add("Articulo", "Articulo");
            dgv_carrito_venta.Columns.Add("Cantidad", "Cantidad");
            dgv_carrito_venta.Columns.Add("Precio", "Precio");
            dgv_carrito_venta.Columns.Add("Total", "Total");

            dgv_carrito_venta.Columns["Articulo"].ReadOnly = true;
            dgv_carrito_venta.Columns["Precio"].ReadOnly = true;
            dgv_carrito_venta.Columns["Total"].ReadOnly = true;

            // columna  boton quitar
            DataGridViewButtonColumn colQuitar = new DataGridViewButtonColumn();
            colQuitar.Name = "Quitar";
            colQuitar.HeaderText = "";
            colQuitar.Text = "Quitar";
            colQuitar.UseColumnTextForButtonValue = true;
            dgv_carrito_venta.Columns.Add(colQuitar);

            // desplegable cliente
            AutoCompleteStringCollection listaClientes = new AutoCompleteStringCollection();

            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            SqlCommand cm = new SqlCommand("select isnull(nombre, '') + ' ' + isnull(apellido, '') from Cliente", cnn);
            cnn.Open();
            SqlDataReader rd = cm.ExecuteReader();
            while (rd.Read())
            {
                listaClientes.Add(rd[0].ToString());
            }
            cnn.Close();

            txtCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCliente.AutoCompleteCustomSource = listaClientes;

            // lista desplegable articulos
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

            SqlConnection cn = new SqlConnection(ConectaBD.StringConnection);
            SqlCommand cmd = new SqlCommand("select art_descripcion from Articulo", cn);
            cn.Open();                       // antes decia cnn.Open() y el comando usa cn
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr[0].ToString());
            }
            cn.Close();

            txt_articulo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_articulo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_articulo.AutoCompleteCustomSource = lista;
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
            pnl_filtro.Visible = false;
        }

        private void btn_cancelar_venta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("seguro que quiere cancelar la operacion?", "cancelar operacion", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                // vacia el carrito y los campos
                dgv_carrito_venta.Rows.Clear();
                txtCliente.Clear();
                txt_articulo.Clear();
                NuDcantidad.Value = 1;
                ActualizarTotales();

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

        }

        private void btn_crear_producto_Click(object sender, EventArgs e)
        {
            agregar_articulo art = new agregar_articulo();
            art.ShowDialog();
        }

        private void btn_filtro_todos_Click(object sender, EventArgs e)
        {
            CargarGrillaTODAS();
        }

        private void dgv_articulos_h_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            SqlCommand cmd = new SqlCommand(@"select s.costo + (s.costo * s.ganancia / 100)
                from Articulo a
                inner join Stock s on s.id_articulo = a.id_articulo
                where a.art_descripcion = @desc", cnn);
            cmd.Parameters.AddWithValue("@desc", txt_articulo.Text);

            cnn.Open();
            object resultado = cmd.ExecuteScalar();
            cnn.Close();

            if (resultado == null)
            {
                MessageBox.Show("El artículo no existe");
                return;
            }

            decimal precio = Convert.ToDecimal(resultado);
            int cantidad = (int)NuDcantidad.Value;

            dgv_carrito_venta.Rows.Add(txt_articulo.Text, cantidad, precio, precio * cantidad);
            ActualizarTotales();
            txt_articulo.Clear();
            NuDcantidad.Value = 1;
            txt_articulo.Focus();
        }

        private void btn_quitar_art_Click(object sender, EventArgs e)
        {
            txt_articulo.Clear();
            NuDcantidad.Value = 1;
            txt_articulo.Focus();
        }

        private void cargaEncabezados()
        {
            string consultaVentas = @"select v.id_h_ventas AS ID, v.fecha_hora AS Fecha, c.nombre AS Cliente, v.subtotal AS Subtotal, v.descuento AS Descuento, v.total AS Total from H_ventas v inner join Cliente c on c.id_cliente = v.id_cliente where 1 = 0";

            consultas.traer_datos_sql(consultaVentas, dgv_ventas_h);
        }

        public void CargarGrillaTODAS()
        {
            string consultaVentas = @"select v.id_h_ventas AS ID, v.fecha_hora AS Fecha,
            c.nombre AS Cliente, v.subtotal AS Subtotal,
            v.descuento AS Descuento, v.total AS Total
            from H_ventas v
            inner join Cliente c on c.id_cliente = v.id_cliente";
            consultas.traer_datos_sql(consultaVentas, dgv_ventas_h);
        }

        public void CargarGrillaACTIVA()
        {
            string consultaVentasActivas = @"select v.id_h_ventas AS ID, v.fecha_hora AS Fecha, c.nombre AS Cliente, v.subtotal AS Subtotal, v.descuento AS Descuento, v.total AS Total from H_ventas v inner join Cliente c on c.id_cliente = v.id_cliente where c.activo = 1";

            consultas.traer_datos_sql(consultaVentasActivas, dgv_ventas_h);
        }

        public void CargarGrillaINACTIVAS()
        {
            string consultaVentasInactivas = @"select v.id_h_ventas AS ID, v.fecha_hora AS Fecha,
            c.nombre AS Cliente, v.subtotal AS Subtotal,
            v.descuento AS Descuento, v.total AS Total
            from H_ventas v
            inner join Cliente c on c.id_cliente = v.id_cliente where c.activo = 0";
            consultas.traer_datos_sql(consultaVentasInactivas, dgv_ventas_h);
        }

        decimal precioUnitario = 0;

        private void txt_articulo_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            SqlCommand cmd = new SqlCommand(@"select s.costo + (s.costo * s.ganancia / 100)
                from Articulo a
                inner join Stock s on s.id_articulo = a.id_articulo
                where a.art_descripcion = @desc", cnn);
            cmd.Parameters.AddWithValue("@desc", txt_articulo.Text);

            cnn.Open();
            object resultado = cmd.ExecuteScalar();
            cnn.Close();

            if (resultado == null)
                precioUnitario = 0;
            else
                precioUnitario = Convert.ToDecimal(resultado);

            lbl_precio_unitario.Text = precioUnitario.ToString("N2");
            CalcularTotal();
        }

        private void NuDcantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal total = precioUnitario * NuDcantidad.Value;
            lbl_precio_total.Text = total.ToString("N2");
        }

        private void ActualizarTotales()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow fila in dgv_carrito_venta.Rows)
            {
                if (fila.IsNewRow) continue;
                subtotal += Convert.ToDecimal(fila.Cells["Total"].Value);
            }

            lbl_SUBTOTAL.Text = subtotal.ToString("N2");
            lbl_TOTAL_FINAL.Text = subtotal.ToString("N2");   // sin IVA ni descuento por ahora
        }

        private void dgv_carrito_venta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_carrito_venta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

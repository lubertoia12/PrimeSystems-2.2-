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
            // 1) Validaciones (antes de tocar la pantalla)
            if (dgv_carrito_venta.Rows.Count == 0)
            {
                MessageBox.Show("No hay artículos en la venta");
                return;
            }

            // 2) Busca el id del cliente escrito en el textbox
            SqlConnection cnnCli = new SqlConnection(ConectaBD.StringConnection);
            SqlCommand cmdCli = new SqlCommand("select id_cliente from Cliente where isnull(nombre, '') + ' ' + isnull(apellido, '') = @c", cnnCli);
            cmdCli.Parameters.AddWithValue("@c", txtCliente.Text.Trim());

            cnnCli.Open();
            object resCli = cmdCli.ExecuteScalar();
            cnnCli.Close();

            if (resCli == null)
            {
                MessageBox.Show("Elegí un cliente de la lista");
                return;
            }

            int idCliente = Convert.ToInt32(resCli);
            int idUsuarioLogueado = ConectaBD.IdUsuarioActual;   // automatico: lo guarda el login
            decimal total = Convert.ToDecimal(lbl_TOTAL_FINAL.Text);
            int idVenta;

            // 3) Guarda la venta (todo o nada)
            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            cnn.Open();
            SqlTransaction tran = cnn.BeginTransaction();

            try
            {
                // Cabecera
                SqlCommand cmd = new SqlCommand(@"insert into H_ventas (id_usuario, id_cliente, fecha_hora, subtotal, descuento, total)
                    values (@u, @c, getdate(), @sub, 0, @tot);
                    select SCOPE_IDENTITY();", cnn, tran);
                cmd.Parameters.AddWithValue("@u", idUsuarioLogueado);
                cmd.Parameters.AddWithValue("@c", idCliente);
                cmd.Parameters.AddWithValue("@sub", total);
                cmd.Parameters.AddWithValue("@tot", total);
                idVenta = Convert.ToInt32(cmd.ExecuteScalar());

                // Una fila de detalle por cada artículo de la grilla
                foreach (DataGridViewRow fila in dgv_carrito_venta.Rows)
                {
                    if (fila.IsNewRow) continue;

                    SqlCommand det = new SqlCommand(@"insert into H_ventas_detalles (id_h_ventas, id_articulo, descripcion, precio_unitario, cantidad, precio_total)
                        select @v, id_articulo, art_descripcion, @p, @c, @t
                        from Articulo where art_descripcion = @d", cnn, tran);
                    det.Parameters.AddWithValue("@v", idVenta);
                    det.Parameters.AddWithValue("@d", fila.Cells["Articulo"].Value.ToString());
                    det.Parameters.AddWithValue("@c", Convert.ToInt32(fila.Cells["Cantidad"].Value));
                    det.Parameters.AddWithValue("@p", Convert.ToDecimal(fila.Cells["Precio"].Value));
                    det.Parameters.AddWithValue("@t", Convert.ToDecimal(fila.Cells["Total"].Value));
                    det.ExecuteNonQuery();
                }

                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                cnn.Close();
            }

            MessageBox.Show("Venta registrada correctamente. N° " + idVenta);

            // 4) Limpia todo y vuelve a la pantalla principal (recien ahora que se guardo)
            dgv_carrito_venta.Rows.Clear();
            txtCliente.Clear();
            txt_articulo.Clear();
            NuDcantidad.Value = 1;
            ActualizarTotales();

            //habilitar
            btn_borrar_venta.Enabled = true;
            btn_modificar_venta.Enabled = true;
            btn_nueva_venta.Enabled = true;
            btn_cancelar_venta.Enabled = false;

            //ocultar
            gb_DetalleVenta.Visible = false;
            dgv_carrito_venta.Visible = false;
            pnl_SubTotal.Visible = false;

            //mostrar
            dgv_ventas_h.Visible = true;
            pnl_filtro.Visible = true;

            CargarGrillaTODAS();   // muestra la venta nueva en el historial
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
            if (e.RowIndex >= 0 && dgv_carrito_venta.Columns[e.ColumnIndex].Name == "Quitar")
            {
                dgv_carrito_venta.Rows.RemoveAt(e.RowIndex);
                ActualizarTotales();
            }
        }

        private void dgv_carrito_venta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_carrito_venta.Columns[e.ColumnIndex].Name != "Cantidad") return;

            DataGridViewRow fila = dgv_carrito_venta.Rows[e.RowIndex];

            int cantidad;
            if (!int.TryParse(Convert.ToString(fila.Cells["Cantidad"].Value), out cantidad) || cantidad <= 0)
                cantidad = 1;

            decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);

            fila.Cells["Cantidad"].Value = cantidad;
            fila.Cells["Total"].Value = precio * cantidad;

            ActualizarTotales();
        }
    }
}

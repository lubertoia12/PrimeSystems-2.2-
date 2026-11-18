using PrimeSystems_2._2_.BD;
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

namespace PrimeSystems_2._2_.forms.compras
{
    public partial class alta_compra : Form
    {
        public alta_compra()
        {
            InitializeComponent();
        }

        decimal precio = 0;
        private void alta_compra_Load(object sender, EventArgs e)
        {
            //CargarGrillaCompras();
            lbl_precio_total.Text = "0,00";
            lbl_precio_unitario.Text = "0,00";
            lbl_SUBTOTAL.Text = "0,00";
            lbl_TOTAL_FINAL.Text = "0,00";

            try
            {
                CargarProveedores();
                CargarArticulos();
                CargarUsuario();
                ConfigurarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;   // solo elegir
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            NuDcantidad.Minimum = 0;
            NuDcantidad.Maximum = 100000;
            btn_proc_pago.Text = "Procesar compra";

            ActualizarPrecios();
            CalcularTotal();

            // concecto los eventos acá 
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            NuDcantidad.ValueChanged += NuDcantidad_ValueChanged;
            btn_add_art.Click += btn_add_art_Click;
            btn_quitar_art.Click += btn_quitar_art_Click;
            btn_proc_pago.Click += btn_proc_pago_Click;
            dgv_compras_carrito.CellContentClick += dgv_compras_carrito_CellContentClick;
        }

        // combo de proveedores 
        private void CargarProveedores()
        {
            string consulta = "SELECT id_proveedor, proveedor FROM Proveedor WHERE activo = 1 ORDER BY proveedor";
            SqlDataAdapter da = new SqlDataAdapter(consulta, ConectaBD.StringConnection);
            DataTable tabla = new DataTable();
            da.Fill(tabla);

            comboBox1.DataSource = tabla;
            comboBox1.DisplayMember = "proveedor";
            comboBox1.ValueMember = "id_proveedor";
            comboBox1.SelectedIndex = -1;
        }

        // combo de artículos
        private void CargarArticulos()
        {
            string consulta = @"SELECT a.id_articulo, a.art_descripcion, ISNULL(s.costo, 0) AS costo
                                FROM Articulo a
                                LEFT JOIN Stock s ON s.id_articulo = a.id_articulo
                                ORDER BY a.art_descripcion";
            SqlDataAdapter da = new SqlDataAdapter(consulta, ConectaBD.StringConnection);
            DataTable tabla = new DataTable();
            da.Fill(tabla);

            comboBox2.DataSource = tabla;
            comboBox2.DisplayMember = "art_descripcion";
            comboBox2.ValueMember = "id_articulo";
            comboBox2.SelectedIndex = -1;
        }

        // user responsable
        private void CargarUsuario()
        {
            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT username FROM Usuario WHERE id_usuario = @id", cnn);
            cmd.Parameters.AddWithValue("@id", ConectaBD.IdUsuarioActual);
            textBox2.Text = Convert.ToString(cmd.ExecuteScalar());

            cnn.Close();
        }

        // columnas del carrito
        private void ConfigurarGrilla()
        {
            dgv_compras_carrito.ReadOnly = true;
            dgv_compras_carrito.AllowUserToAddRows = false;
            dgv_compras_carrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_compras_carrito.Columns.Add("id", "Id");
            dgv_compras_carrito.Columns["id"].Visible = false;       // el id queda oculto
            dgv_compras_carrito.Columns.Add("articulo", "Artículo");
            dgv_compras_carrito.Columns.Add("cantidad", "Cantidad");
            dgv_compras_carrito.Columns.Add("precio", "Precio unitario");
            dgv_compras_carrito.Columns.Add("subtotal", "Subtotal");
            dgv_compras_carrito.Columns["precio"].DefaultCellStyle.Format = "N2";
            dgv_compras_carrito.Columns["subtotal"].DefaultCellStyle.Format = "N2";

            // boton para borrar la fila
            DataGridViewButtonColumn btnQuitar = new DataGridViewButtonColumn();
            btnQuitar.Name = "quitar";
            btnQuitar.HeaderText = "";
            btnQuitar.Text = "Quitar";
            btnQuitar.UseColumnTextForButtonValue = true;
            dgv_compras_carrito.Columns.Add(btnQuitar);
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView fila = comboBox2.SelectedItem as DataRowView;
            if (fila != null)
            {
                precio = Convert.ToDecimal(fila["costo"]);
            }
            else
            {
                precio = 0;
            }
            ActualizarPrecios();
        }

        private void NuDcantidad_ValueChanged(object sender, EventArgs e)
        {
            ActualizarPrecios();
        }

        private void ActualizarPrecios()
        {
            lbl_precio_unitario.Text = precio.ToString("N2");
            lbl_precio_total.Text = (precio * NuDcantidad.Value).ToString("N2");
        }

        private void btn_add_art_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Elegí un artículo.");
                return;
            }
            if (NuDcantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad tiene que ser mayor a 0.");
                return;
            }

            int cantidad = (int)NuDcantidad.Value;

            dgv_compras_carrito.Rows.Add(
                Convert.ToInt32(comboBox2.SelectedValue),   
                comboBox2.Text,                             
                cantidad,
                precio,
                precio * cantidad                          
            );

            CalcularTotal();
            LimpiarCampos();
        }

        // btn limpiar campos
        private void btn_quitar_art_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            comboBox2.SelectedIndex = -1;
            NuDcantidad.Value = 0;
            precio = 0;
            ActualizarPrecios();
        }

        // btn quitar d ela grilla
        private void dgv_compras_carrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_compras_carrito.Columns[e.ColumnIndex].Name == "quitar")
            {
                dgv_compras_carrito.Rows.RemoveAt(e.RowIndex);
                CalcularTotal();
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in dgv_compras_carrito.Rows)
            {
                total += Convert.ToDecimal(fila.Cells["subtotal"].Value);
            }
            lbl_SUBTOTAL.Text = total.ToString("N2");
            lbl_TOTAL_FINAL.Text = total.ToString("N2");
        }

        // insert en bd
        private void btn_proc_pago_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Elegí un proveedor.");
                return;
            }
            if (dgv_compras_carrito.Rows.Count == 0)
            {
                MessageBox.Show("Agregá al menos un artículo.");
                return;
            }

            decimal total = 0;
            foreach (DataGridViewRow fila in dgv_compras_carrito.Rows)
            {
                total += Convert.ToDecimal(fila.Cells["subtotal"].Value);
            }

            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            cnn.Open();
            SqlTransaction transaccion = cnn.BeginTransaction();   // todo o nada

            try
            {
                //arriba

                string consultaCabecera = @"INSERT INTO H_Compras (id_usuario, id_proveedor, fecha_hora, sub_total, total, descuento)
                                            VALUES (@usuario, @proveedor, @fecha, @subtotal, @total, 0);
                                            SELECT CAST(SCOPE_IDENTITY() AS int);";
                SqlCommand cmdCabecera = new SqlCommand(consultaCabecera, cnn, transaccion);
                cmdCabecera.Parameters.AddWithValue("@usuario", ConectaBD.IdUsuarioActual);
                cmdCabecera.Parameters.AddWithValue("@proveedor", Convert.ToInt32(comboBox1.SelectedValue));
                cmdCabecera.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
                cmdCabecera.Parameters.AddWithValue("@subtotal", total);
                cmdCabecera.Parameters.AddWithValue("@total", total);
                int idCompra = (int)cmdCabecera.ExecuteScalar();     // id de la compra recién creada

                //detalle
                foreach (DataGridViewRow fila in dgv_compras_carrito.Rows)
                {
                    int idArticulo = Convert.ToInt32(fila.Cells["id"].Value);
                    int cantidad = Convert.ToInt32(fila.Cells["cantidad"].Value);

                    string consultaDetalle = @"INSERT INTO H_compras_detalle (id_h_compra, id_articulo, descripcion, precio_unitario, cantidad, precio_total)
                                               VALUES (@compra, @articulo, @descripcion, @precio, @cantidad, @subtotal)";
                    SqlCommand cmdDetalle = new SqlCommand(consultaDetalle, cnn, transaccion);
                    cmdDetalle.Parameters.AddWithValue("@compra", idCompra);
                    cmdDetalle.Parameters.AddWithValue("@articulo", idArticulo);
                    cmdDetalle.Parameters.AddWithValue("@descripcion", Convert.ToString(fila.Cells["articulo"].Value));
                    cmdDetalle.Parameters.AddWithValue("@precio", Convert.ToDecimal(fila.Cells["precio"].Value));
                    cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad);
                    cmdDetalle.Parameters.AddWithValue("@subtotal", Convert.ToDecimal(fila.Cells["subtotal"].Value));
                    cmdDetalle.ExecuteNonQuery();

                    // aumento de stock
                    SqlCommand cmdStock = new SqlCommand("UPDATE Stock SET cantidad = cantidad + @cantidad WHERE id_articulo = @articulo", cnn, transaccion);
                    cmdStock.Parameters.AddWithValue("@cantidad", cantidad);
                    cmdStock.Parameters.AddWithValue("@articulo", idArticulo);
                    int filasModificadas = cmdStock.ExecuteNonQuery();

                    // si el artículo todavía no tenía fila en Stock la creo
                    if (filasModificadas == 0)
                    {
                        SqlCommand cmdNuevoStock = new SqlCommand("INSERT INTO Stock (id_articulo, cantidad, costo, ganancia) VALUES (@articulo, @cantidad, @costo, 0)", cnn, transaccion);
                        cmdNuevoStock.Parameters.AddWithValue("@articulo", idArticulo);
                        cmdNuevoStock.Parameters.AddWithValue("@cantidad", cantidad);
                        cmdNuevoStock.Parameters.AddWithValue("@costo", Convert.ToDecimal(fila.Cells["precio"].Value));
                        cmdNuevoStock.ExecuteNonQuery();
                    }
                }

                transaccion.Commit();   // si lego hasta aca se guarda todo
                MessageBox.Show("Compra registrada correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                transaccion.Rollback(); // si algo fallo no se guarda nada
                MessageBox.Show("No se pudo guardar la compra: " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}

using PrimeSystems_2._2_.BD;
using PrimeSystems_2._2_.forms.articulo;
using PrimeSystems_2._2_.forms.proveedores;
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
    public partial class agregar_articulo : Form
    {
        public agregar_articulo()
        {
            InitializeComponent();
        }

      // ganancia 
        const decimal GANANCIA_POR_DEFECTO = 30;
        int idSeleccionado = 0; 
        

        private void agregar_articulo_Load(object sender, EventArgs e)
        {
            // Eventos que no estaban enganchados en el diseñador
           
            btn_agregar_producto.Click -= btn_agregar_producto_Click;
            btn_agregar_producto.Click += btn_agregar_producto_Click;

            categoria_art_alta_ab.SelectedIndexChanged -= categoria_art_alta_ab_SelectedIndexChanged;
            categoria_art_alta_ab.SelectedIndexChanged += categoria_art_alta_ab_SelectedIndexChanged;

            filtro_codigo_producto.TextChanged -= filtros_TextChanged;
            filtro_codigo_producto.TextChanged += filtros_TextChanged;

            filtro_proveedor.TextChanged -= filtros_TextChanged;
            filtro_proveedor.TextChanged += filtros_TextChanged;

            // combos solo elegir
            proveedor_art_alta_ab.DropDownStyle = ComboBoxStyle.DropDownList;
            categoria_art_alta_ab.DropDownStyle = ComboBoxStyle.DropDownList;
            subcategoria_art_alta_ab.DropDownStyle = ComboBoxStyle.DropDownList;

            //grilla del listado
            dgv_listado_articulos.ReadOnly = true;
            dgv_listado_articulos.AllowUserToAddRows = false;
            dgv_listado_articulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listado_articulos.MultiSelect = false;

            btn_actualizar_producto.Visible = false;

            try
            {
                CargarProveedores();
                CargarCategorias();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }

            Limpiar();
        }

        //dtaa con parametro
        private DataTable Traer(string consulta, params SqlParameter[] parametros)
        {
            SqlDataAdapter da = new SqlDataAdapter(consulta, ConectaBD.StringConnection);
            foreach (SqlParameter p in parametros)
            {
                da.SelectCommand.Parameters.Add(p);
            }
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            return tabla;
        }



        // comboa
        private void CargarProveedores()
        {
            proveedor_art_alta_ab.DataSource = Traer("select id_proveedor, proveedor from Proveedor where activo = 1 or activo is null order by proveedor");
            proveedor_art_alta_ab.DisplayMember = "proveedor";
            proveedor_art_alta_ab.ValueMember = "id_proveedor";
            proveedor_art_alta_ab.SelectedIndex = -1;
        }

        private void CargarCategorias()
        {
            categoria_art_alta_ab.DataSource = Traer("select id_categoria, nombre from Categoria order by nombre");
            categoria_art_alta_ab.DisplayMember = "nombre";
            categoria_art_alta_ab.ValueMember = "id_categoria";
            categoria_art_alta_ab.SelectedIndex = -1;
        }

        private void CargarSubcategorias(int idCategoria)
        {
            subcategoria_art_alta_ab.DataSource = Traer("select id_subcategoria, nombre from Sub_categoria where id_categoria = @c order by nombre",
                new SqlParameter("@c", idCategoria));
            subcategoria_art_alta_ab.DisplayMember = "nombre";
            subcategoria_art_alta_ab.ValueMember = "id_subcategoria";
            subcategoria_art_alta_ab.SelectedIndex = -1;
        }

        // aAl elegir una categoria, carga sus subcategorias
        private void categoria_art_alta_ab_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView fila = categoria_art_alta_ab.SelectedItem as DataRowView;
            if (fila == null)
            {
                subcategoria_art_alta_ab.DataSource = null;
                return;
            }
            CargarSubcategorias(Convert.ToInt32(fila["id_categoria"]));
        }

        // btn + despues de cerrar el popup se recarga el combo
        private void btn_agregar_proveedor_Click(object sender, EventArgs e)
        {
            alta_proveedor_popup proveedor = new alta_proveedor_popup();
            proveedor.ShowDialog();
            CargarProveedores();
        }

        private void btn_agregar_categoria_Click(object sender, EventArgs e)
        {
            alta_categorias altacat = new alta_categorias();
            altacat.ShowDialog();
            CargarCategorias();
        }

        // filtros de codigo y prov
        private void CargarGrilla()
        {
            string consulta = @"select a.id_articulo AS Codigo, a.art_descripcion AS Descripcion,
                    p.proveedor AS Proveedor, c.nombre AS Categoria, sc.nombre AS Subcategoria,
                    isnull(s.costo, 0) AS Precio,
                    case when a.activo = 1 then 'Activo' else 'Inactivo' end AS Estado
                from Articulo a
                left join Proveedor p on p.id_proveedor = a.id_proveedor
                left join Sub_categoria sc on sc.id_subcategoria = a.id_subcategoria
                left join Categoria c on c.id_categoria = sc.id_categoria
                left join Stock s on s.id_articulo = a.id_articulo
                where cast(a.id_articulo as varchar(10)) like '%' + @cod + '%'
                  and isnull(p.proveedor, '') like '%' + @prov + '%'
                order by a.id_articulo";

            dgv_listado_articulos.DataSource = Traer(consulta,
                new SqlParameter("@cod", filtro_codigo_producto.Text.Trim()),
                new SqlParameter("@prov", filtro_proveedor.Text.Trim()));

            if (dgv_listado_articulos.Columns.Contains("Precio"))
                dgv_listado_articulos.Columns["Precio"].DefaultCellStyle.Format = "N2";
        }

        private void filtros_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }


        // valida
        private bool ValidarCampos()
        {
            if (desc_articulo_alta.Text.Trim() == "")
            {
                MessageBox.Show("Escribí la descripción del artículo.");
                return false;
            }

            decimal precio;
            if (!decimal.TryParse(precio_articulo_alta.Text.Trim(), out precio) || precio < 0)
            {
                MessageBox.Show("El precio tiene que ser un número válido (0 o mayor).");
                return false;
            }

            if (proveedor_art_alta_ab.SelectedIndex == -1)
            {
                MessageBox.Show("Elegí un proveedor.");
                return false;
            }

            if (subcategoria_art_alta_ab.SelectedIndex == -1)
            {
                MessageBox.Show("Elegí una categoría y una subcategoría.");
                return false;
            }

            // descripc no se puede repetir ventas y compras buscan el articulo por su descripcion
            DataTable repetido = Traer("select count(*) from Articulo where art_descripcion = @d and id_articulo <> @id",
                new SqlParameter("@d", desc_articulo_alta.Text.Trim()),
                new SqlParameter("@id", idSeleccionado));

            if (Convert.ToInt32(repetido.Rows[0][0]) > 0)
            {
                MessageBox.Show("Ya existe un artículo con esa descripción.");
                return false;
            }

            return true;
        }

        private void Limpiar()
        {
            idSeleccionado = 0;
            codigo_artiulo_alta.ReadOnly = true;
            codigo_artiulo_alta.Text = "Automático";
            desc_articulo_alta.Clear();
            precio_articulo_alta.Clear();
            proveedor_art_alta_ab.SelectedIndex = -1;
            categoria_art_alta_ab.SelectedIndex = -1;
            subcategoria_art_alta_ab.DataSource = null;
            rd_activo_cliente_alta.Checked = true;
        }

        // GREgar articulo
        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            decimal costo = decimal.Parse(precio_articulo_alta.Text.Trim());

            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            cnn.Open();
            SqlTransaction tran = cnn.BeginTransaction();

            try
            {
                // el articulo
                SqlCommand cmd = new SqlCommand(@"insert into Articulo (id_subcategoria, id_proveedor, art_descripcion, activo)
                        values (@sub, @prov, @desc, @act);
                        select cast(scope_identity() as int);", cnn, tran);
                cmd.Parameters.AddWithValue("@sub", Convert.ToInt32(subcategoria_art_alta_ab.SelectedValue));
                cmd.Parameters.AddWithValue("@prov", Convert.ToInt32(proveedor_art_alta_ab.SelectedValue));
                cmd.Parameters.AddWithValue("@desc", desc_articulo_alta.Text.Trim());
                cmd.Parameters.AddWithValue("@act", rd_activo_cliente_alta.Checked);
                int idNuevo = (int)cmd.ExecuteScalar();

                // fila destock en 0
                SqlCommand st = new SqlCommand(@"insert into Stock (id_articulo, cantidad, costo, ganancia)
                        values (@id, 0, @costo, @gan)", cnn, tran);
                st.Parameters.AddWithValue("@id", idNuevo);
                st.Parameters.AddWithValue("@costo", costo);
                st.Parameters.AddWithValue("@gan", GANANCIA_POR_DEFECTO);
                st.ExecuteNonQuery();

                tran.Commit();
                MessageBox.Show("Artículo cargado. Código: " + idNuevo);

                Limpiar();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("No se pudo guardar el artículo: " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        // carga art elegido
        private void btn_modificar_producto_Click(object sender, EventArgs e)
        {
            if (dgv_listado_articulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un artículo de la lista.");
                return;
            }

            int id = Convert.ToInt32(dgv_listado_articulos.CurrentRow.Cells["Codigo"].Value);

            DataTable t = Traer(@"select a.art_descripcion, a.id_proveedor, a.id_subcategoria,
                        sc.id_categoria, isnull(s.costo, 0) AS costo, a.activo
                    from Articulo a
                    left join Sub_categoria sc on sc.id_subcategoria = a.id_subcategoria
                    left join Stock s on s.id_articulo = a.id_articulo
                    where a.id_articulo = @id", new SqlParameter("@id", id));

            if (t.Rows.Count == 0) return;
            DataRow r = t.Rows[0];

            idSeleccionado = id;
            codigo_artiulo_alta.Text = id.ToString();
            desc_articulo_alta.Text = r["art_descripcion"].ToString();
            precio_articulo_alta.Text = Convert.ToDecimal(r["costo"]).ToString("0.##");
            rd_activo_cliente_alta.Checked = r["activo"] != DBNull.Value && Convert.ToBoolean(r["activo"]);

            if (r["id_proveedor"] != DBNull.Value)
                proveedor_art_alta_ab.SelectedValue = Convert.ToInt32(r["id_proveedor"]);

            if (r["id_categoria"] != DBNull.Value)
            {
                categoria_art_alta_ab.SelectedValue = Convert.ToInt32(r["id_categoria"]);   // esto carga las subcategorias
                subcategoria_art_alta_ab.SelectedValue = Convert.ToInt32(r["id_subcategoria"]);
            }

            //deshabilito
            btn_eliminar_producto.Enabled = false;
            btn_agregar_producto.Enabled = false;
            btn_agregar_producto.Visible = false;
            //muestro
            btn_actualizar_producto.Visible = true;
        }

        // modifica
        private void btn_actualizar_producto_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) return;
            if (!ValidarCampos()) return;

            decimal costo = decimal.Parse(precio_articulo_alta.Text.Trim());

            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            cnn.Open();
            SqlTransaction tran = cnn.BeginTransaction();

            try
            {
                SqlCommand cmd = new SqlCommand(@"update Articulo
                        set id_subcategoria = @sub, id_proveedor = @prov, art_descripcion = @desc, activo = @act
                        where id_articulo = @id", cnn, tran);
                cmd.Parameters.AddWithValue("@sub", Convert.ToInt32(subcategoria_art_alta_ab.SelectedValue));
                cmd.Parameters.AddWithValue("@prov", Convert.ToInt32(proveedor_art_alta_ab.SelectedValue));
                cmd.Parameters.AddWithValue("@desc", desc_articulo_alta.Text.Trim());
                cmd.Parameters.AddWithValue("@act", rd_activo_cliente_alta.Checked);
                cmd.Parameters.AddWithValue("@id", idSeleccionado);
                cmd.ExecuteNonQuery();

                // el costo: si el articulo todavia no tenia fila en Stock, se crea
                SqlCommand st = new SqlCommand(@"update Stock set costo = @costo where id_articulo = @id;
                        if @@rowcount = 0
                            insert into Stock (id_articulo, cantidad, costo, ganancia) values (@id, 0, @costo, @gan);", cnn, tran);
                st.Parameters.AddWithValue("@costo", costo);
                st.Parameters.AddWithValue("@id", idSeleccionado);
                st.Parameters.AddWithValue("@gan", GANANCIA_POR_DEFECTO);
                st.ExecuteNonQuery();

                tran.Commit();
                MessageBox.Show("Artículo actualizado.");

                Limpiar();
                CargarGrilla();

                btn_actualizar_producto.Visible = false;
                btn_agregar_producto.Visible = true;
                btn_agregar_producto.Enabled = true;
                btn_eliminar_producto.Enabled = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("No se pudo actualizar el artículo: " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        // bjaa logica
        private void btn_eliminar_producto_Click(object sender, EventArgs e)
        {
            if (dgv_listado_articulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un artículo de la lista.");
                return;
            }

            DialogResult resultado = MessageBox.Show("Esta seguro que quiere borrar este articulo?", "confirmacion", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgv_listado_articulos.CurrentRow.Cells["Codigo"].Value);

                try
                {
                    SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
                    SqlCommand cmd = new SqlCommand("update Articulo set activo = 0 where id_articulo = @id", cnn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();

                    CargarGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo borrar el artículo: " + ex.Message);
                }
            }
        }

        private void btn_cerrar_pestana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //boton actualizar
        {

        }

        private void btn_agregar_producto_Click_1(object sender, EventArgs e) 
        {

        }
    }
}


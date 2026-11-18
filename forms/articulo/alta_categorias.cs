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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimeSystems_2._2_.forms.articulo
{
    public partial class alta_categorias : Form
    {
        public alta_categorias()
        {
            InitializeComponent();
        }
        int idCategoriaSel = 0;      // categoria elegida en la grilla (0 = ninguna)
        int idSubcategoriaSel = 0;   // subcategoria elegida en la grilla (0 = ninguna)


        // load
        private void alta_categorias_Load(object sender, EventArgs e)
        {
            // Eventos 
            btn_agregar_categoria.Click -= btn_agregar_categoria_Click;
            btn_agregar_categoria.Click += btn_agregar_categoria_Click;
            btn_modificar_categoria.Click -= btn_modificar_categoria_Click;
            btn_modificar_categoria.Click += btn_modificar_categoria_Click;
            btn_eliminar_categoria.Click -= btn_eliminar_categoria_Click;
            btn_eliminar_categoria.Click += btn_eliminar_categoria_Click;

            btn_agregar_subcategoria.Click -= btn_agregar_subcategoria_Click;
            btn_agregar_subcategoria.Click += btn_agregar_subcategoria_Click;
            btn_modificar_subcategoria.Click -= btn_modificar_subcategoria_Click;
            btn_modificar_subcategoria.Click += btn_modificar_subcategoria_Click;
            btn_eliminar_subcat.Click -= btn_eliminar_subcat_Click;
            btn_eliminar_subcat.Click += btn_eliminar_subcat_Click;

            lista.CellClick -= dataGridView1_CellClick;
            lista.CellClick += dataGridView1_CellClick;
            dataGridView2.CellClick -= dataGridView2_CellClick;
            dataGridView2.CellClick += dataGridView2_CellClick;
            categoria.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            categoria.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            //  nombres varchar(30) en base
            nombre.MaxLength = 30;
            txt_subcategoria.MaxLength = 30;

            categoria.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (DataGridView g in new DataGridView[] { lista, dataGridView2 })
            {
                g.ReadOnly = true;
                g.AllowUserToAddRows = false;
                g.MultiSelect = false;
                g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }

            try
            {
                CargarCategorias(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }

        // ---------------------------------------------------------------
        // AYUDA
        // ---------------------------------------------------------------
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

        private void Ejecutar(string consulta, params SqlParameter[] parametros)
        {
            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            SqlCommand cmd = new SqlCommand(consulta, cnn);
            foreach (SqlParameter p in parametros)
            {
                cmd.Parameters.Add(p);
            }
            cnn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cnn.Close();
            }
        }

        // Si no se puede borrar porque esta en uso (error 547 = clave foranea)
        private void MostrarErrorBorrado(Exception ex, string que)
        {
            SqlException sql = ex as SqlException;
            if (sql != null && sql.Number == 547)
                MessageBox.Show("No se puede eliminar " + que + " porque está en uso (tiene subcategorías o artículos asociados).");
            else
                MessageBox.Show("No se pudo eliminar: " + ex.Message);
        }

        // categprias carga de grilla y combo
        // idParaElegir = categoria que queda elegida en el combo 
        private void CargarCategorias(int idParaElegir)
        {
            DataTable tabla = Traer("select id_categoria AS ID, nombre AS Categoria from Categoria order by nombre");

            lista.DataSource = tabla;
            lista.Columns["ID"].Visible = false;
            idCategoriaSel = 0;
            nombre.Clear();

            // El combo de la derecha usa las mismas categorias
            categoria.DataSource = Traer("select id_categoria, nombre from Categoria order by nombre");
            categoria.DisplayMember = "nombre";
            categoria.ValueMember = "id_categoria";

            if (idParaElegir != 0)
                categoria.SelectedValue = idParaElegir;
            else
                categoria.SelectedIndex = -1;

            CargarSubcategorias();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = lista.Rows[e.RowIndex];
            idCategoriaSel = Convert.ToInt32(fila.Cells["ID"].Value);
            nombre.Text = fila.Cells["Categoria"].Value.ToString();
        }

        // ---------------------------------------------------------------
        // catego  add mod borrar
        // ---------------------------------------------------------------
        private bool NombreCategoriaValido()
        {
            if (nombre.Text.Trim() == "")
            {
                MessageBox.Show("Escribí el nombre de la categoría.");
                return false;
            }

            DataTable repetida = Traer("select count(*) from Categoria where nombre = @n and id_categoria <> @id",
                new SqlParameter("@n", nombre.Text.Trim()),
                new SqlParameter("@id", idCategoriaSel));

            if (Convert.ToInt32(repetida.Rows[0][0]) > 0)
            {
                MessageBox.Show("Ya existe una categoría con ese nombre.");
                return false;
            }
            return true;
        }

        private void btn_agregar_categoria_Click(object sender, EventArgs e)
        {
            idCategoriaSel = 0;   // es una categoria nueva
            if (!NombreCategoriaValido()) return;

            try
            {
                Ejecutar("insert into Categoria (nombre) values (@n)",
                    new SqlParameter("@n", nombre.Text.Trim()));

                CargarCategorias(0);
                MessageBox.Show("Categoría agregada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la categoría: " + ex.Message);
            }
        }

        private void btn_modificar_categoria_Click(object sender, EventArgs e)
        {
            if (idCategoriaSel == 0)
            {
                MessageBox.Show("Seleccioná una categoría de la lista.");
                return;
            }
            if (!NombreCategoriaValido()) return;

            try
            {
                int id = idCategoriaSel;
                Ejecutar("update Categoria set nombre = @n where id_categoria = @id",
                    new SqlParameter("@n", nombre.Text.Trim()),
                    new SqlParameter("@id", id));

                CargarCategorias(id);
                MessageBox.Show("Categoría modificada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar la categoría: " + ex.Message);
            }
        }

        private void btn_eliminar_categoria_Click(object sender, EventArgs e)
        {
            if (idCategoriaSel == 0)
            {
                MessageBox.Show("Seleccioná una categoría de la lista.");
                return;
            }

            if (MessageBox.Show("¿Seguro que querés eliminar esta categoría?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                Ejecutar("delete from Categoria where id_categoria = @id",
                    new SqlParameter("@id", idCategoriaSel));

                CargarCategorias(0);
            }
            catch (Exception ex)
            {
                MostrarErrorBorrado(ex, "la categoría");
            }
        }

        // ---------------------------------------------------------------
        // SUBCATEGORIAS: la grilla muestra las de la categoria elegida en el combo
        // ---------------------------------------------------------------
        private void CargarSubcategorias()
        {
            idSubcategoriaSel = 0;
            txt_subcategoria.Clear();

            if (categoria.SelectedValue == null || categoria.SelectedIndex == -1)
            {
                dataGridView2.DataSource = null;
                return;
            }

            int idCat = Convert.ToInt32(categoria.SelectedValue);

            dataGridView2.DataSource = Traer("select id_subcategoria AS ID, nombre AS Subcategoria from Sub_categoria where id_categoria = @c order by nombre",
                new SqlParameter("@c", idCat));
            dataGridView2.Columns["ID"].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Al cargar el combo el SelectedValue puede venir como DataRowView; se ignora
            if (categoria.SelectedValue is DataRowView) return;
            CargarSubcategorias();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dataGridView2.Rows[e.RowIndex];
            idSubcategoriaSel = Convert.ToInt32(fila.Cells["ID"].Value);
            txt_subcategoria.Text = fila.Cells["Subcategoria"].Value.ToString();
        }

        // subcate add mod borrar
        private bool NombreSubcategoriaValido()
        {
            if (categoria.SelectedIndex == -1)
            {
                MessageBox.Show("Elegí primero la categoría.");
                return false;
            }
            if (txt_subcategoria.Text.Trim() == "")
            {
                MessageBox.Show("Escribí el nombre de la subcategoría.");
                return false;
            }

            DataTable repetida = Traer("select count(*) from Sub_categoria where nombre = @n and id_categoria = @c and id_subcategoria <> @id",
                new SqlParameter("@n", txt_subcategoria.Text.Trim()),
                new SqlParameter("@c", Convert.ToInt32(categoria.SelectedValue)),
                new SqlParameter("@id", idSubcategoriaSel));

            if (Convert.ToInt32(repetida.Rows[0][0]) > 0)
            {
                MessageBox.Show("Esa categoría ya tiene una subcategoría con ese nombre.");
                return false;
            }
            return true;
        }

        private void btn_agregar_subcategoria_Click(object sender, EventArgs e)
        {
            idSubcategoriaSel = 0;   // es una subcategoria nueva
            if (!NombreSubcategoriaValido()) return;

            try
            {
                Ejecutar("insert into Sub_categoria (id_categoria, nombre) values (@c, @n)",
                    new SqlParameter("@c", Convert.ToInt32(categoria.SelectedValue)),
                    new SqlParameter("@n", txt_subcategoria.Text.Trim()));

                CargarSubcategorias();
                MessageBox.Show("Subcategoría agregada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la subcategoría: " + ex.Message);
            }
        }

        private void btn_modificar_subcategoria_Click(object sender, EventArgs e)
        {
            if (idSubcategoriaSel == 0)
            {
                MessageBox.Show("Seleccioná una subcategoría de la lista.");
                return;
            }
            if (!NombreSubcategoriaValido()) return;

            try
            {
                Ejecutar("update Sub_categoria set nombre = @n where id_subcategoria = @id",
                    new SqlParameter("@n", txt_subcategoria.Text.Trim()),
                    new SqlParameter("@id", idSubcategoriaSel));

                CargarSubcategorias();
                MessageBox.Show("Subcategoría modificada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar la subcategoría: " + ex.Message);
            }
        }

        private void btn_eliminar_subcat_Click(object sender, EventArgs e)
        {
            if (idSubcategoriaSel == 0)
            {
                MessageBox.Show("Seleccioná una subcategoría de la lista.");
                return;
            }

            if (MessageBox.Show("¿Seguro que querés eliminar esta subcategoría?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                Ejecutar("delete from Sub_categoria where id_subcategoria = @id",
                    new SqlParameter("@id", idSubcategoriaSel));

                CargarSubcategorias();
            }
            catch (Exception ex)
            {
                MostrarErrorBorrado(ex, "la subcategoría");
            }
        }

        private void btn_cerrar_altaCat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

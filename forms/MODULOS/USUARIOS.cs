using PrimeSystems_2._2_.BD;
using PrimeSystems_2._2_.forms.usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeSystems_2._2_.forms.MODULOS
{
    public partial class USUARIOS : Form
    {
        public USUARIOS()
        {
            InitializeComponent();
        }

        public int idSeleccionado { get; set; }

        public void CargarGrillaActivos()
        {
            string consulta = @"select id_usuario AS ID, nombre AS Nombre, apellido AS Apellido,
                        DNI, tel AS Telefono, mail AS Mail, username AS Username, activo AS Estado
                        from Usuario where activo = 1";
            consultas.traer_datos_sql(consulta, dgv_usuarios);
        }
        public void CargarGrillaTodos()
        {
            string consulta = @"select id_usuario AS ID, nombre AS Nombre, apellido AS Apellido,
                        DNI, tel AS Telefono, mail AS Mail, username AS Username, activo AS Estado
                        from Usuario";
            consultas.traer_datos_sql(consulta, dgv_usuarios);
        }
        public void CargarGrillaInactivo()
        {
            string consulta = @"select id_usuario AS ID, nombre AS Nombre, apellido AS Apellido,
                        DNI, tel AS Telefono, mail AS Mail, username AS Username, activo AS Estado
                        from Usuario where activo = 0";
            consultas.traer_datos_sql(consulta, dgv_usuarios);
        }
        private void USUARIOS_Load(object sender, EventArgs e)
        {
            
        }
        private void dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgv_usuarios.Rows[e.RowIndex].Cells["ID"].Value);
            }
        }
        private void btn_nuevo_user_Click(object sender, EventArgs e)
        {
            panel_frm.Controls.Clear();

            AltaUsuario usuario = new AltaUsuario();

            usuario.u = this;
            usuario.TopLevel = false;
            usuario.FormBorderStyle = FormBorderStyle.None;
            usuario.Dock = DockStyle.Fill;

            panel_frm.Controls.Add(usuario);
            usuario.Show();
        }
        private void btn_modificar_user_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)                // confirma que haya elegido a alguien
            {
                MessageBox.Show("Para poder modificar, primero seleccioná un usuario de la grilla y luego vuelve a presionar el boton.");
                return;
            }

            panel_frm.Controls.Clear();

            ModificarUsuario usuario = new ModificarUsuario();
            usuario.u = this;                       // <- NUEVO
            usuario.TopLevel = false;
            usuario.FormBorderStyle = FormBorderStyle.None;
            usuario.Dock = DockStyle.Fill;

            panel_frm.Controls.Add(usuario);
            usuario.Show();
        }
        private void btn_borrar_user_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)                // confirma que haya elegido a alguien
            {
                MessageBox.Show("Seleccioná un usuario primero.");
                return;
            }
            else
            {

                DialogResult resultado = MessageBox.Show("Seguro que quiere dar de baja este usuario?", "confirmacion", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    if (consultas.BajaLogica_user(idSeleccionado, false))
                    {
                        idSeleccionado = 0;
                        CargarGrillaActivos();
                    }
                }
            }
        }
        private void btn_cancelar_user_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_filtro_todos_Click(object sender, EventArgs e)
        {
            CargarGrillaTodos();
        }
        private void btn_filtro_activas_Click(object sender, EventArgs e)
        {
            CargarGrillaActivos();
        }
        private void btn_filtro_inactivas_Click(object sender, EventArgs e)
        {
            CargarGrillaInactivo();

        }



    }
}

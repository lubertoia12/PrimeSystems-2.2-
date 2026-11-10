using PrimeSystems_2._2_.BD;
using PrimeSystems_2._2_.forms.proveedores;
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
    public partial class PROVEEDORES : Form
    {
        public PROVEEDORES()
        {
            InitializeComponent();
        }


        public int idSeleccionado { get; set; }


        public void CargarGrillaProveedoresACTIVOS()
        {
            string consulta = @"select id_proveedor AS ID, proveedor AS [Razón social], CUIT,
                    nombre AS Nombre, apellido AS Apellido, tel AS Telefono,
                    mail AS Mail, direccion AS Direccion, activo AS Estado
                    from Proveedor where activo = 1";
            consultas.traer_datos_sql(consulta, dgv_proveedores);
        }
        public void CargarGrillaProveedoresINACTIVOS()
        {
            string consulta = @"select id_proveedor AS ID, proveedor AS [Razón social], CUIT,
                    nombre AS Nombre, apellido AS Apellido, tel AS Telefono,
                    mail AS Mail, direccion AS Direccion, activo AS Estado
                    from Proveedor where activo = 0";
            consultas.traer_datos_sql(consulta, dgv_proveedores);
        }
        public void CargarGrillaProveedoresTODOS()
        {
            string consulta = @"select id_proveedor AS ID, proveedor AS [Razón social], CUIT,
                    nombre AS Nombre, apellido AS Apellido, tel AS Telefono,
                    mail AS Mail, direccion AS Direccion, activo AS Estado
                    from Proveedor";
            consultas.traer_datos_sql(consulta, dgv_proveedores);
        }





        private void PROVEEDORES_Load(object sender, EventArgs e)
        {
        }
        private void dgv_proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
             idSeleccionado = Convert.ToInt32(dgv_proveedores.Rows[e.RowIndex].Cells["ID"].Value);
        }


        //botones abm
        private void btn_nuevo_proveedor_Click(object sender, EventArgs e)
        {
            panel_frm.Controls.Clear();

            AltaProveedor proveedor = new AltaProveedor();
            proveedor.TopLevel = false;
            proveedor.FormBorderStyle = FormBorderStyle.None;
            proveedor.Dock = DockStyle.Fill;
            panel_frm.Controls.Add(proveedor);
            proveedor.Show();


            //inhabilito
            btn_modificar_proveedor.Enabled = false;
            btn_borrar_proveedor.Enabled = false;

        } //anda
        private void btn_modificar_proveedor_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccioná un proveedor primero.");
                return;
            }
            panel_frm.Controls.Clear();

            ModificarProveedor proveedor = new ModificarProveedor();
            proveedor.p = this;
            proveedor.TopLevel = false;
            proveedor.FormBorderStyle = FormBorderStyle.None;
            proveedor.Dock = DockStyle.Fill;

            panel_frm.Controls.Add(proveedor);
            proveedor.Show();

            //inhabilito
            btn_nuevo_proveedor.Enabled = false;
            btn_borrar_proveedor.Enabled = false;
            //habilito
            btn_cancelar_proveedor.Enabled = true;

        } //no anda
        private void btn_borrar_proveedor_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccioná un proveedor primero.");
                return;
            }

            DialogResult res = MessageBox.Show(
                "¿Seguro que querés dar de baja este proveedor?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                if (consultas.BajaLogica_proveedor(idSeleccionado, false))
                {
                    idSeleccionado = 0;
                    CargarGrillaProveedoresACTIVOS();
                }
            }
        }
        private void btn_cancelar_proveedor_Click(object sender, EventArgs e)
        {
            //oculto
            panel_frm.Visible = false;

            //habilito
            btn_nuevo_proveedor.Enabled = true;
            btn_modificar_proveedor.Enabled = true;
            btn_borrar_proveedor.Enabled = true;
            btn_cancelar_proveedor.Enabled = false;

        }




        //filtros tan ok
        private void btn_filtro_todos_Click(object sender, EventArgs e)
        {
            CargarGrillaProveedoresTODOS();
        }

        private void btn_filtro_activas_Click(object sender, EventArgs e)
        {
            CargarGrillaProveedoresACTIVOS();
        }

        private void btn_filtro_inactivas_Click(object sender, EventArgs e)
        {
            CargarGrillaProveedoresINACTIVOS();
        }
    }
}


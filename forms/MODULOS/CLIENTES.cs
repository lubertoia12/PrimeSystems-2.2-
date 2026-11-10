using PrimeSystems_2._2_.BD;
using PrimeSystems_2._2_.forms.cliente;
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
    public partial class CLIENTES : Form
    {
        public CLIENTES()
        {
            InitializeComponent();
        }

        public int idSeleccionado { get; set; }
        public void CargarGrillaClientes()   // cambiar consulta a cliente
        {
            string consulta = @"select id_cliente AS ID, nombre AS Nombre, apellido AS Apellido,
                CUIT, entidad AS Entidad, tipo AS Tipo, telefono AS Telefono,
                mail AS Mail, direccion AS Direccion, activo AS Estado
                from Cliente where activo = 1";
            consultas.traer_datos_sql(consulta, dgv_clientes);
        }


        private void CLIENTES_Load(object sender, EventArgs e)
        {

        }


        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;    // clic en el encabezado
            idSeleccionado = Convert.ToInt32(dgv_clientes.Rows[e.RowIndex].Cells["ID"].Value);
        }

        private void btn_nuevo_cliente_Click(object sender, EventArgs e)
        {
            panel_frm.Controls.Clear();

            AgregarCliente cliente = new AgregarCliente();

            cliente.TopLevel = false;
            cliente.FormBorderStyle = FormBorderStyle.None;
            cliente.Dock = DockStyle.Fill;

            panel_frm.Controls.Add(cliente);
            cliente.Show();
        }

        private void btn_modificar_cliente_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccioná un cliente primero.");
                return;
            }

            panel_frm.Controls.Clear();

            ModificarCliente cliente = new ModificarCliente();
            cliente.c = this;
            cliente.TopLevel = false;
            cliente.FormBorderStyle = FormBorderStyle.None;
            cliente.Dock = DockStyle.Fill;

            panel_frm.Controls.Add(cliente);
            cliente.Show();
        }

        private void btn_borrar_cliente_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccioná un cliente primero.");
                return;
            }

            DialogResult res = MessageBox.Show("¿Seguro que querés dar de baja este cliente?", "confirmacion", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if (consultas.BajaLogica_cliente(idSeleccionado, false))
                {
                    idSeleccionado = 0;
                    CargarGrillaClientes();
                }
            }
        }

        private void btn_cancelar_cliente_Click(object sender, EventArgs e)
        {

        }
    }
}


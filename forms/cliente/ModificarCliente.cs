using PrimeSystems_2._2_.BD;
using PrimeSystems_2._2_.forms.MODULOS;
using PrimeSystems_2._2_.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeSystems_2._2_.forms.cliente
{
    public partial class ModificarCliente : Form
    {
        public ModificarCliente()
        {
            InitializeComponent();
        }


        public CLIENTES c { get; set; }

        public bool Valida_modificacion_cliente()
        {
            bool ok = true;

            ok &= validaciones.func_validaCampoVacio(cliente_nom_mod, msj_error);//nom y entidad
            ok &= validaciones.func_validaTel(cliente_tel_mod, msj_error);
            ok &= validaciones.func_validaCUIT(cliente_dni_mod, msj_error);

            return ok;
        }


        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            DataGridViewRow fila = c.dgv_clientes.CurrentRow;

            cliente_nom_mod.Text = fila.Cells["Nombre"].Value.ToString();
            cliente_ape_mod.Text = fila.Cells["Entidad"].Value.ToString();
            cliente_dni_mod.Text = fila.Cells["CUIT"].Value.ToString();      
            cliente_mail_mod.Text = fila.Cells["Mail"].Value.ToString();
            cliente_tel_mod.Text = fila.Cells["Telefono"].Value.ToString();
            cliente_dire_mod.Text = fila.Cells["Direccion"].Value.ToString();  

            bool activo = Convert.ToBoolean(fila.Cells["Estado"].Value);
            activo_mod_cliente.Checked = activo;
            inactivo_mod_cliente.Checked = !activo;
        }
        

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (Valida_modificacion_cliente() == true)
            {

                int id = c.idSeleccionado;

                bool resultado = consultas.ModificarCliente(id, cliente_nom_mod.Text, cliente_ape_mod.Text, cliente_tel_mod.Text, cliente_dni_mod.Text, /*cliente_mail_mod.Text,*/  activo_mod_cliente.Checked);
                if (resultado == true)
                {
                    c.CargarGrillaClientes();
                    this.Close();
                }
                else { MessageBox.Show("No se pudo modificar el Cliente."); }
            }
        }

    }
}


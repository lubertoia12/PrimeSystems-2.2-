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
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        CLIENTES c { get; set; }

        public bool Valida_alta_cliente()
        {
            bool ok = true;

            ok &= validaciones.func_validaCampoVacio(alta_nom_cliente, msj_error);//nom y entidad
            ok &= validaciones.func_validaTel(alta_tel_cliente, msj_error);
            ok &= validaciones.func_validaCUIT(alta_dni_cliente, msj_error);

            return ok;
        }


        private void btn_agregar_cliente_Click(object sender, EventArgs e)
        {
            if (Valida_alta_cliente() == true)
            {
                consultas.AgregarCliente(alta_nom_cliente.Text, alta_ape_cliente.Text, alta_tel_cliente.Text ,alta_dni_cliente.Text, alta_activo_cliente.Checked);
                c.CargarGrillaClientes();
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

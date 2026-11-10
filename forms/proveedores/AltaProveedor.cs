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

namespace PrimeSystems_2._2_.forms.proveedores
{
    public partial class AltaProveedor : Form
    {
        public AltaProveedor()
        {
            InitializeComponent();
        }

        private void AltaProveedor_Load(object sender, EventArgs e)
        {

        }
        private bool valida_proveedor()
        {
            bool ok = true;

            ok &= validaciones.func_validaCampoVacio(pro_pro_alta, msj_error);
            ok &= validaciones.func_validaCampoVacio(pro_nom_alta, msj_error);
            ok &= validaciones.func_validaCampoVacio(pro_ape_alta, msj_error);
            ok &= validaciones.func_validaCampoVacio(proveedor_dire_alta, msj_error);

            ok &= validaciones.func_validaCUIT(pro_cuit_alta, msj_error);

            ok &= validaciones.func_validaTel(pro_tel_alta, msj_error);

            ok &= validaciones.func_validaMail(pro_mail_alta, msj_error);

            return ok;
        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        } //listo

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            if (valida_proveedor() == true)
            {
                consultas.AgregarProveedor(pro_pro_alta.Text, pro_nom_alta.Text, pro_ape_alta.Text, pro_cuit_alta.Text, pro_tel_alta.Text, proveedor_dire_alta.Text, pro_mail_alta.Text, activo_alta_prov.Checked);
                MessageBox.Show("Proveedor cargado con exito.");
                this.Close();
            }
            else MessageBox.Show("No se pudo cargar el proveedor");return;

        } //listo

        private void cb_tipo_proveedor_SelectedIndexChanged(object sender, EventArgs e) //listo
        {
            if (cb_tipo_proveedor.Text == "EMPRESA")
            {
                lbl_tipo_proveedor.Text = "Razon social:";
            }
            else if (cb_tipo_proveedor.Text == "PARTICULAR")
            {
                lbl_tipo_proveedor.Text = "Nombre fantasia:";
            }
        }
    }
}

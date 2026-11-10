using PrimeSystems_2._2_.BD;
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
    public partial class alta_proveedor_popup : Form
    {
        public alta_proveedor_popup()
        {
            InitializeComponent();
        }
        private bool valida_proveedor()
        {
            bool ok = true; 

            ok &= validaciones.func_validaCampoVacio(pro_nom_alta, msj_error); 
            ok &= validaciones.func_validaCampoVacio(pro_pro_alta, msj_error);
            ok &= validaciones.func_validaCUIT(pro_cuit_alta, msj_error);
            ok &= validaciones.func_validaTel(pro_tel_alta, msj_error);
            ok &= validaciones.func_validaMail(pro_mail_alta, msj_error);


            return ok;
        }

        private void alta_proveedor_popup_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_proveedor_Click(object sender, EventArgs e)  
        {
            if (valida_proveedor()==true)
            {
                consultas.AgregarProveedorPOPUP(pro_pro_alta.Text, pro_nom_alta.Text,pro_cuit_alta.Text, pro_tel_alta.Text,pro_mail_alta.Text, activo_alta_prov.Checked );
                MessageBox.Show("Proveedor cargado.");
                this.Close();

                //se debe precargar en el combobox
            }
        } //listo?

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

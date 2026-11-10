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
    public partial class ModificarProveedor : Form
    {
        public ModificarProveedor()
        {
            InitializeComponent();
        }


        public PROVEEDORES p { get; set; }

        public bool Valida_modificacion_proveedor()
        {
            bool ok = true;

            ok &= validaciones.func_validaCampoVacio(pro_pro_mod, msj_error);
            ok &= validaciones.func_validaCampoVacio(prov_nom_mod, msj_error);
            ok &= validaciones.func_validaCampoVacio(prov_ape_mod, msj_error);
            ok &= validaciones.func_validaCampoVacio(prov_dire_mod, msj_error);

            ok &= validaciones.func_validaCUIT(pro_cuit_mod, msj_error);

            ok &= validaciones.func_validaTel(pro_tel_mod, msj_error);

            ok &= validaciones.func_validaMail(pro_mail_mod, msj_error);

            //falta check activo

            return ok;
        }

        private void ModificarProveedor_Load(object sender, EventArgs e)
        {

        }




        //private void btn_agregar_Click(object sender, EventArgs e)
        //{
        //    if (Valida_modificacion_proveedor())    //ver esto
        //    {
        //        bool resultado = consultas.ModificarProveedor(idSeleccionado,pro_pro_mod.Text,prov_nom_mod.Text,prov_ape_mod.Text,pro_cuit_mod.Text,pro_tel_mod.Text,prov_dire_mod.Text,pro_mail_mod.Text, activo_prov_mod.Checked);

        //        if (resultado)
        //        {
        //            p.CargarGrillaProveedoresACTIVOS();
        //            this.Close();
        //        }
        //        // else { MessageBox.Show("No se pudo modificar el proveedor."); }
        //    }
        //}


    }
}

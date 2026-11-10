using PrimeSystems_2._2_.BD;
using PrimeSystems_2._2_.forms.MODULOS;
using PrimeSystems_2._2_.logica;
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

namespace PrimeSystems_2._2_.forms.usuario
{
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
           Func_cargaComboBox();
        }

       

        private bool validarAddUser()
        {
            bool ok = true;

            ok &= validaciones.func_validaCampoVacio(user_nom_alta, msj_error);
            ok &= validaciones.func_validaCampoVacio(user_ape_alta, msj_error);
            ok &= validaciones.func_validaEspacios(user_user_alta, msj_error);
            ok &= validaciones.func_validaEspacios(user_pass_alta, msj_error);
            ok &= validaciones.func_validaEspacios(user_passConf_alta, msj_error);
            ok &= validaciones.func_validaDNI(user_dni_alta, msj_error);
            ok &= validaciones.func_validaTel(user_tel_alta, msj_error);
            ok &= validaciones.func_validaMail(user_mail_alta, msj_error);
            ok &= validaciones.Func_validaTipoUsuario(cb_rol_alta, msj_error);

            return ok;
        }

        public void Func_cargaComboBox()           // solo carga tipos usuarios
        {
            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            try
            {
                cnn.Open();


                SqlCommand trae_TiposUsuario = new SqlCommand(@"select tipo from Usuarios_Tipo", cnn);
                using (ConectaBD.lector = trae_TiposUsuario.ExecuteReader())
                {

                    while (ConectaBD.lector.Read())
                    {
                        cb_rol_alta.Items.Add(ConectaBD.lector["tipo"].ToString()); 
                    }
                }
            }
            finally { cnn.Close(); }   /////////////////////ver esto
        }




        public USUARIOS u { get; set; }


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (validarAddUser() == true)
            {
                if (validaciones.valida_contrasenias(user_pass_alta.Text, user_passConf_alta.Text))
                {
                    consultas.AgregarUser(user_nom_alta.Text, user_ape_alta.Text, user_tel_alta.Text, user_dni_alta.Text, user_mail_alta.Text, user_user_alta.Text, activo_alta_user.Checked, user_passConf_alta.Text, cb_rol_alta.Text);

                    MessageBox.Show("Usuario agregado.");
                    
                    u.CargarGrillaActivos();
                    this.Close();

                }
            }
            else { MessageBox.Show("No se pudo agregar"); }


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}

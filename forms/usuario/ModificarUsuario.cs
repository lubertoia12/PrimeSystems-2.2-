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
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
            Func_cargaComboBox();
           
        }

        public USUARIOS u { get; set; }



        //funciones mias
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
                        cb_rol_mod.Items.Add(ConectaBD.lector["tipo"].ToString());
                    }
                }
            }
            finally { cnn.Close(); }   /////////////////////ver esto
        }

        private bool validarModUser()
        {
            bool ok = true;

            ok &= validaciones.func_validaCampoVacio(user_nom_mod, msj_error);
            ok &= validaciones.func_validaCampoVacio(user_ape_mod, msj_error);
            ok &= validaciones.func_validaEspacios(user_user_mod, msj_error);
            ok &= validaciones.func_validaEspacios(user_pass_mod, msj_error);
            ok &= validaciones.func_validaEspacios(user_passConf_mod, msj_error);
            ok &= validaciones.func_validaDNI(user_dni_mod, msj_error);
            ok &= validaciones.func_validaTel(user_tel_mod, msj_error);
            ok &= validaciones.func_validaMail(user_mail_mod, msj_error);
            ok &= validaciones.Func_validaTipoUsuario(cb_rol_mod, msj_error);
            ok &= validaciones.func_validaActivo(activo_mod_user, inactivo_mod_user, msj_error);

            return ok;
        }




        //objetos

        private void btn_mod_Click(object sender, EventArgs e)
        {

            if (validarModUser() == true)
            {
                if (validaciones.valida_contrasenias(user_pass_mod.Text, user_passConf_mod.Text))
                {

                    int id = u.idSeleccionado;   

                    bool resultado = consultas.ModificarUser(id, user_nom_mod.Text, user_ape_mod.Text, user_tel_mod.Text, user_dni_mod.Text, user_mail_mod.Text, user_user_mod.Text, user_passConf_mod.Text, cb_rol_mod.Text, activo_mod_user.Checked);
                    if (resultado == true)
                    {
                        MessageBox.Show("Usuario modificado.");
                        u.CargarGrillaActivos();
                        this.Close();
                    }
                    else { MessageBox.Show("No se pudo modificar el usuario."); }
                }
            }
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            DataGridViewRow fila = u.dgv_usuarios.CurrentRow;

            user_nom_mod.Text = fila.Cells["Nombre"].Value.ToString();
            user_ape_mod.Text = fila.Cells["Apellido"].Value.ToString();
            user_dni_mod.Text = fila.Cells["DNI"].Value.ToString();
            user_mail_mod.Text = fila.Cells["Mail"].Value.ToString();
            user_tel_mod.Text = fila.Cells["Telefono"].Value.ToString();
            user_user_mod.Text = fila.Cells["Username"].Value.ToString();

            bool activo = Convert.ToBoolean(fila.Cells["Estado"].Value);
            activo_mod_user.Checked = activo;
            inactivo_mod_user.Checked = !activo;
        }

        private void btn_cancelar_ModUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
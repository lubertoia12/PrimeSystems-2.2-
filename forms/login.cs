using PrimeSystems_2._2_.BD;
using PrimeSystems_2._2_.forms;
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

namespace PrimeSystems_2._2_
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void bt_inicioSesion_Click(object sender, EventArgs e)
        {
            string aviso;

            if (validaciones.Func_ValidarLogin(tx_user.Text, tx_pass.Text, out aviso))
            {
                if (ConectaBD.Func_TraeDatosLogin(tx_user.Text, tx_pass.Text))
                {

                    home homeform = new home();
                    homeform.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(aviso);
            }

            
        }


        private void login_Load(object sender, EventArgs e)
        {
            ConectaBD.Func_cargarBD2();
        }
    }
}

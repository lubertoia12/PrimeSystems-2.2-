using PrimeSystems_2._2_.forms;
using PrimeSystems_2._2_.forms.cliente;
using PrimeSystems_2._2_.forms.MODULOS;
using PrimeSystems_2._2_.forms.proveedores;
using PrimeSystems_2._2_.forms.usuario;
using PrimeSystems_2._2_.pruebas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace PrimeSystems_2._2_.UserControls
{
    public partial class UC_menuStrip : UserControl
    {
        public UC_menuStrip()
        {
            InitializeComponent();
        }

        public home controles { get; set; }


        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controles.panel_padre.Controls.Clear();

            USUARIOS usuario = new USUARIOS();
            usuario.TopLevel = false;
            usuario.FormBorderStyle = FormBorderStyle.None;
            usuario.Dock = DockStyle.Fill;
            
            controles.panel_padre.Controls.Add(usuario);
            usuario.Show();

        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controles.panel_padre.Controls.Clear();

            CLIENTES cliente = new CLIENTES();
            cliente.TopLevel = false;
            cliente.FormBorderStyle = FormBorderStyle.None;
            cliente.Dock = DockStyle.Fill;

            controles.panel_padre.Controls.Add(cliente);
            cliente.Show();

           
        }

        private void pROVEEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controles.panel_padre.Controls.Clear();

            PROVEEDORES proveedor = new PROVEEDORES();
            proveedor.TopLevel = false;
            proveedor.FormBorderStyle = FormBorderStyle.None;
            proveedor.Dock = DockStyle.Fill;

            controles.panel_padre.Controls.Add(proveedor);
            proveedor.Show();

        }


        private void cOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controles.panel_padre.Controls.Clear();

            ventas_interfaz ventas = new ventas_interfaz();
            ventas.TopLevel = false;
            ventas.FormBorderStyle = FormBorderStyle.None;
            ventas.Dock = DockStyle.Fill;

            controles.panel_padre.Controls.Add(ventas);
            ventas.Show();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controles.panel_padre.Controls.Clear();

            UC_home home = new UC_home();
            home.Dock = DockStyle.Fill;

            controles.panel_padre.Controls.Add(home);

        }









        //grilla_usuario.AgregarClick += (a, b) =>
        //{
        //    AltaUsuario adduser = new AltaUsuario();
        //    adduser.ShowDialog();
        //};

        // grilla_usuario.ModificarClick += (a, b) =>
        // {
        //     ModificarUsuario moduser = new ModificarUsuario();
        //     moduser.ShowDialog();

        // };

        // grilla_usuario.InactivarClick += (a, b) =>
        // {
        //     DialogResult resultado = MessageBox.Show("Desea eliminar este registro?","confirmacion", MessageBoxButtons.YesNo);

        //     if (resultado == DialogResult.Yes)
        //     { 

        //     }
        //     else {

        //     }
        // };
    }
}

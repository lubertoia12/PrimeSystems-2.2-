using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeSystems_2._2_.forms.articulo
{
    public partial class alta_categorias : Form
    {
        public alta_categorias()
        {
            InitializeComponent();
        }

        private void btn_cerrar_altaCat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Categoria agregada");
            this.Close();
        }
    }
}

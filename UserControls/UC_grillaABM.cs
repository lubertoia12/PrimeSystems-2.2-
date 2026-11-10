using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeSystems_2._2_.UserControls
{
    public partial class UC_grillaABM : UserControl
    {
        public UC_grillaABM()
        {
            InitializeComponent();
        }

        public event EventHandler AgregarClick;
        public event EventHandler ModificarClick;
        public event EventHandler InactivarClick;

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarClick?.Invoke(this, EventArgs.Empty);   //el ? confirma que no sea null AgregarClick(nadie se suscribio) ... INVOKE ejecuta el metodo que se suscribio
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarClick?.Invoke(this, EventArgs.Empty);
        }

        private void btn_inactivar_Click(object sender, EventArgs e)
        {
            InactivarClick?.Invoke(this, EventArgs.Empty);
        }
    }
}

using PrimeSystems_2._2_.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeSystems_2._2_.forms
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        

        private void home_Load(object sender, EventArgs e)
        {
            uC_menuStrip1.controles = this;

        }

        private void uC_menuStrip1_Load(object sender, EventArgs e)
        {

        }
    }
}

using PrimeSystems_2._2_.forms;
using PrimeSystems_2._2_.forms.MODULOS;
using PrimeSystems_2._2_.forms.proveedores;
using PrimeSystems_2._2_.forms.usuario;
using PrimeSystems_2._2_.pruebas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeSystems_2._2_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login()); 
        }
    }
}

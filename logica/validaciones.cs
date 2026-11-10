using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeSystems_2._2_.logica
{
    internal class validaciones
    {

        public static bool Func_ValidarLogin(string user, string password, out string aviso)
        {
            aviso = "";

            if (string.IsNullOrWhiteSpace(user) || (string.IsNullOrWhiteSpace(password)))
            {
                aviso = "Los campos Usuario o Contraseña no pueden quedar vacios o contener espacios.";
                return false;
            }

            else if (user.Length > 20)
            {
                aviso = "el user no puede tener mas de 20 caracteres";
                return false;
            }

            else if (password.Length > 30)
            {
                aviso = "la contraseña no puede tener mas de 30 caracteres";
                return false;
            }
            else { return true; }
        }

        public static bool func_validaCampoVacio(TextBox campo, ErrorProvider msj_error)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                msj_error.SetError(campo, "El campo " + campo.Tag + " no puede estar vacío.");
                return false;
            }
            msj_error.SetError(campo, string.Empty);
            return true;
        }

        public static bool func_validaEspacios(TextBox campo, ErrorProvider msj_error)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                msj_error.SetError(campo, "El campo" + campo.Tag + "no puede estar vacío.");
                return false;
            }
            if (campo.Text.Any(char.IsWhiteSpace))
            {
                msj_error.SetError(campo, "El campo" + campo.Tag + "no puede contener espacios.");
                return false;
            }
            msj_error.SetError(campo, string.Empty);
            return true;
        } //vacio ni espacios
      
        public static bool func_validaDNI(TextBox campo, ErrorProvider msj_error)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                msj_error.SetError(campo, "El DNI no puede estar vacío.");
                return false;
            }
            if (!campo.Text.All(char.IsDigit))
            {
                msj_error.SetError(campo, "El DNI solo puede contener números.");
                return false;
            }
            if (campo.Text.Length > 8)
            {
                msj_error.SetError(campo, "El DNI no puede superar los 8 dígitos.");
                return false;
            }
            msj_error.SetError(campo, string.Empty);
            return true;
        }


        public static bool func_validaCUIT(TextBox campo, ErrorProvider msj_error)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                msj_error.SetError(campo, "El CUIT no puede estar vacío.");
                return false;
            }
            if (!campo.Text.All(char.IsDigit))
            {
                msj_error.SetError(campo, "El CUIT solo puede contener números.");
                return false;
            }
            if (campo.Text.Length > 11)
            {
                msj_error.SetError(campo, "El CUIT no puede superar los 11 dígitos.");
                return false;
            }
            msj_error.SetError(campo, string.Empty);
            return true;
        }





        public static bool func_validaActivo(RadioButton x, RadioButton y, ErrorProvider msj_error)
        {
            if (!x.Checked && !y.Checked)
            {
                msj_error.SetError(x, "Debe seleccionar una opción");
                return false;
            }
            msj_error.SetError(x, string.Empty);
            return true;
        }

        public static bool func_validaTel(TextBox campo, ErrorProvider msj_error)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                msj_error.SetError(campo, "El teléfono no puede estar vacío.");
                return false;
            }
            if (!campo.Text.All(char.IsDigit))
            {
                msj_error.SetError(campo, "El teléfono solo puede contener números.");
                return false;
            }
            if (campo.Text.Length > 11)
            {
                msj_error.SetError(campo, "El teléfono no puede superar los 11 dígitos.");
                return false;
            }
            msj_error.SetError(campo, string.Empty);
            return true;
        }

        public static bool func_validaMail(TextBox campo, ErrorProvider msj_error)
        {
            string mail = campo.Text;

            if (string.IsNullOrWhiteSpace(mail))
            {
                msj_error.SetError(campo, "El mail no puede estar vacío.");
                return false;
            }
            if (mail.Any(char.IsWhiteSpace))
            {
                msj_error.SetError(campo, "El mail no puede contener espacios.");
                return false;
            }
            if (!mail.Contains("@") || !mail.Contains("."))
            {
                msj_error.SetError(campo, "El mail debe contener '@' y '.'.");
                return false;
            }
            msj_error.SetError(campo, string.Empty);
            return true;
        }

        public static bool valida_contrasenias(string password, string password2)
        {
            if (password == password2)
            {
                return true;
            }
            else { MessageBox.Show("La contraseñas no coinciden."); return false; }
        }

        public static bool Func_validaTipoUsuario(ComboBox i, ErrorProvider msj_error)
        {
            if (i.SelectedItem == null)
            {
                msj_error.SetError(i, "Debe elegir un tipo.");
                return false;
            }
            else
            {
                msj_error.SetError(i, string.Empty);
                return true;
            }
        }


    }
}

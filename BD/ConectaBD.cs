using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeSystems_2._2_.BD
{
    public class ConectaBD
    {

        public static string StringConnection = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=PRIMESYSTEMMMS; trusted_connection=TRUE;";
        //nombre instancia sql       //nombre d ela base de datos        //cuando no tiene user ni contrasena

        public static SqlConnection cnn;                  // conceta el programa con la bd
        public static DataTable tabla = new DataTable(); //guarda la info que trae de la bd  
        public static SqlDataReader lector;
        public static int IdUsuarioActual;   // quién inició sesión 


        public static bool Func_TraeDatosLogin(string user, string password)
        {
            SqlConnection cnn = new SqlConnection(StringConnection);
            cnn.Open();

            string consulta = @"select id_usuario from Usuario where username = @user and contraseña = @password";

            SqlCommand cmd = new SqlCommand(consulta, cnn);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@password", password);

            object resultado = cmd.ExecuteScalar();   // null si no existe

            if (resultado == null)
            { MessageBox.Show("el usuario no existe"); }
            else
            { IdUsuarioActual = (int)resultado; }
            cnn.Close();
            return resultado != null;
        }  //si existe usuario

        public static void Func_cargarBD2()
        {
            SqlConnection cnn = new SqlConnection(StringConnection);
            SqlTransaction transaction = null;
            try
            {
                cnn.Open();

                string consulta = "select count(*) from Usuario";
                SqlCommand cmdUser = new SqlCommand(consulta, cnn);

                int existeUsuario = (int)cmdUser.ExecuteScalar();

                if (existeUsuario > 0)
                {
                    return;
                }

                transaction = cnn.BeginTransaction();

                string query = @"insert into Permiso (read_compra, write_compra, read_venta, write_venta,read_rrhh, write_rrhh, read_log, read_products, write_products)
                                 values (1,1,1,1,1,1,1,1,1);
                                 declare @id_admin int = scope_identity();

                                insert into Permiso (read_compra, write_compra, read_venta, write_venta, read_rrhh, write_rrhh, read_log, read_products, write_products)
                                values (0,0,1,1,0,0,0,1,1);
                                declare @id_vendedor int = scope_identity();

                                insert into Permiso (read_compra, write_compra, read_venta, write_venta, read_rrhh, write_rrhh, read_log, read_products, write_products)
                                values (0,0,0,0,1,1,0,0,0);
                                declare @id_rrhh int = scope_identity();

                                insert into  Usuarios_Tipo (tipo, descripcion, id_permiso) VALUES ('admin','acceso ilimitado',@id_admin);
                                insert into Usuarios_Tipo (tipo, descripcion, id_permiso) VALUES ('vendedor', 'acceso limitado', @id_vendedor);
                                insert into Usuarios_Tipo (tipo, descripcion, id_permiso) VALUES ('rrhh', 'permisos especiales',@id_rrhh);
                                            
                                insert into Usuario (username, contraseña, id_usuario_tipo, activo) VALUES ('admin', 'admin', @id_admin, 1);";

                SqlCommand cmdSeen = new SqlCommand(query, cnn, transaction);
                cmdSeen.ExecuteNonQuery();

                transaction.Commit();


                MessageBox.Show("Sistema inicializado correctamente.");
            }
            catch (Exception ex)
            {

                transaction?.Rollback();   // llama al metodo si no es null
                MessageBox.Show("Error al inicializar el sistema: " + ex.Message);
            }
            finally { cnn.Close(); }
        } // 




    }
}

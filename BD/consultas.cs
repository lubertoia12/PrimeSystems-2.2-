using PrimeSystems_2._2_.forms.MODULOS;
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
    internal class consultas
    {
        public static SqlConnection cnn;



        public static DataTable traer_datos_sqlUSUARIO()  //en grilla//esta no va

        {
            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            cnn.Open();
            DataTable tabla_usuarios = new DataTable();

            string consulta_usuario = "select * from Usuario";
            SqlCommand cmd = new SqlCommand(consulta_usuario, cnn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla_usuarios);

            cnn.Close();
            return tabla_usuarios;
        }


        public static void traer_datos_sql(string consulta, DataGridView grilla)  //en grilla

        {
            try
            {
                SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
                DataTable tabla = new DataTable();

                SqlCommand cmd = new SqlCommand(consulta, cnn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);                                 // da espera que lo vuelquen en el datatable (tabla)
                grilla.DataSource = tabla;                         // a la grilla(xparametro) + datasource y le vuelco la tabla
            }
            catch (Exception e)
            { MessageBox.Show(e.Message + "  " + consulta); }
        }


        /// //////////////////////////////////

        public static void AgregarUser(string nombre, string apellido, string telefono, string dni, string mail, string username, bool activo, string password, string UsuarioTipo)
        {

            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            try
            {
                cnn.Open();


                SqlCommand cmdTipo = new SqlCommand("select id_usuario_tipo from Usuarios_Tipo where tipo = @tipo", cnn);
                cmdTipo.Parameters.AddWithValue("@tipo", UsuarioTipo);

                int idTipo = (int)cmdTipo.ExecuteScalar();


                string consulta = @"insert into Usuario (nombre, apellido, tel, dni, mail, activo,username, contraseña, id_usuario_tipo) 
                                                values (@nombre, @apellido, @tel, @dni, @mail, @activo, @username, @contraseña, @id_usuario_tipo)";
                SqlCommand comando = new SqlCommand(consulta, cnn);

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@tel", telefono);
                comando.Parameters.AddWithValue("@dni", dni);
                comando.Parameters.AddWithValue("@mail", mail);
                comando.Parameters.AddWithValue("@activo", activo);
                comando.Parameters.AddWithValue("@username", username);
                comando.Parameters.AddWithValue("@contraseña", password);
                comando.Parameters.AddWithValue("@id_usuario_tipo", idTipo);

                comando.ExecuteNonQuery();
            }
            finally { cnn.Close(); }
        }


        public static bool ModificarUser(int idSeleccionado, string nombre, string apellido, string telefono, string dni, string mail, string username, string password, string UsuarioTipo, bool activo)
        {
            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            try
            {
                cnn.Open();

                SqlCommand cmdTipo = new SqlCommand("select id_usuario_tipo from Usuarios_Tipo where tipo = @tipo", cnn);
                cmdTipo.Parameters.AddWithValue("@tipo", UsuarioTipo);
                int idTipo = (int)cmdTipo.ExecuteScalar();

                string consulta = "update usuario set nombre= @nombre, apellido=@apellido,tel= @tel,DNI=@dni, mail=@mail, username=@username, activo=@activo, contraseña=@contraseña,  id_usuario_tipo=@idTipo where id_usuario=@idSeleccionado";

                SqlCommand cmd = new SqlCommand(consulta, cnn);

                cmd.Parameters.AddWithValue("@idSeleccionado", idSeleccionado);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@tel", telefono);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@contraseña", password);
                cmd.Parameters.AddWithValue("@activo", activo);
                cmd.Parameters.AddWithValue("@idTipo", idTipo);


                int filasAfectadas = cmd.ExecuteNonQuery();


                if (filasAfectadas > 0) // true si modificó algo
                {
                    MessageBox.Show("usuario modificado.");
                    return true;
                }
                return false;
            }
            finally { cnn.Close(); }
        }


        public static bool BajaLogica_user(int idSeleccionado, bool activo)
        {
            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);

            try
            {
                cnn.Open();
                string consulta = @"Update Usuario set activo=@activo where id_usuario = @id_usuario "; // 
                SqlCommand cmd = new SqlCommand(consulta, cnn);

                cmd.Parameters.AddWithValue("@activo", activo);
                cmd.Parameters.AddWithValue("@id_usuario", idSeleccionado);


                int filasAfectadas = cmd.ExecuteNonQuery();


                if (filasAfectadas > 0) // true si modificó algo
                {
                    MessageBox.Show("Usuario dado de baja.");
                    return true;
                }

                return false;
            }
            finally { cnn.Close(); }
        }


        /////////////////////////////////////////////cliente //////////////////////////////////////////////////////////////////



        public static void AgregarCliente(string nombre, string entidad, string telefono, string cuit, bool activo)
        {

            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            try
            {

                cnn.Open();


                string consulta = @"insert into Cliente (nombre, entidad, telefono, CUIT, activo) values (@D1, @D2, @D3, @D4, @D5)";
                SqlCommand comando = new SqlCommand(consulta, cnn);

                comando.Parameters.AddWithValue("@D1", nombre);
                comando.Parameters.AddWithValue("@D2", entidad);
                comando.Parameters.AddWithValue("@D3", telefono);
                comando.Parameters.AddWithValue("@D4", cuit);
                comando.Parameters.AddWithValue("@D5", activo);

                comando.ExecuteNonQuery();
            }
            finally { cnn.Close(); }
        }

        public static bool ModificarCliente(int idSeleccionado, string nombre, string entidad, string telefono, string cuit, bool activo)
        {


            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            try
            {
                cnn.Open();

                string consulta = "update Cliente set nombre= @nombre,entidad=@entidad,telefono= @telefono, CUIT =@cuit, activo=@activo where id_cliente=@idSeleccionado";

                SqlCommand cmd = new SqlCommand(consulta, cnn);

                cmd.Parameters.AddWithValue("@idSeleccionado", idSeleccionado);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@entidad", entidad);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@cuit", cuit);
                cmd.Parameters.AddWithValue("@activo", activo);

                int filasAfectadas = cmd.ExecuteNonQuery();


                if (filasAfectadas > 0) // true si modificó algo
                {
                    MessageBox.Show("cliente modificado.");
                    return true;
                }
                return false;
            }
            finally { cnn.Close(); }
        }



        /// ////////////////////////////////////////// proveedor ////////////////////////////////////////////////////////
        /// 
        public static void AgregarProveedorPOPUP(string proveedor, string nombre, string cuit, string telefono, string mail, bool activo)
        {

            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            try
            {
                cnn.Open();


                string consulta = @"insert into Proveedor (proveedor, nombre, cuit, tel, mail, activo) values ( @proveedor,@nombre, @cuit, @telefono,@mail, @activo)";
                SqlCommand comando = new SqlCommand(consulta, cnn);


                comando.Parameters.AddWithValue("@proveedor", proveedor);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@cuit", cuit);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@mail", mail);
                comando.Parameters.AddWithValue("@activo", activo);

                comando.ExecuteNonQuery();
            }
            finally { cnn.Close(); }
        }

        public static void AgregarProveedor(string proveedor, string nombre, string apellido, string cuit, string telefono, string direccion, string mail, bool activo)
        {

            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            try
            {
                cnn.Open();


                string consulta = @"insert into Proveedor (proveedor, nombre, apellido, cuit, tel, direccion, mail, activo) values (@proveedor, @nombre, @apellido, @cuit, @telefono, @direccion, @mail,@activo)";
                SqlCommand comando = new SqlCommand(consulta, cnn);


                comando.Parameters.AddWithValue("@proveedor", proveedor);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@cuit", cuit);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@mail", mail);
                comando.Parameters.AddWithValue("@activo", activo);

                comando.ExecuteNonQuery();
            }
            finally { cnn.Close(); }
        }

        public static bool ModificarProveedor(int idSeleccionado, string proveedor, string nombre, string apellido, string cuit, string telefono, string direccion, string mail, bool activo)
        {


            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            try
            {
                cnn.Open();

                string consulta = "update Proveedor set proveedor=@proveedor , nombre= @nombre, apellido=@apellido, CUIT=@cuit, tel= @tel,direccion=@direccion, mail=@mail, activo=@activo, where id_proveedor=@idSeleccionado";

                SqlCommand cmd = new SqlCommand(consulta, cnn);

                cmd.Parameters.AddWithValue("@idSeleccionado", idSeleccionado);

                cmd.Parameters.AddWithValue("@proveedor", proveedor);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);

                cmd.Parameters.AddWithValue("@cuit", cuit);
                cmd.Parameters.AddWithValue("@tel", telefono);

                cmd.Parameters.AddWithValue("@direccion", direccion);

                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@activo", activo);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0) // true si modificó algo
                {
                    MessageBox.Show("proveedor modificado.");
                    return true;
                }

                return false;
            }
            finally { cnn.Close(); }
        }


        //bajas logicas


        public static bool BajaLogica_cliente(int idSeleccionado, bool activo)
        {
            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            try
            {
                cnn.Open();
                string consulta = @"update Cliente set activo = @activo where id_cliente = @id_cliente";
                SqlCommand cmd = new SqlCommand(consulta, cnn);
                cmd.Parameters.AddWithValue("@activo", activo);
                cmd.Parameters.AddWithValue("@id_cliente", idSeleccionado);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cliente dado de baja.");
                    return true;
                }
                return false;
            }
            finally { cnn.Close(); }
        }

        public static bool BajaLogica_proveedor(int idSeleccionado, bool activo)
        {
            SqlConnection cnn = new SqlConnection(ConectaBD.StringConnection);
            try
            {
                cnn.Open();
                string consulta = @"update Proveedor set activo = @activo where id_proveedor = @id_proveedor";
                SqlCommand cmd = new SqlCommand(consulta, cnn);
                cmd.Parameters.AddWithValue("@activo", activo);
                cmd.Parameters.AddWithValue("@id_proveedor", idSeleccionado);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Proveedor dado de baja.");
                    return true;
                }
                return false;
            }
            finally { cnn.Close(); }
        }


    }
}
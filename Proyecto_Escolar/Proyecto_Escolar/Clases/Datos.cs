using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Escolar.Clases
{
    class Datos
    {
        static SqlConnection conexion = new SqlConnection();

        public static void AbrirConexion()
        {
            conexion.ConnectionString = @"Data Source=QE-SEV-LT004\SQLEXPRESS; Initial Catalog=ProyectoEscuela; Integrated Security=Yes";
            conexion.Open();
        }

        public static void CerrarConexion()
        {
            conexion.Close();
        }

        try 
	{	        
		
	}
	catch (global::System.Exception)
	{

		throw;
	}

        public static string IniciarSesion(string usuario, string contrasena)
        {
            int logueado = 0;
            string mensaje = string.Empty;
            AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Loguear";
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@usuario", usuario);
            cmd.Parameters.Add("@contrasena", contrasena);

            SqlParameter pLogueado = new SqlParameter("@logueado",0);
            pLogueado.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pLogueado);

            SqlParameter pMensaje = new SqlParameter("@mensaje",SqlDbType.VarChar);
            pMensaje.Direction = ParameterDirection.Output;
            pMensaje.Size = 40;
            cmd.Parameters.Add(pMensaje);

            cmd.ExecuteNonQuery();
            CerrarConexion();

            logueado = int.Parse(cmd.Parameters["@logueado"].Value.ToString());
            if (logueado > 0)
            {
                mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                return mensaje;
            }
            else
                return mensaje;
        }
    }
}

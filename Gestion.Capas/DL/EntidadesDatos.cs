using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Capas.DL
{
    public class EntidadesDatos
    {
        private Connection2 conexion = new Connection2();
        public DataTable Mostrar()
        {
            SqlConnection Conexiones = new SqlConnection("Data Source=.; Initial Catalog=SellPoint; Integrated Security=True ");

            using (Conexiones)
            {
                Conexiones.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexion.AbrirConexion();
                    cmd.CommandText = "MostrarEntidades";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        /// LOGIN METHOD PROC------------------------------------------------------------------------------------------------------------------------------------------------------------
        public bool LoginTrue(string usuario, string contraseña)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Logear";
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@password", contraseña);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = comando.ExecuteReader();
            comando.Parameters.Clear();

            if (dr.HasRows)
            {
                return true;

            }
            else { return false; }

        }

        /// INSERT PROC METHOD------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Insertar(string Desc, string address, string Localidad, string TEntidad, string TDocumento, Int64 NDocumento, string tell, string PW, string URLF, string URLIG, string URLTW, string URLTK, string CP, string CG, decimal LCredito, string user, string pass, string ROL, string Comment, string estado, byte Eliminable, string Fecha)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarEntidades";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Descripcion", Desc);
            comando.Parameters.AddWithValue("@Direccion", address);
            comando.Parameters.AddWithValue("@Localidad", Localidad);
            comando.Parameters.AddWithValue("@TipoEntidad", TEntidad);
            comando.Parameters.AddWithValue("@TipoDocumento", TDocumento);
            comando.Parameters.AddWithValue("@NumeroDocumento", NDocumento);
            comando.Parameters.AddWithValue("@Telefonos", tell);
            comando.Parameters.AddWithValue("@URLPaginaWeb", PW);
            comando.Parameters.AddWithValue("@URLFacebook", URLF);
            comando.Parameters.AddWithValue("@URLInstagram", URLIG);
            comando.Parameters.AddWithValue("@URLTwitter", URLTW);
            comando.Parameters.AddWithValue("@URLTikTok", URLTK);
            comando.Parameters.AddWithValue("@CodigoPostal", CP);
            comando.Parameters.AddWithValue("@CoordenadasGPS", CG);
            comando.Parameters.AddWithValue("@LimiteCredito", LCredito);
            comando.Parameters.AddWithValue("@UserNameEntidad", user);
            comando.Parameters.AddWithValue("@PasswordEntidad", pass);
            comando.Parameters.AddWithValue("@RolUserEntidad", ROL);
            comando.Parameters.AddWithValue("@Comentario", Comment);
            comando.Parameters.AddWithValue("@Estado", estado);
            comando.Parameters.AddWithValue("@NoEliminable", Eliminable);
            comando.Parameters.AddWithValue("@FechaRegistro", Fecha);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        /// EDIT PROC METHOD------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void EditarEntidades(string Desc, string address, string Localidad, string TEntidad, string TDocumento, Int64 NDocumento, string tell, string PW, string URLF, string URLIG, string URLTW, string URLTK, string CP, string CG, decimal LCredito, string user, string pass, string ROL, string Comment, string estado, byte Eliminable, string Fecha, Int64 ID)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarEntidades";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Descripcion", Desc);
            comando.Parameters.AddWithValue("@Direccion", address);
            comando.Parameters.AddWithValue("@Localidad", Localidad);
            comando.Parameters.AddWithValue("@TipoEntidad", TEntidad);
            comando.Parameters.AddWithValue("@TipoDocumento", TDocumento);
            comando.Parameters.AddWithValue("@NumeroDocumento", NDocumento);
            comando.Parameters.AddWithValue("@Telefonos", tell);
            comando.Parameters.AddWithValue("@URLPaginaWeb", PW);
            comando.Parameters.AddWithValue("@URLFacebook", URLF);
            comando.Parameters.AddWithValue("@URLInstagram", URLIG);
            comando.Parameters.AddWithValue("@URLTwitter", URLTW);
            comando.Parameters.AddWithValue("@URLTikTok", URLTK);
            comando.Parameters.AddWithValue("@CodigoPostal", CP);
            comando.Parameters.AddWithValue("@CoordenadasGPS", CG);
            comando.Parameters.AddWithValue("@LimiteCredito", LCredito);
            comando.Parameters.AddWithValue("@UserNameEntidad", user);
            comando.Parameters.AddWithValue("@PasswordEntidad", pass);
            comando.Parameters.AddWithValue("@RolUserEntidad", ROL);
            comando.Parameters.AddWithValue("@Comentario", Comment);
            comando.Parameters.AddWithValue("@Estado", estado);
            comando.Parameters.AddWithValue("@NoEliminable", Eliminable);
            comando.Parameters.AddWithValue("@FechaRegistro", Fecha);
            comando.Parameters.AddWithValue("@IdEntidad", ID);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        /// DELETE PROC METHOD------------------------------------------------------------------------------------------------------------------------------------------------------------

        public void EliminarEntidades(int ID)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarEntidades";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdEntidad", ID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }



    }
}



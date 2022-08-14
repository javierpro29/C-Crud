using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Capas.DL
{
    public class Connection2
    {
        //CONECTION OPEN------------------------------------------------------------------------------------------------------------------------------------------------------------
        private SqlConnection Conexion = new SqlConnection("Data Source=.; Initial Catalog=SellPoint; Integrated Security=True");

        public SqlConnection AbrirConexion()
        {

            if (Conexion.State == ConnectionState.Closed)

                Conexion.Open();
            return Conexion;

        }
        //CONECTION CLOSE------------------------------------------------------------------------------------------------------------------------------------------------------------
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)

                Conexion.Close();
            return Conexion;

        }
    }
}
//Data Source=.; Initial Catalog=SellPoint; Integrated Security=True 
//Server=sql5101.site4now.net;Database=db_a8b410_gestion;User Id=db_a8b410_gestion_admin;Password=Morla.123321

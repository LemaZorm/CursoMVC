using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;


namespace CapaDatos
{
    public class Conexiones
    {
        private static Conexiones con = null;
        public SqlConnection crearConexion()
        {

            SqlConnection cadena = new SqlConnection();

            try
            {
                cadena.ConnectionString = "Data Source =.; Initial Catalog = EscuelaSalvador; Integrated Security = True";
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexiones crearInstancia()
        {
            if (con == null)
            {
                con = new Conexiones();
            }
            return con;
        }
    }
}

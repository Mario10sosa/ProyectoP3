using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CD_Conexion
    {

        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion_DB"].ConnectionString);

        public SqlConnection Abrir()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;

        }

        public SqlConnection Cerrar()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;

        }

    }
}

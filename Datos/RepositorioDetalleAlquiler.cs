using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioDetalleAlquiler
    {
        CD_Conexion Con = new CD_Conexion();
        private SqlCommand Cmd;

        public void AgregarDetalleAlquiler(CE_Detalle_Alquiler detalle_Alquiler)
        {
            Cmd = new SqlCommand("AgregarDetalleAlquiler", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            Cmd.Parameters.Add(new SqlParameter("@Id_Alquiler", detalle_Alquiler.Id_Alquiler));
            Cmd.Parameters.Add(new SqlParameter("@Id_Producto", detalle_Alquiler.Id_Producto));
            Cmd.Parameters.Add(new SqlParameter("@Duracion", detalle_Alquiler.Duracion));
            Cmd.Parameters.Add(new SqlParameter("@Precio_Alquiler", detalle_Alquiler.Precio_Alquiler));
            Cmd.Parameters.Add(new SqlParameter("@Monto_Total", detalle_Alquiler.Monto_Total));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();

        }

        public void AnularDetalleAlquiler(CE_Detalle_Alquiler detalle_Alquiler)
        {

            string Estado = string.Empty;
            Cmd = new SqlCommand("Select Estado From Alquiler Where Id_Alquiler=" + detalle_Alquiler.Id_Alquiler + "", Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Estado = Dr["Estado"].ToString();
            }

            Dr.Close();

            if (Estado == "Anulado")
            {
                return;
            }
            else
            {

                Cmd = new SqlCommand("AnularDetalleAlquiler", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Id_Alquiler", detalle_Alquiler.Id_Alquiler));
                Cmd.Parameters.Add(new SqlParameter("@Id_Producto", detalle_Alquiler.Id_Producto));
                Cmd.Parameters.Add(new SqlParameter("@Duracion", detalle_Alquiler.Duracion));
                Cmd.Parameters.Add(new SqlParameter("@Precio_Alquiler", detalle_Alquiler.Precio_Alquiler));
                Cmd.Parameters.Add(new SqlParameter("@Monto_Total", detalle_Alquiler.Monto_Total));
                Cmd.Parameters.Add(new SqlParameter("@Id_Detalle_Alquiler", detalle_Alquiler.Id_Detalle_A));
                Cmd.ExecuteNonQuery();


                Con.Cerrar();

            }

        }


        public DataTable MostrarDetalleAlquiler(int Id_Aqluiler)
        {
            DataTable Dt = new DataTable("Detalle Alquiler");
            Cmd = new SqlCommand("Mostrar_Detalle_Alquiler", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Alquiler", Id_Aqluiler));

            Cmd.ExecuteNonQuery();

            SqlDataAdapter Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);



            Con.Cerrar();
            return Dt;
        }
    }
}

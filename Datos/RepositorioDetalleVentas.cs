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
    public class RepositorioDetalleVentas
    {
        CD_Conexion Con = new CD_Conexion();
        private SqlCommand Cmd;

        public void AgregarDetalleVenta(CE_Detalle_Ventas detalle_Ventas)
        {
            Cmd = new SqlCommand("AgregarDetalleVenta", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            Cmd.Parameters.Add(new SqlParameter("@Id_Venta", detalle_Ventas.Id_Venta));
            Cmd.Parameters.Add(new SqlParameter("@Id_Producto", detalle_Ventas.Id_Producto));
            Cmd.Parameters.Add(new SqlParameter("@Cantidad", detalle_Ventas.Cantidad));
            Cmd.Parameters.Add(new SqlParameter("@Precio_Venta", detalle_Ventas.Precio_venta));
            Cmd.Parameters.Add(new SqlParameter("@Sub_Total", detalle_Ventas.Sub_Total));
            Cmd.Parameters.Add(new SqlParameter("@Monto_Total", detalle_Ventas.Monto_Total));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();

        }

        public void AnularDetalleVenta(CE_Detalle_Ventas detalle_Ventas)
        {

            string Estado = string.Empty;
            Cmd = new SqlCommand("Select Estado From Ventas Where Id_Venta=" + detalle_Ventas.Id_Venta + "", Con.Abrir());
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

                Cmd = new SqlCommand("AnularDetalleVenta", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Id_Venta", detalle_Ventas.Id_Venta));
                Cmd.Parameters.Add(new SqlParameter("@Id_Producto", detalle_Ventas.Id_Producto));
                Cmd.Parameters.Add(new SqlParameter("@Cantidad", detalle_Ventas.Cantidad));
                Cmd.Parameters.Add(new SqlParameter("@Precio_Venta", detalle_Ventas.Precio_venta));
                Cmd.Parameters.Add(new SqlParameter("@Sub_Total", detalle_Ventas.Sub_Total));
                Cmd.Parameters.Add(new SqlParameter("@Monto_Total", detalle_Ventas.Monto_Total));
                Cmd.Parameters.Add(new SqlParameter("@Id_Detalle", detalle_Ventas.Id_Detalle));
                Cmd.ExecuteNonQuery();


                Con.Cerrar();

            }

        }


        public DataTable MostrarDetalleVenta(int Id_Venta)
        {
            DataTable Dt = new DataTable("Detalle Venta");
            Cmd = new SqlCommand("Mostrar_Detalle_Venta", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Venta", Id_Venta));

            Cmd.ExecuteNonQuery();

            SqlDataAdapter Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);



            Con.Cerrar();
            return Dt;
        }
    }
}

using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioAlquiler
    {
        CD_Conexion Con = new CD_Conexion();
        private SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt;

        public void AgregarAlquiler(CE_Alquiler alquiler)
        {
            Cmd = new SqlCommand("AgregarAlquiler", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            Cmd.Parameters.Add(new SqlParameter("@Id_Cliente", alquiler.Id_Cliente));
            Cmd.Parameters.Add(new SqlParameter("@No_Factura", alquiler.No_Factura));
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Alquiler", alquiler.Fecha_Alquiler));
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Validez", alquiler.Fecha_Validez));
            Cmd.Parameters.Add(new SqlParameter("@Monto_Total", alquiler.Monto_Total));
            Cmd.Parameters.Add(new SqlParameter("@Metodo_Pago", alquiler.Metodo_Pago));
            Cmd.Parameters.Add(new SqlParameter("@Estado", alquiler.Estado));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();

        }

        public void AnularAlquiler(CE_Alquiler alquiler)
        {

            string Estado = string.Empty;
            Cmd = new SqlCommand("Select Estado From Alquiler Where Id_Alquiler=" + alquiler.Id_Alquiler + "", Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Estado = Dr["Estado"].ToString();
            }

            Dr.Close();

            if (Estado == "Anulado")
            {
                MessageBox.Show("El Alquiler Ya Ha Sido Anulada, Selecione ota Venta Por Favor", "Anular Alquiler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

                Cmd = new SqlCommand("AnularAlquiler", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Id_Cliente", alquiler.Id_Cliente));
                Cmd.Parameters.Add(new SqlParameter("@No_Factura", alquiler.No_Factura));
                Cmd.Parameters.Add(new SqlParameter("@Fecha_Alquiler", alquiler.Fecha_Alquiler));
                Cmd.Parameters.Add(new SqlParameter("@Fecha_Validez", alquiler.Fecha_Validez));
                Cmd.Parameters.Add(new SqlParameter("@Monto_Total", alquiler.Monto_Total));
                Cmd.Parameters.Add(new SqlParameter("@Metodo_Pago", alquiler.Metodo_Pago));
                Cmd.Parameters.Add(new SqlParameter("@Estado", alquiler.Estado));
                Cmd.Parameters.Add(new SqlParameter("@Id_Alquiler", alquiler.Id_Alquiler));
                Cmd.ExecuteNonQuery();


                MessageBox.Show("El Alquiler Fue Anulada Correctamente", "Anular Alquier", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Con.Cerrar();

            }

        }


        public DataTable MostrarAlquiler()
        {
            DataTable Dt = new DataTable("Alquiler de Productos");
            Cmd = new SqlCommand("MostrarAlquiler", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);

            Dr.Close();
            Con.Cerrar();


            return Dt;
        }



        public DataTable Mostrar_Productos_Alquiler()
        {
            DataTable Dt = new DataTable("Mostrar Productos");
            Cmd = new SqlCommand("Mostrar_Productos_Alquiler", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);

            Dr.Close();
            Con.Cerrar();


            return Dt;
        }


        //Buscar Alquiler Cliente
        public DataTable BuscarAlquilerCliente(CE_Alquiler alquiler)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("BuscarAlquilerCliente", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", alquiler.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Buscar Alquiler cedula
        public DataTable BuscarAlquilerCedula(CE_Alquiler alquiler)
        {
            Dt = new DataTable("Cedula");
            Cmd = new SqlCommand("BuscarAlquilerCedula", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", alquiler.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Buscar Alquiler monto total
        public DataTable BuscarAlquilerMonto_Total(CE_Alquiler alquiler)
        {
            Dt = new DataTable("Monto Total");
            Cmd = new SqlCommand("BuscarAlquilerMontoTotal", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", alquiler.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Buscar Alquiler no factura
        public DataTable BuscarAlquilerNo_Factura(CE_Alquiler alquiler)
        {
            Dt = new DataTable("No Factura");
            Cmd = new SqlCommand("BuscarAlquilerNoFactura", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", alquiler.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Buscar Alquiler Metodo Pago
        public DataTable BuscarAlquilerMetodo_Pago(CE_Alquiler alquiler)
        {
            Dt = new DataTable("Metodo Pago");
            Cmd = new SqlCommand("BuscarAlquilerMetodoPago", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", alquiler.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Buscar Alquiler cedula
        public DataTable BuscarAlquilerFechaAlquiler(CE_Alquiler alquiler)
        {
            Dt = new DataTable("Fecha Alquiler");
            Cmd = new SqlCommand("BuscarAlquilerFechaAlquiler", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            // Asumiendo que las fechas se pasan correctamente al servicio
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Alquiler", SqlDbType.Date) { Value = alquiler.Fecha_Alquiler });
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Valides", SqlDbType.Date) { Value = alquiler.Fecha_Validez });

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }


        public bool BuscarClientePorCedula(string cedula)
        {
            bool clienteRegistrado = false;
            Cmd = new SqlCommand("BuscarClientePorCedula", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Cedula", cedula));

            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                clienteRegistrado = true; // El cliente está registrado
            }

            Dr.Close();
            Con.Cerrar();

            return clienteRegistrado;
        }
        public bool BuscarProductoPorCodigoBarra(string codigobarra)
        {
            bool productoRegistrado = false;
            Cmd = new SqlCommand("BuscarProductoPorCodigoBarra", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@CodigoBarra", codigobarra));

            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                productoRegistrado = true;
            }

            Dr.Close();
            Con.Cerrar();

            return productoRegistrado;
        }

        public DataTable ObtenerDatosClientePorCedula(string cedula)
        {
            Dt = new DataTable("Cliente");

            Cmd = new SqlCommand("SELECT Id_Cliente,Cedula,Nombre,Apellido FROM Clientes WHERE Cedula = @Cedula", Con.Abrir());
            Cmd.Parameters.Add(new SqlParameter("@Cedula", cedula));

            using (SqlDataAdapter adapter = new SqlDataAdapter(Cmd))
            {
                adapter.Fill(Dt);
            }

            Con.Cerrar();

            return Dt;
        }

        public DataTable ObtenerDatosProductosPorCodigoBarra(string CodigoBarra)
        {
            Dt = new DataTable("Productos");

            Cmd = new SqlCommand("SELECT Id_Producto,Codigo,CodigoBarra,Nombre,Stock,Costo_Unitario,Costo_Alquiler FROM Productos WHERE CodigoBarra = @CodigoBarra", Con.Abrir());
            Cmd.Parameters.Add(new SqlParameter("@CodigoBarra", CodigoBarra));

            using (SqlDataAdapter adapter = new SqlDataAdapter(Cmd))
            {
                adapter.Fill(Dt);
            }

            Con.Cerrar();

            return Dt;
        }
    }
}

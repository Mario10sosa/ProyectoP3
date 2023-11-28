using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioVentas
    {
        CD_Conexion Con = new CD_Conexion();
        private SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt;

        public void AgregarVenta(CE_Ventas ventas)
        {
            Cmd = new SqlCommand("AgregarVenta", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            

            Cmd.Parameters.Add(new SqlParameter("@Id_Cliente", ventas.Id_Cliente));
            Cmd.Parameters.Add(new SqlParameter("@No_Factura", ventas.No_Factura));
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Venta", ventas.Fecha_Venta));
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Validez", ventas.Fecha_Validez));
            Cmd.Parameters.Add(new SqlParameter("@Sub_Total", ventas.Sub_Total));
            Cmd.Parameters.Add(new SqlParameter("@Monto_Total", ventas.Monto_Total));
            Cmd.Parameters.Add(new SqlParameter("@Metodo_Pago", ventas.Metodo_Pago));
            Cmd.Parameters.Add(new SqlParameter("@Estado", ventas.Estado));
            Cmd.Parameters.Add(new SqlParameter("@Id_Usuario", ventas.Id_Usuario));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();

        }

        public void AnularVenta(CE_Ventas ventas)
        {

            string Estado = string.Empty;
            Cmd = new SqlCommand("Select Estado From Ventas Where Id_Venta=" + ventas.Id_Venta + "", Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                Estado = Dr["Estado"].ToString();
            }

            Dr.Close();

            if (Estado == "Anulado")
            {
                MessageBox.Show("La Venta Ya Ha Sido Anulada, Selecione ota Venta Por Favor", "Anular Venta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

                Cmd = new SqlCommand("AnularVenta", Con.Abrir());
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add(new SqlParameter("@Id_Cliente", ventas.Id_Cliente));
                Cmd.Parameters.Add(new SqlParameter("@No_Factura", ventas.No_Factura));
                Cmd.Parameters.Add(new SqlParameter("@Fecha_Venta", ventas.Fecha_Venta));
                Cmd.Parameters.Add(new SqlParameter("@Fecha_Validez", ventas.Fecha_Validez));
                Cmd.Parameters.Add(new SqlParameter("@Sub_Total", ventas.Sub_Total));
                Cmd.Parameters.Add(new SqlParameter("@Monto_Total", ventas.Monto_Total));
                Cmd.Parameters.Add(new SqlParameter("@Metodo_Pago", ventas.Metodo_Pago));
                Cmd.Parameters.Add(new SqlParameter("@Estado", ventas.Estado));
                Cmd.Parameters.Add(new SqlParameter("@Id_Usuario", ventas.Id_Usuario));
                Cmd.Parameters.Add(new SqlParameter("@Id_Venta", ventas.Id_Venta));
                Cmd.ExecuteNonQuery();


                MessageBox.Show("La Venta Fue Anulada Correctamente", "Anular Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Con.Cerrar();

            }

        }


        public DataTable MostrarVenta()
        {
            DataTable Dt = new DataTable("Venta de Productos");
            Cmd = new SqlCommand("MostrarVenta", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);

            Dr.Close();
            Con.Cerrar();


            return Dt;
        }



        public DataTable Mostrar_Productos_Ventas()
        {
            DataTable Dt = new DataTable("Mostrar Productos");
            Cmd = new SqlCommand("Mostrar_Productos_Ventas", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);

            Dr.Close();
            Con.Cerrar();


            return Dt;
        }


        //Buscar Venta Cliente
        public DataTable BuscarVentaCliente(CE_Ventas ventas)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("BuscarVentaCliente", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", ventas.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

        //Buscar Venta por Cedula
        public DataTable BuscarVentaCedula(CE_Ventas ventas)
        {
            Dt = new DataTable("Cedula");
            Cmd = new SqlCommand("BuscarVentaCedula", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", ventas.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

        //Buscar Venta por Monto Total
        public DataTable BuscarVentaMonto_Total(CE_Ventas ventas)
        {
            Dt = new DataTable("Monto Total");
            Cmd = new SqlCommand("BuscarVentaMonto_Total", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", ventas.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }


        //Buscar Venta por no factura
        public DataTable BuscarVentaNoFactura(CE_Ventas ventas)
        {
            Dt = new DataTable("No Factura");
            Cmd = new SqlCommand("BuscarVentaNoFactura", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", ventas.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

        //Buscar Venta por Metodo pago
        public DataTable BuscarVentaMetodo_Pago(CE_Ventas ventas)
        {
            Dt = new DataTable("Metodo Pago");
            Cmd = new SqlCommand("BuscarVentaMetodoPago", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", ventas.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }


        //Buscar Venta por Fecha Venta
        public DataTable BuscarVentaFechaVenta(CE_Ventas ventas)
        {
            Dt = new DataTable("Fecha Venta");
            Cmd = new SqlCommand("BuscarVentaFecha", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;

            // Asumiendo que las fechas se pasan correctamente al servicio
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Venta", SqlDbType.Date) { Value = ventas.Fecha_Venta });
            Cmd.Parameters.Add(new SqlParameter("@Fecha_Valides", SqlDbType.Date) { Value = ventas.Fecha_Validez });

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

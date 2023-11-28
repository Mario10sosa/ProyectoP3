using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioContactoVentas
    {
        RepositorioVentas repositorioVentas = new RepositorioVentas();

        public void AgregarVenta(CE_Ventas ventas)
        {
            repositorioVentas.AgregarVenta(ventas);
        }

        public void AnularVenta(CE_Ventas ventas)
        {
            repositorioVentas.AnularVenta(ventas);
        }

        public DataTable MostrarVenta()
        {
            return repositorioVentas.MostrarVenta();
        }

        public DataTable Mostrar_Productos_Ventas()
        {
            return repositorioVentas.Mostrar_Productos_Ventas();
        }

        public DataTable BuscarVentaCliente(CE_Ventas ventas)
        {
            return repositorioVentas.BuscarVentaCliente(ventas);
        }

        //Buscar Venta por Cedula
        public DataTable BuscarVentaCedula(CE_Ventas ventas)
        {
            return repositorioVentas.BuscarVentaCedula(ventas);
        }

        //Buscar Venta por Monto Total
        public DataTable BuscarVentaMonto_Total(CE_Ventas ventas)
        {
            return repositorioVentas.BuscarVentaMonto_Total(ventas);
        }


        //Buscar Venta por no factura
        public DataTable BuscarVentaNoFactura(CE_Ventas ventas)
        {
            return repositorioVentas.BuscarVentaNoFactura(ventas);
        }

        //Buscar Venta por Metodo pago
        public DataTable BuscarVentaMetodo_Pago(CE_Ventas ventas)
        {
            return repositorioVentas.BuscarVentaMetodo_Pago(ventas);
        }

        //Buscar Venta por Fecha Venta
        public DataTable BuscarVentaFechaVenta(CE_Ventas ventas)
        {
            return repositorioVentas.BuscarVentaFechaVenta(ventas);
        }

        public bool BuscarClientePorCedula(string cedula)
        {
            return repositorioVentas.BuscarClientePorCedula(cedula);
        }

        public bool BuscarProductoPorCodigoBarra(string codigobarra)
        {
            return repositorioVentas.BuscarProductoPorCodigoBarra(codigobarra);
        }

        public DataTable ObtenerDatosClientePorCedula(string cedula)
        {
            return repositorioVentas.ObtenerDatosClientePorCedula(cedula);
        }

        public DataTable ObtenerDatosProductosPorCodigoBarra(string CodigoBarra)
        {
            return repositorioVentas.ObtenerDatosProductosPorCodigoBarra(CodigoBarra);
        }
    }
}

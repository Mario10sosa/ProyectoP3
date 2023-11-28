using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class ServicioContactoAlquiler
    {
        RepositorioAlquiler repositorioAlquiler = new RepositorioAlquiler();
        public void AgregarAlquiler(CE_Alquiler alquiler)
        {
            repositorioAlquiler.AgregarAlquiler(alquiler);
        }

        public void AnularAlquiler(CE_Alquiler alquiler)
        {
            repositorioAlquiler.AnularAlquiler(alquiler);
        }


        public DataTable MostrarAlquiler()
        {
            return repositorioAlquiler.MostrarAlquiler();
        }



        public DataTable Mostrar_Productos_Alquiler()
        {
            return repositorioAlquiler.Mostrar_Productos_Alquiler();
        }


        //Buscar Alquiler Cliente
        public DataTable BuscarAlquilerCliente(CE_Alquiler alquiler)
        {
            return repositorioAlquiler.BuscarAlquilerCliente(alquiler);
        }
        //Buscar Alquiler cedula
        public DataTable BuscarAlquilerCedula(CE_Alquiler alquiler)
        {
            return repositorioAlquiler.BuscarAlquilerCedula(alquiler);
        }
        //Buscar Alquiler monto total
        public DataTable BuscarAlquilerMonto_Total(CE_Alquiler alquiler)
        {
            return repositorioAlquiler.BuscarAlquilerMonto_Total(alquiler);
        }

        //Buscar Alquiler no factura
        public DataTable BuscarAlquilerNo_Factura(CE_Alquiler alquiler)
        {
            return repositorioAlquiler.BuscarAlquilerNo_Factura(alquiler);
        }

        //Buscar Alquiler Metodo Pago
        public DataTable BuscarAlquilerMetodo_Pago(CE_Alquiler alquiler)
        {
            return repositorioAlquiler.BuscarAlquilerMetodo_Pago(alquiler);
        }
        //Buscar Alquiler fecha
        public DataTable BuscarAlquilerFechaAlquiler(CE_Alquiler alquiler)
        {
            return repositorioAlquiler.BuscarAlquilerFechaAlquiler(alquiler);
        }
        public bool BuscarClientePorCedula(string cedula)
        {
            return repositorioAlquiler.BuscarClientePorCedula(cedula);
        }

        public DataTable ObtenerDatosClientePorCedula(string cedula)
        {
            return repositorioAlquiler.ObtenerDatosClientePorCedula(cedula);
        }

        public bool BuscarProductoPorCodigoBarra(string codigobarra)
        {
            return repositorioAlquiler.BuscarProductoPorCodigoBarra(codigobarra);
        }
        public DataTable ObtenerDatosProductosPorCodigoBarra(string CodigoBarra)
        {
            return repositorioAlquiler.ObtenerDatosProductosPorCodigoBarra(CodigoBarra);
        }
    }
}

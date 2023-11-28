using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class ServicioContactoDetalleVentas
    {
        RepositorioDetalleVentas repositorioDetalleVentas = new RepositorioDetalleVentas();
        public void AgregarDetalleVenta(CE_Detalle_Ventas detalle_Ventas)
        {
            repositorioDetalleVentas.AgregarDetalleVenta(detalle_Ventas);
        }

        public void AnularDetalleVenta(CE_Detalle_Ventas detalle_Ventas)
        {
            repositorioDetalleVentas.AnularDetalleVenta(detalle_Ventas);
        }

        public DataTable MostrarDetalleVenta(int Id_Venta)
        {
            return repositorioDetalleVentas.MostrarDetalleVenta(Id_Venta);
        }
    }
}

using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioContactoDetalleAlquiler
    {
        RepositorioDetalleAlquiler repositorioDetalleAlquiler = new RepositorioDetalleAlquiler();
        public void AgregarDetalleAlquiler(CE_Detalle_Alquiler detalle_Alquiler)
        {
            repositorioDetalleAlquiler.AgregarDetalleAlquiler(detalle_Alquiler);
        }

        public void AnularDetalleAlquiler(CE_Detalle_Alquiler detalle_Alquiler)
        {
            repositorioDetalleAlquiler.AnularDetalleAlquiler(detalle_Alquiler);
        }

        public DataTable MostrarDetalleAlquiler(int Id_Aqluiler)
        {
            return repositorioDetalleAlquiler.MostrarDetalleAlquiler(Id_Aqluiler);
        }
    }
}

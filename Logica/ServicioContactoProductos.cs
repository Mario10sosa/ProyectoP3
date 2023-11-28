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
    public class ServicioContactoProductos 
    {
        RepositorioProductos repositorioProductos = new RepositorioProductos();
        public void AgregarProducto(CE_Productos producto)
        {
            repositorioProductos.AgregarProducto(producto);
        }

        //Edita Un Producto en la base de datos

        public void EditarProducto(CE_Productos producto)
        {
           repositorioProductos.EditarProducto(producto);
        }

        //Eliminar Un Producto en la base de datos
        public void EliminarProducto(CE_Productos producto)
        {
            repositorioProductos.EliminarProducto(producto);
        }


        //Buscar Por nombre
        public DataTable Buscar_Producto_Nombre(CE_Productos producto)
        {
            return repositorioProductos.Buscar_Producto_Nombre(producto);

        }

        //Buscar Por codigo
        public DataTable Buscar_Producto_Codigo(CE_Productos producto)
        {
            return repositorioProductos.Buscar_Producto_Codigo(producto);

        }

        //Buscar Por codigoBarra
        public DataTable Buscar_Producto_CodigoBarra(CE_Productos producto)
        {
            return repositorioProductos.Buscar_Producto_CodigoBarra(producto);
        }

        public DataTable ObtenerProductosMasVendidos()
        {
            return repositorioProductos.ObtenerProductosMasVendidos();
        }
    }
}

using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioProductos 
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt;

        //Agregar producto a la Base De Datos
        public void AgregarProducto(CE_Productos producto)
        {
            Cmd = new SqlCommand("AgregarProducto", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", producto.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@CodigoBarra", producto.CodigoBarra));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", producto.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Descripcion", producto.Descripcion));
            Cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", producto.Costo_Unitario));
            Cmd.Parameters.Add(new SqlParameter("@Costo_Alquiler", producto.Costo_Alquiler));
            Cmd.Parameters.Add(new SqlParameter("@Stock", producto.Stock));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Edita Un Producto en la base de datos

        public void EditarProducto(CE_Productos producto)
        {
            Cmd = new SqlCommand("EditarProducto", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Codigo", producto.Codigo));
            Cmd.Parameters.Add(new SqlParameter("@CodigoBarra", producto.CodigoBarra));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", producto.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Descripcion", producto.Descripcion));
            Cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", producto.Costo_Unitario));
            Cmd.Parameters.Add(new SqlParameter("@Costo_Alquiler", producto.Costo_Alquiler));
            Cmd.Parameters.Add(new SqlParameter("@Stock", producto.Stock));
            Cmd.Parameters.Add(new SqlParameter("@Id_Producto", producto.Id_Producto));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Eliminar Un Producto en la base de datos
        public void EliminarProducto(CE_Productos producto)
        {
            Cmd = new SqlCommand("EliminarProducto", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Producto", producto.Id_Producto));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }


        //Buscar Por nombre
        public DataTable Buscar_Producto_Nombre(CE_Productos producto)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("Buscar_Producto_Nombre", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", producto.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

        //Buscar Por codigo
        public DataTable Buscar_Producto_Codigo(CE_Productos producto)
        {
            Dt = new DataTable("Codigo");
            Cmd = new SqlCommand("Buscar_Producto_Codigo", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", producto.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        //Buscar Por codigoBarra
        public DataTable Buscar_Producto_CodigoBarra(CE_Productos producto)
        {
            Dt = new DataTable("CodigoBarra");
            Cmd = new SqlCommand("Buscar_Producto_CodigoBarra", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", producto.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        public DataTable ObtenerProductosMasVendidos()
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand("ObtenerProductosmasvendido", Con.Abrir()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            Con.Cerrar();
            return dt;
        }

    }
}

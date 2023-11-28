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
    public class RepositorioEmpresa 
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;
        SqlDataAdapter Da;
        DataTable Dt;

        //Agregar empresa a la Base De Datos
        public void AgregarEmpresa(CE_Empresa empresa)
        {
            Cmd = new SqlCommand("AgregarEmpresa", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Nit", empresa.Nit));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", empresa.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", empresa.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", empresa.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Correo", empresa.Correo));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Edita Un Empresa en la base de datos

        public void EditarEmpresa(CE_Empresa empresa)
        {
            Cmd = new SqlCommand("EditarEmpresa", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Nit", empresa.Nit));
            Cmd.Parameters.Add(new SqlParameter("@Nombre", empresa.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Telefono", empresa.Telefono));
            Cmd.Parameters.Add(new SqlParameter("@Direccion", empresa.Direccion));
            Cmd.Parameters.Add(new SqlParameter("@Correo", empresa.Correo));
            Cmd.Parameters.Add(new SqlParameter("@Id_Empresa", empresa.Id_Empresa));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Eliminar Un Empresa en la base de datos
        public void EliminarEmpresa(CE_Empresa empresa)
        {
            Cmd = new SqlCommand("EliminarEmpresa", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Empresa", empresa.Id_Empresa));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }


        //Buscar Por Nombre
        public DataTable Buscar_Empresa_Nombre(CE_Empresa empresa)
        {
            Dt = new DataTable("Nombre");
            Cmd = new SqlCommand("Buscar_Empresa_Nombre", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", empresa.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

        //Buscar Por Nit
        public DataTable Buscar_Empresa_Nit(CE_Empresa empresa)
        {
            Dt = new DataTable("Nit");
            Cmd = new SqlCommand("Buscar_Empresa_Nit", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", empresa.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

    }
}

using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Caches;

namespace Datos
{
    public class RepositorioUsuarios 
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;
        SqlDataAdapter Da;
        SqlDataReader Dr;
        DataTable Dt;

        //Agregar Usuario a la base de datos
        public void AgregarUsuario(CE_Usuarios usuarios)
        {
            Cmd = new SqlCommand("SP_Agregar_Usuario", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Nombre", usuarios.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Apellidos", usuarios.Apellido));
            Cmd.Parameters.Add(new SqlParameter("@Usuario", usuarios.Usuario));
            Cmd.Parameters.Add(new SqlParameter("@Password", usuarios.Password));

            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Edita Un Usuario en la base de datos

        public void EditarUsuario(CE_Usuarios usuarios)
        {
            Cmd = new SqlCommand("SP_Editar_Usuario", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Nombre", usuarios.Nombre));
            Cmd.Parameters.Add(new SqlParameter("@Apellidos", usuarios.Apellido));
            Cmd.Parameters.Add(new SqlParameter("@Usuario", usuarios.Usuario));
            Cmd.Parameters.Add(new SqlParameter("@Password", usuarios.Password));
            Cmd.Parameters.Add(new SqlParameter("@Id_Usuario", usuarios.Id_Usuario));

            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Eliminar Un Usuario en la base de datos
        public void EliminarUsuario(CE_Usuarios usuarios)
        {
            Cmd = new SqlCommand("SP_Eliminar_Usuario", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Id_Usuario", usuarios.Id_Usuario));
            Cmd.ExecuteNonQuery();

            Con.Cerrar();
        }

        //Buscar Usuario
        public DataTable Buscar_Usuario(CE_Usuarios usuarios)
        {
            Dt = new DataTable("Usuario");
            Cmd = new SqlCommand("Buscar_Usuario", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Buscar", usuarios.Buscar));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;

        }

        // Acceder Al Sistema
        public DataTable LoginUsuario(CE_Usuarios usuarios)
        {
            Dt = new DataTable("Login Usuario");

            Cmd = new SqlCommand("SP_Login", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Usuario", usuarios.Usuario));
            Cmd.Parameters.Add(new SqlParameter("@Password", usuarios.Password));

            Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);

            Con.Cerrar();
            return Dt;
        }

        public void DatosUsuario(string Usuario)
        {
            DataTable Dt = new DataTable("Datos Usuarios");
            Cmd = new SqlCommand("SP_DatosUsuario", Con.Abrir());
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.Add(new SqlParameter("@Usuario", Usuario));
            Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                InformacionUsuario.Id_Usuario = Dr.GetInt32(0);
                InformacionUsuario.Nombre = Dr.GetString(1);
                InformacionUsuario.Apellido = Dr.GetString(2);
                InformacionUsuario.Usuario = Dr.GetString(3);
                InformacionUsuario.Password = Dr.GetString(4);
            }
            Dr.Close();
            Con.Cerrar();
        }
    }
}

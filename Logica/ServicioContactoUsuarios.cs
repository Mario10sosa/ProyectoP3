using Datos;
using Entidades;
using Entidades.Caches;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioContactoUsuarios 
    {
        RepositorioUsuarios repositorioUsuarios = new RepositorioUsuarios();
        public void AgregarUsuario(CE_Usuarios usuarios)
        {
           repositorioUsuarios.AgregarUsuario(usuarios);
        }

        //Edita Un Usuario en la base de datos

        public void EditarUsuario(CE_Usuarios usuarios)
        {
            repositorioUsuarios.EditarUsuario(usuarios);
        }

        //Eliminar Un Usuario en la base de datos
        public void EliminarUsuario(CE_Usuarios usuarios)
        {
            repositorioUsuarios.EliminarUsuario(usuarios);
        }

        //Buscar Usuario
        public DataTable Buscar_Usuario(CE_Usuarios usuarios)
        {
            return repositorioUsuarios.Buscar_Usuario(usuarios);

        }

        // Acceder Al Sistema
        public DataTable LoginUsuario(CE_Usuarios usuarios)
        {
            return repositorioUsuarios.LoginUsuario(usuarios);
        }

        public void DatosUsuario(string Usuario)
        {
            repositorioUsuarios.DatosUsuario(Usuario);
        }
    }
}

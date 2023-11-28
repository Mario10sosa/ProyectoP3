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
    public class ServicioContactoClientes
    {
        RepositorioClientes repositorioClientes = new RepositorioClientes();

        //agregar un cliente en la base de datos
        public void AgregarCliente(CE_Clientes clientes)
        {
            repositorioClientes.AgregarCliente(clientes);
        }
        // editar un cliente en la base de datos
        public void EditarCliente(CE_Clientes clientes)
        {
            repositorioClientes.EditarCliente(clientes);
        }

        //Eliminar Un Cliente en la base de datos
        public void EliminarCliente(CE_Clientes clientes)
        {
            repositorioClientes.EliminarCliente(clientes);
        }


        //Buscar Por Codigo
        public DataTable Buscar_Cliente_Id(CE_Clientes clientes)
        {
          
            return repositorioClientes.Buscar_Cliente_Id(clientes);
        }

        //Buscar Por Nombre
        public DataTable Buscar_Cliente_Nombre(CE_Clientes clientes)
        {
            return repositorioClientes.Buscar_Cliente_Nombre(clientes);
        }

        //Buscar Por Cedula
        public DataTable Buscar_Cliente_Cedula(CE_Clientes clientes)
        {
            return repositorioClientes.Buscar_Cliente_Cedula(clientes);
        }

    }
}

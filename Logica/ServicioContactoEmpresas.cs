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
    public class ServicioContactoEmpresas 
    {
        RepositorioEmpresa repositorioEmpresa = new RepositorioEmpresa();

        public void AgregarEmpresa(CE_Empresa empresa)
        {
            repositorioEmpresa.AgregarEmpresa(empresa);
        }

        //Edita Un Empresa en la base de datos

        public void EditarEmpresa(CE_Empresa empresa)
        {
            repositorioEmpresa.EditarEmpresa(empresa);
        }

        //Eliminar Un Empresa en la base de datos
        public void EliminarEmpresa(CE_Empresa empresa)
        {
            repositorioEmpresa.EliminarEmpresa(empresa);
        }

        //Buscar Por Nombre
        public DataTable Buscar_Empresa_Nombre(CE_Empresa empresa)
        {
            return repositorioEmpresa.Buscar_Empresa_Nombre(empresa);
        }

        //Buscar Por Nit
        public DataTable Buscar_Empresa_Nit(CE_Empresa empresa)
        {
           return repositorioEmpresa.Buscar_Empresa_Nit(empresa);
        }
    }
}

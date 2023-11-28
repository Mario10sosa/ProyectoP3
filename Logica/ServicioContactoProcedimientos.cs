using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class ServicioContactoProcedimientos
    {
        Procedimientos repositorioProcedimiento = new Procedimientos();
        //Cagar los datos de una tabla a un datagridview
        public DataTable CargarDatos(string Tabla)
        {
            return repositorioProcedimiento.CargarDatos(Tabla);
        }

        public void AlternarColorFilaDataGridView(DataGridView Dgv)
        {
            repositorioProcedimiento.AlternarColorFilaDataGridView(Dgv);
        }

        //GenerarCodigoId

        public string GenerarCodigoId(string Tabla)
        {
            return repositorioProcedimiento.GenerarCodigoId(Tabla);
        }

        public void FormatoMoneda(TextBox xTBox)
        {
            repositorioProcedimiento.FormatoMoneda(xTBox);
        }

        //Limpiar Caja de Control
        public void LimpiarControles(Form xForm)
        {
            repositorioProcedimiento.LimpiarControles(xForm);
        }

        public string GenerarCodigo(string Tabla)
        {
            return repositorioProcedimiento.GenerarCodigo(Tabla);
        }

        //LLenar Combo Box
        public void LlenarComboBox(string Tabla, string Nombre, ComboBox xCbox)
        {
            repositorioProcedimiento.LlenarComboBox(Tabla,Nombre,xCbox);
        }
    }
}

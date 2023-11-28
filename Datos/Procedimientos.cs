using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Datos
{
    public class Procedimientos
    {
        CD_Conexion Con = new CD_Conexion();

        SqlCommand Cmd;
        SqlDataReader Dr;
        DataTable Dt;

        //Cagar los datos de una tabla a un datagridview
        public DataTable CargarDatos(string Tabla)
        {
            Dt = new DataTable("Cargar_Datos");
            Cmd = new SqlCommand("Select * From " + Tabla, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();
            Dt.Load(Dr);
            Dr.Close();

            Con.Cerrar();
            return Dt;
        }

        public void AlternarColorFilaDataGridView(DataGridView Dgv)
        {
            Dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            Dgv.DefaultCellStyle.BackColor = Color.White;
        }

        //GenerarCodigoId

        public string GenerarCodigoId(string Tabla)
        {
            string Codigo = string.Empty;
            int Total = 0;
            Cmd = new SqlCommand("Select Count(*) as TotalRegistro From " + Tabla, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                Total = Convert.ToInt32(Dr["TotalRegistro"]) + 1;
            }
            Dr.Close();

            Codigo = Convert.ToString(Total);

            Con.Cerrar();
            return Codigo;
        }

        public void FormatoMoneda(TextBox xTBox)
        {
            if (xTBox.Text == string.Empty)
            {
                return;
            }
            else
            {
                decimal Monto;

                Monto = Convert.ToDecimal(xTBox.Text);
                xTBox.Text = Monto.ToString("N2");
            }
        }

        //Limpiar Caja de Control
        public void LimpiarControles(Form xForm)
        {
            foreach (var xCtrl in xForm.Controls)
            {
                if (xCtrl is TextBox)
                {
                    ((TextBox)xCtrl).Text = string.Empty;
                }
                else if (xCtrl is MaskedTextBox)
                {
                    ((MaskedTextBox)xCtrl).Text = string.Empty;
                }
            }
        }

        //generar codigo
        public string GenerarCodigo(string Tabla)
        {
            string Codigo = string.Empty;
            int Total = 0;
            Cmd = new SqlCommand("Select Count(*) as TotalRegistro From " + Tabla, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                Total = Convert.ToInt32(Dr["TotalRegistro"]) + 1;
            }
            Dr.Close();

            if (Total < 10)
            {
                Codigo = "0000000" + Total;
            }
            else if (Total < 100)
            {
                Codigo = "000000" + Total;
            }
            else if (Total < 1000)
            {
                Codigo = "00000" + Total;
            }
            else if (Total < 10000)
            {
                Codigo = "0000" + Total;
            }
            else if (Total < 100000)
            {
                Codigo = "000" + Total;
            }
            else if (Total < 1000000)
            {
                Codigo = "00" + Total;
            }
            else if (Total < 10000000)
            {
                Codigo = "0" + Total;
            }


            Con.Cerrar();
            return Codigo;
        }

        //LLenar Combo Box
        public void LlenarComboBox(string Tabla, string Nombre, ComboBox xCbox)
        {
            Cmd = new SqlCommand("Select * From " + Tabla, Con.Abrir());
            Cmd.CommandType = CommandType.Text;

            Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                xCbox.Items.Add(Dr[Nombre].ToString());
            }
        }
    }
}

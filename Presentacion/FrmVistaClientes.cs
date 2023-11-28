using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmVistaClientes : Form
    {
        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoClientes Clientes = new ServicioContactoClientes();
        CE_Clientes Cliente = new CE_Clientes();
        public FrmVistaClientes()
        {
            InitializeComponent();
            CboTipoBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FrmVistaClientes_Load(object sender, EventArgs e)
        {
            
            CargarGrilla();
            ConfiguracionGrilla();
        }

        private void ConfiguracionGrilla()
        {
            DtClientes.Columns[0].Visible = false;


            DtClientes.Columns[1].Width = 150;
            DtClientes.Columns[2].Width = 150;
            DtClientes.Columns[3].Width = 150;
            DtClientes.Columns[4].Width = 150;
            DtClientes.Columns[5].Width = 250;

            DtClientes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtClientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void CargarGrilla()
        {
            DtClientes.DataSource = Procedimientos.CargarDatos("Clientes");
            DtClientes.ClearSelection();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            try
            {
                if (CboTipoBusqueda.Text == "Id")
                {
                    Cliente.Buscar = TxtBuscarClientes.Text.Trim();
                    DtClientes.DataSource = Clientes.Buscar_Cliente_Id(Cliente);
                }
                else if (CboTipoBusqueda.Text == "Nombre")
                {
                    Cliente.Buscar = TxtBuscarClientes.Text.Trim();
                    DtClientes.DataSource = Clientes.Buscar_Cliente_Nombre(Cliente);
                }
                else if (CboTipoBusqueda.Text == "Cedula")
                {
                    Cliente.Buscar = TxtBuscarClientes.Text.Trim();
                    DtClientes.DataSource = Clientes.Buscar_Cliente_Cedula(Cliente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El cliente no fue encontrado por: " + ex.Message, "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DtClientes_DoubleClick(object sender, EventArgs e)
        {
            if (DtClientes.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}

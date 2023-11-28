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
    public partial class FrmClientes : Form
    {
        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoClientes Clientes = new ServicioContactoClientes();
        CE_Clientes Cliente = new CE_Clientes();
        public FrmClientes()
        {
            InitializeComponent();
            CBTipoBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            
            CargarGrilla();
            ConfigurarGrilla();
        }

        private void ConfigurarGrilla()
        {
            DtClientes.Columns[0].Visible = false;//id_Cliente
            DtClientes.Columns[1].Width = 150;//Cedula
            DtClientes.Columns[2].Width = 150;//Nombre
            DtClientes.Columns[3].Width = 150;//Apellido
            DtClientes.Columns[4].Width = 150;//Telefono
            DtClientes.Columns[5].Width = 250;//Direccion

            DtClientes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtClientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Procedimientos.AlternarColorFilaDataGridView(DtClientes);
        }
        void CargarGrilla()
        {
            DtClientes.DataSource = Procedimientos.CargarDatos("Clientes");
            DtClientes.ClearSelection();
        }

        public void AgClie_UpdateEventHandler(object sender, FrmAgregarCliente.UpdateEventArgs args)
        {
            CargarGrilla();
        }
       
        private void EdClie_UpdateEventHandler(object sender, FrmEditarClientes.UpdateEventArgs args)
        {
            CargarGrilla();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            AbrirFormularioAgregarCliente();
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            EditarCliente();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void AbrirFormularioAgregarCliente()
        {
            FrmAgregarCliente agregarClientes = new FrmAgregarCliente(this, null, null);
            agregarClientes.UpdateEventHandler += AgClie_UpdateEventHandler;
            agregarClientes.ShowDialog();
        }

        private void TxtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            try
            {
                if (CBTipoBusqueda.Text == "Id")
                {
                    Cliente.Buscar = TxtBuscarClientes.Text.Trim();
                    DtClientes.DataSource = Clientes.Buscar_Cliente_Id(Cliente);
                }
                else if (CBTipoBusqueda.Text == "Nombre")
                {
                    Cliente.Buscar = TxtBuscarClientes.Text.Trim();
                    DtClientes.DataSource = Clientes.Buscar_Cliente_Nombre(Cliente);
                }
                else if (CBTipoBusqueda.Text == "Cedula")
                {
                    Cliente.Buscar = TxtBuscarClientes.Text.Trim();
                    DtClientes.DataSource = Clientes.Buscar_Cliente_Cedula(Cliente);
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("El Cliente No Fue Encontrado Por: " + ex.Message, "Buscar Cliente", MessageBoxIcon.Exclamation);
            }
        }

        private void EditarCliente()
        {
            if (DtClientes.Rows.Count == 0)
            {
                MostrarMensaje("No Hay Registro Para Editar", "Editar Clientes", MessageBoxIcon.Exclamation);
            }
            else
            {
                if (DtClientes.SelectedRows == null)
                {
                    return;
                }
                else
                {
                    try
                    {
                        FrmEditarClientes EditarClientes = new FrmEditarClientes(this);
                        EditarClientes.UpdateEventHandler += EdClie_UpdateEventHandler;
                        LlenarDatosEditarCliente(EditarClientes);
                        EditarClientes.ShowDialog();
                    }
                    catch (Exception)
                    {
                        MostrarMensaje("Debe Seleccionar Un Registro Por Favor", "Editar Cliente", MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void LlenarDatosEditarCliente(FrmEditarClientes editarClientes)
        {
            editarClientes.TxtIdCliente.Text = DtClientes.SelectedRows[0].Cells[0].Value.ToString();
            editarClientes.TxtCedulaCliente.Text = DtClientes.SelectedRows[0].Cells[1].Value.ToString();
            editarClientes.TxtNombreCliente.Text = DtClientes.SelectedRows[0].Cells[2].Value.ToString();
            editarClientes.TxtApellidoCliente.Text = DtClientes.SelectedRows[0].Cells[3].Value.ToString();
            editarClientes.MTxtTelefonoCliente.Text = DtClientes.SelectedRows[0].Cells[4].Value.ToString();
            editarClientes.TxtDireccionCliente.Text = DtClientes.SelectedRows[0].Cells[5].Value.ToString();
        }
        private void Eliminar()
        {
            if (DtClientes.Rows.Count == 0)
            {
                MostrarMensaje("No hay registro para Eliminar", "Eliminar Clientes", MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (DtClientes.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult Resultados = MessageBox.Show("¿Esta seguro que desea eliminar este Cliente?", "Eliminar Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Cliente.Id_Cliente = Convert.ToInt32(DtClientes.SelectedRows[0].Cells[0].Value.ToString());
                            Clientes.EliminarCliente(Cliente);
                            CargarGrilla();
                        }
                    }

                }
                catch (Exception)
                {
                    MostrarMensaje("Debe Seleccionar un registro para Eliminar", "Eliminar Clientes", MessageBoxIcon.Exclamation);

                }
            }
        }

        private void MostrarMensaje(string mensaje, string titulo, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }

    }
}

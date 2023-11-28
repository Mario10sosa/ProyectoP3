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
    public partial class FrmEmpresas : Form
    {
        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoEmpresas Empresas = new ServicioContactoEmpresas();
        CE_Empresa Empresa = new CE_Empresa();

        public FrmEmpresas()
        {
            InitializeComponent();
            CBTipoBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FrmEmpresas_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ConfigurarGrilla();

        }
        private void ConfigurarGrilla()
        {
            DtEmpresas.Columns[0].Visible = false;
            DtEmpresas.Columns[1].Width = 130;
            DtEmpresas.Columns[2].Width = 130;
            DtEmpresas.Columns[3].Width = 130;
            DtEmpresas.Columns[4].Width = 130;
            DtEmpresas.Columns[5].Width = 250;

            DtEmpresas.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtEmpresas.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Procedimientos.AlternarColorFilaDataGridView(DtEmpresas);
        }

        void CargarGrilla()
        {
            DtEmpresas.DataSource = Procedimientos.CargarDatos("Empresas");
            DtEmpresas.ClearSelection();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgEmpresa_UpdateEventHandler(object sender, FrmAgregarEmpresa.UpdateEventArgs args)
        {
            CargarGrilla();
        }

        private void EdEmpresa_UpdateEventHandler(object sender, FrmEditarEmpresa.UpdateEventArgs args)
        {
            CargarGrilla();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            AbrirFormularioAgregarEmpresa();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditarEmpresa();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void TxtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void AbrirFormularioAgregarEmpresa()
        {
            FrmAgregarEmpresa agregarEmpresa = new FrmAgregarEmpresa(this);
            agregarEmpresa.UpdateEventHandler += AgEmpresa_UpdateEventHandler;
            agregarEmpresa.ShowDialog();
        }

        public void Buscar()
        { 
            try
            {
                if (CBTipoBusqueda.Text == "Nombre")
                {
                    Empresa.Buscar = TxtBuscarClientes.Text.Trim();
                    DtEmpresas.DataSource = Empresas.Buscar_Empresa_Nombre(Empresa);
                }
                else if (CBTipoBusqueda.Text == "Nit")
                {
                    Empresa.Buscar = TxtBuscarClientes.Text.Trim();
                    DtEmpresas.DataSource = Empresas.Buscar_Empresa_Nit(Empresa);
                }

            }
            catch (Exception ex)
            {
                MostrarMensaje("La Empresa No Fue Encontrada Por: " + ex.Message, "Buscar Empresa", MessageBoxIcon.Exclamation);
            }
        }

        private void EditarEmpresa()
        {
            if (DtEmpresas.Rows.Count == 0)
            {
                MostrarMensaje("No Hay Registro Para Editar", "Editar Empresa", MessageBoxIcon.Exclamation);
            }
            else
            {
                if (DtEmpresas.SelectedRows == null)
                {
                    return;
                }
                else
                {
                    try
                    {
                        FrmEditarEmpresa EditarEmpresa = new FrmEditarEmpresa(this);
                        EditarEmpresa.UpdateEventHandler += EdEmpresa_UpdateEventHandler;
                        LlenarDatosEditarEmpresa(EditarEmpresa);
                        EditarEmpresa.ShowDialog();
                    }
                    catch (Exception)
                    {
                        MostrarMensaje("Debe Seleccionar Un Registro Por Favor", "Editar Empresa", MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void LlenarDatosEditarEmpresa(FrmEditarEmpresa editarEmpresa)
        {
            editarEmpresa.TxtIdEmpresa.Text = DtEmpresas.SelectedRows[0].Cells[0].Value.ToString();
            editarEmpresa.TxtNombreEmpresa.Text = DtEmpresas.SelectedRows[0].Cells[1].Value.ToString();
            editarEmpresa.TxtNitEmpresa.Text = DtEmpresas.SelectedRows[0].Cells[2].Value.ToString();
            editarEmpresa.TxtDireccionEmpresa.Text = DtEmpresas.SelectedRows[0].Cells[3].Value.ToString();
            editarEmpresa.MTxtTelefonoEmpresa.Text = DtEmpresas.SelectedRows[0].Cells[4].Value.ToString();
            editarEmpresa.TxtCorreoEmpresa.Text = DtEmpresas.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Eliminar()
        {
            if (DtEmpresas.Rows.Count == 0)
            {
                MostrarMensaje("No hay registro Para Eliminar", "Eliminar Empresa", MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (DtEmpresas.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult Resultados = MessageBox.Show("¿Esta Seguro Que Desea Eliminar Esta Empresa?", "Eliminar Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Empresa.Id_Empresa = Convert.ToInt32(DtEmpresas.SelectedRows[0].Cells[0].Value.ToString());
                            Empresas.EliminarEmpresa(Empresa);
                            CargarGrilla();
                        }
                    }

                }
                catch (Exception)
                {
                    MostrarMensaje("Debe Seleccionar Un Registro Para Eliminar", "Eliminar Empresa",MessageBoxIcon.Exclamation);

                }
            }

        }

        private void MostrarMensaje(string mensaje, string titulo, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }

    }
}

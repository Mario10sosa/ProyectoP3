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
    public partial class FrmUsuarios : Form
    {
        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoUsuarios Usuarios = new ServicioContactoUsuarios();
        CE_Usuarios Usuario = new CE_Usuarios();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ConfigurarGrilla();
        }
        private void ConfigurarGrilla()
        {
            DtUsuario.Columns[0].Visible = false;
            DtUsuario.Columns[4].Visible = false;
            Procedimientos.AlternarColorFilaDataGridView(DtUsuario);
        }
        void CargarGrilla()
        {
            DtUsuario.DataSource = Procedimientos.CargarDatos("Usuarios");
            DtUsuario.ClearSelection();
        }
        private void AgUsua_UpdateEventHandler(object sender, FrmAgregarUsuario.UpdateEventArgs args)
        {
            CargarGrilla();
        }
        private void EdUsa_UpdateEventHandler(object sender, FrmEditarUsuario.UpdateEventArgs args)
        {
            CargarGrilla();
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            AbrirFormularioAgregarUsuario();
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditarUsuario();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void AbrirFormularioAgregarUsuario()
        {
            FrmAgregarUsuario agregarUsuario = new FrmAgregarUsuario(this);
            agregarUsuario.UpdateEventHandler += AgUsua_UpdateEventHandler;
            agregarUsuario.ShowDialog();
        }
        private void EditarUsuario()
        {
            if (DtUsuario.Rows.Count == 0)
            {
                MostrarMensaje("No Hay Registro Para Editar", "Editar Usuario", MessageBoxIcon.Exclamation);
            }
            else
            {
                if (DtUsuario.SelectedRows == null)
                {
                    return;
                }
                else
                {
                    try
                    {
                        FrmEditarUsuario editarUsuario = new FrmEditarUsuario(this);
                        editarUsuario.UpdateEventHandler += EdUsa_UpdateEventHandler;
                        LlenarDatosEditarUsuario(editarUsuario);
                        editarUsuario.ShowDialog();
                    }
                    catch (Exception)
                    {
                        MostrarMensaje("No Ha Seleccionado Un Usuario Para Editar", "Editar Usuario", MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void LlenarDatosEditarUsuario(FrmEditarUsuario editarUsuario)
        {
            editarUsuario.TxtId_Usuario.Text = DtUsuario.SelectedRows[0].Cells[0].Value.ToString();
            editarUsuario.TxtNombre.Text = DtUsuario.SelectedRows[0].Cells[1].Value.ToString();
            editarUsuario.TxtApellido.Text = DtUsuario.SelectedRows[0].Cells[2].Value.ToString();
            editarUsuario.TxtUsuario.Text = DtUsuario.SelectedRows[0].Cells[3].Value.ToString();
            editarUsuario.TxtContra.Text = DtUsuario.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void Eliminar()
        {
            if (DtUsuario.Rows.Count == 0)
            {
                MostrarMensaje("No hay registro para Eliminar", "Eliminar Usuario", MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (DtUsuario.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult Resultados = MessageBox.Show("¿Esta seguro que desea eliminar este Usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Usuario.Id_Usuario = Convert.ToInt32(DtUsuario.SelectedRows[0].Cells[0].Value.ToString());
                            Usuarios.EliminarUsuario(Usuario);
                            CargarGrilla();
                        }
                    }
                }
                catch (Exception)
                {
                    MostrarMensaje("Debe Seleccionar Un Registro Para Eliminar", "Eliminar Usuario", MessageBoxIcon.Exclamation);
                }
            }

        }
        private void MostrarMensaje(string mensaje, string titulo, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }
    }
}

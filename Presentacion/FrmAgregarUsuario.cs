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
    public partial class FrmAgregarUsuario : Form
    {
        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoUsuarios Usuarios = new ServicioContactoUsuarios();
        CE_Usuarios Usuario = new CE_Usuarios();

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public FrmAgregarUsuario(FrmUsuarios Usuarios)
        {
            InitializeComponent();
            Restrinccion();
        }

        private void Restrinccion()
        {
            TxtNombre.KeyPress += TextBoxEnterKeyPress;
            TxtApellido.KeyPress += TextBoxEnterKeyPress;
            TxtUsuario.KeyPress += TextBoxEnterKeyPress;
            TxtContra.KeyPress += TextBoxEnterKeyPress;
            TxtConfirmar.KeyPress += TextBoxEnterKeyPress;
        }

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void AgregarGrilla()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private bool Guardar()
        {
            try
            {
                if (CamposUsuarioIncompletos())
                {
                    MostrarMensaje("Por Favor Debe Completar Todos Los Datos", "Crear Usuario", MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (TxtContra.Text != TxtConfirmar.Text)
                    {
                        MostrarMensaje("Las Contraseñas No Coinciden", "Crear Usuario", MessageBoxIcon.Error);
                        TxtConfirmar.Focus();
                    }
                    else
                    {
                        DatosUsuario();
                        Usuarios.AgregarUsuario(Usuario);
                        MostrarMensaje("El Usuario Fue Agregado Correctamente", "Crear Usuario", MessageBoxIcon.Information);
                        LimpiarCampos();
                        TxtNombre.Focus();
                        AgregarGrilla();
                        return true;

                    }
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("El Usuario No Fue Agregado Por: " + ex.Message, "Crear Usuario", MessageBoxIcon.Error);
            }
            return false;
        }

        private bool CamposUsuarioIncompletos()
        {
            return string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                   string.IsNullOrWhiteSpace(TxtApellido.Text) ||
                   string.IsNullOrWhiteSpace(TxtUsuario.Text) ||
                   string.IsNullOrWhiteSpace(TxtContra.Text);
        }

        private void DatosUsuario()
        {
            Usuario.Nombre = TxtNombre.Text.Trim();
            Usuario.Apellido = TxtApellido.Text.Trim();
            Usuario.Usuario = TxtUsuario.Text.Trim();
            Usuario.Password = TxtContra.Text.Trim();
        }

        private void LimpiarCampos()
        {
            Procedimientos.LimpiarControles(this);
        }

        private void TextBoxEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CambiarFocoSegunTextBox((TextBox)sender);
                e.Handled = true;
            }
        }

        private void CambiarFocoSegunTextBox(TextBox textBox)
        {
            switch (textBox.Name)
            {
                case "TxtNombre":
                    TxtApellido.Focus();
                    break;
                case "TxtApellido":
                    TxtUsuario.Focus();
                    break;
                case "TxtUsuario":
                    TxtContra.Focus();
                    break;
                case "TxtContra":
                    TxtConfirmar.Focus();
                    break;
                case "TxtConfirmar":
                    BtnAgregar.Focus();
                    break;
            }
        }

        private void MostrarMensaje(string mensaje, string titulo, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }

    }
}

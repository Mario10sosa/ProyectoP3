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
    public partial class FrmEditarUsuario : Form
    {
        ServicioContactoUsuarios Usuarios = new ServicioContactoUsuarios();
        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        CE_Usuarios Usuario = new CE_Usuarios();

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public FrmEditarUsuario(FrmUsuarios usuario)
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

        protected void Actualizar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        private void FrmEdiatrUsuario_Load(object sender, EventArgs e)
        {
            TxtConfirmar.Text = TxtContra.Text;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditarUsuario();
        }

        public void EditarUsuario()
        {
            try
            {
                if (CamposUsuarioIncompletos())
                {
                    MostrarMensaje("Por Favor Debe completar todos los campos", "Editar Usuario", MessageBoxIcon.Exclamation);
                }
                else if (!ConfirmacionContrasenaCorrecta())
                {
                    MostrarMensaje("Las contraseñas no coinciden", "Editar Usuario", MessageBoxIcon.Error);
                    TxtConfirmar.Focus();
                }
                else
                {
                    ActualizarDatosUsuario();
                    Usuarios.EditarUsuario(Usuario);
                    MostrarMensaje("El Usuario fue Editado Correctamente", "Editar Usuario", MessageBoxIcon.Information);
                    CerrarVentana();
                    Actualizar();
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("El Usuario No Fue Editado Por: " + ex.Message, "Editar Usuario", MessageBoxIcon.Error);
            }
        }

        private bool CamposUsuarioIncompletos()
        {
            return string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                   string.IsNullOrWhiteSpace(TxtApellido.Text) ||
                   string.IsNullOrWhiteSpace(TxtUsuario.Text) ||
                   string.IsNullOrWhiteSpace(TxtContra.Text);
        }

        private bool ConfirmacionContrasenaCorrecta()
        {
            return TxtContra.Text == TxtConfirmar.Text;
        }

        private void ActualizarDatosUsuario()
        {
            Usuario.Id_Usuario = Convert.ToInt32(TxtId_Usuario.Text.Trim());
            Usuario.Nombre = TxtNombre.Text.Trim();
            Usuario.Apellido = TxtApellido.Text.Trim();
            Usuario.Usuario = TxtUsuario.Text.Trim();
            Usuario.Password = TxtContra.Text.Trim();
        }

        private void CerrarVentana()
        {
            this.Close();
        }

        private void MostrarMensaje(string mensaje, string titulo, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
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
                    BtnEditar.Focus();
                    break;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FrmEditarEmpresa : Form
    {
        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoEmpresas empresas = new ServicioContactoEmpresas();
        CE_Empresa empresa = new CE_Empresa();
        public FrmEditarEmpresa(FrmEmpresas empresas)
        {
            InitializeComponent();
            Restrinccion();
        }

        private void Restrinccion()
        {
            TxtNombreEmpresa.KeyPress += TextBox_KeyPress;
            TxtCorreoEmpresa.KeyPress += TextBox_KeyPress;
            TxtNitEmpresa.KeyPress += TextBox_KeyPress;
            TxtDireccionEmpresa.KeyPress += TextBox_KeyPress;
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Actualizar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditarEmpresa();
        }

        public void EditarEmpresa()
        {
            try
            {
                if (CamposEmpresaIncompletos())
                {
                    MostrarMensaje("Por Favor Debe completar todos los campos", "Editar Empresa", MessageBoxIcon.Exclamation);
                }
                else
                {
                    ActualizarDatosEmpresa();
                    empresas.EditarEmpresa(empresa);
                    MostrarMensaje("La Empresa fue Editada correctamente", "Editar Empresa", MessageBoxIcon.Information);
                    LimpiarYCerrarVentana();
                    Actualizar();
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("La Empresa No Fue Editada Por: " + ex.Message, "Editar Empresa", MessageBoxIcon.Error);
            }
        }

        private bool CamposEmpresaIncompletos()
        {
            return string.IsNullOrWhiteSpace(TxtNombreEmpresa.Text) ||
                   string.IsNullOrWhiteSpace(TxtNitEmpresa.Text) ||
                   string.IsNullOrWhiteSpace(TxtDireccionEmpresa.Text) ||
                   string.IsNullOrWhiteSpace(MTxtTelefonoEmpresa.Text) ||
                   string.IsNullOrWhiteSpace(TxtCorreoEmpresa.Text);
        }

        private void ActualizarDatosEmpresa()
        {
            empresa.Id_Empresa = Convert.ToInt32(TxtIdEmpresa.Text);
            empresa.Nombre = TxtNombreEmpresa.Text.Trim();
            empresa.Nit = TxtNitEmpresa.Text.Trim();
            empresa.Direccion = TxtDireccionEmpresa.Text.Trim();
            empresa.Telefono = MTxtTelefonoEmpresa.Text.Trim();
            empresa.Correo = TxtCorreoEmpresa.Text.Trim();
        }

        private void LimpiarYCerrarVentana()
        {
            Procedimientos.LimpiarControles(this);
            this.Close();
        }

        private void MostrarMensaje(string mensaje, string titulo,MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (RestringirCaracteres(textBox, e))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CambiarFocoSegunTextBox(textBox);
                e.Handled = true;
            }
        }

        private bool RestringirCaracteres(TextBox textBox, KeyPressEventArgs e)
        {
            if ((textBox == TxtNitEmpresa) &&
                ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)))
            {
                return true;
            }

            if ((textBox == TxtNombreEmpresa) &&
                ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255)))
            {
                return true;
            }

            return false;
        }

        private void CambiarFocoSegunTextBox(TextBox textBox)
        {
            switch (textBox.Name)
            {
                case "TxtNombreEmpresa":
                    TxtCorreoEmpresa.Focus();
                    break;
                case "TxtCorreoEmpresa":
                    TxtNitEmpresa.Focus();
                    break;
                case "TxtNitEmpresa":
                    TxtDireccionEmpresa.Focus();
                    break;
                case "TxtDireccionEmpresa":
                    MTxtTelefonoEmpresa.Focus();
                    break;
            }
        }
        
        private void MTxtTelefonoEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnEditar.Focus();
                e.Handled = true;
            }
        }
    }
}

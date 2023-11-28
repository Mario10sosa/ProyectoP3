using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace Presentacion
{
    public partial class FrmEditarClientes : Form
    {
        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoClientes Clientes = new ServicioContactoClientes();
        CE_Clientes Cliente = new CE_Clientes();

        public FrmEditarClientes(FrmClientes clientes)
        {
            InitializeComponent();
            Restrinccion();
        }

        private void Restrinccion()
        {
            TxtNombreCliente.KeyPress += TextBox_KeyPress;
            TxtApellidoCliente.KeyPress += TextBox_KeyPress;
            TxtCedulaCliente.KeyPress += TextBox_KeyPress;
            TxtDireccionCliente.KeyPress += TextBox_KeyPress;
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void ActualizarGrilla()
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
            EditarCliente();
        }

        public void EditarCliente()
        {
            try
            {
                if (CamposClienteIncompletos())
                {
                    MostrarMensaje("Por Favor Debe completar todos los campos", "Editar Cliente", MessageBoxIcon.Exclamation);
                }
                else
                {
                    ActualizarDatosCliente();
                    Clientes.EditarCliente(Cliente);
                    MostrarMensaje("El Cliente fue Editado correctamente", "Editar Cliente", MessageBoxIcon.Information);
                    LimpiarYCerrarVentana();
                    ActualizarGrilla();
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("El Cliente No Fue Editado Por: " + ex.Message, "Editar Cliente", MessageBoxIcon.Error);
            }
        }

        private bool CamposClienteIncompletos()
        {
            return string.IsNullOrWhiteSpace(TxtNombreCliente.Text) ||
                   string.IsNullOrWhiteSpace(TxtCedulaCliente.Text) ||
                   string.IsNullOrWhiteSpace(TxtDireccionCliente.Text) ||
                   string.IsNullOrWhiteSpace(MTxtTelefonoCliente.Text) ||
                   string.IsNullOrWhiteSpace(TxtApellidoCliente.Text);
        }

        private void ActualizarDatosCliente()
        {
            Cliente.Id_Cliente = Convert.ToInt32(TxtIdCliente.Text.Trim());
            Cliente.Cedula = TxtCedulaCliente.Text.Trim();
            Cliente.Nombre = TxtNombreCliente.Text.Trim();
            Cliente.Apellido = TxtApellidoCliente.Text.Trim();
            Cliente.Telefono = MTxtTelefonoCliente.Text.Trim();
            Cliente.Direccion = TxtDireccionCliente.Text.Trim();
        }

        private void LimpiarYCerrarVentana()
        {
            Procedimientos.LimpiarControles(this);
            this.Close();
        }

        private void MostrarMensaje(string mensaje, string titulo, MessageBoxIcon icono)
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
            if ((textBox == TxtCedulaCliente) &&
                ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)))
            {
                return true;
            }

            if ((textBox == TxtNombreCliente || textBox == TxtApellidoCliente) &&
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
                case "TxtNombreCliente":
                    TxtApellidoCliente.Focus();
                    break;
                case "TxtApellidoCliente":
                    TxtCedulaCliente.Focus();
                    break;
                case "TxtCedulaCliente":
                    TxtDireccionCliente.Focus();
                    break;
                case "TxtDireccionCliente":
                    MTxtTelefonoCliente.Focus();
                    break;
            }
        }

        private void MTxtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
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

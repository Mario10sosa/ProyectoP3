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
    public partial class FrmAgregarProducto : Form
    {
        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoProductos Productos = new ServicioContactoProductos();
        CE_Productos producto = new CE_Productos();

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        public FrmAgregarProducto(FrmProductos productoss)
        {
            InitializeComponent();
            Restrinccion();
        }

        private void Restrinccion()
        {
            TxtNombreProducto.KeyPress += TextBox_KeyPress;
            TxtCodigoBarra.KeyPress += TextBox_KeyPress; 
            TxtDescripcionProducto.KeyPress += TextBox_KeyPress;
            TxtPrecioVentaProducto.KeyPress += TextBox_KeyPress;
            TxtPrecioAlquilerProducto.KeyPress += TextBox_KeyPress;
            TxtStock.KeyPress += TextBox_KeyPress;
        }
        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            Generarcodigo();
        }
      
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void CargarGrilla()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void Generarcodigo()
        {
            TxtCodigoProducto.Text = Procedimientos.GenerarCodigo("Productos");
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
                if (CamposProductoIncompletos())
                {
                    MostrarMensaje("Por Favor Debe completar todos los campos", "Agregar Producto", MessageBoxIcon.Exclamation);
                }
                else
                {
                    DatosProducto();
                    Productos.AgregarProducto(producto);
                    MostrarMensaje("El Producto fue agregado correctamente", "Agregar Producto", MessageBoxIcon.Information);
                    LimpiarFormulario();
                    Generarcodigo();
                    TxtCodigoBarra.Focus();
                    CargarGrilla();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("El Producto no fue agregado por: " + ex.Message, "Agregar Producto", MessageBoxIcon.Error);
            }
            return false;
        }

        private bool CamposProductoIncompletos()
        {
            return string.IsNullOrWhiteSpace(TxtCodigoProducto.Text) ||
                   string.IsNullOrWhiteSpace(TxtCodigoBarra.Text) ||
                   string.IsNullOrWhiteSpace(TxtNombreProducto.Text) ||
                   string.IsNullOrWhiteSpace(TxtPrecioVentaProducto.Text) ||
                   string.IsNullOrWhiteSpace(TxtDescripcionProducto.Text) ||
                   string.IsNullOrWhiteSpace(TxtStock.Text) ||
                   string.IsNullOrWhiteSpace(TxtPrecioAlquilerProducto.Text);
        }

        private void DatosProducto()
        {
            producto.Codigo = TxtCodigoProducto.Text;
            producto.CodigoBarra = TxtCodigoBarra.Text.Trim();
            producto.Nombre = TxtNombreProducto.Text.Trim();
            producto.Descripcion = TxtDescripcionProducto.Text.Trim();
            producto.Costo_Unitario = Convert.ToDecimal(TxtPrecioVentaProducto.Text.Trim());
            producto.Costo_Alquiler = Convert.ToDecimal(TxtPrecioAlquilerProducto.Text.Trim());
            producto.Stock = Convert.ToInt32(TxtStock.Text.Trim());
        }

        private void LimpiarFormulario()
        {
            Procedimientos.LimpiarControles(this);
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
            if ((textBox == TxtPrecioAlquilerProducto || textBox == TxtPrecioAlquilerProducto || textBox == TxtStock || textBox == TxtCodigoBarra) &&
                ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)))
            {
                return true;
            }

            if ((textBox == TxtNombreProducto || textBox == TxtDescripcionProducto) &&
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
                case "TxtCodigoBarra":
                    TxtNombreProducto.Focus();
                    break;
                case "TxtNombreProducto":
                    TxtDescripcionProducto.Focus();
                    break;
                case "TxtDescripcionProducto":
                    TxtPrecioVentaProducto.Focus();
                    break;
                case "TxtPrecioVentaProducto":
                    TxtPrecioAlquilerProducto.Focus();
                    break;
                case "TxtPrecioAlquilerProducto":
                    TxtStock.Focus();
                    break;
                case "TxtStock":
                    BtnAgregar.Focus();
                    break;
            }
        }
        
    }
}

using Entidades;
using Logica;
using System;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public partial class FrmAgregarVenta : Form
    {
        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoVentas Ventas = new ServicioContactoVentas();
        ServicioContactoDetalleVentas DetalleVentas = new ServicioContactoDetalleVentas();

        CE_Ventas Venta = new CE_Ventas();
        CE_Detalle_Ventas DetalleVenta = new CE_Detalle_Ventas();

        public FrmAgregarVenta(FrmVentas ventas)
        {
            InitializeComponent();
            CboMetodoP.DropDownStyle = ComboBoxStyle.DropDownList;
            Restrinciones();
        }

        DateTime UltimoDia = new DateTime(DateTime.Now.Year, 12, 31);

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public static int ContFila = 0;
        public static decimal Total1 = 0, Total2 = 0, Total5 = 0;
        public static double Importe1 = 0, ImporteNeto = 0,Monto_total = 0;

        public void AgClie_UpdateEventHandler(object sender, FrmAgregarCliente.UpdateEventArgs args)
        {

        }

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        private void Restrinciones()
        {
            TxtCedula.KeyPress += TextBox_KeyPress;
            TxtCodigoBarra.KeyPress += TextBox_KeyPress;
            TxtCantidad.KeyPress += TextBox_KeyPress;
        }
        protected void CargarGrilla()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void FrmAgregarVenta_Load(object sender, EventArgs e)
        {
            GenerarCorrelativo();
            LlenarComboBox();
            DtpFechaValidez.Text = Convert.ToString(UltimoDia);
            MejorVista();
        }
        private void GenerarCorrelativo()
        {
            TxtNoFactura.Text = "FACT" + Procedimientos.GenerarCodigo("Ventas");
            TxtIdVenta.Text = Procedimientos.GenerarCodigoId("Ventas");
        }

        private void LlenarComboBox()
        {
            CboMetodoP.DataSource = Procedimientos.CargarDatos("Metodo_Pago");
            CboMetodoP.ValueMember = "Id_Metodo_Pago";
            CboMetodoP.DisplayMember = "Nombre_Metodo";
        }

        private void MejorVista()
        {
            DtDetalleVentas.Columns[0].Visible = false;// id Producto

            DtDetalleVentas.Columns[1].Width = 245;//codigo barra
            DtDetalleVentas.Columns[2].Width = 300;//nombre
            DtDetalleVentas.Columns[3].Width = 240;//cantidad
            DtDetalleVentas.Columns[4].Width = 245;//precio venta
            DtDetalleVentas.Columns[5].Width = 245;//importe
            DtDetalleVentas.Columns[6].Width = 245;//total

            Formato();
        }

        private void Formato()
        {
            DtDetalleVentas.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtDetalleVentas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtDetalleVentas.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtDetalleVentas.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtDetalleVentas.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            Procedimientos.AlternarColorFilaDataGridView(DtDetalleVentas);
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmVistaClientes vistaClientes = new FrmVistaClientes();
            vistaClientes.ShowDialog();

            try
            {
                if (vistaClientes.DialogResult == DialogResult.OK)
                {
                    LlenarTextBoxClienteDesdeVistaClientes(vistaClientes);
                }
            }
            catch (Exception)
            {
                MostrarMensaje("Debe Seleccionar Un Cliente En La Lista", "Seleccionar Cliente", MessageBoxIcon.Information);
            }
        }

        private void TxTCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarCliente(TxtCedula.Text);

            }

        }

        private void TxtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarProducto(TxtCodigoBarra.Text);

            }

        }

        void BuscarCliente(string cedulaABuscar)
        {
            bool clienteRegistrado = Ventas.BuscarClientePorCedula(cedulaABuscar);

            if (clienteRegistrado)
            {
         
                DataTable clienteEncontrado = Ventas.ObtenerDatosClientePorCedula(cedulaABuscar);

                if (clienteEncontrado.Rows.Count > 0)
                {
                    LlenarTextBoxCliente(clienteEncontrado);
                }
            }
            else
            {
                MostrarMensaje("El cliente no está registrado.", "Buscar Cliente", MessageBoxIcon.Information);
                AgregarNuevoCliente();
                TxtCedula.Focus();
            }
        }
        private void LlenarTextBoxCliente(DataTable clienteEncontrado)
        {
            string cedulaCliente = clienteEncontrado.Rows[0]["Cedula"].ToString();
            string nombreCliente = clienteEncontrado.Rows[0]["Nombre"].ToString();
            string apellidoCliente = clienteEncontrado.Rows[0]["Apellido"].ToString();
            string idCliente = clienteEncontrado.Rows[0]["Id_Cliente"].ToString();

            // Llena los TextBox con los datos obtenidos
            TxtCedula.Text = cedulaCliente;
            TxtNombreCliente.Text = nombreCliente;
            TxtApellidoCliente.Text = apellidoCliente;
            TxtIdCliente.Text = idCliente;
        }

        void BuscarProducto(string CodigoBarra)
        {
            bool ProductoRegistrado = Ventas.BuscarProductoPorCodigoBarra(CodigoBarra);

            if (ProductoRegistrado)
            {

                DataTable ProductoEncontrado = Ventas.ObtenerDatosProductosPorCodigoBarra(CodigoBarra);

                if (ProductoEncontrado.Rows.Count > 0)
                {
                    LlenarTextBoxProductos(ProductoEncontrado);
                }
            }
            else
            {
                MostrarMensaje("El Producto No Está Registrado.", "Buscar Producto", MessageBoxIcon.Information);
                TxtCodigoBarra.Focus();
            }
        }

        private void LlenarTextBoxProductos(DataTable productoEncontrado)
        {
            string codigo = productoEncontrado.Rows[0]["Codigo"].ToString();
            string codigobarra = productoEncontrado.Rows[0]["CodigoBarra"].ToString();
            string nombreproducto = productoEncontrado.Rows[0]["Nombre"].ToString();
            string stock = productoEncontrado.Rows[0]["Stock"].ToString();
            string precioventa = productoEncontrado.Rows[0]["Costo_Unitario"].ToString();
            string id_producto = productoEncontrado.Rows[0]["Id_Producto"].ToString();

            // Llena los TextBox con los datos obtenidos
            TxtCodigoProducto.Text = codigo;
            TxtCodigoBarra.Text = codigobarra;
            TxtNombreProducto.Text = nombreproducto;
            TxtStockActual.Text = stock;
            TxtPrecioVenta.Text = precioventa;
            TxtIdProducto.Text = id_producto;
        }

        private void AgregarNuevoCliente()
        {
            FrmAgregarCliente agregarCliente = new FrmAgregarCliente(null, this, null);
            agregarCliente.UpdateEventHandler += AgClie_UpdateEventHandler;
            agregarCliente.ShowDialog();
        }

        private void LlenarTextBoxClienteDesdeVistaClientes(FrmVistaClientes vistaClientes)
        {
            TxtIdCliente.Text = vistaClientes.DtClientes.Rows[vistaClientes.DtClientes.CurrentRow.Index].Cells[0].Value.ToString();
            TxtCedula.Text = vistaClientes.DtClientes.Rows[vistaClientes.DtClientes.CurrentRow.Index].Cells[1].Value.ToString();
            TxtNombreCliente.Text = vistaClientes.DtClientes.Rows[vistaClientes.DtClientes.CurrentRow.Index].Cells[2].Value.ToString();
            TxtApellidoCliente.Text = vistaClientes.DtClientes.Rows[vistaClientes.DtClientes.CurrentRow.Index].Cells[3].Value.ToString();
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmVista_Productos_Ventas vistaProductosVenta = new FrmVista_Productos_Ventas();
            vistaProductosVenta.ShowDialog();

            try
            {
                if (vistaProductosVenta.DialogResult == DialogResult.OK)
                {
                    LlenarTextBoxProductoDesdeVistaProducto(vistaProductosVenta.DtProductos.Rows[vistaProductosVenta.DtProductos.CurrentRow.Index]);
                    TxtCantidad.Focus();
                }
            }
            catch (Exception)
            {
                MostrarMensaje("Debe Seleccionar Un Producto En La Lista", "Seleccionar Productos", MessageBoxIcon.Exclamation);
            }
        }

        private void LlenarTextBoxProductoDesdeVistaProducto(DataGridViewRow selectedRow)
        {
            TxtIdProducto.Text = selectedRow.Cells[0].Value.ToString();
            TxtCodigoProducto.Text = selectedRow.Cells[1].Value.ToString();
            TxtCodigoBarra.Text = selectedRow.Cells[2].Value.ToString();
            TxtNombreProducto.Text = selectedRow.Cells[3].Value.ToString();
            TxtPrecioVenta.Text = selectedRow.Cells[5].Value.ToString();
            TxtStockActual.Text = selectedRow.Cells[6].Value.ToString();
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarDetalleProducto();
        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarDetalleProducto();
        }

        private void AgregarDetalleProducto()
        {
            try
            {
                if (CamposIncompletos())
                {
                    MostrarMensaje("Debe completar todos los Campos", "Agregar Producto", MessageBoxIcon.Exclamation);
                    return;
                }

                double importe = Convert.ToDouble(TxtPrecioVenta.Text) * Convert.ToDouble(TxtCantidad.Text);
                double montoTotal = importe;

                if (ContFila == 0 || !ProductoExiste())
                {
                    DtDetalleVentas.Rows.Add(TxtIdProducto.Text,TxtCodigoBarra.Text,TxtNombreProducto.Text, TxtCantidad.Text, TxtPrecioVenta.Text,
                        importe.ToString("N2"), montoTotal.ToString("N2"));

                    ContFila++;
                }
                else
                {
                    ActualizarDetalle(importe, montoTotal);
                }

                ActualizarTotales();
                LimpiarDetalle();
                TxtCodigoBarra.Focus();
            }
            catch (Exception ex)
            {
                MostrarMensaje("El producto no fue agregado por: " + ex.Message, "Agregar Producto", MessageBoxIcon.Error);
            }
        }

        private bool CamposIncompletos()
        {
            return string.IsNullOrWhiteSpace(TxtIdProducto.Text) ||
                   string.IsNullOrWhiteSpace(TxtCodigoProducto.Text) ||
                   string.IsNullOrWhiteSpace(TxtCodigoBarra.Text) ||
                   string.IsNullOrWhiteSpace(TxtNombreProducto.Text) || 
                   string.IsNullOrWhiteSpace(TxtCantidad.Text) ||
                   string.IsNullOrWhiteSpace(TxtStockActual.Text) ||
                   string.IsNullOrWhiteSpace(TxtPrecioVenta.Text);
        }

        private bool ProductoExiste()
        {
            foreach (DataGridViewRow row in DtDetalleVentas.Rows)
            {
                if (row.Cells[0].Value.ToString() == TxtIdProducto.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void ActualizarDetalle(double importe, double montoTotal)
        {
            int noFila = 0;

            foreach (DataGridViewRow row in DtDetalleVentas.Rows)
            {
                if (row.Cells[0].Value.ToString() == TxtIdProducto.Text)
                {
                    row.Cells[3].Value = Convert.ToDouble(TxtCantidad.Text) + Convert.ToDouble(row.Cells[3].Value);
                    row.Cells[5].Value = (importe + Convert.ToDouble(row.Cells[4].Value)).ToString("N2");
                    row.Cells[6].Value = (montoTotal + Convert.ToDouble(row.Cells[5].Value)).ToString("N2");
                    break;
                }
                noFila++;
            }
        }

        private void ActualizarTotales()
        {
            Total1 = 0;
            Total2 = 0;

            foreach (DataGridViewRow row1 in DtDetalleVentas.Rows)
            {
                Total1 += Convert.ToDecimal(row1.Cells[5].Value);
                Total2 += Convert.ToDecimal(row1.Cells[6].Value);
            }

            TxtSubTotal.Text = Total1.ToString("N2");
            TxtMontoTotal.Text = Total2.ToString("N2");
        }
        private void LimpiarDetalle()
        {
            TxtIdProducto.Text = string.Empty;
            TxtCodigoProducto.Text = string.Empty;
            TxtNombreProducto.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
            TxtStockActual.Text = string.Empty;
            TxtPrecioVenta.Text = string.Empty;
            TxtCodigoBarra.Text = string.Empty;
            BtnBuscarProducto.Focus();
        }
        private void EliminarDetalleProducto()
        {
            try
            {
                if (ContFila > 0 && DtDetalleVentas.CurrentRow != null)
                {
                    Total5 -= Convert.ToDecimal(DtDetalleVentas.Rows[DtDetalleVentas.CurrentRow.Index].Cells[5].Value);
                    DtDetalleVentas.Rows.RemoveAt(DtDetalleVentas.CurrentRow.Index);
                    ContFila--;

                    ActualizarTotales();
                }
                else
                {
                    MostrarMensaje("No Hay Fila Para Eliminar", "Seleccionar Productos", MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error al eliminar fila: " + ex.Message, "Error", MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            GuardarVentas();
        }

        private bool GuardarVentas()
        {
            try
            {
                if (CamposObligatoriosNoCompletos())
                {
                    MostrarMensaje("Debe completar todos los Campos por favor", "Agregar Venta Producto", MessageBoxIcon.Exclamation);
                    return false;
                }

                DatosVenta();

                foreach (DataGridViewRow row in DtDetalleVentas.Rows)
                {
                    DatosDetalleVenta(row);
                    DetalleVentas.AgregarDetalleVenta(DetalleVenta);
                }

                Ventas.AgregarVenta(Venta);

                MostrarMensaje("Venta de Productos agregada correctamente", "Agregar Venta Producto", MessageBoxIcon.Information);
                CargarGrilla();

                btnFacturar.Enabled = true;
                BtnAgregar.Enabled = false;

                return true;
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error al agregar la venta: " + ex.Message, "Agregar Venta Producto", MessageBoxIcon.Error);
                return false;
            }
        }

        private bool CamposObligatoriosNoCompletos()
        {
            return string.IsNullOrWhiteSpace(TxtNoFactura.Text) ||
                   string.IsNullOrWhiteSpace(TxtNombreCliente.Text) ||
                   string.IsNullOrWhiteSpace(TxtCedula.Text)||
                   string.IsNullOrWhiteSpace(TxtApellidoCliente.Text);
        }

        private void DatosVenta()
        {
            Venta.No_Factura = TxtNoFactura.Text;
            Venta.Id_Cliente = Convert.ToInt32(TxtIdCliente.Text);
            Venta.Fecha_Venta = Convert.ToDateTime(DtpFechaFactura.Text);
            Venta.Fecha_Validez = Convert.ToDateTime(DtpFechaValidez.Text);
            Venta.Sub_Total = Convert.ToDecimal(TxtSubTotal.Text);
            Venta.Monto_Total = Convert.ToDecimal(TxtMontoTotal.Text);
            Venta.Metodo_Pago = CboMetodoP.Text;
            Venta.Estado = "Emitido";
            Venta.Id_Usuario = 1; 
        }

        private void DatosDetalleVenta(DataGridViewRow row)
        {
            DetalleVenta.Id_Venta = Convert.ToInt32(TxtIdVenta.Text);
            DetalleVenta.Id_Producto = Convert.ToInt32(row.Cells[0].Value.ToString());
            DetalleVenta.Cantidad = Convert.ToInt32(row.Cells[3].Value.ToString());
            DetalleVenta.Precio_venta = Convert.ToDecimal(row.Cells[4].Value.ToString());
            DetalleVenta.Sub_Total = Convert.ToDecimal(row.Cells[5].Value.ToString());
            DetalleVenta.Monto_Total = Convert.ToDecimal(row.Cells[6].Value.ToString());
        }

      

        private void LimpiarCampos()
        {
            TxtIdCliente.Text = string.Empty;
            TxtNoFactura.Text = string.Empty;
            TxtNombreCliente.Text = string.Empty;
            TxtCedula.Text = string.Empty;
            DtDetalleVentas.Rows.Clear();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            string carpetaFacturas = @"C:\Users\mario\OneDrive\Documentos\ProyectoGUI\Facturas\FacturasVentas";
            string pdf = ".pdf";
            string fileName = Path.Combine(carpetaFacturas, TxtNoFactura.Text + DateTime.Now.ToString("ddMMyyyy") + pdf);

            string plantillaHtml = Properties.Resources.plantilla.ToString();
            plantillaHtml = plantillaHtml.Replace("@Fact", "Ventas")
                                       .Replace("@FACTURA", TxtNoFactura.Text)
                                       .Replace("@Estado", "Emitido")
                                       .Replace("@CLIENTE", TxtNombreCliente.Text)
                                       .Replace("@Apellido", TxtApellidoCliente.Text)
                                       .Replace("@DOCUMENTO", TxtCedula.Text)
                                       .Replace("@FECHA", DtpFechaFactura.Text)
                                       .Replace("@MetodoPago", CboMetodoP.Text);

            decimal total = 0;
            string filasHtml = string.Empty;

            foreach (DataGridViewRow row in DtDetalleVentas.Rows)
            {
                filasHtml += $"<tr><td align=\"center\">{row.Cells["Cantidad"].Value}</td>" +
                             $"<td>{row.Cells["Nombre_Producto"].Value}</td>" +
                             $"<td align=\"right\">{row.Cells["Precio_Venta"].Value}</td>" +
                             $"<td align=\"right\">{row.Cells["Importe"].Value}</td></tr>";
                total += decimal.Parse(row.Cells["Importe"].Value.ToString());
            }

            plantillaHtml = plantillaHtml.Replace("@Filas", filasHtml)
                                       .Replace("@Total", total.ToString());

            try
            {
                if (!Directory.Exists(carpetaFacturas))
                {
                    Directory.CreateDirectory(carpetaFacturas);
                }

                using (FileStream stream = new FileStream(fileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logotipo, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(plantillaHtml))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                }

                Process.Start(fileName);

                // Limpiar controles y campos después de generar el PDF
                Procedimientos.LimpiarControles(this);
                TxtSubTotal.Text = "0.00";
                TxtMontoTotal.Text = "0.00";
                LimpiarDetalle();
                LimpiarCampos();
                GenerarCorrelativo();
                BtnAgregar.Enabled = true;
                btnFacturar.Enabled = false;

                // Mensaje de confirmación
                if (File.Exists(fileName))
                {
                    MostrarMensaje($"Factura guardada en: {fileName}", "Éxito", MessageBoxIcon.Information);
                }
                else
                {
                    MostrarMensaje("Error al guardar la factura", "Error", MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al generar y guardar la factura: {ex.Message}", "Error", MessageBoxIcon.Error);
            }
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
            if ((textBox == TxtCedula || textBox == TxtCodigoBarra || textBox == TxtCantidad) &&
                ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)))
            {
                return true;
            }

            return false;
        }

        private void CambiarFocoSegunTextBox(TextBox textBox)
        {
            switch (textBox.Name)
            {
                case "TxtCedula":
                    TxtCodigoBarra.Focus();
                    break;
                case "TxtCodigoBarra":
                    TxtCantidad.Focus();
                    break;
                case "TxtCantidad":
                    BtnAgregarProducto.Focus();
                    break;
            }
        }

        private void MostrarMensaje(string mensaje, string titulo, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

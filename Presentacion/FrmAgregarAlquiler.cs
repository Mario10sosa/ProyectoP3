using Entidades;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using Logica;
using System;
using System.Data;
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
    public partial class FrmAgregarAlquiler : Form
    {

        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoAlquiler Alquileres = new ServicioContactoAlquiler();
        ServicioContactoDetalleAlquiler DetalleAlquiler = new ServicioContactoDetalleAlquiler();

        CE_Alquiler Alquiler = new CE_Alquiler();
        CE_Detalle_Alquiler Detalle_Alquiler = new CE_Detalle_Alquiler();
        DateTime UltimoDia = new DateTime(DateTime.Now.Year, 12, 31);

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public FrmAgregarAlquiler(FrmAlquiler alquiler)
        {
            InitializeComponent();
            CboMetodoP.DropDownStyle = ComboBoxStyle.DropDownList;
            Restrinciones();
        }

        public static int ContFila = 0;
        public static decimal Total1 = 0, Total2 = 0, Total5 = 0;
        public static double Importe1 = 0, ImporteNeto = 0, Monto_total = 0;

        private void Restrinciones()
        {
            TxtCedula.KeyPress += TextBox_KeyPress;
            TxtCodigoBarra.KeyPress += TextBox_KeyPress;
            TxtDuracion.KeyPress += TextBox_KeyPress;
        }
        public void AgClie_UpdateEventHandler(object sender, FrmAgregarCliente.UpdateEventArgs args)
        {

        }
        protected void CargarGrilla()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        private void FrmAgregarAlquiler_Load(object sender, EventArgs e)
        {
            GenerarCorrelativo();
            LlenarComboBox();
            DtpFechaValidez.Text = Convert.ToString(UltimoDia);
            MejorVista();

        }

        private void LlenarComboBox()
        {
            CboMetodoP.DataSource = Procedimientos.CargarDatos("Metodo_Pago");
            CboMetodoP.ValueMember = "Id_Metodo_Pago";
            CboMetodoP.DisplayMember = "Nombre_Metodo";
        }

        private void GenerarCorrelativo()
        {
            TxtNoFactura.Text = "FACT" + Procedimientos.GenerarCodigo("Alquiler");
            TxtIdAlquiler.Text = Procedimientos.GenerarCodigoId("Alquiler");
        }

        private void MejorVista()
        {
            DtDetalleVentas.Columns[0].Visible = false;// id Producto

            DtDetalleVentas.Columns[1].Width = 300;//codigo barra
            DtDetalleVentas.Columns[2].Width = 320;//nombre prodcto
            DtDetalleVentas.Columns[3].Width = 300;//Duracion
            DtDetalleVentas.Columns[4].Width = 300;//precio venta
            DtDetalleVentas.Columns[5].Width = 300;//total

            Formato();
        }
        private void Formato()
        {
            DtDetalleVentas.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtDetalleVentas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtDetalleVentas.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtDetalleVentas.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


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
                MostrarMensaje("Debe Seleccionar Un Clientes En La Lista", "Seleccionar Clientes",MessageBoxIcon.Information);
            }
        }

        private void TxTCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarCliente(TxtCedula.Text);

            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        void BuscarCliente(string cedulaABuscar)
        {
            bool clienteRegistrado = Alquileres.BuscarClientePorCedula(cedulaABuscar);

            if (clienteRegistrado)
            {
                // Si el cliente está registrado, obtén su nombre y ID
                DataTable clienteEncontrado = Alquileres.ObtenerDatosClientePorCedula(cedulaABuscar);

                if (clienteEncontrado.Rows.Count > 0)
                {
                    LlenarTextBoxCliente(clienteEncontrado);
                }
            }
            else
            {
                MostrarMensaje("El cliente no está registrado.", "Buscar Cliente", MessageBoxIcon.Information);
                AgregarNuevoCliente();
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

        private void AgregarNuevoCliente()
        {
            FrmAgregarCliente agregarCliente = new FrmAgregarCliente(null, null, this);
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
            FrmVista_Producto_Alquiler vistaProductosAlquiler = new FrmVista_Producto_Alquiler();
            vistaProductosAlquiler.ShowDialog();

            try
            {
                if (vistaProductosAlquiler.DialogResult == DialogResult.OK)
                {
                    LlenarTextBoxProductoDesdeVistaProducto(vistaProductosAlquiler.DtProductos.Rows[vistaProductosAlquiler.DtProductos.CurrentRow.Index]);
                    TxtDuracion.Focus();
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
            TxtPrecioAlquiler.Text = selectedRow.Cells[5].Value.ToString();
            TxtStockActual.Text = selectedRow.Cells[6].Value.ToString();
        }
        private void TxtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarProducto(TxtCodigoBarra.Text);
            }
        }

        void BuscarProducto(string CodigoBarra)
        {
            bool ProductoRegistrado = Alquileres.BuscarProductoPorCodigoBarra(CodigoBarra);

            if (ProductoRegistrado)
            {

                DataTable ProductoEncontrado = Alquileres.ObtenerDatosProductosPorCodigoBarra(CodigoBarra);

                if (ProductoEncontrado.Rows.Count > 0)
                {
                    LlenarTextBoxProductos(ProductoEncontrado);
                }
            }
            else
            {
                MostrarMensaje("El Producto No Está Registrado.", "Buscar Producto", MessageBoxIcon.Information);
            }
        }

        private void LlenarTextBoxProductos(DataTable productoEncontrado)
        {
            string codigo = productoEncontrado.Rows[0]["Codigo"].ToString();
            string codigobarra = productoEncontrado.Rows[0]["CodigoBarra"].ToString();
            string nombreproducto = productoEncontrado.Rows[0]["Nombre"].ToString();
            string stock = productoEncontrado.Rows[0]["Stock"].ToString();
            string precioalquiler = productoEncontrado.Rows[0]["Costo_Alquiler"].ToString();
            string id_producto = productoEncontrado.Rows[0]["Id_Producto"].ToString();

            // Llena los TextBox con los datos obtenidos
            TxtCodigoProducto.Text = codigo;
            TxtCodigoBarra.Text = codigobarra;
            TxtNombreProducto.Text = nombreproducto;
            TxtStockActual.Text = stock;
            TxtPrecioAlquiler.Text = precioalquiler;
            TxtIdProducto.Text = id_producto;
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarDetalleProducto();
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

                double montoTotal = Convert.ToDouble(TxtPrecioAlquiler.Text) * Convert.ToDouble(TxtDuracion.Text);

                if (ContFila == 0 || !ProductoExiste())
                {
                    DtDetalleVentas.Rows.Add(TxtIdProducto.Text, TxtCodigoBarra.Text,TxtNombreProducto.Text, TxtDuracion.Text, TxtPrecioAlquiler.Text,
                    montoTotal.ToString("N2"));

                    ContFila++;
                }
                else
                {
                    ActualizarDetalle(montoTotal);
                }

                ActualizarTotales();
                LimpiarDetalle();
                BtnBuscarProducto.Enabled = false;
                TxtDuracion.Enabled = false;
                BtnAgregarProducto.Enabled = false;
            }
            catch (Exception ex)
            {
                MostrarMensaje("El producto no fue agregado por: " + ex.Message, "Agregar Producto", MessageBoxIcon.Error);
            }
        }

        private bool CamposIncompletos()
        {
            return string.IsNullOrWhiteSpace(TxtIdProducto.Text) || string.IsNullOrWhiteSpace(TxtCodigoProducto.Text) ||
                   string.IsNullOrWhiteSpace(TxtNombreProducto.Text) || string.IsNullOrWhiteSpace(TxtDuracion.Text) ||
                   string.IsNullOrWhiteSpace(TxtStockActual.Text) || string.IsNullOrWhiteSpace(TxtPrecioAlquiler.Text) ||
                   string.IsNullOrWhiteSpace(TxtCodigoBarra.Text);
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

        private void ActualizarDetalle(double montoTotal)
        {
            int noFila = 0;

            foreach (DataGridViewRow row in DtDetalleVentas.Rows)
            {
                if (row.Cells[0].Value.ToString() == TxtIdProducto.Text)
                {
                    row.Cells[4].Value = (montoTotal + Convert.ToDouble(row.Cells[5].Value)).ToString("N2");
                    break;
                }
                noFila++;
            }
        }

        private void ActualizarTotales()
        {
            Total1 = 0;

            foreach (DataGridViewRow row1 in DtDetalleVentas.Rows)
            {
                Total1 += Convert.ToDecimal(row1.Cells[5].Value);
            }

            TxtMontoTotal.Text = Total1.ToString("N2");
        }

        private void LimpiarDetalle()
        {
            TxtIdProducto.Text = string.Empty;
            TxtCodigoProducto.Text = string.Empty;
            TxtCodigoBarra.Text = string.Empty;
            TxtNombreProducto.Text = string.Empty;
            TxtDuracion.Text = string.Empty;
            TxtStockActual.Text = string.Empty;
            TxtPrecioAlquiler.Text = string.Empty;
        }
        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ContFila > 0)
                {
                    DtDetalleVentas.Rows.RemoveAt(DtDetalleVentas.CurrentRow.Index);
                    ContFila--;

                    ActualizarTotales();
                    BtnAgregarProducto.Enabled = true;
                    BtnBuscarProducto.Enabled = true;
                    TxtDuracion.Enabled = true;
                }
                else
                {
                    MostrarMensaje("No Hay Fila Para Eliminar", "Seleccionar Productos", MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxIcon.Error);
            }
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool Guardar()
        {
            try
            {
                if (CamposObligatoriosNoCompletos())
                {
                    MostrarMensaje("Debe completar todos los Campos por favor", "Agregar Alquiler Producto",MessageBoxIcon.Exclamation);

                }
                else
                {
                    DatosAlquiler();

                    foreach (DataGridViewRow row in DtDetalleVentas.Rows)
                    {
                        DatosDetalleAlquiler(row);
                        DetalleAlquiler.AgregarDetalleAlquiler(Detalle_Alquiler);
                    }

                    Alquileres.AgregarAlquiler(Alquiler);
                    MostrarMensaje("Alquiler de Productos agregada correctamente", "Agregar Alquiler Producto", MessageBoxIcon.Information);
                    CargarGrilla();
                    BtnFacturar.Enabled = true;
                    BtnAgregar.Enabled = false;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("El Alquiler de Producto no fue agregada por: " + ex.Message, "Agregar Alquiler Producto", MessageBoxIcon.Error);
            }
            return false;
        }
        private bool CamposObligatoriosNoCompletos()
        {
            return string.IsNullOrWhiteSpace(TxtNoFactura.Text) ||
                   string.IsNullOrWhiteSpace(TxtNombreCliente.Text) ||
                   string.IsNullOrWhiteSpace(TxtCedula.Text) ||
                   string.IsNullOrWhiteSpace(TxtApellidoCliente.Text);
        }

        private void DatosAlquiler()
        {
            Alquiler.No_Factura = TxtNoFactura.Text;
            Alquiler.Id_Cliente = Convert.ToInt32(TxtIdCliente.Text);
            Alquiler.Fecha_Alquiler = Convert.ToDateTime(DtpFechaFactura.Text);
            Alquiler.Fecha_Validez = Convert.ToDateTime(DtpFechaValidez.Text);
            Alquiler.Monto_Total = Convert.ToDecimal(TxtMontoTotal.Text);
            Alquiler.Metodo_Pago = CboMetodoP.Text;
            Alquiler.Estado = "Emitido";
        }

        private void DatosDetalleAlquiler(DataGridViewRow row)
        {
            Detalle_Alquiler.Id_Alquiler = Convert.ToInt32(TxtIdAlquiler.Text);
            Detalle_Alquiler.Id_Producto = Convert.ToInt32(row.Cells[0].Value.ToString());
            Detalle_Alquiler.Duracion = Convert.ToInt32(row.Cells[3].Value.ToString());
            Detalle_Alquiler.Precio_Alquiler = Convert.ToDecimal(row.Cells[4].Value.ToString());
            Detalle_Alquiler.Monto_Total = Convert.ToDecimal(row.Cells[5].Value.ToString());
        }
        private void LimpiarCampos()
        {
            TxtIdCliente.Text = string.Empty;
            TxtNoFactura.Text = string.Empty;
            TxtNombreCliente.Text = string.Empty;
            TxtApellidoCliente.Text = string.Empty; 
            TxtCedula.Text = string.Empty;
            DtDetalleVentas.Rows.Clear();
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            string carpetaFacturas = @"C:\Users\mario\OneDrive\Documentos\ProyectoGUI\Facturas\FacturasAlquileres";
            string pdf = ".pdf";
            string fileName = Path.Combine(carpetaFacturas, TxtNoFactura.Text + DateTime.Now.ToString("ddMMyyyy") + pdf);

            string plantillaHtml = Properties.Resources.plantilla.ToString();
            plantillaHtml = plantillaHtml.Replace("@Fact", "Alquiler")
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
                filasHtml += $"<tr><td align=\"center\">{row.Cells["Duracion"].Value}</td>" +
                             $"<td>{row.Cells["Nombre_Producto"].Value}</td>" +
                             $"<td align=\"right\">{row.Cells["Precio_Alquiler"].Value}</td>" +
                             $"<td align=\"right\">{row.Cells["Total"].Value}</td></tr>";
                total += decimal.Parse(row.Cells["Total"].Value.ToString());
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
                TxtMontoTotal.Text = "0.00";
                LimpiarDetalle();
                LimpiarCampos();
                GenerarCorrelativo();
                BtnAgregar.Enabled = true;
                BtnFacturar.Enabled = false;
                BtnAgregarProducto.Enabled = true;
                BtnBuscarProducto.Enabled = true;
                TxtDuracion.Enabled = true;

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
            if ((textBox == TxtCedula || textBox == TxtCodigoBarra || textBox == TxtDuracion) &&
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
                    TxtDuracion.Focus();
                    break;
                case "TxtDuracion":
                    BtnAgregarProducto.Focus();
                    break;
            }
        }

        private void MostrarMensaje(string mensaje, string titulo, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }

    }
}

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
    public partial class FrmAnularVenta : Form
    {
        public FrmAnularVenta(FrmVentas ventas)
        {
            InitializeComponent();
        }
        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoVentas Ventas = new ServicioContactoVentas();
        ServicioContactoDetalleVentas DetalleVentas = new ServicioContactoDetalleVentas();

        CE_Ventas Venta = new CE_Ventas();
        CE_Detalle_Ventas DetalleVenta = new CE_Detalle_Ventas();

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Anular()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        private void FrmAnularVenta_Load(object sender, EventArgs e)
        {
            Procedimientos.FormatoMoneda(TxtSubTotal);
            Procedimientos.FormatoMoneda(TxtMontoTotal);

            MostrarDetalleVenta();
            MejorVista();
            
        }

        private void MostrarDetalleVenta()
        {
            DtDetalleVentas.DataSource = DetalleVentas.MostrarDetalleVenta(Convert.ToInt32(TxtIdVenta.Text));
            DtDetalleVentas.ClearSelection();
        }

        private void MejorVista()
        {
            DtDetalleVentas.Columns[0].Visible = false; //id detalle
            DtDetalleVentas.Columns[1].Visible = false;// id Producto

            DtDetalleVentas.Columns[2].Width = 245;//codigo barra
            DtDetalleVentas.Columns[3].Width = 300;//nombre
            DtDetalleVentas.Columns[4].Width = 240;//cantidad
            DtDetalleVentas.Columns[5].Width = 245;//precio venta
            DtDetalleVentas.Columns[6].Width = 245;//importe
            DtDetalleVentas.Columns[7].Width = 245;//total
            Formato();
            
        }

        private void Formato()
        {
            DtDetalleVentas.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtDetalleVentas.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DtDetalleVentas.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtDetalleVentas.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtDetalleVentas.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DtDetalleVentas.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            DtDetalleVentas.Columns[6].DefaultCellStyle.Format = "#,##0.00";
            DtDetalleVentas.Columns[7].DefaultCellStyle.Format = "#,##0.00";


            Procedimientos.AlternarColorFilaDataGridView(DtDetalleVentas);
        }
        private void BtnAnular_Click(object sender, EventArgs e)
        {
            AnularVenta();
        }
        public void AnularVenta()
        {
            try
            {
                if (CamposObligatoriosNoCompletos())
                {
                    MessageBox.Show("Debe Completar todos los campos por favor", "Anular Venta Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Esta Seguro Que Quiere Anular Este Registro", "Anular Venta Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (resultado == DialogResult.Yes)
                    {
                        DatosVentas();

                        foreach (DataGridViewRow row in DtDetalleVentas.Rows)
                        {

                            DatosDetalleAlquiler(row);
                            DetalleVentas.AnularDetalleVenta(DetalleVenta);
                        }

                        Ventas.AnularVenta(Venta);
                        this.Close();
                        Anular();
                    }
                    else
                    {
                        return;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Venta no fue Anulado por: " + ex.Message, "Anular Venta Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CamposObligatoriosNoCompletos()
        {
            return string.IsNullOrWhiteSpace(TxtNoFactura.Text) ||
                   string.IsNullOrWhiteSpace(TxtNombreCliente.Text) ||
                   string.IsNullOrWhiteSpace(TxtCedula.Text) ||
                   string.IsNullOrWhiteSpace(TxtApellidoCliente.Text);
        }
        private void DatosVentas()
        {
            Venta.Id_Venta = Convert.ToInt32(TxtIdVenta.Text.Trim());
            Venta.No_Factura = TxtNoFactura.Text;
            Venta.Id_Cliente = Convert.ToInt32(TxtIdCliente.Text);
            Venta.Fecha_Venta = Convert.ToDateTime(DtpFechaFactura.Text);
            Venta.Fecha_Validez = Convert.ToDateTime(DtpFechaValidez.Text);
            Venta.Sub_Total = Convert.ToDecimal(TxtSubTotal.Text);
            Venta.Monto_Total = Convert.ToDecimal(TxtMontoTotal.Text);
            Venta.Metodo_Pago = CboMetodoP.Text;
            Venta.Estado = "Anulado";
            Venta.Id_Usuario = 1;
        }

        private void DatosDetalleAlquiler(DataGridViewRow row)
        {
            DetalleVenta.Id_Detalle = Convert.ToInt32(row.Cells[0].Value.ToString());
            DetalleVenta.Id_Venta = Convert.ToInt32(TxtIdVenta.Text);
            DetalleVenta.Id_Producto = Convert.ToInt32(row.Cells[1].Value.ToString());
            DetalleVenta.Cantidad = Convert.ToInt32(row.Cells[4].Value.ToString());
            DetalleVenta.Precio_venta = Convert.ToDecimal(row.Cells[5].Value.ToString());
            DetalleVenta.Sub_Total = Convert.ToDecimal(row.Cells[6].Value.ToString());
            DetalleVenta.Monto_Total = Convert.ToDecimal(row.Cells[7].Value.ToString());
        }
    }
}

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
    public partial class FrmAnularAlquiler : Form
    {
        public FrmAnularAlquiler(FrmAlquiler alquiler)
        {
            InitializeComponent();
        }

        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoAlquiler Alquileres = new ServicioContactoAlquiler();
        ServicioContactoDetalleAlquiler DetalleAlquiler = new ServicioContactoDetalleAlquiler();

        CE_Alquiler Alquiler = new CE_Alquiler();
        CE_Detalle_Alquiler Detalle_Alquiler = new CE_Detalle_Alquiler();

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Anular()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        private void FrmAnularAlquiler_Load(object sender, EventArgs e)
        {
            Procedimientos.FormatoMoneda(TxtMontoTotal);

            MostrarDetalleAlquiler();
            MejorVista();
        }
        private void MostrarDetalleAlquiler()
        {
            DtDetalleAlquiler.DataSource = DetalleAlquiler.MostrarDetalleAlquiler(Convert.ToInt32(TxtIdAlquiler.Text));
            DtDetalleAlquiler.ClearSelection();
        }
        private void MejorVista()
        {
            DtDetalleAlquiler.Columns[0].Visible = false;//id detalle
            DtDetalleAlquiler.Columns[1].Visible = false;// id Producto

            DtDetalleAlquiler.Columns[2].Width = 300;//codigo barra
            DtDetalleAlquiler.Columns[3].Width = 320;//nombre producto
            DtDetalleAlquiler.Columns[4].Width = 300;//Duracion
            DtDetalleAlquiler.Columns[5].Width = 300;//precio venta
            DtDetalleAlquiler.Columns[6].Width = 300;//total

            Formato();
        }
        private void Formato()
        {
            DtDetalleAlquiler.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtDetalleAlquiler.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtDetalleAlquiler.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtDetalleAlquiler.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DtDetalleAlquiler.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            DtDetalleAlquiler.Columns[6].DefaultCellStyle.Format = "#,##0.00";
            Procedimientos.AlternarColorFilaDataGridView(DtDetalleAlquiler);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            AnularAlquiler();
        }
        public void AnularAlquiler()
        {
            try
            {
                if (CamposObligatoriosNoCompletos())
                {
                    MessageBox.Show("Debe Completar todos los campos por favor", "Anular Alquiler Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Esta Seguro Que Quiere Anular Este Registro", "Anular Alquiler Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (resultado == DialogResult.Yes)
                    {
                        DatosAlquiler();

                        foreach (DataGridViewRow row in DtDetalleAlquiler.Rows)
                        {

                            DatosDetalleAlquiler(row);
                            DetalleAlquiler.AnularDetalleAlquiler(Detalle_Alquiler);
                        }

                        Alquileres.AnularAlquiler(Alquiler);
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
                MessageBox.Show("El Alquiler no fue Anulado por: " + ex.Message, "Anular Alquiler Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CamposObligatoriosNoCompletos()
        {
            return string.IsNullOrWhiteSpace(TxtNoFactura.Text) ||
                   string.IsNullOrWhiteSpace(TxtNombreCliente.Text) ||
                   string.IsNullOrWhiteSpace(TxTCedula.Text) ||
                   string.IsNullOrWhiteSpace(TxtApellidoCliente.Text);
        }

        private void DatosAlquiler()
        {
            Alquiler.Id_Alquiler = Convert.ToInt32(TxtIdAlquiler.Text.Trim());
            Alquiler.No_Factura = TxtNoFactura.Text;
            Alquiler.Id_Cliente = Convert.ToInt32(TxtIdCliente.Text);
            Alquiler.Fecha_Alquiler = Convert.ToDateTime(DtpFechaFactura.Text);
            Alquiler.Fecha_Validez = Convert.ToDateTime(DtpFechaValidez.Text);
            Alquiler.Monto_Total = Convert.ToDecimal(TxtMontoTotal.Text);
            Alquiler.Metodo_Pago = CboMetodoP.Text;
            Alquiler.Estado = "Anulado";
        }

        private void DatosDetalleAlquiler(DataGridViewRow row)
        {
            Detalle_Alquiler.Id_Detalle_A = Convert.ToInt32(row.Cells[0].Value.ToString());
            Detalle_Alquiler.Id_Alquiler = Convert.ToInt32(TxtIdAlquiler.Text);
            Detalle_Alquiler.Id_Producto = Convert.ToInt32(row.Cells[1].Value.ToString());
            Detalle_Alquiler.Duracion = Convert.ToInt32(row.Cells[4].Value.ToString());
            Detalle_Alquiler.Precio_Alquiler = Convert.ToDecimal(row.Cells[5].Value.ToString());
            Detalle_Alquiler.Monto_Total = Convert.ToDecimal(row.Cells[6].Value.ToString());
        }
    }
}

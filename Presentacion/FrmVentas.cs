using Entidades;
using Logica;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmVentas : Form
    {
        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoVentas ventas = new ServicioContactoVentas();
        CE_Ventas Venta = new CE_Ventas();

        ServicioContactoDetalleVentas DetalleVentas = new ServicioContactoDetalleVentas();
        CE_Detalle_Ventas DetalleVenta = new CE_Detalle_Ventas();

        public FrmVentas()
        {
            InitializeComponent();
            CBTipoBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            DtpFechaVenta.ValueChanged += new EventHandler(DtpFechaVenta_ValueChanged);
            
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ConfigurarGrilla();
        }

        private void ConfigurarGrilla()
        {
            DtVentas.Columns[0].Visible = false;//id venta
            DtVentas.Columns[2].Visible = false;//id cliente


            DtVentas.Columns[1].Width = 140;//numero factura
            DtVentas.Columns[3].Width = 200;//nombre cliente
            DtVentas.Columns[4].Width = 200;//apellido cliente
            DtVentas.Columns[5].Width = 200;//Cedula cliente
            DtVentas.Columns[6].Width = 140;//fecha factura
            DtVentas.Columns[7].Width = 140;//fecha de valider
            DtVentas.Columns[8].Width = 140;//sub total
            DtVentas.Columns[9].Width = 140;//monto total
            DtVentas.Columns[10].Width = 200;//metodo pago
            DtVentas.Columns[11].Width = 140;//estado
            DtVentas.Columns[12].Width = 130;//usuario

            Formato();
        }
        private void Formato()
        {
            DtVentas.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtVentas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtVentas.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtVentas.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtVentas.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtVentas.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DtVentas.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtVentas.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DtVentas.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtVentas.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            DtVentas.Columns[8].DefaultCellStyle.Format = "#,#0.00";
            DtVentas.Columns[9].DefaultCellStyle.Format = "#,#0.00";

            Procedimientos.AlternarColorFilaDataGridView(DtVentas);
        }
        private void CargarDatos()
        {
            DtVentas.DataSource = ventas.MostrarVenta();
            DtVentas.ClearSelection();
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AgVen_UpdateEventHandler(object sender, FrmAgregarVenta.UpdateEventArgs args)
        {
            CargarDatos();
        }
        private void AnVen_UpdateEventHandler(object sender, FrmAnularVenta.UpdateEventArgs args)
        {
            CargarDatos();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormularioAgregarVenta();
        }
        private void BtnAnular_Click(object sender, EventArgs e)
        {
            AnularVenta();
        }
        private void TxtBuscarVentas_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void DtpFechaVenta_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void AbrirFormularioAgregarVenta()
        {
            FrmAgregarVenta agregarVenta = new FrmAgregarVenta(this);
            agregarVenta.UpdateEventHandler += AgVen_UpdateEventHandler;
            agregarVenta.ShowDialog();
        }

        private void AnularVenta()
        {
            if (DtVentas.Rows.Count == 0)
            {
                MostrarMensaje("No hay Venta para Anular", "Anular Venta", MessageBoxIcon.Exclamation);
                return;
            }

            if (DtVentas.CurrentRow == null)
            {
                MostrarMensaje("Debe Seleccionar Una Venta Para Anular", "Anular Venta", MessageBoxIcon.Exclamation);
                return;
            }

            FrmAnularVenta anularVenta = new FrmAnularVenta(this);
            anularVenta.UpdateEventHandler += AnVen_UpdateEventHandler;
            LlenarDatosAnularVenta(anularVenta);
            anularVenta.ShowDialog();
        }

        private void LlenarDatosAnularVenta(FrmAnularVenta anularVenta)
        {
            var selectedRow = DtVentas.SelectedRows[0];
            anularVenta.TxtIdVenta.Text = selectedRow.Cells[0].Value.ToString();
            anularVenta.TxtNoFactura.Text = selectedRow.Cells[1].Value.ToString();
            anularVenta.TxtIdCliente.Text = selectedRow.Cells[2].Value.ToString();
            anularVenta.TxtNombreCliente.Text = selectedRow.Cells[3].Value.ToString();
            anularVenta.TxtApellidoCliente.Text = selectedRow.Cells[4].Value.ToString();
            anularVenta.TxtCedula.Text = selectedRow.Cells[5].Value.ToString();
            anularVenta.DtpFechaFactura.Text = selectedRow.Cells[6].Value.ToString();
            anularVenta.DtpFechaValidez.Text = selectedRow.Cells[7].Value.ToString();
            anularVenta.TxtSubTotal.Text = selectedRow.Cells[8].Value.ToString();
            anularVenta.TxtMontoTotal.Text = selectedRow.Cells[9].Value.ToString();
            anularVenta.CboMetodoP.Text = selectedRow.Cells[10].Value.ToString();
        }

        public void Buscar()
        {
            try
            {
                if (CBTipoBusqueda.Text == "Nombre")
                {
                    TxtBuscarVentas.Focus();
                    Venta.Buscar = TxtBuscarVentas.Text.Trim();
                    DtVentas.DataSource = ventas.BuscarVentaCliente(Venta);
                }
                else if (CBTipoBusqueda.Text == "Cedula")
                {
                    TxtBuscarVentas.Focus();
                    Venta.Buscar = TxtBuscarVentas.Text.Trim();
                    DtVentas.DataSource = ventas.BuscarVentaCedula(Venta);
                }
                else if (CBTipoBusqueda.Text == "Fecha Venta")
                {
                    DateTime fechaBusqueda = DtpFechaVenta.Value.Date;

                    Venta.Fecha_Venta = fechaBusqueda;
                    Venta.Fecha_Validez = fechaBusqueda.AddDays(1).AddTicks(-1);

                    DtVentas.DataSource = ventas.BuscarVentaFechaVenta(Venta);
                }
                else if (CBTipoBusqueda.Text == "Metodo Pago")
                {
                   
                    Venta.Buscar = TxtBuscarVentas.Text.Trim();
                    DtVentas.DataSource = ventas.BuscarVentaMetodo_Pago(Venta);
                }
                else if (CBTipoBusqueda.Text == "Monto Total")
                {
                    
                    Venta.Buscar = TxtBuscarVentas.Text.Trim();
                    DtVentas.DataSource = ventas.BuscarVentaMonto_Total(Venta);
                }
                else if (CBTipoBusqueda.Text == "No Factura")
                {
                    
                    Venta.Buscar = TxtBuscarVentas.Text.Trim();
                    DtVentas.DataSource = ventas.BuscarVentaNoFactura(Venta);
                }
                else if(CBTipoBusqueda.Text == "(Mostrar Todo)")
                {
                    CargarDatos();
                   
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("La Venta No Fue Encontrado Por: " + ex.Message, "Buscar Venta", MessageBoxIcon.Exclamation);
            }
        }

        private void MostrarMensaje(string mensaje, string titulo, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }


       
    }
}

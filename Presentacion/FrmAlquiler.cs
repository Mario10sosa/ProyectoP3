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
    public partial class FrmAlquiler : Form
    {
        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoAlquiler Alquileres = new ServicioContactoAlquiler();
        CE_Alquiler Alquiler = new CE_Alquiler();

        public FrmAlquiler()
        {
            InitializeComponent();
            CBTipoBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            DtpFechaVenta.ValueChanged += new EventHandler(DtpFechaVenta_ValueChanged);
        }

        private void FrmAlquiler_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ConfigurarGrilla();
        }
        private void ConfigurarGrilla()
        {
            DtAlquiler.Columns[0].Visible = false;//id venta
            DtAlquiler.Columns[2].Visible = false;//id cliente


            DtAlquiler.Columns[1].Width = 140;//numero factura
            DtAlquiler.Columns[3].Width = 200;//nombre cliente
            DtAlquiler.Columns[4].Width = 200;//apellido cliente
            DtAlquiler.Columns[5].Width = 150;//Cedula cliente
            DtAlquiler.Columns[6].Width = 140;//fecha factura
            DtAlquiler.Columns[7].Width = 140;//fecha de valider
            DtAlquiler.Columns[8].Width = 150;//monto total
            DtAlquiler.Columns[9].Width = 200;//Metodo pago
            DtAlquiler.Columns[10].Width = 150;//estado

            Formato();
        }

        private void Formato()
        {

            DtAlquiler.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtAlquiler.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtAlquiler.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtAlquiler.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtAlquiler.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtAlquiler.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtAlquiler.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtAlquiler.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            DtAlquiler.Columns[8].DefaultCellStyle.Format = "#,#0.00";

            Procedimientos.AlternarColorFilaDataGridView(DtAlquiler);
        }
        void CargarDatos()
        {
            DtAlquiler.DataSource = Alquileres.MostrarAlquiler();
            DtAlquiler.ClearSelection();
        }

        private void AgAlqui_UpdateEventHandler(object sender, FrmAgregarAlquiler.UpdateEventArgs args)
        {
            CargarDatos();
        }
        private void AnAlqui_UpdateEventHandler(object sender, FrmAnularAlquiler.UpdateEventArgs args)
        {
            CargarDatos();
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            AbrirFormularioAgregarAlquiler();
        }
        private void AbrirFormularioAgregarAlquiler()
        {
            FrmAgregarAlquiler agregarAlquiler = new FrmAgregarAlquiler(this);
            agregarAlquiler.UpdateEventHandler += AgAlqui_UpdateEventHandler;
            agregarAlquiler.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            AnularAlquiler();
        }

        private void AnularAlquiler()
        {
            if (DtAlquiler.Rows.Count == 0)
            {
                MostrarMensaje("No hay Compras para Anular", "Anular Compra", MessageBoxIcon.Exclamation);
                return;
            }

            if (DtAlquiler.CurrentRow == null)
            {
                MostrarMensaje("Debe Seleccionar una Compra para Anular", "Anular Compra", MessageBoxIcon.Exclamation);
                return;
            }

            FrmAnularAlquiler anularAlquiler = new FrmAnularAlquiler(this);
            anularAlquiler.UpdateEventHandler += AnAlqui_UpdateEventHandler;
            LlenarDatosAnularAlquiler(anularAlquiler);
            anularAlquiler.ShowDialog();
        }

        private void LlenarDatosAnularAlquiler(FrmAnularAlquiler anularAlquiler)
        {
            var selectedRow = DtAlquiler.SelectedRows[0];
            anularAlquiler.TxtIdAlquiler.Text = selectedRow.Cells[0].Value.ToString();
            anularAlquiler.TxtNoFactura.Text = selectedRow.Cells[1].Value.ToString();
            anularAlquiler.TxtIdCliente.Text = selectedRow.Cells[2].Value.ToString();
            anularAlquiler.TxtNombreCliente.Text = selectedRow.Cells[3].Value.ToString();
            anularAlquiler.TxtApellidoCliente.Text = selectedRow.Cells[4].Value.ToString();
            anularAlquiler.TxTCedula.Text = selectedRow.Cells[5].Value.ToString();
            anularAlquiler.DtpFechaFactura.Text = selectedRow.Cells[6].Value.ToString();
            anularAlquiler.DtpFechaValidez.Text = selectedRow.Cells[7].Value.ToString();
            anularAlquiler.TxtMontoTotal.Text = selectedRow.Cells[8].Value.ToString();
            anularAlquiler.CboMetodoP.Text = selectedRow.Cells[9].Value.ToString();
        }
        private void TxtBuscarAlquiler_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void DtpFechaVenta_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {
            try
            {
                if (CBTipoBusqueda.Text == "Nombre")
                {
                    Alquiler.Buscar = TxtBuscarAlquiler.Text.Trim();
                    DtAlquiler.DataSource = Alquileres.BuscarAlquilerCliente(Alquiler);
                }
                else if (CBTipoBusqueda.Text == "Cedula")
                {
                    Alquiler.Buscar = TxtBuscarAlquiler.Text.Trim();
                    DtAlquiler.DataSource = Alquileres.BuscarAlquilerCedula(Alquiler);
                }
                else if (CBTipoBusqueda.Text == "Fecha Alquiler")
                {
                    DateTime fechaBusqueda = DtpFechaVenta.Value.Date;

                    Alquiler.Fecha_Alquiler = fechaBusqueda;
                    Alquiler.Fecha_Validez = fechaBusqueda.AddDays(1).AddTicks(-1);

                    DtAlquiler.DataSource = Alquileres.BuscarAlquilerFechaAlquiler(Alquiler);
                }
                else if(CBTipoBusqueda.Text == "(Mostrar Todo)")
                {
                    CargarDatos();
                }
                else if (CBTipoBusqueda.Text == "No Factura")
                {
                    Alquiler.Buscar = TxtBuscarAlquiler.Text.Trim();
                    DtAlquiler.DataSource = Alquileres.BuscarAlquilerNo_Factura(Alquiler);
                }
                else if (CBTipoBusqueda.Text == "Metodo Pago")
                {
                    Alquiler.Buscar = TxtBuscarAlquiler.Text.Trim();
                    DtAlquiler.DataSource = Alquileres.BuscarAlquilerMetodo_Pago(Alquiler);
                }
                else if (CBTipoBusqueda.Text == "Monto Total")
                {
                    Alquiler.Buscar = TxtBuscarAlquiler.Text.Trim();
                    DtAlquiler.DataSource = Alquileres.BuscarAlquilerMonto_Total(Alquiler);
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("El Alquiler No Fue Encontrado Por: " + ex.Message, "Buscar Alquiler", MessageBoxIcon.Exclamation);
            }
        }
        private void MostrarMensaje(string mensaje, string titulo, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }

       
    }
}

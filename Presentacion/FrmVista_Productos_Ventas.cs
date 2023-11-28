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
    public partial class FrmVista_Productos_Ventas : Form
    {
        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoProductos Productos = new ServicioContactoProductos();
        ServicioContactoVentas Ventas = new ServicioContactoVentas();
        CE_Productos Producto;
        public FrmVista_Productos_Ventas()
        {
            InitializeComponent();
            CBTipoBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void FrmVista_Productos_Ventas_Load(object sender, EventArgs e)
        {
            Mostrar_Productos_Ventas();
            ConfiguracionGrilla();
        }

        private void ConfiguracionGrilla()
        {

            DtProductos.Columns[0].Visible = false;//id_Producto


            DtProductos.Columns[1].Width = 150;//Codigo 
            DtProductos.Columns[2].Width = 200;//Nombre
            DtProductos.Columns[3].Width = 250;//Descripcion
            DtProductos.Columns[4].Width = 150;//Costo_Unitario
            DtProductos.Columns[5].Width = 150;//Stock
            Formato();
            Procedimientos.AlternarColorFilaDataGridView(DtProductos);
        }

        private void Formato()
        {
            DtProductos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtProductos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtProductos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DtProductos.Columns[4].DefaultCellStyle.Format = "#,##0.00";
        }
        private void Mostrar_Productos_Ventas()
        {
            DtProductos.DataSource = Ventas.Mostrar_Productos_Ventas();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DtProductos_DoubleClick(object sender, EventArgs e)
        {
            if (DtProductos.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void TxtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {
            try
            {
                if (CBTipoBusqueda.Text == "Codigo")
                {
                    Producto.Buscar = TxtBuscarProducto.Text.Trim();
                    DtProductos.DataSource = Productos.Buscar_Producto_Codigo(Producto);
                }
                else if (CBTipoBusqueda.Text == "Nombre")
                {
                    Producto.Buscar = TxtBuscarProducto.Text.Trim();
                    DtProductos.DataSource = Productos.Buscar_Producto_Nombre(Producto);
                }
                else if (CBTipoBusqueda.Text == "Codigo Barra")
                {
                    Producto.Buscar = TxtBuscarProducto.Text.Trim();
                    DtProductos.DataSource = Productos.Buscar_Producto_CodigoBarra(Producto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Producto No Fue Encontrado Por: " + ex.Message, "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

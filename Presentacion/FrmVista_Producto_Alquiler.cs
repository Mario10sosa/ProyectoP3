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
    public partial class FrmVista_Producto_Alquiler : Form
    {
        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoProductos Productos = new ServicioContactoProductos();
        ServicioContactoAlquiler Alquiler = new ServicioContactoAlquiler();

        CE_Productos Producto = new CE_Productos();
        public FrmVista_Producto_Alquiler()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVista_Producto_Alquiler_Load(object sender, EventArgs e)
        {
            Mostrar_Productos_Alquiler();
            ConfiguracionGrilla();
        }

        private void ConfiguracionGrilla()
        {

            DtProductos.Columns[0].Visible = false;//id_Producto


            DtProductos.Columns[1].Width = 150;//Codigo 
            DtProductos.Columns[2].Width = 200;//Nombre
            DtProductos.Columns[3].Width = 250;//Descripcion
            DtProductos.Columns[4].Width = 150;//Costo_Alquiler
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

        private void Mostrar_Productos_Alquiler()
        {
            DtProductos.DataSource = Alquiler.Mostrar_Productos_Alquiler();
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

        private void TxtBuscarProductos_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {
            try
            {
                if (CBTipoBusqueda.Text == "Codigo")
                {
                    Producto.Buscar = TxtBuscarProductos.Text.Trim();
                    DtProductos.DataSource = Productos.Buscar_Producto_Codigo(Producto);
                }
                else if (CBTipoBusqueda.Text == "Nombre")
                {
                    Producto.Buscar = TxtBuscarProductos.Text.Trim();
                    DtProductos.DataSource = Productos.Buscar_Producto_Nombre(Producto);
                }
                else if (CBTipoBusqueda.Text == "Codigo Barra")
                {
                    Producto.Buscar = TxtBuscarProductos.Text.Trim();
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

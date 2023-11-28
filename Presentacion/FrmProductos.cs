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
    public partial class FrmProductos : Form
    {
        ServicioContactoProcedimientos Procedimientos = new ServicioContactoProcedimientos();
        ServicioContactoProductos Productos = new ServicioContactoProductos();
        CE_Productos Producto = new CE_Productos();
        public FrmProductos()
        {
            InitializeComponent();
            CBTipoBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FrmHospitalarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ConfigurarGrilla();
        }
        private void ConfigurarGrilla()
        {
            DtProductos.Columns[0].Visible = false;//id_producto
            DtProductos.Columns[1].Width = 150;//codigo
            DtProductos.Columns[2].Width = 150;//codigobarra
            DtProductos.Columns[3].Width = 200;//nombre
            DtProductos.Columns[4].Width = 200;//Descripcion
            DtProductos.Columns[5].Width = 150;//precioVenta
            DtProductos.Columns[6].Width = 150;//preccionAlquiler
            DtProductos.Columns[7].Width = 100;//stock
            formato();
        }
        private void formato()
        {
            DtProductos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtProductos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DtProductos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtProductos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DtProductos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DtProductos.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            DtProductos.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaDataGridView(DtProductos);
        }
        void CargarGrilla()
        {
            DtProductos.DataSource = Procedimientos.CargarDatos("Productos");
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgProducto_UpdateEventHandler(object sender, FrmAgregarProducto.UpdateEventArgs args)
        {
            CargarGrilla();
        }

        private void EdProducto_UpdateEventHandler(object sender, FrmEditarProducto.UpdateEventArgs args)
        {
            CargarGrilla();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            AbrirFormularioAgregarProducto();
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditarProducto();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void TxtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void AbrirFormularioAgregarProducto()
        {
            FrmAgregarProducto agregarProducto = new FrmAgregarProducto(this);
            agregarProducto.UpdateEventHandler += AgProducto_UpdateEventHandler;
            agregarProducto.ShowDialog();
        }

        private void Buscar()
        { 
            try
            {
                if (CBTipoBusqueda.Text == "Codigo")
                {
                    Producto.Buscar = TxtBuscarClientes.Text.Trim();
                    DtProductos.DataSource = Productos.Buscar_Producto_Codigo(Producto);
                }
                else if (CBTipoBusqueda.Text == "Nombre")
                {
                    Producto.Buscar = TxtBuscarClientes.Text.Trim();
                    DtProductos.DataSource = Productos.Buscar_Producto_Nombre(Producto);
                }
                else if (CBTipoBusqueda.Text == "Codigo Barra")
                {
                    Producto.Buscar = TxtBuscarClientes.Text.Trim();
                    DtProductos.DataSource = Productos.Buscar_Producto_CodigoBarra(Producto);
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("El Producto No Fue Encontrado Por: " + ex.Message, "Buscar Producto",MessageBoxIcon.Exclamation);
            }
        }

        private void EditarProducto()
        {
            if (DtProductos.Rows.Count == 0)
            {
                MostrarMensaje("No Hay Registro Para Editar", "Editar Producto", MessageBoxIcon.Exclamation);
            }
            else
            {
                if (DtProductos.SelectedRows == null)
                {
                    return;
                }
                else
                {
                    try
                    {
                        FrmEditarProducto EditarProducto = new FrmEditarProducto(this);
                        EditarProducto.UpdateEventHandler += EdProducto_UpdateEventHandler;
                        LlenarDatosEditarProducto(EditarProducto);
                        EditarProducto.ShowDialog();
                    }
                    catch (Exception)
                    {
                        MostrarMensaje("Debe Seleccionar Un Registro Por Favor", "Editar Producto", MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void LlenarDatosEditarProducto(FrmEditarProducto editarProducto)
        {
            editarProducto.TxtIdProducto.Text = DtProductos.SelectedRows[0].Cells[0].Value.ToString();
            editarProducto.TxtCodigoProducto.Text = DtProductos.SelectedRows[0].Cells[1].Value.ToString();
            editarProducto.TxtCodigoBarra.Text = DtProductos.SelectedRows[0].Cells[2].Value.ToString();
            editarProducto.TxtNombreProducto.Text = DtProductos.SelectedRows[0].Cells[3].Value.ToString();
            editarProducto.TxtDescripcionProducto.Text = DtProductos.SelectedRows[0].Cells[4].Value.ToString();
            editarProducto.TxtPrecioVentaProducto.Text = DtProductos.SelectedRows[0].Cells[5].Value.ToString();
            editarProducto.TxtPrecioAlquilerProducto.Text = DtProductos.SelectedRows[0].Cells[6].Value.ToString();
            editarProducto.TxtStock.Text = DtProductos.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void Eliminar()
        {
            if (DtProductos.Rows.Count == 0)
            {
                MostrarMensaje("No hay registro para Eliminar", "Eliminar Producto", MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (DtProductos.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult Resultados = MessageBox.Show("¿Esta Seguro Que Desea Eliminar Este Producto?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultados == DialogResult.Yes)
                        {
                            Producto.Id_Producto = Convert.ToInt32(DtProductos.SelectedRows[0].Cells[0].Value.ToString());
                            Productos.EliminarProducto(Producto);
                            CargarGrilla();
                        }
                    }

                }
                catch (Exception)
                {
                    MostrarMensaje("Debe Seleccionar Un Registro Para Eliminar", "Eliminar Producto", MessageBoxIcon.Exclamation);

                }
            }

        }
        private void MostrarMensaje(string mensaje, string titulo, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }

        private void BtnFiltar_Click(object sender, EventArgs e)
        {
            try
            {
               
                DataTable productosMasVendidos = Productos.ObtenerProductosMasVendidos();

                DtProductos.DataSource = productosMasVendidos;

                ConfigurarGrilla();
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error al obtener los productos más vendidos: " + ex.Message, "Error", MessageBoxIcon.Error);
            }
        }
    }
}

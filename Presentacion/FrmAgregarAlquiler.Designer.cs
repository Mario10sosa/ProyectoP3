﻿namespace Presentacion
{
    partial class FrmAgregarAlquiler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnBuscarProducto = new System.Windows.Forms.Button();
            this.BtnEliminarProducto = new System.Windows.Forms.Button();
            this.TxtPrecioAlquiler = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMontoTotal = new System.Windows.Forms.TextBox();
            this.TxtStockActual = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.DtDetalleVentas = new System.Windows.Forms.DataGridView();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Alquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtDuracion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtApellidoCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CboMetodoP = new System.Windows.Forms.ComboBox();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechaValidez = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.TxtIdAlquiler = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNoFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.TxtIdProducto = new System.Windows.Forms.TextBox();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtCodigoBarra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnFacturar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtDetalleVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscarProducto.Location = new System.Drawing.Point(238, 65);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Size = new System.Drawing.Size(167, 29);
            this.BtnBuscarProducto.TabIndex = 11;
            this.BtnBuscarProducto.Text = "Listar Productos";
            this.BtnBuscarProducto.UseVisualStyleBackColor = true;
            this.BtnBuscarProducto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminarProducto.Location = new System.Drawing.Point(1614, 65);
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Size = new System.Drawing.Size(112, 29);
            this.BtnEliminarProducto.TabIndex = 17;
            this.BtnEliminarProducto.Text = "Eliminar P.";
            this.BtnEliminarProducto.UseVisualStyleBackColor = true;
            this.BtnEliminarProducto.Click += new System.EventHandler(this.BtnEliminarProducto_Click);
            // 
            // TxtPrecioAlquiler
            // 
            this.TxtPrecioAlquiler.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtPrecioAlquiler.Enabled = false;
            this.TxtPrecioAlquiler.ForeColor = System.Drawing.Color.Black;
            this.TxtPrecioAlquiler.Location = new System.Drawing.Point(952, 68);
            this.TxtPrecioAlquiler.Multiline = true;
            this.TxtPrecioAlquiler.Name = "TxtPrecioAlquiler";
            this.TxtPrecioAlquiler.Size = new System.Drawing.Size(169, 28);
            this.TxtPrecioAlquiler.TabIndex = 16;
            this.TxtPrecioAlquiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(948, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Precio Alquiler: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1164, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stock Actual :";
            // 
            // TxtMontoTotal
            // 
            this.TxtMontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtMontoTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtMontoTotal.Enabled = false;
            this.TxtMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMontoTotal.ForeColor = System.Drawing.Color.Black;
            this.TxtMontoTotal.Location = new System.Drawing.Point(17, 813);
            this.TxtMontoTotal.Multiline = true;
            this.TxtMontoTotal.Name = "TxtMontoTotal";
            this.TxtMontoTotal.Size = new System.Drawing.Size(273, 28);
            this.TxtMontoTotal.TabIndex = 25;
            this.TxtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtStockActual
            // 
            this.TxtStockActual.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtStockActual.Enabled = false;
            this.TxtStockActual.ForeColor = System.Drawing.Color.Black;
            this.TxtStockActual.Location = new System.Drawing.Point(1168, 68);
            this.TxtStockActual.Multiline = true;
            this.TxtStockActual.Name = "TxtStockActual";
            this.TxtStockActual.Size = new System.Drawing.Size(111, 28);
            this.TxtStockActual.TabIndex = 14;
            this.TxtStockActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(13, 790);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Monto Total:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Location = new System.Drawing.Point(1403, 813);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(113, 29);
            this.BtnAgregar.TabIndex = 22;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.Location = new System.Drawing.Point(1641, 813);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(113, 29);
            this.BtnCancelar.TabIndex = 20;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // DtDetalleVentas
            // 
            this.DtDetalleVentas.AllowUserToAddRows = false;
            this.DtDetalleVentas.AllowUserToDeleteRows = false;
            this.DtDetalleVentas.AllowUserToOrderColumns = true;
            this.DtDetalleVentas.AllowUserToResizeRows = false;
            this.DtDetalleVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtDetalleVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtDetalleVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Producto,
            this.CodigoBarra,
            this.Nombre_Producto,
            this.Duracion,
            this.Precio_Alquiler,
            this.Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtDetalleVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtDetalleVentas.EnableHeadersVisualStyles = false;
            this.DtDetalleVentas.Location = new System.Drawing.Point(12, 364);
            this.DtDetalleVentas.Name = "DtDetalleVentas";
            this.DtDetalleVentas.ReadOnly = true;
            this.DtDetalleVentas.RowHeadersVisible = false;
            this.DtDetalleVentas.RowHeadersWidth = 51;
            this.DtDetalleVentas.RowTemplate.Height = 24;
            this.DtDetalleVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtDetalleVentas.Size = new System.Drawing.Size(1752, 423);
            this.DtDetalleVentas.TabIndex = 23;
            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "Id Producto";
            this.Id_Producto.MinimumWidth = 6;
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.ReadOnly = true;
            this.Id_Producto.Width = 125;
            // 
            // CodigoBarra
            // 
            this.CodigoBarra.HeaderText = "Codigo Barra";
            this.CodigoBarra.MinimumWidth = 6;
            this.CodigoBarra.Name = "CodigoBarra";
            this.CodigoBarra.ReadOnly = true;
            this.CodigoBarra.Width = 125;
            // 
            // Nombre_Producto
            // 
            this.Nombre_Producto.HeaderText = "Nombre Producto";
            this.Nombre_Producto.MinimumWidth = 6;
            this.Nombre_Producto.Name = "Nombre_Producto";
            this.Nombre_Producto.ReadOnly = true;
            this.Nombre_Producto.Width = 125;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.MinimumWidth = 6;
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            this.Duracion.Width = 125;
            // 
            // Precio_Alquiler
            // 
            this.Precio_Alquiler.HeaderText = "Precio Alquiler";
            this.Precio_Alquiler.MinimumWidth = 6;
            this.Precio_Alquiler.Name = "Precio_Alquiler";
            this.Precio_Alquiler.ReadOnly = true;
            this.Precio_Alquiler.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // TxtDuracion
            // 
            this.TxtDuracion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtDuracion.ForeColor = System.Drawing.Color.Black;
            this.TxtDuracion.Location = new System.Drawing.Point(1318, 67);
            this.TxtDuracion.Multiline = true;
            this.TxtDuracion.Name = "TxtDuracion";
            this.TxtDuracion.Size = new System.Drawing.Size(137, 28);
            this.TxtDuracion.TabIndex = 12;
            this.TxtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.TxtApellidoCliente);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.TxtCedula);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.CboMetodoP);
            this.groupBox1.Controls.Add(this.BtnBuscarCliente);
            this.groupBox1.Controls.Add(this.TxtIdCliente);
            this.groupBox1.Controls.Add(this.TxtNombreCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(1, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1764, 110);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACION DE LA FACTURA";
            // 
            // TxtApellidoCliente
            // 
            this.TxtApellidoCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtApellidoCliente.Enabled = false;
            this.TxtApellidoCliente.ForeColor = System.Drawing.Color.Black;
            this.TxtApellidoCliente.Location = new System.Drawing.Point(719, 57);
            this.TxtApellidoCliente.Multiline = true;
            this.TxtApellidoCliente.Name = "TxtApellidoCliente";
            this.TxtApellidoCliente.Size = new System.Drawing.Size(266, 28);
            this.TxtApellidoCliente.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(715, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Apellido Cliente:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(35, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Cedula Cliente:";
            // 
            // TxtCedula
            // 
            this.TxtCedula.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtCedula.ForeColor = System.Drawing.Color.Black;
            this.TxtCedula.Location = new System.Drawing.Point(39, 54);
            this.TxtCedula.Multiline = true;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(200, 28);
            this.TxtCedula.TabIndex = 0;
            this.TxtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTCedula_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(1008, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Metodo Pago:";
            // 
            // CboMetodoP
            // 
            this.CboMetodoP.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CboMetodoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboMetodoP.FormattingEnabled = true;
            this.CboMetodoP.Location = new System.Drawing.Point(1012, 57);
            this.CboMetodoP.Name = "CboMetodoP";
            this.CboMetodoP.Size = new System.Drawing.Size(217, 26);
            this.CboMetodoP.TabIndex = 13;
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(254, 53);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(152, 29);
            this.BtnBuscarCliente.TabIndex = 10;
            this.BtnBuscarCliente.Text = "Listar Clientes";
            this.BtnBuscarCliente.UseVisualStyleBackColor = true;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtIdCliente.ForeColor = System.Drawing.Color.Black;
            this.TxtIdCliente.Location = new System.Drawing.Point(10, 54);
            this.TxtIdCliente.Multiline = true;
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(23, 28);
            this.TxtIdCliente.TabIndex = 5;
            this.TxtIdCliente.Visible = false;
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtNombreCliente.Enabled = false;
            this.TxtNombreCliente.ForeColor = System.Drawing.Color.Black;
            this.TxtNombreCliente.Location = new System.Drawing.Point(433, 57);
            this.TxtNombreCliente.Multiline = true;
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(246, 28);
            this.TxtNombreCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(429, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Cliente:";
            // 
            // DtpFechaValidez
            // 
            this.DtpFechaValidez.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFechaValidez.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaValidez.Location = new System.Drawing.Point(1601, 45);
            this.DtpFechaValidez.Name = "DtpFechaValidez";
            this.DtpFechaValidez.Size = new System.Drawing.Size(153, 27);
            this.DtpFechaValidez.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1427, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha Validez:";
            // 
            // DtpFechaFactura
            // 
            this.DtpFechaFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFactura.Location = new System.Drawing.Point(1600, 6);
            this.DtpFechaFactura.Name = "DtpFechaFactura";
            this.DtpFechaFactura.Size = new System.Drawing.Size(153, 27);
            this.DtpFechaFactura.TabIndex = 7;
            // 
            // TxtIdAlquiler
            // 
            this.TxtIdAlquiler.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtIdAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdAlquiler.ForeColor = System.Drawing.Color.Black;
            this.TxtIdAlquiler.Location = new System.Drawing.Point(367, 64);
            this.TxtIdAlquiler.Multiline = true;
            this.TxtIdAlquiler.Name = "TxtIdAlquiler";
            this.TxtIdAlquiler.Size = new System.Drawing.Size(23, 28);
            this.TxtIdAlquiler.TabIndex = 6;
            this.TxtIdAlquiler.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1427, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Factura:";
            // 
            // TxtNoFactura
            // 
            this.TxtNoFactura.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtNoFactura.Enabled = false;
            this.TxtNoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNoFactura.ForeColor = System.Drawing.Color.Black;
            this.TxtNoFactura.Location = new System.Drawing.Point(148, 64);
            this.TxtNoFactura.Multiline = true;
            this.TxtNoFactura.Name = "TxtNoFactura";
            this.TxtNoFactura.Size = new System.Drawing.Size(213, 28);
            this.TxtNoFactura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Factura:";
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(1489, 65);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(113, 29);
            this.BtnAgregarProducto.TabIndex = 10;
            this.BtnAgregarProducto.Text = "Agregar P.";
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtIdProducto.ForeColor = System.Drawing.Color.Black;
            this.TxtIdProducto.Location = new System.Drawing.Point(11, 66);
            this.TxtIdProducto.Multiline = true;
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.Size = new System.Drawing.Size(23, 28);
            this.TxtIdProducto.TabIndex = 6;
            this.TxtIdProducto.Visible = false;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtNombreProducto.Enabled = false;
            this.TxtNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.TxtNombreProducto.Location = new System.Drawing.Point(672, 68);
            this.TxtNombreProducto.Multiline = true;
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(246, 28);
            this.TxtNombreProducto.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(668, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nombre Producto:";
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtCodigoProducto.Enabled = false;
            this.TxtCodigoProducto.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigoProducto.Location = new System.Drawing.Point(40, 66);
            this.TxtCodigoProducto.Multiline = true;
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(175, 28);
            this.TxtCodigoProducto.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(36, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Codigo Producto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.TxtCodigoBarra);
            this.groupBox2.Controls.Add(this.BtnBuscarProducto);
            this.groupBox2.Controls.Add(this.BtnEliminarProducto);
            this.groupBox2.Controls.Add(this.TxtPrecioAlquiler);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtStockActual);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtDuracion);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.BtnAgregarProducto);
            this.groupBox2.Controls.Add(this.TxtIdProducto);
            this.groupBox2.Controls.Add(this.TxtNombreProducto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtCodigoProducto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(0, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1764, 127);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETALLE DE PRODUCTO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(430, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 20);
            this.label17.TabIndex = 26;
            this.label17.Text = "Codigo Barra:";
            // 
            // TxtCodigoBarra
            // 
            this.TxtCodigoBarra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtCodigoBarra.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigoBarra.Location = new System.Drawing.Point(434, 68);
            this.TxtCodigoBarra.Multiline = true;
            this.TxtCodigoBarra.Name = "TxtCodigoBarra";
            this.TxtCodigoBarra.Size = new System.Drawing.Size(200, 28);
            this.TxtCodigoBarra.TabIndex = 25;
            this.TxtCodigoBarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoBarra_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1320, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "¿Cuantos Dias? ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtNoFactura);
            this.panel1.Controls.Add(this.TxtIdAlquiler);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DtpFechaValidez);
            this.panel1.Controls.Add(this.DtpFechaFactura);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1765, 109);
            this.panel1.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(264, 61);
            this.label15.TabIndex = 13;
            this.label15.Text = "CAMILO I-H";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(693, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(333, 32);
            this.label14.TabIndex = 12;
            this.label14.Text = "Facturacion De Alquiler";
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFacturar.Enabled = false;
            this.BtnFacturar.ForeColor = System.Drawing.Color.Black;
            this.BtnFacturar.Location = new System.Drawing.Point(1522, 813);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(113, 29);
            this.BtnFacturar.TabIndex = 27;
            this.BtnFacturar.Text = "Facturar";
            this.BtnFacturar.UseVisualStyleBackColor = true;
            this.BtnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // FrmAgregarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1765, 880);
            this.Controls.Add(this.BtnFacturar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtMontoTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.DtDetalleVentas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAgregarAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion Alquiler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAgregarAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtDetalleVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BtnBuscarProducto;
        public System.Windows.Forms.Button BtnEliminarProducto;
        public System.Windows.Forms.TextBox TxtPrecioAlquiler;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtMontoTotal;
        public System.Windows.Forms.TextBox TxtStockActual;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button BtnAgregar;
        public System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.DataGridView DtDetalleVentas;
        public System.Windows.Forms.TextBox TxtDuracion;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.DateTimePicker DtpFechaValidez;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpFechaFactura;
        public System.Windows.Forms.TextBox TxtIdAlquiler;
        public System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtNoFactura;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BtnAgregarProducto;
        public System.Windows.Forms.TextBox TxtIdProducto;
        public System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtCodigoProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CboMetodoP;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox TxtApellidoCliente;
        public System.Windows.Forms.Button BtnFacturar;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox TxtCodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Alquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label10;
    }
}
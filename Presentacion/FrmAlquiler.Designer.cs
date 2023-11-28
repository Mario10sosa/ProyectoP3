namespace Presentacion
{
    partial class FrmAlquiler
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
            this.DtAlquiler = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Label();
            this.BtnFacturacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscarAlquiler = new System.Windows.Forms.TextBox();
            this.CBTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.DtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DtAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // DtAlquiler
            // 
            this.DtAlquiler.AllowUserToAddRows = false;
            this.DtAlquiler.AllowUserToDeleteRows = false;
            this.DtAlquiler.AllowUserToOrderColumns = true;
            this.DtAlquiler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtAlquiler.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtAlquiler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtAlquiler.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtAlquiler.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtAlquiler.EnableHeadersVisualStyles = false;
            this.DtAlquiler.Location = new System.Drawing.Point(25, 119);
            this.DtAlquiler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtAlquiler.Name = "DtAlquiler";
            this.DtAlquiler.ReadOnly = true;
            this.DtAlquiler.RowHeadersVisible = false;
            this.DtAlquiler.RowHeadersWidth = 51;
            this.DtAlquiler.RowTemplate.Height = 24;
            this.DtAlquiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtAlquiler.Size = new System.Drawing.Size(1341, 448);
            this.DtAlquiler.TabIndex = 86;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminar.BackColor = System.Drawing.Color.Azure;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(165, 584);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(120, 30);
            this.BtnEliminar.TabIndex = 88;
            this.BtnEliminar.Text = "Anular";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.BackColor = System.Drawing.Color.Azure;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(25, 584);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(120, 30);
            this.BtnNuevo.TabIndex = 87;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 40);
            this.label2.TabIndex = 89;
            this.label2.Text = "Gestion Alquiler";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.AutoSize = true;
            this.BtnCerrar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Black;
            this.BtnCerrar.Location = new System.Drawing.Point(1350, 11);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtnCerrar.TabIndex = 91;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnFacturacion
            // 
            this.BtnFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnFacturacion.BackColor = System.Drawing.Color.Azure;
            this.BtnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturacion.Location = new System.Drawing.Point(304, 584);
            this.BtnFacturacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFacturacion.Name = "BtnFacturacion";
            this.BtnFacturacion.Size = new System.Drawing.Size(120, 30);
            this.BtnFacturacion.TabIndex = 92;
            this.BtnFacturacion.Text = "Facturacion";
            this.BtnFacturacion.UseVisualStyleBackColor = false;
            this.BtnFacturacion.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(730, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "Buscar:";
            // 
            // TxtBuscarAlquiler
            // 
            this.TxtBuscarAlquiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarAlquiler.BackColor = System.Drawing.Color.Linen;
            this.TxtBuscarAlquiler.Location = new System.Drawing.Point(970, 75);
            this.TxtBuscarAlquiler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBuscarAlquiler.Multiline = true;
            this.TxtBuscarAlquiler.Name = "TxtBuscarAlquiler";
            this.TxtBuscarAlquiler.Size = new System.Drawing.Size(233, 24);
            this.TxtBuscarAlquiler.TabIndex = 95;
            this.TxtBuscarAlquiler.TextChanged += new System.EventHandler(this.TxtBuscarAlquiler_TextChanged);
            // 
            // CBTipoBusqueda
            // 
            this.CBTipoBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBTipoBusqueda.BackColor = System.Drawing.Color.Linen;
            this.CBTipoBusqueda.FormattingEnabled = true;
            this.CBTipoBusqueda.Items.AddRange(new object[] {
            "(Mostrar Todo)",
            "Cedula",
            "Fecha Alquiler",
            "Nombre",
            "Metodo Pago",
            "No Factura",
            "Monto Total"});
            this.CBTipoBusqueda.Location = new System.Drawing.Point(804, 75);
            this.CBTipoBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBTipoBusqueda.Name = "CBTipoBusqueda";
            this.CBTipoBusqueda.Size = new System.Drawing.Size(160, 24);
            this.CBTipoBusqueda.TabIndex = 94;
            // 
            // DtpFechaVenta
            // 
            this.DtpFechaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFechaVenta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaVenta.Location = new System.Drawing.Point(1209, 75);
            this.DtpFechaVenta.Name = "DtpFechaVenta";
            this.DtpFechaVenta.Size = new System.Drawing.Size(157, 24);
            this.DtpFechaVenta.TabIndex = 97;
            this.DtpFechaVenta.Value = new System.DateTime(2023, 11, 26, 21, 46, 55, 0);
            this.DtpFechaVenta.ValueChanged += new System.EventHandler(this.DtpFechaVenta_ValueChanged);
            // 
            // FrmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1387, 673);
            this.Controls.Add(this.DtpFechaVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscarAlquiler);
            this.Controls.Add(this.CBTipoBusqueda);
            this.Controls.Add(this.BtnFacturacion);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.DtAlquiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAlquiler";
            this.Text = "FrmAlquiler";
            this.Load += new System.EventHandler(this.FrmAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DtAlquiler;
        public System.Windows.Forms.Button BtnEliminar;
        public System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BtnCerrar;
        public System.Windows.Forms.Button BtnFacturacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscarAlquiler;
        private System.Windows.Forms.ComboBox CBTipoBusqueda;
        private System.Windows.Forms.DateTimePicker DtpFechaVenta;
    }
}
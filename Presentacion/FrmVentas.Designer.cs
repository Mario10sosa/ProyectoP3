namespace Presentacion
{
    partial class FrmVentas
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
            this.label2 = new System.Windows.Forms.Label();
            this.DtVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscarVentas = new System.Windows.Forms.TextBox();
            this.CBTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.BtnAnular = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Label();
            this.DtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DtVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 40);
            this.label2.TabIndex = 95;
            this.label2.Text = "Gestion De Ventas";
            // 
            // DtVentas
            // 
            this.DtVentas.AllowUserToAddRows = false;
            this.DtVentas.AllowUserToDeleteRows = false;
            this.DtVentas.AllowUserToResizeRows = false;
            this.DtVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtVentas.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtVentas.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtVentas.EnableHeadersVisualStyles = false;
            this.DtVentas.Location = new System.Drawing.Point(25, 119);
            this.DtVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtVentas.Name = "DtVentas";
            this.DtVentas.ReadOnly = true;
            this.DtVentas.RowHeadersVisible = false;
            this.DtVentas.RowHeadersWidth = 51;
            this.DtVentas.RowTemplate.Height = 24;
            this.DtVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtVentas.Size = new System.Drawing.Size(1341, 448);
            this.DtVentas.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(763, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Buscar:";
            // 
            // TxtBuscarVentas
            // 
            this.TxtBuscarVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarVentas.BackColor = System.Drawing.Color.Linen;
            this.TxtBuscarVentas.Location = new System.Drawing.Point(1003, 75);
            this.TxtBuscarVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBuscarVentas.Multiline = true;
            this.TxtBuscarVentas.Name = "TxtBuscarVentas";
            this.TxtBuscarVentas.Size = new System.Drawing.Size(191, 24);
            this.TxtBuscarVentas.TabIndex = 92;
            this.TxtBuscarVentas.TextChanged += new System.EventHandler(this.TxtBuscarVentas_TextChanged);
            // 
            // CBTipoBusqueda
            // 
            this.CBTipoBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBTipoBusqueda.BackColor = System.Drawing.Color.Linen;
            this.CBTipoBusqueda.FormattingEnabled = true;
            this.CBTipoBusqueda.Items.AddRange(new object[] {
            "(Mostrar Todo)",
            "Cedula",
            "Nombre",
            "Fecha Venta",
            "Metodo Pago",
            "No Factura",
            "Monto Total"});
            this.CBTipoBusqueda.Location = new System.Drawing.Point(837, 75);
            this.CBTipoBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBTipoBusqueda.Name = "CBTipoBusqueda";
            this.CBTipoBusqueda.Size = new System.Drawing.Size(160, 24);
            this.CBTipoBusqueda.TabIndex = 91;
            // 
            // BtnAnular
            // 
            this.BtnAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAnular.BackColor = System.Drawing.Color.Azure;
            this.BtnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnular.Location = new System.Drawing.Point(165, 584);
            this.BtnAnular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(120, 30);
            this.BtnAnular.TabIndex = 89;
            this.BtnAnular.Text = "Anular";
            this.BtnAnular.UseVisualStyleBackColor = false;
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAgregar.BackColor = System.Drawing.Color.Azure;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(25, 584);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 30);
            this.BtnAgregar.TabIndex = 88;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.AutoSize = true;
            this.BtnCerrar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Black;
            this.BtnCerrar.Location = new System.Drawing.Point(1355, 10);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtnCerrar.TabIndex = 87;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // DtpFechaVenta
            // 
            this.DtpFechaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFechaVenta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaVenta.Location = new System.Drawing.Point(1200, 75);
            this.DtpFechaVenta.Name = "DtpFechaVenta";
            this.DtpFechaVenta.Size = new System.Drawing.Size(157, 24);
            this.DtpFechaVenta.TabIndex = 96;
            this.DtpFechaVenta.Value = new System.DateTime(2023, 11, 26, 21, 46, 55, 0);
            this.DtpFechaVenta.ValueChanged += new System.EventHandler(this.DtpFechaVenta_ValueChanged);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1387, 673);
            this.Controls.Add(this.DtpFechaVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscarVentas);
            this.Controls.Add(this.CBTipoBusqueda);
            this.Controls.Add(this.BtnAnular);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView DtVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscarVentas;
        private System.Windows.Forms.ComboBox CBTipoBusqueda;
        public System.Windows.Forms.Button BtnAnular;
        public System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label BtnCerrar;
        private System.Windows.Forms.DateTimePicker DtpFechaVenta;
    }
}
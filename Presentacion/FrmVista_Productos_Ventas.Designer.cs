namespace Presentacion
{
    partial class FrmVista_Productos_Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCerrar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscarProducto = new System.Windows.Forms.TextBox();
            this.CBTipoBusqueda = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.AutoSize = true;
            this.BtnCerrar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Black;
            this.BtnCerrar.Location = new System.Drawing.Point(1352, 11);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtnCerrar.TabIndex = 107;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 40);
            this.label2.TabIndex = 106;
            this.label2.Text = "Gestion De Productos\r\n";
            // 
            // DtProductos
            // 
            this.DtProductos.AllowUserToAddRows = false;
            this.DtProductos.AllowUserToDeleteRows = false;
            this.DtProductos.AllowUserToOrderColumns = true;
            this.DtProductos.AllowUserToResizeRows = false;
            this.DtProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtProductos.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DtProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtProductos.DefaultCellStyle = dataGridViewCellStyle4;
            this.DtProductos.EnableHeadersVisualStyles = false;
            this.DtProductos.Location = new System.Drawing.Point(25, 119);
            this.DtProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtProductos.Name = "DtProductos";
            this.DtProductos.ReadOnly = true;
            this.DtProductos.RowHeadersVisible = false;
            this.DtProductos.RowHeadersWidth = 51;
            this.DtProductos.RowTemplate.Height = 24;
            this.DtProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtProductos.Size = new System.Drawing.Size(1341, 448);
            this.DtProductos.TabIndex = 105;
            this.DtProductos.DoubleClick += new System.EventHandler(this.DtProductos_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(817, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "Buscar:";
            // 
            // TxtBuscarProducto
            // 
            this.TxtBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarProducto.BackColor = System.Drawing.Color.Linen;
            this.TxtBuscarProducto.Location = new System.Drawing.Point(1057, 71);
            this.TxtBuscarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBuscarProducto.Multiline = true;
            this.TxtBuscarProducto.Name = "TxtBuscarProducto";
            this.TxtBuscarProducto.Size = new System.Drawing.Size(309, 24);
            this.TxtBuscarProducto.TabIndex = 103;
            this.TxtBuscarProducto.TextChanged += new System.EventHandler(this.TxtBuscarProducto_TextChanged);
            // 
            // CBTipoBusqueda
            // 
            this.CBTipoBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CBTipoBusqueda.BackColor = System.Drawing.Color.Linen;
            this.CBTipoBusqueda.FormattingEnabled = true;
            this.CBTipoBusqueda.Items.AddRange(new object[] {
            "Codigo",
            "Codigo Barra",
            "Nombre"});
            this.CBTipoBusqueda.Location = new System.Drawing.Point(891, 71);
            this.CBTipoBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBTipoBusqueda.Name = "CBTipoBusqueda";
            this.CBTipoBusqueda.Size = new System.Drawing.Size(160, 24);
            this.CBTipoBusqueda.TabIndex = 102;
            // 
            // FrmVista_Productos_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1387, 673);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscarProducto);
            this.Controls.Add(this.CBTipoBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVista_Productos_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVista_Productos_Ventas";
            this.Load += new System.EventHandler(this.FrmVista_Productos_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BtnCerrar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView DtProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscarProducto;
        private System.Windows.Forms.ComboBox CBTipoBusqueda;
    }
}
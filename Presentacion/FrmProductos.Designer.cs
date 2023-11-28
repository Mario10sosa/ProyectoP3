namespace Presentacion
{
    partial class FrmProductos
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
            this.DtProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscarClientes = new System.Windows.Forms.TextBox();
            this.CBTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Label();
            this.BtnFiltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtProductos)).BeginInit();
            this.SuspendLayout();
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
            this.label2.TabIndex = 95;
            this.label2.Text = "Gestion De Productos";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtProductos.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.DtProductos.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(817, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Buscar:";
            // 
            // TxtBuscarClientes
            // 
            this.TxtBuscarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarClientes.BackColor = System.Drawing.Color.Linen;
            this.TxtBuscarClientes.Location = new System.Drawing.Point(1057, 71);
            this.TxtBuscarClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBuscarClientes.Multiline = true;
            this.TxtBuscarClientes.Name = "TxtBuscarClientes";
            this.TxtBuscarClientes.Size = new System.Drawing.Size(311, 24);
            this.TxtBuscarClientes.TabIndex = 92;
            this.TxtBuscarClientes.TextChanged += new System.EventHandler(this.TxtBuscarClientes_TextChanged);
            // 
            // CBTipoBusqueda
            // 
            this.CBTipoBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.CBTipoBusqueda.TabIndex = 91;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminar.BackColor = System.Drawing.Color.Azure;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(304, 584);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(120, 30);
            this.BtnEliminar.TabIndex = 90;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEditar.BackColor = System.Drawing.Color.Azure;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(165, 584);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(120, 30);
            this.BtnEditar.TabIndex = 89;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
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
            this.BtnNuevo.TabIndex = 88;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.AutoSize = true;
            this.BtnCerrar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Black;
            this.BtnCerrar.Location = new System.Drawing.Point(1355, 11);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtnCerrar.TabIndex = 87;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnFiltar
            // 
            this.BtnFiltar.Location = new System.Drawing.Point(594, 71);
            this.BtnFiltar.Name = "BtnFiltar";
            this.BtnFiltar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltar.TabIndex = 97;
            this.BtnFiltar.Text = "Filtar";
            this.BtnFiltar.UseVisualStyleBackColor = true;
            this.BtnFiltar.Click += new System.EventHandler(this.BtnFiltar_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1387, 673);
            this.Controls.Add(this.BtnFiltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscarClientes);
            this.Controls.Add(this.CBTipoBusqueda);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductos";
            this.Text = "FrmHospitalarios";
            this.Load += new System.EventHandler(this.FrmHospitalarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView DtProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscarClientes;
        private System.Windows.Forms.ComboBox CBTipoBusqueda;
        public System.Windows.Forms.Button BtnEliminar;
        public System.Windows.Forms.Button BtnEditar;
        public System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Label BtnCerrar;
        private System.Windows.Forms.Button BtnFiltar;
    }
}
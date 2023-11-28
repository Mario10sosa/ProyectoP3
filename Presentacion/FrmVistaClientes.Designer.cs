namespace Presentacion
{
    partial class FrmVistaClientes
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
            this.DtClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscarClientes = new System.Windows.Forms.TextBox();
            this.CboTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.BtnCerrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 40);
            this.label2.TabIndex = 92;
            this.label2.Text = "Gestion Clientes";
            // 
            // DtClientes
            // 
            this.DtClientes.AllowUserToAddRows = false;
            this.DtClientes.AllowUserToDeleteRows = false;
            this.DtClientes.AllowUserToOrderColumns = true;
            this.DtClientes.AllowUserToResizeRows = false;
            this.DtClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtClientes.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtClientes.EnableHeadersVisualStyles = false;
            this.DtClientes.Location = new System.Drawing.Point(25, 119);
            this.DtClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtClientes.Name = "DtClientes";
            this.DtClientes.ReadOnly = true;
            this.DtClientes.RowHeadersVisible = false;
            this.DtClientes.RowHeadersWidth = 51;
            this.DtClientes.RowTemplate.Height = 24;
            this.DtClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtClientes.Size = new System.Drawing.Size(1341, 448);
            this.DtClientes.TabIndex = 91;
            this.DtClientes.DoubleClick += new System.EventHandler(this.DtClientes_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(817, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 90;
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
            this.TxtBuscarClientes.Size = new System.Drawing.Size(309, 24);
            this.TxtBuscarClientes.TabIndex = 89;
            this.TxtBuscarClientes.TextChanged += new System.EventHandler(this.TxtBuscarClientes_TextChanged);
            // 
            // CboTipoBusqueda
            // 
            this.CboTipoBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CboTipoBusqueda.BackColor = System.Drawing.Color.Linen;
            this.CboTipoBusqueda.FormattingEnabled = true;
            this.CboTipoBusqueda.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Cedula"});
            this.CboTipoBusqueda.Location = new System.Drawing.Point(891, 71);
            this.CboTipoBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboTipoBusqueda.Name = "CboTipoBusqueda";
            this.CboTipoBusqueda.Size = new System.Drawing.Size(160, 24);
            this.CboTipoBusqueda.TabIndex = 88;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.AutoSize = true;
            this.BtnCerrar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Black;
            this.BtnCerrar.Location = new System.Drawing.Point(1344, 32);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtnCerrar.TabIndex = 87;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmVistaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1387, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscarClientes);
            this.Controls.Add(this.CboTipoBusqueda);
            this.Controls.Add(this.BtnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVistaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista Clientes";
            this.Load += new System.EventHandler(this.FrmVistaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView DtClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscarClientes;
        private System.Windows.Forms.ComboBox CboTipoBusqueda;
        private System.Windows.Forms.Label BtnCerrar;
    }
}
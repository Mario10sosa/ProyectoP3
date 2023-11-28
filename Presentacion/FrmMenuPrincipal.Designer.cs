namespace Presentacion
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.BtnEmpresas = new System.Windows.Forms.Button();
            this.BtnAlquiler = new System.Windows.Forms.Button();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.BtnIHospitalarios = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.iconominimizar = new System.Windows.Forms.PictureBox();
            this.iconorestaurar = new System.Windows.Forms.PictureBox();
            this.iconomaximizar = new System.Windows.Forms.PictureBox();
            this.iconoSalir = new System.Windows.Forms.PictureBox();
            this.BtnSlide = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.tmExpandirMenu = new System.Windows.Forms.Timer(this.components);
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconominimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconorestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconomaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.BtnUsuario);
            this.MenuVertical.Controls.Add(this.BtnEmpresas);
            this.MenuVertical.Controls.Add(this.BtnAlquiler);
            this.MenuVertical.Controls.Add(this.BtnVentas);
            this.MenuVertical.Controls.Add(this.BtnIHospitalarios);
            this.MenuVertical.Controls.Add(this.BtnClientes);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(311, 738);
            this.MenuVertical.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.logotipo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.FlatAppearance.BorderSize = 0;
            this.BtnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuario.ForeColor = System.Drawing.Color.White;
            this.BtnUsuario.Image = global::Presentacion.Properties.Resources.usuario;
            this.BtnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuario.Location = new System.Drawing.Point(16, 371);
            this.BtnUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(296, 49);
            this.BtnUsuario.TabIndex = 7;
            this.BtnUsuario.Text = "Usuario";
            this.BtnUsuario.UseVisualStyleBackColor = true;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // BtnEmpresas
            // 
            this.BtnEmpresas.FlatAppearance.BorderSize = 0;
            this.BtnEmpresas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpresas.ForeColor = System.Drawing.Color.White;
            this.BtnEmpresas.Image = global::Presentacion.Properties.Resources.edificio_de_oficinas;
            this.BtnEmpresas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpresas.Location = new System.Drawing.Point(15, 323);
            this.BtnEmpresas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEmpresas.Name = "BtnEmpresas";
            this.BtnEmpresas.Size = new System.Drawing.Size(296, 49);
            this.BtnEmpresas.TabIndex = 6;
            this.BtnEmpresas.Text = "Empresas";
            this.BtnEmpresas.UseVisualStyleBackColor = true;
            this.BtnEmpresas.Click += new System.EventHandler(this.BtnEmpresas_Click);
            // 
            // BtnAlquiler
            // 
            this.BtnAlquiler.FlatAppearance.BorderSize = 0;
            this.BtnAlquiler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlquiler.ForeColor = System.Drawing.Color.White;
            this.BtnAlquiler.Image = global::Presentacion.Properties.Resources.alquiler_de_signo;
            this.BtnAlquiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlquiler.Location = new System.Drawing.Point(11, 276);
            this.BtnAlquiler.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAlquiler.Name = "BtnAlquiler";
            this.BtnAlquiler.Size = new System.Drawing.Size(296, 49);
            this.BtnAlquiler.TabIndex = 5;
            this.BtnAlquiler.Text = "Alquiler";
            this.BtnAlquiler.UseVisualStyleBackColor = true;
            this.BtnAlquiler.Click += new System.EventHandler(this.BtnAlquiler_Click);
            // 
            // BtnVentas
            // 
            this.BtnVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.ForeColor = System.Drawing.Color.White;
            this.BtnVentas.Image = global::Presentacion.Properties.Resources.carro;
            this.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.Location = new System.Drawing.Point(11, 219);
            this.BtnVentas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(296, 49);
            this.BtnVentas.TabIndex = 4;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // BtnIHospitalarios
            // 
            this.BtnIHospitalarios.FlatAppearance.BorderSize = 0;
            this.BtnIHospitalarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnIHospitalarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIHospitalarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIHospitalarios.ForeColor = System.Drawing.Color.White;
            this.BtnIHospitalarios.Image = global::Presentacion.Properties.Resources.herramientas_medicas;
            this.BtnIHospitalarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIHospitalarios.Location = new System.Drawing.Point(15, 175);
            this.BtnIHospitalarios.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIHospitalarios.Name = "BtnIHospitalarios";
            this.BtnIHospitalarios.Size = new System.Drawing.Size(296, 49);
            this.BtnIHospitalarios.TabIndex = 3;
            this.BtnIHospitalarios.Text = "Productos";
            this.BtnIHospitalarios.UseVisualStyleBackColor = true;
            this.BtnIHospitalarios.Click += new System.EventHandler(this.BtnIHospitalarios_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.Color.White;
            this.BtnClientes.Image = global::Presentacion.Properties.Resources.personas;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(16, 129);
            this.BtnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(296, 49);
            this.BtnClientes.TabIndex = 1;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTitulo.Controls.Add(this.iconominimizar);
            this.BarraTitulo.Controls.Add(this.iconorestaurar);
            this.BarraTitulo.Controls.Add(this.iconomaximizar);
            this.BarraTitulo.Controls.Add(this.iconoSalir);
            this.BarraTitulo.Controls.Add(this.BtnSlide);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(311, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1156, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown_1);
            // 
            // iconominimizar
            // 
            this.iconominimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconominimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconominimizar.Image = global::Presentacion.Properties.Resources.menos;
            this.iconominimizar.Location = new System.Drawing.Point(1045, 8);
            this.iconominimizar.Margin = new System.Windows.Forms.Padding(4);
            this.iconominimizar.Name = "iconominimizar";
            this.iconominimizar.Size = new System.Drawing.Size(31, 22);
            this.iconominimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconominimizar.TabIndex = 4;
            this.iconominimizar.TabStop = false;
            this.iconominimizar.Click += new System.EventHandler(this.iconominimizar_Click);
            // 
            // iconorestaurar
            // 
            this.iconorestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconorestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconorestaurar.Image = global::Presentacion.Properties.Resources.cuadricula;
            this.iconorestaurar.Location = new System.Drawing.Point(1084, 8);
            this.iconorestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.iconorestaurar.Name = "iconorestaurar";
            this.iconorestaurar.Size = new System.Drawing.Size(31, 22);
            this.iconorestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconorestaurar.TabIndex = 3;
            this.iconorestaurar.TabStop = false;
            this.iconorestaurar.Visible = false;
            this.iconorestaurar.Click += new System.EventHandler(this.iconorestaurar_Click);
            // 
            // iconomaximizar
            // 
            this.iconomaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconomaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconomaximizar.Image = global::Presentacion.Properties.Resources.maximizar_ventana;
            this.iconomaximizar.Location = new System.Drawing.Point(1084, 7);
            this.iconomaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.iconomaximizar.Name = "iconomaximizar";
            this.iconomaximizar.Size = new System.Drawing.Size(28, 23);
            this.iconomaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconomaximizar.TabIndex = 2;
            this.iconomaximizar.TabStop = false;
            this.iconomaximizar.Click += new System.EventHandler(this.iconomaximizar_Click);
            // 
            // iconoSalir
            // 
            this.iconoSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoSalir.Image = global::Presentacion.Properties.Resources.boton_cerrar;
            this.iconoSalir.Location = new System.Drawing.Point(1120, 7);
            this.iconoSalir.Margin = new System.Windows.Forms.Padding(4);
            this.iconoSalir.Name = "iconoSalir";
            this.iconoSalir.Size = new System.Drawing.Size(32, 22);
            this.iconoSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoSalir.TabIndex = 1;
            this.iconoSalir.TabStop = false;
            this.iconoSalir.Click += new System.EventHandler(this.iconoSalir_Click);
            // 
            // BtnSlide
            // 
            this.BtnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSlide.Image = global::Presentacion.Properties.Resources.menu;
            this.BtnSlide.Location = new System.Drawing.Point(9, 6);
            this.BtnSlide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSlide.Name = "BtnSlide";
            this.BtnSlide.Size = new System.Drawing.Size(43, 34);
            this.BtnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSlide.TabIndex = 0;
            this.BtnSlide.TabStop = false;
            this.BtnSlide.Click += new System.EventHandler(this.BtnSlide_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbFecha);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(311, 614);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 124);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(111, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cargo: Admistrador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(111, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellidos: Sosa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(111, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombres: Mario Andres";
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(807, 87);
            this.lbFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(275, 25);
            this.lbFecha.TabIndex = 4;
            this.lbFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Presentacion.Properties.Resources.vendedor;
            this.pictureBox7.Location = new System.Drawing.Point(16, 22);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(87, 80);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(812, 14);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(259, 67);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "21:49:45";
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
            // 
            // tmExpandirMenu
            // 
            this.tmExpandirMenu.Interval = 15;
            this.tmExpandirMenu.Tick += new System.EventHandler(this.tmExpandirMenu_Tick);
            // 
            // tmContraerMenu
            // 
            this.tmContraerMenu.Interval = 15;
            this.tmContraerMenu.Tick += new System.EventHandler(this.tmContraerMenu_Tick);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(311, 50);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1156, 564);
            this.PanelContenedor.TabIndex = 7;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 738);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¿";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconominimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconorestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconomaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox BtnSlide;
        private System.Windows.Forms.PictureBox iconominimizar;
        private System.Windows.Forms.PictureBox iconorestaurar;
        private System.Windows.Forms.PictureBox iconomaximizar;
        private System.Windows.Forms.PictureBox iconoSalir;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnAlquiler;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.Button BtnIHospitalarios;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.Button BtnEmpresas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmFechaHora;
        private System.Windows.Forms.Timer tmExpandirMenu;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


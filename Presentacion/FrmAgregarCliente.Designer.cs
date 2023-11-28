namespace Presentacion
{
    partial class FrmAgregarCliente
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
            this.TxtCodigoCliente = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MTxtTelefonoCliente = new System.Windows.Forms.MaskedTextBox();
            this.TxtDireccionCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCedulaCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtApellidoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtCodigoCliente
            // 
            this.TxtCodigoCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtCodigoCliente.Enabled = false;
            this.TxtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoCliente.Location = new System.Drawing.Point(29, 100);
            this.TxtCodigoCliente.Multiline = true;
            this.TxtCodigoCliente.Name = "TxtCodigoCliente";
            this.TxtCodigoCliente.Size = new System.Drawing.Size(180, 25);
            this.TxtCodigoCliente.TabIndex = 0;
            this.TxtCodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.BackColor = System.Drawing.Color.Azure;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(511, 247);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(120, 30);
            this.BtnCancelar.TabIndex = 59;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.BackColor = System.Drawing.Color.Azure;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(385, 247);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 30);
            this.BtnAgregar.TabIndex = 58;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "Telefono Cliente:";
            // 
            // MTxtTelefonoCliente
            // 
            this.MTxtTelefonoCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.MTxtTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtTelefonoCliente.Location = new System.Drawing.Point(29, 244);
            this.MTxtTelefonoCliente.Mask = "000-000-0000";
            this.MTxtTelefonoCliente.Name = "MTxtTelefonoCliente";
            this.MTxtTelefonoCliente.Size = new System.Drawing.Size(180, 28);
            this.MTxtTelefonoCliente.TabIndex = 56;
            this.MTxtTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTxtTelefonoCliente_KeyPress);
            // 
            // TxtDireccionCliente
            // 
            this.TxtDireccionCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccionCliente.Location = new System.Drawing.Point(215, 171);
            this.TxtDireccionCliente.Multiline = true;
            this.TxtDireccionCliente.Name = "TxtDireccionCliente";
            this.TxtDireccionCliente.Size = new System.Drawing.Size(416, 25);
            this.TxtDireccionCliente.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Direccion Cliente:";
            // 
            // TxtCedulaCliente
            // 
            this.TxtCedulaCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedulaCliente.Location = new System.Drawing.Point(29, 171);
            this.TxtCedulaCliente.Multiline = true;
            this.TxtCedulaCliente.Name = "TxtCedulaCliente";
            this.TxtCedulaCliente.Size = new System.Drawing.Size(180, 25);
            this.TxtCedulaCliente.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Cedula Cliente:";
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCliente.Location = new System.Drawing.Point(215, 100);
            this.TxtNombreCliente.Multiline = true;
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(200, 25);
            this.TxtNombreCliente.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nombre Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Codigo Cliente:";
            // 
            // TxtApellidoCliente
            // 
            this.TxtApellidoCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidoCliente.Location = new System.Drawing.Point(431, 100);
            this.TxtApellidoCliente.Multiline = true;
            this.TxtApellidoCliente.Name = "TxtApellidoCliente";
            this.TxtApellidoCliente.Size = new System.Drawing.Size(200, 25);
            this.TxtApellidoCliente.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Apellido Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "AGREGAR CLIENTE";
            // 
            // FrmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(656, 302);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtApellidoCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCodigoCliente);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MTxtTelefonoCliente);
            this.Controls.Add(this.TxtDireccionCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCedulaCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.Load += new System.EventHandler(this.FrmAgregarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtCodigoCliente;
        public System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox MTxtTelefonoCliente;
        public System.Windows.Forms.TextBox TxtDireccionCliente;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtCedulaCliente;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtApellidoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}
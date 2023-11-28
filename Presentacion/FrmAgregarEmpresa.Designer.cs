namespace Presentacion
{
    partial class FrmAgregarEmpresa
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
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCodigoEmpresa = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MTxtTelefonoEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.TxtDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNitEmpresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCorreoEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 20);
            this.label6.TabIndex = 78;
            this.label6.Text = "AGREGAR EMPRESA";
            // 
            // TxtCodigoEmpresa
            // 
            this.TxtCodigoEmpresa.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtCodigoEmpresa.Enabled = false;
            this.TxtCodigoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoEmpresa.Location = new System.Drawing.Point(29, 95);
            this.TxtCodigoEmpresa.Multiline = true;
            this.TxtCodigoEmpresa.Name = "TxtCodigoEmpresa";
            this.TxtCodigoEmpresa.Size = new System.Drawing.Size(149, 25);
            this.TxtCodigoEmpresa.TabIndex = 64;
            this.TxtCodigoEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.BackColor = System.Drawing.Color.Azure;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(511, 242);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(120, 30);
            this.BtnCancelar.TabIndex = 75;
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
            this.BtnAgregar.Location = new System.Drawing.Point(385, 242);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 30);
            this.BtnAgregar.TabIndex = 74;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 73;
            this.label7.Text = "Telefono Empresa:";
            // 
            // MTxtTelefonoEmpresa
            // 
            this.MTxtTelefonoEmpresa.BackColor = System.Drawing.Color.PowderBlue;
            this.MTxtTelefonoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtTelefonoEmpresa.Location = new System.Drawing.Point(29, 239);
            this.MTxtTelefonoEmpresa.Mask = "000-000-0000";
            this.MTxtTelefonoEmpresa.Name = "MTxtTelefonoEmpresa";
            this.MTxtTelefonoEmpresa.Size = new System.Drawing.Size(180, 28);
            this.MTxtTelefonoEmpresa.TabIndex = 72;
            this.MTxtTelefonoEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTxtTelefonoEmpresa_KeyPress);
            // 
            // TxtDireccionEmpresa
            // 
            this.TxtDireccionEmpresa.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtDireccionEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccionEmpresa.Location = new System.Drawing.Point(215, 166);
            this.TxtDireccionEmpresa.Multiline = true;
            this.TxtDireccionEmpresa.Name = "TxtDireccionEmpresa";
            this.TxtDireccionEmpresa.Size = new System.Drawing.Size(416, 25);
            this.TxtDireccionEmpresa.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Direccion Empresa:";
            // 
            // TxtNitEmpresa
            // 
            this.TxtNitEmpresa.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtNitEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNitEmpresa.Location = new System.Drawing.Point(29, 166);
            this.TxtNitEmpresa.Multiline = true;
            this.TxtNitEmpresa.Name = "TxtNitEmpresa";
            this.TxtNitEmpresa.Size = new System.Drawing.Size(180, 25);
            this.TxtNitEmpresa.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Nit Empresa:";
            // 
            // TxtNombreEmpresa
            // 
            this.TxtNombreEmpresa.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreEmpresa.Location = new System.Drawing.Point(193, 95);
            this.TxtNombreEmpresa.Multiline = true;
            this.TxtNombreEmpresa.Name = "TxtNombreEmpresa";
            this.TxtNombreEmpresa.Size = new System.Drawing.Size(200, 25);
            this.TxtNombreEmpresa.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Nombre Empresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Codigo Empresa:";
            // 
            // TxtCorreoEmpresa
            // 
            this.TxtCorreoEmpresa.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtCorreoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreoEmpresa.Location = new System.Drawing.Point(400, 95);
            this.TxtCorreoEmpresa.Multiline = true;
            this.TxtCorreoEmpresa.Name = "TxtCorreoEmpresa";
            this.TxtCorreoEmpresa.Size = new System.Drawing.Size(232, 25);
            this.TxtCorreoEmpresa.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "Correo Empresa:";
            // 
            // FrmAgregarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 302);
            this.Controls.Add(this.TxtCorreoEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCodigoEmpresa);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MTxtTelefonoEmpresa);
            this.Controls.Add(this.TxtDireccionEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNitEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNombreEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarEmpresa";
            this.Load += new System.EventHandler(this.FrmAgregarEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtCodigoEmpresa;
        public System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox MTxtTelefonoEmpresa;
        public System.Windows.Forms.TextBox TxtDireccionEmpresa;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtNitEmpresa;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtNombreEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtCorreoEmpresa;
        private System.Windows.Forms.Label label3;
    }
}
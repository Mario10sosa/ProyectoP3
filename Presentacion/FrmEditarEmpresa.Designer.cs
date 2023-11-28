namespace Presentacion
{
    partial class FrmEditarEmpresa
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
            this.TxtCorreoEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIdEmpresa = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MTxtTelefonoEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.TxtDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNitEmpresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtCorreoEmpresa
            // 
            this.TxtCorreoEmpresa.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtCorreoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreoEmpresa.Location = new System.Drawing.Point(246, 85);
            this.TxtCorreoEmpresa.Multiline = true;
            this.TxtCorreoEmpresa.Name = "TxtCorreoEmpresa";
            this.TxtCorreoEmpresa.Size = new System.Drawing.Size(385, 25);
            this.TxtCorreoEmpresa.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "Correo Empresa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 20);
            this.label6.TabIndex = 93;
            this.label6.Text = "EDITAR EMPRESA";
            // 
            // TxtIdEmpresa
            // 
            this.TxtIdEmpresa.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtIdEmpresa.Enabled = false;
            this.TxtIdEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdEmpresa.Location = new System.Drawing.Point(203, 54);
            this.TxtIdEmpresa.Multiline = true;
            this.TxtIdEmpresa.Name = "TxtIdEmpresa";
            this.TxtIdEmpresa.Size = new System.Drawing.Size(33, 25);
            this.TxtIdEmpresa.TabIndex = 81;
            this.TxtIdEmpresa.Visible = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.BackColor = System.Drawing.Color.Azure;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(511, 232);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(120, 30);
            this.BtnCancelar.TabIndex = 92;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.BackColor = System.Drawing.Color.Azure;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(385, 232);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(120, 30);
            this.BtnEditar.TabIndex = 91;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 90;
            this.label7.Text = "Telefono Empresa:";
            // 
            // MTxtTelefonoEmpresa
            // 
            this.MTxtTelefonoEmpresa.BackColor = System.Drawing.Color.PowderBlue;
            this.MTxtTelefonoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTxtTelefonoEmpresa.Location = new System.Drawing.Point(29, 229);
            this.MTxtTelefonoEmpresa.Mask = "000-000-0000";
            this.MTxtTelefonoEmpresa.Name = "MTxtTelefonoEmpresa";
            this.MTxtTelefonoEmpresa.Size = new System.Drawing.Size(180, 28);
            this.MTxtTelefonoEmpresa.TabIndex = 89;
            this.MTxtTelefonoEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTxtTelefonoEmpresa_KeyPress);
            // 
            // TxtDireccionEmpresa
            // 
            this.TxtDireccionEmpresa.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtDireccionEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccionEmpresa.Location = new System.Drawing.Point(215, 156);
            this.TxtDireccionEmpresa.Multiline = true;
            this.TxtDireccionEmpresa.Name = "TxtDireccionEmpresa";
            this.TxtDireccionEmpresa.Size = new System.Drawing.Size(416, 25);
            this.TxtDireccionEmpresa.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 87;
            this.label5.Text = "Direccion Empresa:";
            // 
            // TxtNitEmpresa
            // 
            this.TxtNitEmpresa.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtNitEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNitEmpresa.Location = new System.Drawing.Point(29, 156);
            this.TxtNitEmpresa.Multiline = true;
            this.TxtNitEmpresa.Name = "TxtNitEmpresa";
            this.TxtNitEmpresa.Size = new System.Drawing.Size(180, 25);
            this.TxtNitEmpresa.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Nit Empresa:";
            // 
            // TxtNombreEmpresa
            // 
            this.TxtNombreEmpresa.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreEmpresa.Location = new System.Drawing.Point(29, 85);
            this.TxtNombreEmpresa.Multiline = true;
            this.TxtNombreEmpresa.Name = "TxtNombreEmpresa";
            this.TxtNombreEmpresa.Size = new System.Drawing.Size(211, 25);
            this.TxtNombreEmpresa.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Nombre Empresa:";
            // 
            // FrmEditarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 283);
            this.Controls.Add(this.TxtCorreoEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtIdEmpresa);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MTxtTelefonoEmpresa);
            this.Controls.Add(this.TxtDireccionEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNitEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNombreEmpresa);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtCorreoEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtIdEmpresa;
        public System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox MTxtTelefonoEmpresa;
        public System.Windows.Forms.TextBox TxtDireccionEmpresa;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtNitEmpresa;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtNombreEmpresa;
        private System.Windows.Forms.Label label2;
    }
}
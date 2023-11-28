namespace Presentacion
{
    partial class FrmEditarUsuario
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
            this.TxtConfirmar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.TxtContra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtId_Usuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtConfirmar
            // 
            this.TxtConfirmar.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirmar.Location = new System.Drawing.Point(89, 341);
            this.TxtConfirmar.Multiline = true;
            this.TxtConfirmar.Name = "TxtConfirmar";
            this.TxtConfirmar.PasswordChar = '*';
            this.TxtConfirmar.Size = new System.Drawing.Size(273, 25);
            this.TxtConfirmar.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 20);
            this.label5.TabIndex = 91;
            this.label5.Text = "Confirmar Contraseña:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(89, 92);
            this.TxtNombre.Multiline = true;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(273, 25);
            this.TxtNombre.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 89;
            this.label4.Text = "Nombre:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(89, 152);
            this.TxtApellido.Multiline = true;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(273, 25);
            this.TxtApellido.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = "Apellido: ";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.BackColor = System.Drawing.Color.Azure;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(242, 393);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(120, 30);
            this.BtnCancelar.TabIndex = 86;
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
            this.BtnEditar.Location = new System.Drawing.Point(89, 393);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(120, 30);
            this.BtnEditar.TabIndex = 85;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // TxtContra
            // 
            this.TxtContra.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContra.Location = new System.Drawing.Point(89, 273);
            this.TxtContra.Multiline = true;
            this.TxtContra.Name = "TxtContra";
            this.TxtContra.PasswordChar = '*';
            this.TxtContra.Size = new System.Drawing.Size(273, 25);
            this.TxtContra.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Contraseña:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(89, 213);
            this.TxtUsuario.Multiline = true;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(273, 25);
            this.TxtUsuario.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 80;
            this.label6.Text = "EDITAR USUARIO";
            // 
            // TxtId_Usuario
            // 
            this.TxtId_Usuario.BackColor = System.Drawing.Color.PowderBlue;
            this.TxtId_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId_Usuario.Location = new System.Drawing.Point(326, 66);
            this.TxtId_Usuario.Multiline = true;
            this.TxtId_Usuario.Name = "TxtId_Usuario";
            this.TxtId_Usuario.ReadOnly = true;
            this.TxtId_Usuario.Size = new System.Drawing.Size(36, 25);
            this.TxtId_Usuario.TabIndex = 92;
            this.TxtId_Usuario.Visible = false;
            // 
            // FrmEdiatrUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 453);
            this.Controls.Add(this.TxtId_Usuario);
            this.Controls.Add(this.TxtConfirmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.TxtContra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEdiatrUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEdiatrUsuario";
            this.Load += new System.EventHandler(this.FrmEdiatrUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtConfirmar;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button BtnCancelar;
        public System.Windows.Forms.Button BtnEditar;
        public System.Windows.Forms.TextBox TxtContra;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtId_Usuario;
    }
}
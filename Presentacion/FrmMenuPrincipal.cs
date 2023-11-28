using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        int lx, ly;
        int sw, sh;

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 233)
            {
                MenuVertical.Width = 75;
            }
            else
                MenuVertical.Width = 233;
                
        }

        private void iconoSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void iconomaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconorestaurar.Visible = true;
            iconomaximizar.Visible = false;
        }

        private void iconorestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            iconorestaurar.Visible = false;
            iconomaximizar .Visible = true;
        }

        private void iconominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (MenuVertical.Width >= 233)
                this.tmExpandirMenu.Stop();
            else
                MenuVertical.Width = MenuVertical.Width + 5;
        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (MenuVertical.Width <= 75)
                this.tmContraerMenu.Stop();
            else
                MenuVertical.Width = MenuVertical.Width - 5;
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmClientes());
        }

        private void BtnVendedores_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel();
        }

        private void BtnIHospitalarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmProductos());
        }

        private void BtnAlquiler_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAlquiler());
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmVentas());
        }

        private void BtnEmpresas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmEmpresas());
        }
        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmUsuarios());
        }




    }
}

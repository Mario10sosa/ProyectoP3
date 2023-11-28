using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPdf : Form
    {
        public FrmPdf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Herramientas herramientas = new Herramientas();
            herramientas.imprimir();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

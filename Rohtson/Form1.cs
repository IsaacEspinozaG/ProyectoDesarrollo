using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rohtson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            uc_cliente1.BringToFront();
        }

        private void Fecha_hora_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToLongTimeString();
            fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            uc_pedidos1.BringToFront();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            inicio1.BringToFront();
        }

        private void btn_gastos_Click(object sender, EventArgs e)
        {
            uc_gastos1.BringToFront();
        }

        private void btn_salidas_Click(object sender, EventArgs e)
        {
            uc_salidas1.BringToFront();
        }
    }
}

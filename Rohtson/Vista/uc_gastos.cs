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
    public partial class uc_gastos : UserControl
    {
        public uc_gastos()
        {
            InitializeComponent();
            Panel_registrar.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Panel_registrar.Visible = true;
            Panel_registrar.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel_nuevo.BringToFront();
            Panel_registrar.Visible = false;
        }

        private void uc_gastos_Load(object sender, EventArgs e)
        {

        }
    }
}

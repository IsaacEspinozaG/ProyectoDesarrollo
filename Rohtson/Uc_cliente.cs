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
    public partial class Uc_cliente : UserControl
    {
        public Uc_cliente()
        {
            InitializeComponent();
            panel_agre.BringToFront();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            panel_agre.Visible = true;
            panel_agre.BringToFront();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            panel_mod.BringToFront(); 
            panel_agre.Visible = false;
        }

        private void Uc_cliente_Load(object sender, EventArgs e)
        {

        }
    }
}

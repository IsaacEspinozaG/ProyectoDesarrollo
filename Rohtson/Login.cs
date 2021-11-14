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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalirProg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {
            Form Menu = new Form1();
            Menu.Show();
            this.Hide();
        }
    }
}

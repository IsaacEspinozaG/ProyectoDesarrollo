﻿using System;
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
            if ((textBox1.Text == "Claudia") && (textBox2.Text == "1234"))
            {
                Form Menu = new Form1();
                Menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            
        }
    }
}

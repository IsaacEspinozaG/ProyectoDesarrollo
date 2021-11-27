using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Rohtson
{
    public partial class uc_pedidos : UserControl
    {
        public uc_pedidos()
        {
            InitializeComponent();
        }

        SqlConnection Conexion = new SqlConnection("SERVER=DESKTOP-I6M7LDG;DATABASE=Rohtson;Integrated security=true");

        private void uc_pedidos_Load(object sender, EventArgs e)
        {

        }
    }
}

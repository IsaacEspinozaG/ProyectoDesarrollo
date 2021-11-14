using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection Conexion = new SqlConnection("");
        string cnnstring = System.Configuration.ConfigurationManager.ConnectionStrings[""].ConnectionString;

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
            Conexion.Open();
            SqlCommand cmd = Conexion.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from....";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            
            dgvClientes.DataSource = dt;

            Conexion.Close();
        }

        //private void btnGuardarCliente_Click(object sender, EventArgs e)
        //{
        //    Conexion.Open();

        //    int flag = 0;
        //    string Cadena = "Exec INSERTA_VEHICULO..." + txtMatricula + txtMarca + txtModelo + "";

        //    SqlCommand comando = new SqlCommand (Cadena, Conexion);
        //    flag = comando.ExecuteNonQuery();

        //    if (flag == 0)
        //    {
        //        MessageBox.Show("Se agrego");
        //    }
        //    else 
        //    {
        //        MessageBox.Show("No se agrego");
                
        //    }

        //    Conexion.Close();
        //}

        private void btnGuardarCliente_Click_1(object sender, EventArgs e)
        {
            Conexion.Open();

            int flag = 0;
            string Cadena = "Exec INSERTA_VEHICULO..." + txtNombreCliente + txtDireccionCliente + txtCorreoCliente + txtTelefonoCliente + "";

            SqlCommand comando = new SqlCommand(Cadena, Conexion);
            flag = comando.ExecuteNonQuery();

            if (flag == 0)
            {
                MessageBox.Show("Se agrego");
            }
            else
            {
                MessageBox.Show("No se agrego");

            }

            Conexion.Close();
        }
    }
}

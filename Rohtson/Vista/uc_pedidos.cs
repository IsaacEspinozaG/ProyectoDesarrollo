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
using Rohtson.Controlador;
using Rohtson.Modelo.DAO;

namespace Rohtson
{
    public partial class uc_pedidos : UserControl
    {
        public uc_pedidos()
        {
            InitializeComponent();
            PedidosController ctrl1 = new PedidosController(this);

            CargarCombobox car = new CargarCombobox();
            gbx_IDCli.DataSource = car.CargarClientes();
            gbx_IDCli.DisplayMember = "Nombre";
            gbx_IDCli.ValueMember = "Id_Cliente";
        }

        public class CargarCombobox
        {
            SqlConnection Conexion = new SqlConnection("SERVER=DESKTOP-I6M7LDG;DATABASE=Rohtson;Integrated security=true");
            public DataTable CargarClientes()
            {
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGARCOMBOBOX", Conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        } 

        SqlConnection Conexion = new SqlConnection("SERVER=DESKTOP-I6M7LDG;DATABASE=Rohtson;Integrated security=true");

        private void uc_pedidos_Load(object sender, EventArgs e) 
        {
            label2.Text = gbx_IDCli.SelectedValue.ToString();     
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (txtcantidad.Text == "")
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    Conexion.Open();
                    SqlCommand cmc = Conexion.CreateCommand();
                    SqlCommand cmd = Conexion.CreateCommand();

                    cmc.CommandType = CommandType.Text;
                    cmc.CommandText = "Insert into PEDIDOS (ID_Cliente, Fecha_entrega, Cantidad) values (" + Convert.ToInt32(label2.Text) + ",'" + guna2DateTimePicker2.Value.ToShortDateString() + "'," + txtcantidad.Text + ")";

                    int f = cmc.ExecuteNonQuery();

                    if (f == 1)
                    {
                        MessageBox.Show("El pedido se agrego correctamente");

                        txtcantidad.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error");
                    }

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from PEDIDOS";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvPedidos.DataSource = dt;

                    Conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void gbx_IDCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = gbx_IDCli.SelectedValue.ToString();
        }
    }
}

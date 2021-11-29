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
using System.Text.RegularExpressions;
using Rohtson.Controlador;
using Rohtson.Modelo.DAO;

namespace Rohtson
{
    public partial class Uc_cliente : UserControl 
    {
        
        public Uc_cliente()
        {
            InitializeComponent();
            ClienteController ctrl = new ClienteController(this);
            panel_agre.BringToFront();
        }
        SqlConnection Conexion = new SqlConnection("SERVER=DESKTOP-I6M7LDG;DATABASE=Rohtson;Integrated security=true");

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

        private void Uc_cliente_Load(object sender, EventArgs e) { }

        //Validar que solo se puedan escribir 10 digitos
        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        //Validar si el correo tiene el formato adecuado
        public Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //Validar que solo se puedan numero en el campo telefono al modificar
        private void txtModTelefono_KeyPress(object sender, KeyPressEventArgs e)
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


        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if(txtNombreCliente.Text == "" || txtDireccionCliente.Text == "" || txtCorreoCliente.Text == "" || txtTelefonoCliente.Text == "")
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {                
                if (email_bien_escrito(txtCorreoCliente.Text) == false)
                {
                    MessageBox.Show("Ingrese un correo valido");
                }
                else
                {
                    try
                    {
                        Conexion.Open();
                        SqlCommand cmc = Conexion.CreateCommand();
                        SqlCommand cmd = Conexion.CreateCommand();

                        cmc.CommandType = CommandType.Text;
                        cmc.CommandText = "Insert into CLIENTES (Nombre,Direccion,Correo,Telefono) values ('" + txtNombreCliente.Text + "','" + txtDireccionCliente.Text + "','" + txtCorreoCliente.Text + "','" + txtTelefonoCliente.Text + "')";

                        int f = cmc.ExecuteNonQuery();

                        if (f == 1)
                        {
                            MessageBox.Show("El cliente se agrego correctamente");

                            txtNombreCliente.Text = "";
                            txtDireccionCliente.Text = "";
                            txtCorreoCliente.Text = "";
                            txtTelefonoCliente.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error");
                        }

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Select * from CLIENTES";
                        cmd.ExecuteNonQuery();

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(dt);

                        dgvClientes.DataSource = dt;

                        Conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }  
        }

        //Boton para modificar
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtModNombre.Text == "" || txtModDireccion.Text == "" || txtModCorreo.Text == "" || txtModTelefono.Text == "")
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                if (email_bien_escrito(txtModCorreo.Text) == false)
                {
                    MessageBox.Show("Ingrese un correo valido");
                }
                else
                {
                    try
                    {
                        Conexion.Open();
                        SqlCommand cmc = Conexion.CreateCommand();
                        SqlCommand cmd = Conexion.CreateCommand();

                        cmc.CommandType = CommandType.Text;
                        cmc.CommandText = "UPDATE CLIENTES SET Nombre = '" + txtModNombre.Text + "', Direccion = '" + txtModDireccion.Text + "', Correo = '" + txtModCorreo.Text + "', Telefono ='" + txtModTelefono.Text + "' WHERE Id_Cliente = '" + txtIdCliente.Text + "'";

                        int f = cmc.ExecuteNonQuery();

                        if (f == 1)
                        {
                            MessageBox.Show("El cliente se modifico correctamente");

                            txtIdCliente.Text = "";
                            txtModNombre.Text = "";
                            txtModDireccion.Text = "";
                            txtModCorreo.Text = "";
                            txtModTelefono.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error");
                        }

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Select * from CLIENTES";
                        cmd.ExecuteNonQuery();

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(dt);

                        dgvClientes.DataSource = dt;

                        Conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        
    }
}


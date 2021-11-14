using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rohtson.Conexion
{
     class Conexion
    {
        //Conexion con la base de datos...
        SqlConnection con = new SqlConnection("");

        //Procedimiento para abrir la conexion con la base de datos...
        public void conectar()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Procedimiento que cierra la conexion con la base de datos...
        public void desconectar() 
        { 
            con.Close();
        }
    }
}

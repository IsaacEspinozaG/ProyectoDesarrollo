using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Rohtson.Modelo.DAO
{
    internal class ConexionBD
    {
        protected SqlConnection Conexion = new SqlConnection("SERVER=DESKTOP-I6M7LDG;DATABASE=Rohtson;Integrated security=true");
    }
}

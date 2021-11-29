using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Rohtson.Modelo.DTO;

namespace Rohtson.Modelo.DAO
{
    internal class PedidosDao : ConexionBD
    {
        SqlDataReader LeerFilas1;
        SqlCommand Comando = new SqlCommand();

        //METODOS CRUD
        public List<PedidosDto> VerPedidos(string Condicion)
        {
            Comando.Connection = Conexion;
            Comando.CommandText = "VerPedidos";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Condicion", Condicion);

            Conexion.Open();
            LeerFilas1 = Comando.ExecuteReader();
            List<PedidosDto> ListaGenerica = new List<PedidosDto>();
            while (LeerFilas1.Read())
            {
                ListaGenerica.Add(new PedidosDto
                {
                    ID_Cliente = LeerFilas1.GetInt32(0),
                    ID_Pedido = LeerFilas1.GetInt32(1),
                    Fecha_entrega = LeerFilas1.GetDateTime(2),
                    Cantidad = LeerFilas1.GetInt32(3)
                });
            }
            LeerFilas1.Close();
            Conexion.Close();
            return ListaGenerica;
        }
    }
}

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
    internal class ClienteDao:ConexionBD
    {
        SqlDataReader LeerFilas;
        SqlCommand Comando = new SqlCommand();

        //METODOS CRUD
        public List<ClienteDto> VerRegistros(string Condicion)
        {
            Comando.Connection = Conexion;
            Comando.CommandText = "VerRegistros";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Condicion", Condicion);

            Conexion.Open();    
            LeerFilas = Comando.ExecuteReader();    
            List<ClienteDto> ListaGenerica = new List<ClienteDto>();
            while (LeerFilas.Read())
            {
                ListaGenerica.Add(new ClienteDto
                {
                    Id_Cliente = LeerFilas.GetInt32(0),
                    Nombre = LeerFilas.GetString(1),
                    Direccion = LeerFilas.GetString(2),
                    Correo = LeerFilas.GetString(3),
                    Telefono = LeerFilas.GetString(4)
                }); 
            }
            LeerFilas.Close();
            Conexion.Close();
            return ListaGenerica;
        }
        public void Insert() { }
        public void Edit() { }
        public void Delete() { }
    }
}

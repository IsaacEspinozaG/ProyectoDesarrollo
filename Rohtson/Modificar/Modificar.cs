using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace Siniestro
{
    public class Modificar
    {
        //Representa una coleccion de pares de clave y valor
        Hashtable hsRegistros = new Hashtable();
        //Nombre de la tabla a la que vamos a actualizar.
        string strNombreTabla, strCampoLlave, strValorLlave;
        string cnnString = System.Configuration.ConfigurationManager.ConnectionStrings[""].ConnectionString;
        //Constructor
        public Modificar(string NombreTabla, string CampoLlave, string ValorLlave)
        {
            this.strNombreTabla = NombreTabla;
            this.strCampoLlave = CampoLlave;
            this.strValorLlave = ValorLlave;
        }

        public void Agregar(string strColumna, object strValor)
        {
            hsRegistros.Add(strColumna, strValor);
        }

        public void Executar(string strQuery)
        {
            using (SqlConnection sqlConn = new SqlConnection(cnnString))
            {
                using (SqlCommand sqlCom = new SqlCommand(strQuery, sqlConn))
                {
                    sqlConn.Open();
                    sqlCom.ExecuteNonQuery();
                    sqlConn.Close();
                }
            }
        }
        public override string ToString()
        {
            StringBuilder strBuilderValores = new StringBuilder();
            IDictionaryEnumerator deRegistro = hsRegistros.GetEnumerator();
            bool Primero = true;
            while (deRegistro.MoveNext())
            {
                if (Primero)
                {
                    Primero = false;
                }
                else
                {
                    strBuilderValores.Append(", ");
                }
                strBuilderValores.Append(deRegistro.Key.ToString() + "= '" + deRegistro.Value.ToString() + "'");
            }
            return "UPDATE dbo." + strNombreTabla + " SET " + strBuilderValores + " WHERE " + strCampoLlave + " = " + strValorLlave + ";";
        }
    }
}
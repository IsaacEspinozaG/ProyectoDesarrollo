using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohtson.Modelo.DTO
{
    internal class PedidosDto
    {
        //Atributos
        int _ID_Pedido;
        int _ID_Cliente;
        DateTime _Fecha_entrega;
        int _Cantidad;

        //PROPIEDADES GETTERS AND SETTERS
        public int ID_Pedido { get => _ID_Pedido; set => _ID_Pedido = value; }
        public int ID_Cliente { get => _ID_Cliente; set => _ID_Cliente = value; }
        public DateTime Fecha_entrega { get => _Fecha_entrega; set => _Fecha_entrega = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
    }
}

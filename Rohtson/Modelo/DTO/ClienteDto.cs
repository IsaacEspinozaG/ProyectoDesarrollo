using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rohtson.Modelo.DTO
{
    internal class ClienteDto
    {
        //ATRIBUTOS
        int _Id_Cliente;
        string _Nombre;
        string _Direccion;
        string _Correo;
        string _Telefono;

        //PROPIEDADES GETTERS AND SETTERS
        public int Id_Cliente { get => _Id_Cliente; set => _Id_Cliente = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }

        
    }
}

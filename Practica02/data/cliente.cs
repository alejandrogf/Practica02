using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02.data
{
    public class Cliente
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        //Constructor
        public Cliente(string nombre, string dni, string telefono)
        {
            Nombre = nombre;
            Dni = dni;
            Telefono = telefono;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02.data
{
    public abstract class Producto
    {
        public string Cliente { get; set; }
        public double Saldo { get; set; }

        //Constructor
        protected Producto(string codCliente, double saldo)
        {
            Cliente = codCliente;
            Saldo = saldo;
        }

        public void Detalles()
        {
            Console.WriteLine ("{0}Código de Cliente: {1}" +
                              "{0}Saldo Disponible: {2}", Environment.NewLine, Cliente, Saldo);
        }

        public abstract double Ingresar();
        public abstract double Retirada();

    }
}

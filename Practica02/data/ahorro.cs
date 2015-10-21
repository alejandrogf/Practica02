using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02.data
{
    public class Ahorro:Producto
    {
        public string Bonificacion { get; set; }
        public string Penalizacion { get; set; }

        public Ahorro(string codCliente, double saldo) : base(codCliente, saldo)
        {
        }

        public override double Ingresar()
        {
            throw new NotImplementedException();
        }

        public override double Retirada()
        {
            throw new NotImplementedException();
        }
    }
}

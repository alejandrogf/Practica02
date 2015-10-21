using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02.data
{
    public class Cuenta:Producto
    {
        public int Credito { get; set; }
        public double TipoInteres { get; set; }

        public Cuenta(string codCliente, double saldo) : base(codCliente, saldo)
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

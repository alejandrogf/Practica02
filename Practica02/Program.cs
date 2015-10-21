using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica02.data;

namespace Practica02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pantalla inicial, donde pido datos para crear el cliente
            Console.WriteLine("Bienvenido. Por favor, ingrese sus datos\n\n");
            Console.WriteLine("\nNombre:");
            var nombre = Console.ReadLine();
            Console.WriteLine("\nDNI:");
            var dni = Console.ReadLine();
            Console.WriteLine("\nTelefono:");
            var telefono = Console.ReadLine();
            //Creo el nuevo cliente llamando al constructor.
            var nuevoCliente = new Cliente(nombre, dni, telefono);


            //Creo los productos, llamando al constructor del mismo, 
            //Le paso un codigo cliente e importe inicial (0)
            double saldo = 0;
            string codCliente = nuevoCliente.Nombre.Substring(0, 2) +
                                nuevoCliente.Dni.Substring(0, 2) +
                                nuevoCliente.Telefono.Substring(0, 2);

            var nuevaCuentaCredito = new Cuenta(codCliente, saldo);
            var nuevaCuentaAhorro = new Ahorro(codCliente, saldo);

            nuevaCuentaAhorro.Detalles();
            Console.ReadLine();
        }
    }
}

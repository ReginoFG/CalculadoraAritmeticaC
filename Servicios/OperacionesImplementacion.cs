using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCalculadoraAritmetica.Servicios
{
    internal class OperacionesImplementacion : OperacionesInterfaz
    {
         private double pedirOperando()
        {
            double operando;
            Console.WriteLine("Indique un operando: ");
            operando = double.Parse(Console.ReadLine());
            return operando;
        }
        public void dividir()
        {
            double operandoUno = pedirOperando();
            double operandoDos = pedirOperando();
            double resultado = operandoUno / operandoDos;
            Console.WriteLine(resultado);
        }

        public void multiplicar()
        {
            double operandoUno = pedirOperando();
            double operandoDos = pedirOperando();
            double resultado = operandoUno * operandoDos;
            Console.WriteLine(resultado);
        }

        public void restar()
        {
            double operandoUno = pedirOperando();
            double operandoDos = pedirOperando();
            double resultado = operandoUno - operandoDos;
            Console.WriteLine(resultado);
        }

        public void sumar()
        {
            double operandoUno = pedirOperando();
            double operandoDos = pedirOperando();
            double resultado = operandoUno + operandoDos;
            Console.WriteLine(resultado);
        }
    }
}

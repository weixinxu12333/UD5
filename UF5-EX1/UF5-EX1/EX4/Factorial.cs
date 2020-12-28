using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class Factorial
    {
        public void inicio() 
        {
            Console.WriteLine("Introduce un numero para calcular factorial:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado es " + calcularFactorial(num));
        }

        public int calcularFactorial(int num)
        {
            int resultado = 1;
            int suma;

            for (int i = 1; i <= num; i++)
            {
                suma = resultado * i;
                resultado = suma;
            }

            return resultado;
        }
    }
}

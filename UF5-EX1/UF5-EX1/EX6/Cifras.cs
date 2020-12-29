using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class Cifras
    {
        public void inicio()
        {
            Console.WriteLine("Introduce un numero para calcular cifras:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("El resultado es " + calcularCifras(num));
            }
            else
            {
                Console.WriteLine("Numero ha de ser positivo");
            }
            
        }

        public int calcularCifras(int num)
        {
            return num.ToString().Length;
        }
    }
}

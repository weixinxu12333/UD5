using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class Primo
    {
        public void inicio() 
        {
            Console.WriteLine("Introduce un numero para ver si es primo o no:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El numero {(esPrimo(num) ? "no " : "")}es primo");
        }
        public bool esPrimo(int num) {
            for (int i = 2; i < num; i++)
                if (num % i == 0) return true;
            return false;
        }
    }
}

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
            Console.WriteLine($"El numero {(!Helpers.isPrime(num) ? "no " : "")}es primo");
        }
    }
}

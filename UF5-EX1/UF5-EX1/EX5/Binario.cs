using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class Binario
    {
        public void inicio() 
        {
            Console.WriteLine("Introduce un numero para calcular binario:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado es " + calcularBinario(num));
        }

        public string calcularBinario(int num)
        {
            int mod = 0, div = 0;
            string resultado = "";

            while (num > 0)
            {
                mod = num % 2;
                num = num / 2;
                resultado = mod.ToString() + resultado;
            }

            return resultado;
        }
    }
}

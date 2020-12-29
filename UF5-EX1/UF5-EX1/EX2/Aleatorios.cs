using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class Aleatorios
    {
        Random rd = new Random();
       List<int> lista = new List<int>(); 

        public void inicio() 
        {
            Console.WriteLine("Escibe el rango de los numeros que quieres generar. Solo numeros enteros, sino saldra error.");
            
            Console.WriteLine("Cuantos numeros quieres?");
            int num = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Minimo:");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maximo:");
            int max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numeros generados:");
            for (int i = 0; i < num; i++)
            {
                lista.Add(rd.Next(min, max));
                Console.WriteLine(lista[i]);
            }
            
        }
    }
}

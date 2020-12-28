using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class EX9_ARRAY2
    {
        public void array2()
        {
            Console.WriteLine("Escribe longitud de un array, y vamos a rellenar los valores a mano: ");
            int longitud = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int[longitud];

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("Posicion {0}, valor a introducir:", i);
                array2[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Posicion {0}, con valor: {1}", i, array2[i]);
                Console.WriteLine("------------------------------");
            }
        }
    }
}

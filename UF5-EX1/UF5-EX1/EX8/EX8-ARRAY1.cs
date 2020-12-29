using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class EX8_ARRAY1
    {
        public void array1() 
        {
            Console.WriteLine("Escribe longitud de un array, y vamos a rellenar los valores su posicion: ");
            int longitud = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[longitud];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i;
                Console.WriteLine(array1[i]);
            }

        }
    }
}

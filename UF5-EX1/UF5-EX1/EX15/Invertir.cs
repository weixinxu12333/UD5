using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class Invertir
    {
        public void invertirArrays()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = array1;

            Console.WriteLine("Array original");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            Array.Reverse(array2);

            Console.WriteLine("Array invertido");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
        }
    }
}

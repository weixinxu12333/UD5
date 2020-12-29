using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class EX21_ARRAY10
    {
        public void inicio()
        {
            var size = Helpers.ReadNumber("Introduce el tamaño del array:");
            int[] arr1 = new int[size];
            arr1 = Helpers.FillArray(arr1, () => Helpers.RandomBetween(1, 300+1));

            int[] arr2 = new int[size];
            int digit = Helpers.ReadNumber("Introduce un digito:");

            if (digit < 10 && digit >= 0)
            {
                CheckArray(arr1, arr2, digit);
                Console.WriteLine("Array que contiene digito :" + digit);
                Helpers.PrintArray(arr2);
            }
            else
                Console.WriteLine("Numero introducido error");

        }

        private int[] CheckArray(int[] arr1, int[] arr2, int digit)
        {
            int c = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                int lastDigit = arr1[i] % 10;
                if (lastDigit == digit)
                {
                    arr2[c] = arr1[i];
                    c++;
                }
            }
            return arr2;
        }
    }
}

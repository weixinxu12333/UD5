using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    public class EX20_ARRAY9
    {
        public void inicio()
        {
            var size = Helpers.ReadNumber("Introduce el tamaño del array:");
            int[] arr1 = new int[size], arr2 = new int[size];
            arr1 = Helpers.FillArray(arr1, () => Helpers.RandomBetween(0, 10));
            arr2 = arr1;
            arr1 = Helpers.FillArray(new int[size], () => Helpers.RandomBetween(0, 10));
            int[] arr3 = MultiplicaArrays(arr1, arr2);
            Console.WriteLine("Primer array:");
            Helpers.PrintArray(arr1);
            Console.WriteLine("Segundo array:");
            Helpers.PrintArray(arr2);
            Console.WriteLine("Tercero array:");
            Helpers.PrintArray(arr3);
        }

        private int[] MultiplicaArrays(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i] * arr2[i];
            }
            return arr3;
        }
    }
}

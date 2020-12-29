using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class EX19_ARRAY8
    {
        public void inicio()
        {
            Console.WriteLine("Indica longitud de array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Entre que numeros? Indica el menor:");
            int men = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ahora el mayor:");
            int may = Convert.ToInt32(Console.ReadLine());

            rellenarArray(arr, men, may);
            mostrarArray(arr);
        }
        public int[] rellenarArray(int[] arr, int men, int may)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = generarPrimo(men, may);
            }
            return arr;
        }
        public int[] mostrarArray(int[] arr)
        {
            int numMayor = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Posicion {0}, valor {1}", i, arr[i]);
                if (arr[i] > numMayor) numMayor = arr[i];
            }
            Console.WriteLine("Numero mayor " + numMayor);
            return arr;
        }

        private int generarPrimo(int men, int may)
        {
            Random rd = new Random();
            int num;
            do
            {
                num = rd.Next(men, may + 1);
            } while (!Helpers.isPrime(num));
            return num;
        }

    }
}

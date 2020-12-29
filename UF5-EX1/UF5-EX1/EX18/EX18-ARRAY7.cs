using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class EX18_ARRAY7
    {
        public void inicio()
        {
            Console.WriteLine("Indica longitud de array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            rellenarArray(arr);
            mostrarArray(arr);
        }
        public int[] rellenarArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = generarNumeros();
            }
            return arr;
        }
        public int[] mostrarArray(int[] arr)
        {
            int suma = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Posicion {0}, valor {1}", i, arr[i]);
                suma += arr[i];
            }
            Console.WriteLine("Suma total " + suma);
            return arr;
        }
        private int generarNumeros() 
        {
            Random rd = new Random();
            int num = rd.Next(0,10);
            return num;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class ArrayManualmente
    {

    public void inicio() 
        {
            int[] arr = new int[10];
            rellenarArray(arr);
            mostrarArray(arr);
        }
        public int[] rellenarArray(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Introduce un numero entero:");
                int n = Convert.ToInt32(Console.ReadLine());
                arr[i] = n;
            }
            return arr;
        }

        public int[] mostrarArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Posicion {0}, valor {1}", i, arr[i]);
            }
            return arr;
        }
    }
}

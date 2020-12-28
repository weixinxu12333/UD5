using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class EX14_ARRAY6
    {
        public void inicio()
        {
            Console.WriteLine("Introduce un numero para longitud de un array:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un numero, comprobamos si existe en el array");
            int n = Convert.ToInt32(Console.ReadLine());
            comprobarArray(rellenarArray(num), n);
        }

        public int[] rellenarArray(int num)
        {
            int[] array5 = new int[num];
            Random rd = new Random();

            for (int i = 0; i < array5.Length; i++)
            {
                array5[i] = rd.Next(1, 10);
                Console.WriteLine("Posicion {0}, valor {1}", i, array5[i]);
            }

            return array5;
        }

        public void comprobarArray(int[] array, int num)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num) Console.WriteLine("Si que existeix");
            }
        }
    }
}

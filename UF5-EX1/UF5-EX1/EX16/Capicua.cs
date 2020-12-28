using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class Capicua
    {
        public void inicio()
        {
            int[] arr = new int[4];
            rellenarArray(arr);
            calcularCapicua(arr);
        }
        public int[] rellenarArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Random rd = new Random();
                arr[i] = rd.Next(1,3);
                Console.WriteLine(arr[i]);
            }
            return arr;
        }
        public void calcularCapicua(int[] arr)
        {
            int inici = 0, final = arr.Length - 1;
            bool esCapicua = true;

            while (inici <= final && esCapicua)
            {
                esCapicua = (arr[inici++] == arr[final--]);
            }

            if (esCapicua) 
                Console.WriteLine("Es capicua");
            else
                Console.WriteLine("No es capicua");
        }

    }
}

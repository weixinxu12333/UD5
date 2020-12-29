using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class EX12_ARRAY4
    {
        public void array4()
        {
            int[] array4 = new int[10];
            int suma = 0;

            for (int i = 0; i < array4.Length; i++)
            {
                array4[i] = i;
                suma = suma + array4[i];
            }

            Console.WriteLine("Suma total = " + (suma / 10));
        }
    }
}

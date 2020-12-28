using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class EX11_ARRAY3
    {
        public void array3()
        {
            int[] array3 = new int[10];
            int suma = 0;

            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = i;
                suma = suma + array3[i];
            }

            Console.WriteLine("Suma total = " + suma);
        }
    }
}

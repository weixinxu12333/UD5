using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class Tabla
    {
        public void inicio() 
        {
            Console.WriteLine("Introduce un numero y vamos a crear tabla de calculo:");
            int num = Convert.ToInt32(Console.ReadLine());
            calcularTabla(num);
        }

        public void calcularTabla(int num)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}" , num, i, (num * i) );
            }
        }
    }
}

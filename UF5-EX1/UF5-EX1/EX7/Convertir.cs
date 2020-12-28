using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class Convertir
    {
        public void convertirMonedas()
        {
            Console.WriteLine("Escribe cuantos euros quieres cambiar:");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe que moneda quieres cambiar, LIBRAS, DOLARES o YENES:");
            string m = Console.ReadLine();
            string moneda = m.ToUpper();

            double dinero = 0;

            switch (moneda)
            {
                case "LIBRAS":
                    dinero = 0.86 * cantidad;
                    Console.WriteLine("{0} euros es igual a {1} libras", cantidad, dinero);
                    break;
                case "DOLARES":
                    dinero = 1.28611 * cantidad;
                    Console.WriteLine("{0} euros es igual a {1} dolares", cantidad, dinero);
                    break;
                case "YENES":
                    dinero = 129.852 * cantidad;
                    Console.WriteLine("{0} euros es igual a {1} yenes", cantidad, dinero);
                    break;
                default:
                    Console.WriteLine("Hay errores");
                    break;
            }
        }

    }
}

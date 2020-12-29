using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    class Calculos
    {
        public void inicio() {
            Console.WriteLine("Que quieres calcular? CIRCULO, TRIANGULO, CUADRADO ?");
            string opcion = Console.ReadLine().ToUpper();

            Calculos c = new Calculos();
            double resultado = 0;

            switch (opcion)
            {
                case "CIRCULO":
                    Console.WriteLine("Introduce radio:");
                    double r = Convert.ToDouble(Console.ReadLine());
                    //Calculos calculoCirculo = new Calculos();
                    resultado = c.circulo(r);
                    Console.WriteLine("Circulo de la figura = " + resultado);
                    break;

                case "TRIANGULO":
                    Console.WriteLine("Introduce base:");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introduce altura:");
                    double a = Convert.ToDouble(Console.ReadLine());
                    resultado = c.triangulo(b, a);
                    Console.WriteLine("Triangulo de la figura = " + resultado);
                    break;

                case "CUADRADO":
                    Console.WriteLine("Introduce lado:");
                    double l = Convert.ToDouble(Console.ReadLine());
                    resultado = c.cuadrado(l);
                    Console.WriteLine("Cuadrado de la figura = " + resultado);
                    break;

                default:
                    Console.WriteLine("Hay error");
                    break;
            }
        }
        public int circulo(double radio) {
            double r = Math.Pow(radio, 2) * Math.PI;
            int resultado = Convert.ToInt32(r);
            return resultado;
        }

        public int triangulo(double basee, double altura) {
            double r = (basee * altura) / 2;
            int resultado = Convert.ToInt32(r);
            return resultado;
        }

        public int cuadrado(double lado) {
            double r = lado * lado;
            int resultado = Convert.ToInt32(r);
            return resultado;
        }
    }
}

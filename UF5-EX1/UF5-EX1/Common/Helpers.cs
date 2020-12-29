using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    public static class Helpers
    {
        private static Random rd = new Random();
        public static bool IsPrime(int val) 
        {
            for (int i = 2; i < val; i++)
                if (val % i == 0) return false;
            return true;
        }

        public static int ReadNumber(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int[] FillArray(int[] arr, Func<int> generator)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = generator();
            }
            return arr;
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("Posicion {0}, valor {1}", i, arr[i]);
        }

        public static int RandomBetween(int min, int max)
        {
            int num = rd.Next(min, max + 1);
            return num;
        }
    }
}

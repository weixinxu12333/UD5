using System;
using System.Collections.Generic;
using System.Text;

namespace UF5_EX1
{
    public static class Helpers
    {
        public static bool isPrime(int val) 
        {
            for (int i = 2; i < val; i++)
                if (val % i == 0) return true;
            return false;
        }
    }
}

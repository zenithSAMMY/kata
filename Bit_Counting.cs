using System;

namespace Bit_Counting
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static int CountBits(int n)
        {
            string binary = Convert.ToString(n, 2);
            int a = 0;
            foreach (var c in binary)
            {
                if (c == '1')
                {
                    a++;
                }
            }
            return a;
        }
    }
}

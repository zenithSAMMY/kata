using System;
using System.Collections.Generic;
using System.Linq;


namespace Sum_of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Number
    {
        public int DigitalRoot(long n)
        {
            // Your awesome code here!
            while (n > 9)
            {
                int tmp = 0;
                var n_str = n.ToString();
                foreach (var num in n_str)
                {
                    tmp += Convert.ToInt32(num) - '0';
                }
                n = Convert.ToInt64(tmp);
            }
            return Convert.ToInt32(n);
        }
    }
}

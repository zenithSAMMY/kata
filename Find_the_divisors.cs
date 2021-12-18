// https://www.codewars.com/kata/544aed4c4a30184e960010f4/train/csharp

using System;
using System.Collections.Generic;

namespace Find_the_divisors
{
    public class Kata
    {
        static void Main(string[] args)
        {
        }

        public static int[] Divisors(int n)
        {
            List<int> numsList = new List<int>();
            for (var i = 2; i <= Math.Round(Math.Sqrt(n), 2); i++)
            {
                if (n % i == 0)
                {
                    numsList.Add(i);
                    Console.WriteLine(i);
                    if (n / i == i)
                    {

                    }
                    else
                    {
                        numsList.Add(n / i);
                        Console.WriteLine(n / i);
                    }
                }
            }
            Console.WriteLine(numsList.Count);
            if (numsList.Count == 0)
            {
                return null;
            }
            numsList.Sort();
            int [] nums = numsList.ToArray();
            Console.WriteLine(nums);
            foreach (var VARIABLE in nums)
            {
                Console.WriteLine(VARIABLE);
            }
            return nums;
        }


    }
}

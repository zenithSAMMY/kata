using System;

namespace Build_a_pile_of_Cubes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class ASum
    {
        public static long findNb(long m)
        {
            // your code
            long l = 1;
            long tmp = (l * (l + 1)) / 2;
            tmp = tmp * tmp;
            while (m > tmp)
            {
                l++;
                tmp = (l * (l + 1)) / 2;
                tmp = tmp * tmp;
            }

            if (m == tmp)
            {
                return l;
            }
            else
            {
                return -1;
            }
        }

    }


}

using System;
namespace Solution
{

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class  Kata
    {
        public int BinaryArrayToNumber(int[] BinaryArray)
        {
            //Code here
            int arr_len = BinaryArray.Length;
            double res = 0;
            int power = arr_len - 1;
            for (int i = 0; i < arr_len; i++)
            {
                res += BinaryArray[i] * Math.Pow(2, power);
                power--;
            }
            return Convert.ToInt32(res);
        }
    }
}
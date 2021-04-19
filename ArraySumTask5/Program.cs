using System;

namespace ArraySumTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = {56, 23, 12, 44, 13, 10};
            Console.WriteLine(Sum(data));
        }

        static int Sum (int[] arr)
        {
            int totalSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                totalSum += arr[i];
            }
            return totalSum;
        }
    }
}

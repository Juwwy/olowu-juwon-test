using System;

namespace ArrayTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[50];
            int sum = 0;

            for (int i = 1; i < Arr.Length; i++)
            {
                Arr[i] = i;
                sum += Arr[i];
            }
            Console.Write(sum);
        }
    }
}

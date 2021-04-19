using System;

namespace CheckMonthTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number between 1 - 12 to get Month: ");
            int response = Convert.ToInt32(Console.ReadLine());

            int num = 13 ;
            while(response < num)
            {
                switch(response)
                {
                    case 1 :
                    Console.Write("Month is : January");
                    break;
                    case 2 :
                    Console.Write("Month is : February");
                    break;
                    case 3 :
                    Console.Write("Month is : March");
                    break;
                    case 4 :
                    Console.Write("Month is : April");
                    break;
                    case 5 :
                    Console.Write("Month is : May");
                    break;
                    case 6 :
                    Console.Write("Month is : June");
                    break;
                    case 7 :
                    Console.Write("Month is : July");
                    break;
                    case 8 :
                    Console.Write("Month is : August");
                    break;
                    case 9 :
                    Console.Write("Month is : September");
                    break;
                    case 10 :
                    Console.Write("Month is : October");
                    break;
                    case 11 :
                    Console.Write("Month is : November");
                    break;
                    case 12 :
                    Console.Write("Month is : December");
                    break;
                    default:
                    break;
                }
                break;
            }
        }
    }
}

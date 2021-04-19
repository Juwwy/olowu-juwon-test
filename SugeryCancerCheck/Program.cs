using System;

namespace SugeryCancerCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter illness Cancer or Cold: ");
            string response = Console.ReadLine();

            


            if(response == "Cancer" || response == "cancer")
            {
            Console.Write("Enter financial status (Rich or Poor): ");
            string finResponse = Console.ReadLine();
            switch(finResponse)
            {
                case "rich":
                Console.Write("Surgery");
                break;
                case "poor":
                Console.Write("Make Public Call for Help");
                break;
                default:
                Console.Write("There are no other Possiblities that can happen.");
                break;
            }

            }else if(response == "Cold" || response == "cold")
            {
            Console.Write("Enter financial status (Rich or Poor): ");
            string finResponse = Console.ReadLine();
            switch(finResponse)
            {
                case "rich":
                Console.Write("Take Special Care");
                break;
                case "poor":
                Console.Write("Send home");
                break;
                default:
                Console.Write("There are no other Possiblities that can happen.");
                break;
            }
            }
            

           
        }
    }
}

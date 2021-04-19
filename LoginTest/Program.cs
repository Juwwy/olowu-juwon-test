using System;

namespace LoginTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = {"John", "Sammy23", "Faithy97", "MikeRandy", "Goldie"};
            string[] password = {"Jay23q", "Holt3", "lovelyn@2", "DiamR6", "JamiesT"};
            bool response1 = false;
            bool response2 = false;

            Console.Write("Enter Your Username: ");
            string userResponse = Console.ReadLine();

            Console.Write("Enter Your Password: ");
            string userPswd = Console.ReadLine();

            for (int i = 0; i < userNames.Length; i++)
            {
                
                if(userResponse == userNames[i])
                {
                    response1 = true;
                   
                }
                

                if(userPswd == password[i])
                {
                    response2 = true;
                   
                }

            
            }
            if(response1 == true && response2 == true)
            {
                Console.Write("\nLogin successful");
            }else{
                Console.Write("\nWrong Password");
            }

            
        }
    }
}

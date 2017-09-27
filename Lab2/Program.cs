using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramContinue = true;

            while (ProgramContinue == true)
            {

                // put your code here

                int UserInput;
                Console.WriteLine("Enter A Number between 1 and 100");
                UserInput = int.Parse (Console.ReadLine());

                if (UserInput % 2 == 1 && UserInput < 60)
                {
                    Console.WriteLine("Odd");
                    Console.WriteLine(UserInput);
                }
                else if (UserInput % 2 == 1 && UserInput >= 60)
                {
                    Console.WriteLine("Odd");
                    Console.WriteLine(UserInput);
                }
                else if (UserInput % 2 == 0 && UserInput >= 2 && UserInput <= 25)
                {
                    Console.WriteLine("Even");
                    Console.WriteLine("Less than 25");
                }

                else if (UserInput % 2 == 0 && UserInput >= 26 && UserInput <= 60)
                {
                    Console.WriteLine("Even");
                }
                else if (UserInput % 2 == 0 && UserInput > 60)
                {
                    Console.WriteLine("Even");
                }
             
                string UserChoice;
                Console.WriteLine("Do you want to run the code again? (N/No/y/yes)");
                UserChoice = Console.ReadLine();
                if (UserChoice == "N" || UserChoice == "No")
                {
                    ProgramContinue = false;
                }
            }






        }

    }
}

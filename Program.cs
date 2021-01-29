/*
 Author: Ashton Crowder
 Date: 1/29/2021
*/

using System;

namespace CrowderDev2IterationStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for user input
            Console.Write("Enter an Integer Value between 1 and 100: ");

            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to perform a For Loop interation statement and is parsed as ana integer
                int value_of_input = int.Parse(input);

                if (value_of_input <= 100)
                {
                    Console.WriteLine("You have entered " + value_of_input.ToString());
                    // For Loop Statement
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program...");
                    // Pause program and await user instructions
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter a whole integer number between 1 and 100");
                    Console.WriteLine("Press any key to exit the program and try again");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter a whole integer value between 1 and 100 and try again");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }
        }
    }
} // End of Program

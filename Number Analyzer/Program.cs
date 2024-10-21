// See https://aka.ms/new-console-template for more information
using System;

class Program

{
    static void Main(string[] args)
    {
        string continueProgram;
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Welcome, {userName}! Let's get started.");
        do
        {
            int input;

            do
            {
                Console.WriteLine("Enter an integer between 1 and 100:");
                bool validInput = int.TryParse(Console.ReadLine(), out input);

                if (!validInput || input < 1 || input > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer between 1 and 100");
                }
            } while (input < 1 || input > 100);

            //Checking whether the input number is odd and less than 60
            if (input < 60 && input % 2 != 0)
            {
                Console.WriteLine($"{input}: Odd and less than 60");
            }
            //Checking if input is an even number between 2 and 24, inclusive
            else if (input >= 2 && input <= 24 && input % 2 == 0)
            {
                Console.WriteLine($"{input}: Even and less than 25");
            }
            //Checking if input is an even number between 26 and 60, inclusive
            else if (input >= 26 && input <= 60 && input % 2 == 0)
            {
                Console.WriteLine($"{input}: Even and between 26 and 60 inclusive");
            }

            //Checking if input is an even number greater than 60
            else if (input > 60 && input % 2 == 0)
            {
                Console.WriteLine($"{input}: Even and greater than 60");
            }
            //Checking if input is an odd number greater than 60
            else if (input > 60 && input % 2 != 0)
            {
                Console.WriteLine($"{input}: Odd and greater than 60");
            }

            Console.WriteLine("Would you like to enter another number? (yes/no)");
            continueProgram = Console.ReadLine();

        }
        while (continueProgram.ToLower() == "yes");
        Console.WriteLine("Thank you for using the program! Goodbye.");
            }
            }
        
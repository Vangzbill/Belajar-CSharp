using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("Please enter your choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine("You chose " + choice + "!");
            Random rnd = new Random();
            int computerChoice = rnd.Next(1, 4);
            if (computerChoice == 1)
            {
                Console.WriteLine("The computer chose rock!");
            }
            else if (computerChoice == 2)
            {
                Console.WriteLine("The computer chose paper!");
            }
            else
            {
                Console.WriteLine("The computer chose scissors!");
            }
            if (choice == "rock" && computerChoice == 1)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (choice == "rock" && computerChoice == 2)
            {
                Console.WriteLine("You lose!");
            }
            else if (choice == "rock" && computerChoice == 3)
            {
                Console.WriteLine("You win!");
            }
            else if (choice == "paper" && computerChoice == 1)
            {
                Console.WriteLine("You win!");
            }
            else if (choice == "paper" && computerChoice == 2)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (choice == "paper" && computerChoice == 3)
            {
                Console.WriteLine("You lose!");
            }
            else if (choice == "scissors" && computerChoice == 1)
            {
                Console.WriteLine("You lose!");
            }
            else if (choice == "scissors" && computerChoice == 2)
            {
                Console.WriteLine("You win!");
            }
            else if (choice == "scissors" && computerChoice == 3)
            {
                Console.WriteLine("It's a tie!");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine(); // Add this line to wait for an Enter key press
        }
    }
}
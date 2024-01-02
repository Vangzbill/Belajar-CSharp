using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Simple Calculator!");
            Console.WriteLine("Please enter your first number: ");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Please enter your second number: ");
            string secondNumber = Console.ReadLine();
            Console.WriteLine("Please enter your operation: ");
            string operation = Console.ReadLine();
            int firstNumberInt = Convert.ToInt32(firstNumber);
            int secondNumberInt = Convert.ToInt32(secondNumber);
            if (operation == "+")
            {
                Console.WriteLine(firstNumberInt + secondNumberInt);
            }
            else if (operation == "-")
            {
                Console.WriteLine(firstNumberInt - secondNumberInt);
            }
            else if (operation == "*")
            {
                Console.WriteLine(firstNumberInt * secondNumberInt);
            }
            else if (operation == "/")
            {
                Console.WriteLine(firstNumberInt / secondNumberInt);
            }
            else
            {
                Console.WriteLine("Invalid operation!");
            }
        }
    }
}
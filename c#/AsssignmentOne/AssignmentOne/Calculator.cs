using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            float result;
            string operand;

            // Display title as the C# console calculator app.
            Console.WriteLine("Console Application Calculator \r");
            Console.WriteLine("------------------------\n");


            Console.WriteLine("Enter the First Number");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the operation to be performed (+,-,*,/):");
            operand = Console.ReadLine();

            switch (operand)
            {
                case "+":
                    result = (num1 + num2);
                    Console.WriteLine("Result is: " + result);
                    break;
                case "-":
                    result = (num1 - num2);
                    Console.WriteLine("Result is: " + result);
                    break;
                case "*":
                    result = (num1 * num2);
                    Console.WriteLine("Result is: " + result);
                    break;
                case "/":
                    result = (num1 / num2);
                    Console.WriteLine("Result is: " + result);
                    break;
                default:
                    Console.WriteLine("please Enter Correct Operator");
                    break;
            }

        }
    }
}

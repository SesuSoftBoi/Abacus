using Giraffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Calculator.Program;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                Console.Write("Enter First Number:");
                var num1successful = int.TryParse(Console.ReadLine(), out var num1);

                Console.Write("Enter Second Number:");
                var num2successful = int.TryParse(Console.ReadLine(), out var num2);

                Console.Write("Enter Operation (/,+,-,*):");
                string symbol = Console.ReadLine();

                if (num1successful == false || num2successful == false)
                {
                    Console.WriteLine("Wrong number, try again you dingus.");
                }
                else
                {
                    Operation? operation = null;
                    operation = FindOperation(symbol);

                    var abacus = new Abacus(num1, num2, operation);
                    var result = abacus.Calculate();
                    if (result != null)
                    {
                        Console.WriteLine($"Joe mama, here numba: {result} ");
                    }
                    else
                    {
                        Console.WriteLine("Ur dum");
                    }
                }
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }

        public static Operation? FindOperation(string symbol)
        {
            switch (symbol)
            {
                case "+":
                     return Operation.Addition;

                case "-":
                    return Operation.Subtraction;

                case "*":
                    return Operation.Multiplication;

                case "/":
                    return Operation.Division;

                default:
                    Console.WriteLine("Wrong Operation");
                    return null;
            }
        }
    }
}
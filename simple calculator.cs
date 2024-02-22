using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
  Console.WriteLine("Simple Calculator");
                Console.WriteLine("Enter two numbers:");

                int num1;
                int num2;
                double result = 0.0;
                char operation;

                Console.Write("Enter the first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());


                Console.Write("Enter an operation (+, -, *, /): ");
                operation = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter the second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero.");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        return;
                }

                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            }
        }
    }

                    
                
           

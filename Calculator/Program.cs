using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.Write("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol(+,-,*,/):");
                string symbol = Console.ReadLine();
                if (symbol == "+")
                {
                    res = num1 + num2;
                    Console.WriteLine("Addition:" + res);
                }
                else if (symbol == "-")
                {
                    res = num1 - num2;
                    Console.WriteLine("Subtraction:" + res);
                }
                else if (symbol == "*")
                {
                    res = num1 * num2;
                    Console.WriteLine("Multiplication:" + res);
                }
                else if (symbol == "/")
                {
                    res = num1 / num2;
                    Console.WriteLine("Division:" + res);
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
    }
}

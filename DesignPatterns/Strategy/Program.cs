using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            
            var valueA = 70;
            var valueB = 35;

            Console.WriteLine($"Results for inputted numbers ({valueA}, {valueB}): ");
            
            calc.SetOperation(new Addition());
            Console.WriteLine("Addition: " + calc.Calculate(valueA, valueB).ToString());

            calc.SetOperation(new Subtraction());
            Console.WriteLine("Subtraction: " + calc.Calculate(valueA, valueB).ToString());

            calc.SetOperation(new Multiply());
            Console.WriteLine("Multiply: " + calc.Calculate(valueA, valueB).ToString());

            calc.SetOperation(new Division());
            Console.WriteLine("Division: " + calc.Calculate(valueA, valueB).ToString());

            Console.ReadKey();

        }
    }
}

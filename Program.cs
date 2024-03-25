using System;

namespace Assignment8ex2
{
    // Custom delegate for comparison method
    public delegate double ComparisonDelegate(double a, double b);

    public class MathSolutions
    {
        public double GetSum(double x, double y)
        {
            return x + y;
        }

        public double GetProduct(double a, double b)
        {
            return a * b;
        }

        // Method for comparison
        public static void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }

        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            Console.WriteLine($" {num1} + {num2} = {answer.GetSum(num1, num2)}");
            Console.WriteLine($" {num1} * {num2} = {answer.GetProduct(num1, num2)}");

            // Using Action delegate for GetSmaller method
            Action<double, double> actionDelegate = GetSmaller;
            actionDelegate(num1, num2);

            // Using Func delegate for GetSum method
            Func<double, double, double> funcDelegate = answer.GetSum;
            Console.WriteLine($"Using Func delegate: {num1} + {num2} = {funcDelegate(num1, num2)}");

            // Using custom delegate for GetProduct method
            ComparisonDelegate customDelegate = answer.GetProduct;
            Console.WriteLine($"Using custom delegate: {num1} * {num2} = {customDelegate(num1, num2)}");
        }
    }
}
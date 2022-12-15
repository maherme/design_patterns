using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            ITarget calculator = new CCalculator();

            result = calculator.Addition(4, 3);
            Console.WriteLine("Result is {0}", result);
            Console.WriteLine("------------------");
            calculator = new CAdapter();
            // This Addition method is adapting the AdditionArray of class CCalculatorArray
            result = calculator.Addition(5, 6);
            Console.WriteLine("Result is {0}", result);
        }
    }
}

using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = 0;
            string type = "";
            IPrimitive quality = null;
            double total = 0;

            Console.WriteLine("1- Cheap, 2- Normal");
            type = Console.ReadLine();

            switch(type){
                case "1":
                    quality = new CCheap();
                    break;
                case "2":
                    quality = new CNormal();
                    break;
                default:
                    // Do nothing
                    break;
            }

            Console.WriteLine("How many toys to produce?");
            quantity = Convert.ToInt32(Console.ReadLine());

            CAlgorithm production = new CAlgorithm();
            total = production.methodTemplate(quality, quantity);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("The total is {0}", total);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

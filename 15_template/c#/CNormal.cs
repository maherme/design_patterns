using System;

namespace Template
{
    class CNormal:IPrimitive
    {
        public double Decorate(int quantity){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Do {0} times", quantity);
            Console.WriteLine("Print Logo");
            Console.WriteLine("Polish Process");
            Console.WriteLine("Put Stickers");
            // The decoration process costs 7.5$ for each toy
            return 7.5*quantity;
        }

        public double Pack(int quantity){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Do {0} times", quantity);
            Console.WriteLine("Prepare Box");
            Console.WriteLine("Print Manual");
            Console.WriteLine("Print Warranty");
            Console.WriteLine("Packaging Process");
            Console.WriteLine("Seal Box");
            // The cost is 12.5$ for each box
            return 12.5*quantity;
        }
    }
}

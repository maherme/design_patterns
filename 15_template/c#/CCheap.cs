using System;

namespace Template
{
    class CCheap:IPrimitive
    {
        public double Decorate(int quantity){
            Console.ForegroundColor = ConsoleColor.Green;
            for(int i = 0; i < quantity; i++){
                Console.WriteLine("Put Label");
            }
            // The cost is 1.5$ for each label
            return 1.5*quantity;
        }

        public double Pack(int quantity){
            Console.ForegroundColor = ConsoleColor.Yellow;
            for(int i = 0; i < quantity; i++){
                Console.WriteLine("Put in Bag");
            }
            // The cost is 0.25$ for each bag
            return 0.25*quantity;
        }
    }
}

using System;

namespace Decorator{

    class Program{
        static void Main(string[] args){
            // CVehicle implement the IComponent interface, so this is allowed:
            IComponent myVehicle = new CVehicle("car",  "150CV engine", 15000);
            Console.WriteLine(myVehicle);
            // For using a method of CVehicle a type cast is needed:
            ((CVehicle)myVehicle).Engine(true);
            Console.WriteLine("------------");

            // Decorate myVehicle with a turbo system
            myVehicle = new CTurbo(myVehicle);
            // Check the decoration
            Console.WriteLine(myVehicle.Price());
            Console.WriteLine(myVehicle.Working());
            Console.WriteLine(myVehicle);
            // For using a specific method of a decorator class a type cast is needed:
            ((CTurbo)myVehicle).UseTurbo();
            Console.WriteLine("------------");

            // Decorate myVehicle again
            myVehicle = new CAutopilot(myVehicle);
            // Check the decoration
            Console.WriteLine(myVehicle.Price());
            Console.WriteLine(myVehicle.Working());
            Console.WriteLine(myVehicle);
            Console.WriteLine("------------");

            // Decorate myVehicle again
            myVehicle = new CElectricEngine(myVehicle);
            // Check the decoration
             Console.WriteLine(myVehicle.Price());
            Console.WriteLine(myVehicle.Working());
            Console.WriteLine(myVehicle);
            Console.WriteLine("------------");

            // Call a method of an object which was decorated will failed due to the type cast can not
            // be done, if you need to use this method, you need to think about including in the interface
            // ((CVehicle)myVehicle).Engine(true);
        }
    }
}

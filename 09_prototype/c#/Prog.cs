using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            CAdminPrototypes admin = new CAdminPrototypes();
            CPerson one = (CPerson)admin.CreatePrototype("Person");
            CPerson two = (CPerson)admin.CreatePrototype("Person");
            // Verify the default values
            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine("----------------------------");
            // Change the state
            one.Name = "Mary";
            two.Name = "Peter";
            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine("----------------------------");

            CAuto auto = new CAuto("Nissan", 250000);
            admin.AddPrototype("Auto", auto);
            CAuto auto2 = (CAuto)admin.CreatePrototype("Auto");
            auto2.Model = "Honda";
            Console.WriteLine(auto);
            Console.WriteLine(auto2);
            Console.WriteLine("----------------------------");

            CValues val = (CValues)admin.CreatePrototype("Values");
            Console.WriteLine(val);
        }
    }
}

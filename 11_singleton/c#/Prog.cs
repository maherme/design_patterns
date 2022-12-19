using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            CSingleton one = CSingleton.GetInstance();
            one.SetData("Mark", 32);
            one.SomeProcess();
            Console.WriteLine(one);
            Console.WriteLine("---------------------------------------");
            // The new creation will return the same object, because it can be only one instance
            CSingleton two = CSingleton.GetInstance();
            Console.WriteLine(two);
        }
    }
}

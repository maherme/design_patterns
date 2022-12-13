using System;
using System.Collections.Generic;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> product = new Dictionary<string, double>();

            product.Add("P001", 10.5);
            product.Add("A003", 5);
            product.Add("Z102", 100.25);
            product.Add("P205", 55.15);
            product.Add("P913", 33.65);
            product.Add("A075", 7.85);
            product.Add("Z333", 99.99);
            product.Add("P066", 9.75);
            product.Add("A111", 225);

            // Test implementation which needs an object with the implementation
//            CAbstraction bridge = new CAbstraction(new CImplementation1(), product);
//            CAbstraction bridge = new CAbstraction(new CImplementation2(), product);
//            CAbstraction bridge = new CAbstraction(new CImplementation3(), product);

            // Test implementation with index selection
            CAbstraction bridge = new CAbstraction(2, product);

            bridge.ShowTotal();
            bridge.ListTotal();
        }
    }
}

using System;

namespace AbstractFactory
{
    class CCoconutMilk:IProductMilk
    {
        public void Produce(){
            Console.WriteLine("Search for the coconuts");
        }

        public string getData(){
            return "Natural coconut milk, 330ml";
        }
    }
}

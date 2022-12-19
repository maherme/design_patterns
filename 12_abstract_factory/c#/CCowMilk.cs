using System;

namespace AbstractFactory
{
    class CCowMilk:IProductMilk
    {
        public void Produce(){
            Console.WriteLine("Milk the cow in the farm");
        }

        public string getData(){
            return "Cow milk, 330ml";
        }
    }
}

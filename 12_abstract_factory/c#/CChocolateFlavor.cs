using System;

namespace AbstractFactory
{
    class CChocolateFlavor:IProductFlavoring
    {
        public void getFlavor(){
            Console.WriteLine("Produced FLVCHT");
        }

        public string Information(){
            return "Chocolate flavor";
        }
    }
}

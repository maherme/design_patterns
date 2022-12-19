using System;

namespace AbstractFactory
{
    class CNaturalVanilla:IProductFlavoring
    {
        public void getFlavor(){
            Console.WriteLine("It extracts from vanilla pods");
        }

        public string Information(){
            return "Natural vanilla extract";
        }
    }
}

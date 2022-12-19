using System;

namespace AbstractFactory
{
    class CNaturalFactory:IFactory
    {
        private IProductMilk milk;
        private IProductFlavoring flavor;

        public IProductMilk GetProductMilk{get{return milk;}}
        public IProductFlavoring GetFlavor{get{return flavor;}}

        public void createProducts(){
            Console.ForegroundColor = ConsoleColor.Green;
            string selection;
            Console.WriteLine("We are creating your drink");
            Console.WriteLine("1 Almonds, 2 Coconut");
            selection = Console.ReadLine();

            switch(selection){
                case "1":
                    milk = new CAlmondMilk();
                    break;
                default:
                    milk = new CCoconutMilk();
                    break;
            }

            milk.Produce();
            Console.WriteLine("We extracts the flavor");
            flavor = new CNaturalVanilla();
            flavor.getFlavor();
        }
    }
}

using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory myFactory = new CChemicalFactory();
            myFactory.createProducts();
            IProductMilk myMilk = myFactory.GetProductMilk;
            IProductFlavoring myFlavor = myFactory.GetFlavor;
            myMilk.Produce();
            myFlavor.getFlavor();
            Console.WriteLine("My milkshake is made of {0} and {1}",
                              myMilk.getData(),
                              myFlavor.Information());

            Console.WriteLine("-------------------------------------------------------------");

            myFactory = new CNaturalFactory();
            myFactory.createProducts();
            myMilk = myFactory.GetProductMilk;
            myFlavor = myFactory.GetFlavor;
            Console.WriteLine("My milkshake is made of {0} and {1}",
                              myMilk.getData(),
                              myFlavor.Information());

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

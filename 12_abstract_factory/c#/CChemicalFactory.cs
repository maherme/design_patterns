using System;

namespace AbstractFactory
{
    class CChemicalFactory:IFactory
    {
        private IProductMilk milk;
        private IProductFlavoring flavor;

        public IProductMilk GetProductMilk{get{return milk;}}
        public IProductFlavoring GetFlavor{get{return flavor;}}

        public void createProducts(){
            Console.WriteLine("We are creating your milkshake");
            milk = new CCowMilk();
            flavor = new CChocolateFlavor();
        }
    }
}

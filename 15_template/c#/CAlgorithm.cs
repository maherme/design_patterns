using System;

namespace Template
{
    class CAlgorithm
    {
        public double methodTemplate(IPrimitive type, int quantity){
            double total = 0;
            total += createToy(quantity);
            // The decoration can change, so is implemented using the interface
            total += type.Decorate(quantity);
            quality();
            // The package can change, so is implemented using the interface
            total += type.Pack(quantity);
            return total;
        }

        private double createToy(int pQuantity){
            Console.WriteLine("Creating {0} toys", pQuantity);
            // Each toy has a price of 16.50$
            return 16.50*pQuantity;
        }

        private void quality(){
            Console.WriteLine("Quality Control Passed");
        }
    }
}

using System.Collections.Generic;

namespace Bridge
{
    class CAbstraction
    {
        // Reference to implementation
        IBridge implementation;
        Dictionary<string, double> product;

        // This is an implementation that needs a IBridge object
        public CAbstraction(IBridge pImp, Dictionary<string, double> pProd)
        {
            implementation = pImp;
            product = pProd;
        }

        // This is an implementation that needs you select a particular implementation from an index
        public CAbstraction(int pType, Dictionary<string, double> pProd)
        {
            switch(pType){
                case 1:
                    implementation = new CImplementation1();
                    break;
                case 2:
                    implementation = new CImplementation2();
                    break;
                case 3:
                    implementation = new CImplementation3();
                    break;
                default:
                    break;
            }
            product = pProd;
        }

        // Interface with the client
        public void ShowTotal()
        {
            implementation.ShowTotal(product);
        }

        public void ListTotal()
        {
            implementation.ListTotal(product);
        }
    }
}

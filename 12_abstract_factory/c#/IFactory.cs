namespace AbstractFactory
{
    interface IFactory
    {
        void createProducts();
        IProductMilk GetProductMilk{get;}
        IProductFlavoring GetFlavor{get;}
    }
}

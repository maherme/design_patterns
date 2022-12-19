using System;

namespace AbstractFactory
{
    class CAlmondMilk:IProductMilk
    {
        public void Produce(){
            Console.WriteLine("Process the almonds");
        }

        public string getData(){
            return "Organic almond milk, 330ml";
        }
    }
}

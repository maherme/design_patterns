using System;

namespace Flyweight
{
    class CRecipe:IFlyweight
    {
        private string name;
        private double price;
        private double sale;

        public void AddName(string pName){
            name = pName;
        }

        public void CalculatePrice(){
            foreach(char character in name){
                price += (int)character;
            }
            sale = price*1.5;
        }

        public void Show(){
            Console.WriteLine("{0} price {1}", name, sale);
        }

        public string GetName(){
            return name;
        }
    }
}

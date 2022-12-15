using System;
using System.Collections.Generic;

namespace Flyweight
{
    class CFlyweightFactory
    {
        private List<IFlyweight> flyweights = new List<IFlyweight>();
        private int count = 0;
        public int Count{get => count; set => count = value;}

        public int Addition(string pName)
        {
            bool exist = false;

            foreach(IFlyweight f in flyweights){
                if(f.GetName() == pName){
                    exist = true;
                }
            }

            if(exist){
                Console.WriteLine("The object already exists, so it will not be added");
                return -1;
            }
            else{
                CRecipe myRecipe = new CRecipe();
                myRecipe.AddName(pName);
                flyweights.Add(myRecipe);
                count = flyweights.Count;
                return count -1;
            }
        }

        public IFlyweight this[int index]
        {
            get{return flyweights[index];}
        }
    }
}

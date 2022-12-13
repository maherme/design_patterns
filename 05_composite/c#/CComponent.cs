using System;

namespace Composite
{
    class CComponent<T>:IComponent<T>
    {
        public T Name{get; set;}

        public CComponent(T pName){
            Name = pName;
        }

        public void Addition(IComponent<T> pElement){
            Console.WriteLine("You can not add in a component, only in a composite");
        }

        public IComponent<T> Erase(T pElement){
            Console.WriteLine("It can not be erased directly");
            return this;
        }

        public IComponent<T> Search(T pElement){
            if(pElement.Equals(Name)){
                return this;
            }
            else{
                return null;
            }
        }

        public string Show(int pDeep){
            return new String('-', pDeep) + Name + "\r\n";
        }
    }
}

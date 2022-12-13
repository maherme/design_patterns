using System;
using System.Text;
using System.Collections.Generic;

namespace Composite
{
    class CComposite<T>:IComponent<T>
    {
        List<IComponent<T>> elements;
        public T Name{get; set;}

        public CComposite(T pName){
            Name = pName;
            elements = new List<IComponent<T>>();
        }

        public void Addition(IComponent<T> pElement){
            elements.Add(pElement);
        }

        public IComponent<T> Erase(T pElement){
            IComponent<T> element = this.Search(pElement);
            if(element != null){
                (this as CComposite<T>).elements.Remove(element);
            }
            return this;
        }

        public IComponent<T> Search(T pElement){
            if(Name.Equals(pElement)){
                return this;
            }
            IComponent<T> found = null;
            foreach(IComponent<T> element in elements){
                found = element.Search(pElement);
                if(found != null){
                    break;
                }
            }
            return found;
        }

        public string Show(int pDeep){
            StringBuilder infoElement = new StringBuilder(new String('-', pDeep));
            infoElement.Append("Composite: " + Name + " elements: " + elements.Count + "\r\n");
            foreach(IComponent<T> element in elements){
                infoElement.Append(element.Show(pDeep + 1));
            }
            return infoElement.ToString();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Prototype
{
    class CAdminPrototypes
    {
        private Dictionary<string, IPrototype> prototypes = new Dictionary<string, IPrototype>();

        public CAdminPrototypes(){
            CPerson person = new CPerson("Citizen", 18);
            prototypes.Add("Person", person);
            CValues values = new CValues(1);
            prototypes.Add("Values", values);
        }

        public void AddPrototype(string pKey, IPrototype pPrototype){
            prototypes.Add(pKey, pPrototype);
        }

        public object CreatePrototype(string pKey){
            return prototypes[pKey].Clone();
        }
    }
}

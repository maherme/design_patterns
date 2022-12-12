using System;

namespace Proxy{

    class Program{
        static void Main(string[] args){

            CProxy.ISubject myProxy = new CProxy.CSimpleProxy();
            // Access to the CSubject class is not possible
            // CProxy.CSubject mySubject = new CProxy.CSubject();
            myProxy.Request(1);
            Console.WriteLine("-----------------------");
            myProxy.Request(2);
            Console.WriteLine("-----------------------");

            CProxy.ISubject mySProxy = new CProxy.CSecureProxy();
            mySProxy.Request(1);
            Console.WriteLine("-----------------------");
            mySProxy.Request(2);
            Console.WriteLine("-----------------------");
        }
    }
}

using System;

namespace Singleton
{
    class CSingleton
    {
        private static CSingleton instance;
        private string name;
        private int age;

        // The constructor must be private, to avoid more than one instance
        private CSingleton(){
            name = "unassigned";
            age = 99;
        }

        public static CSingleton GetInstance(){
            // Verify if does not exist an instance
            if(instance == null){
                instance = new CSingleton();
                Console.WriteLine("Instance created for the first time");
            }
            return instance;
        }

        // Own methods provided by the class
        public override string ToString(){
            return string.Format("The person {0}, is {1} age old", name, age);
        }

        public void SetData(string pName, int pAge){
            name = pName;
            age = pAge;
        }

        public void SomeProcess(){
            Console.WriteLine("{0} is working in something", name);
        }
    }
}

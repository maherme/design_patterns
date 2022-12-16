namespace Prototype
{
    class CPerson:IPrototype
    {
        private string name;
        private int age;
        public string Name{get => name; set => name = value;}

        public CPerson(string pName, int pAge){
            name = pName;
            age = pAge;
        }

        public override string ToString(){
            return string.Format("{0}, {1}", name, age);
        }

        public object Clone(){
            CPerson clon = new CPerson(name, age);
            return clon;
        }
    }
}

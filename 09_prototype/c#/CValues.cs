using System;

namespace Prototype
{
    class CValues:IPrototype
    {
        private double summation;
        private int m = 1;
        public int M{get => m; set => m = value;}
        public double Summation{get => summation; set => summation = value;}

        public CValues(){
        }

        // This is a constructor demanding in resources
        public CValues(int pM){
            m = pM;
            for(int n = 0; n < 90; n++){
                summation += Math.Sin(n*0.0175);
            }
        }

        public override string ToString(){
            return string.Format("{0}", summation*m);
        }

        public object Clone(){
            // Notice the constructor is the less cost
            CValues clon = new CValues();
            // Here we copy the calculated value to the clon, this is less cost than call the cost
            // constructor
            clon.M = m;
            clon.Summation = summation;
            return clon;
        }
    }
}

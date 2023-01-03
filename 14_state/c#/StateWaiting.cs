using System;

namespace State
{
    class StateWaiting:IState
    {
        CBoiler myBoiler;

        public StateWaiting(CBoiler pBoiler){
            myBoiler = pBoiler;
        }

        public void Working(){
            myBoiler.Temperature -= 5;

            if((myBoiler.Temperature < 60) && (myBoiler.Fuel > 0)){
                myBoiler.ChangeState(myBoiler.Heating);
            }
        }

        public void StopLighting(){
            Console.WriteLine("Stop Lighting");
        }

        public void FillFuel(){
            Console.WriteLine("Refilling Fuel");
            myBoiler.Fuel += 28;
        }

        public void ForceLighting(){
            if(myBoiler.Fuel > 0){
                Console.WriteLine("Forcing Lighting");
                myBoiler.Fuel -= 3;
                myBoiler.Temperature += 10;

                if(myBoiler.Temperature > 100){
                    myBoiler.ChangeState(myBoiler.Alarm);
                }
            }
        }

        public override string ToString(){
            return string.Format("Waiting -> temp {0}, fuel {1}", myBoiler.Temperature, myBoiler.Fuel);
        }
    }
}

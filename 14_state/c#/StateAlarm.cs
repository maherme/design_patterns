using System;

namespace State
{
    class StateAlarm:IState
    {
        CBoiler myBoiler;

        public StateAlarm(CBoiler pBoiler){
            myBoiler = pBoiler;
        }

        public void Working(){
            Console.WriteLine("ALARM! High Temperature");
            myBoiler.Temperature -= 5;
            // Check a possible state change
            if((myBoiler.Temperature < 90) || (myBoiler.Fuel <= 0)){
                myBoiler.ChangeState(myBoiler.Wait);
            }
        }

        public void StopLighting(){
            Console.WriteLine("Stop Lighting");
        }

        public void FillFuel(){
            Console.WriteLine("It is not possible fill fuel when the temperature is high");
        }

        public void ForceLighting(){
            Console.WriteLine("Temperature will raise!");
            myBoiler.Fuel -= 3;
            myBoiler.Temperature += 10;
        }

        public override string ToString(){
            return string.Format("Alarm-> temp {0}, fuel {1}", myBoiler.Temperature, myBoiler.Fuel);
        }
    }
}

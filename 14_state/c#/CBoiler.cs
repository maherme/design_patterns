using System;

namespace State
{
    class CBoiler
    {
        private IState heating;
        private IState alarm;
        private IState wait;
        private IState current_state;
        private int temperature;
        private int fuel;

        public int Temperature{get => temperature; set => temperature = value;}
        public int Fuel{get => fuel; set => fuel = value;}
        public IState Heating{get => heating; set => heating = value;}
        public IState Alarm{get => alarm; set => alarm = value;}
        public IState Wait{get => wait; set => wait = value;}

        public CBoiler(){
            temperature = 20;
            fuel = 50;
            heating = new StateHeating(this);
            alarm = new StateAlarm(this);
            wait = new StateWaiting(this);
            current_state = heating;
        }

        public void ChangeState(IState pState){
            Console.WriteLine("---State Change---");
            current_state = pState;
        }

        public void Working(){
            current_state.Working();
        }

        public void StopLighting(){
            current_state.StopLighting();
        }

        public void FillFuel(){
            current_state.FillFuel();
        }

        public void ForceLighting(){
            current_state.ForceLighting();
        }

        public override string ToString(){
            return current_state.ToString();
        }
    }
}

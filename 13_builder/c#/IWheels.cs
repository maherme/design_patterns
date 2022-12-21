namespace Builder
{
    interface IWheels
    {
        string Info();
    }

    class CWheels:IWheels
    {
        public string Info(){
            return "14 inches wheels";
        }
    }

    class CSuperWheels:IWheels
    {
        public string Info(){
            return "18 inches aluminum wheels";
        }
    }
}

namespace Builder
{
    interface IBody
    {
        string Features();
    }

    class CBasicBody:IBody
    {
        public string Features(){
            return "Metal body";
        }
    }

    class CSpecialBody:IBody
    {
        public string Features(){
            return "Fiber carbon body";
        }
    }
}

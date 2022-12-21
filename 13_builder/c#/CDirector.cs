namespace Builder
{
    class CDirector
    {
        public void Build(IBuilder pBuilder){
            // The director sets the steps for the building.
            pBuilder.BuildMotor();
            pBuilder.BuildBody();
            pBuilder.BuildWheels();
        }
    }
}

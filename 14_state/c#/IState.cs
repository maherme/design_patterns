namespace State
{
    interface IState
    {
        void Working();
        void StopLighting();
        void FillFuel();
        void ForceLighting();
    }
}

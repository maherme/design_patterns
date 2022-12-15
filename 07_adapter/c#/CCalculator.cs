namespace Adapter
{
    class CCalculator:ITarget
    {
        public int Addition(int pA, int pB)
        {
            return pA + pB;
        }
    }
}

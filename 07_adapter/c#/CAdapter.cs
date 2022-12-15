namespace Adapter
{
    class CAdapter:ITarget
    {
        CCalculatorArray adapted = new CCalculatorArray();

        public int Addition(int pA, int pB){
            double result = 0;
            int[] operands = {pA, pB};
            result = adapted.AdditionArray(operands);
            return (int)result;
        }
    }
}

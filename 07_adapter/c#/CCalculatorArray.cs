namespace Adapter
{
    class CCalculatorArray
    {
        public double AdditionArray(int[] pOperands){
            int n = 0;
            double result = 0;

            for(n = 0; n < pOperands.Length; n++){
                result += pOperands[n];
            }
            return result;
        }
    }
}

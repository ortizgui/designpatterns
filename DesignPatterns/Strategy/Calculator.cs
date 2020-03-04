namespace Strategy
{
    public class Calculator
    {
        private IMath _operation;
        public void SetOperation(IMath operation)
        {
            _operation = operation;
        }

        public int Calculate(int ValueA, int ValueB)
        {
            return _operation.Execute(ValueA, ValueB);
        }
    }
}
namespace Strategy
{
    public class Multiply : IMath
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}
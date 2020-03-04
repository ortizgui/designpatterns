namespace Strategy
{
    public class Subtraction : IMath
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }
}
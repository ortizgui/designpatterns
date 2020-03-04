namespace Strategy
{
    public class Addition : IMath
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }
}
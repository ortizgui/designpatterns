using System;

namespace Strategy
{
    public class Division : IMath
    {
        public int Execute(int a, int b)
        {
            try 
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }
    }    
}
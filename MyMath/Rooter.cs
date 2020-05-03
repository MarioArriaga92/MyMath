using System;

namespace MyMath
{
    public class Rooter
    {
        public double SquareRoot(in double input)
        {
            if (input <= 0.0)
            {
                throw new ArgumentOutOfRangeException();
            }
            double result = input;
            double previousResult = -input;
            while (Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                result = (result + input / result) / 2;
                //was: result = result - (result * result - input) / (2 * result);
            }

            return result;
        }
    }
}
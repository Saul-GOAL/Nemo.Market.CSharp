using Nemo.Market.Kata.Enums;
using System;

namespace Nemo.Market.Kata.Classes
{
    internal class PipeDiameterCalculator
    {
        public PipeDiameterCalculator()
        {
        }

        internal PipeDiameter ProcessDiameter( int v )
        {
            if ((v <= 0)|| (v >= 21))
                throw new ArgumentOutOfRangeException();
            else if (v <= 5)
                return PipeDiameter.Small;
            else if (v <=10)
                return PipeDiameter.Medium;
            else if (v <= 15)
                return PipeDiameter.Large;
           
            return PipeDiameter.ExtraLarge;  
        }
    }
}
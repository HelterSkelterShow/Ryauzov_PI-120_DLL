using System;

namespace Ryauzov_PI_120_DLL
{
    public class Rates
    {
        public static decimal SumRate(Decimal V, int t, int k)
        {
            return (V * t * k + V);
        }
    }
}

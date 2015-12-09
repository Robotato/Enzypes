using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enzypes.Network.Utilities
{
    public static class Bounds
    {
        public static double RestrictLower(double value, double lowerBound)
        {
            return Math.Max(value, lowerBound);
        }

        public static double RestrictUpper(double value, double upperBound)
        {
            return Math.Min(value, upperBound);
        }

        public static double Restrict(double value, double lowerBound, double upperBound)
        {
            return RestrictUpper(RestrictLower(value, lowerBound), upperBound);
        }
    }
}
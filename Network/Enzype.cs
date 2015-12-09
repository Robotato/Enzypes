using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enzypes.Network
{
    public class Enzype : Linkable
    {
        /// <summary>
        /// Must be in interval [0, 1].
        /// </summary>
        public double Active_Fraction { get; set; }

        /// <summary>
        /// Must be >= 0.
        /// </summary>
        public double Number { get; set; }

        public Enzype(double activeFraction, double number)
        {
            Active_Fraction = activeFraction;
            Number = number;
        }
    }
}

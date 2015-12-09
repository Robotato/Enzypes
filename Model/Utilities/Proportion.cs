using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enzypes.Model.Utilities
{
    public struct Proportion
    {
        private double _value;

        public static implicit operator double(Proportion p)
        {
            return p._value;
        }

        public static explicit operator Proportion(double d)
        {
            if (d < 0)
                d = 0;
            else if (d > 1)
                d = 1;

            return new Proportion { _value = d };
        }
    }
}
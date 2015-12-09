using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enzypes.Network.Utilities
{
    public class CircularList<T> : List<T>
    {
        public new T this[int i]
        {
            get
            {
                return base[WrapIndex(i, Count)];
            }

            set
            {
                base[WrapIndex(i, Count)] = value;
            }
        }

        public static int WrapIndex(int index, int count)
        {
            return (index % count) >= 0 ?
                        (index % count) :
                        count + (index % count);
        }
    }
}
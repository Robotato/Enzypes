using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enzypes.Network
{
    public class Operon : Linkable
    {
        public int StartIndex { get; set; }
        
        /// <summary>
        /// Must be >= 0.
        /// </summary>
        public double P_current { get; set; }
        
        /// <summary>
        /// Must be >= 0.
        /// </summary>
        public double P_default { get; set; }

        public Operon(int startIndex, double p_default)
        {
            StartIndex = startIndex;
            P_current = p_default;
            P_default = p_default;
        }
    }
}

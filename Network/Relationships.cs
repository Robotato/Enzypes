using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enzypes.Network
{
    public abstract class Relationship
    {
        public Linkable source, substrate;

        /// <summary>
        /// Must be in range 0 to 1.
        /// </summary>
        public double BindingAffinity { get; set; }
    }

    public class ActivationRelationship : Relationship
    {
        /// <summary>
        /// Must be > 0.
        /// </summary>
        public double ActionTime { get; set; }

        public bool Activating { get; set; }
    }

    public class ProductionRateRelationship : Relationship
    {
        /// <summary>
        /// Must be >= 0.
        /// </summary>
        public double delta_P { get; set; }

        public bool Promoting { get; set; }
    }

    public class DegradingRelationship
    {
        /// <summary>
        /// Must be > 0.
        /// </summary>
        public double ActionTime { get; set; }
    }
}
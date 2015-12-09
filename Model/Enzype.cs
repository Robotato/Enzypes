using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Enzypes.Model.Utilities;

namespace Enzypes.Model
{
    public class Enzype
    {
        //internal properties
        public Proportion Activation { get; set; }
        public double PopulationSize { get; set; }
        public double ProductionRate { get; set; }

        //relational properties
        public double[] BindingTimes { get; set; }
        public Relationship[] Relationships { get; set; }
    }
}
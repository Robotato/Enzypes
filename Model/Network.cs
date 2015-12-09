using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Enzypes.Model.Utilities;

namespace Enzypes.Model
{
    public enum Relationship { None, Activating, Inactivating, Promoting, Demoting, Degrading }

    public class Network
    {
        public List<Enzype> members;

        public Proportion[] GetAlphas()
        {
            throw new NotImplementedException();
        }

        public double[][] GetBindingTimes()
        {
            throw new NotImplementedException();
        }
    }
}
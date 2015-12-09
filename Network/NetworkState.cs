using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Enzypes.Network.Utilities;

namespace Enzypes.Network
{
    public class NetworkState
    {
        public CircularList<Operon> Operons;
        public CircularList<Enzype> Enzypes;
        public List<Relationship> Relationships;

        public NetworkState(CircularList<Operon> operons, CircularList<Enzype> enzypes, List<Relationship> relationships)
        {
            Operons = operons;
            Enzypes = enzypes;
            Relationships = relationships;
        }

        public CircularList<Enzype> GetEnzypes(int operonIndex)
        {
            //edge case handling
            if (operonIndex == 0 && Operons.Count == 1)
                return Enzypes;

            //clean up operon indices
            foreach (Operon o in Operons)
            {
                o.StartIndex = CircularList<Enzype>.WrapIndex(o.StartIndex, Enzypes.Count);
            }
            //sort ascending
            Operons.Sort((a, b) => a.StartIndex.CompareTo(b.StartIndex));

            CircularList<Enzype> result = new CircularList<Enzype>();
            for (int i = Operons[operonIndex].StartIndex; i < Operons[operonIndex + 1].StartIndex; i++)
            {
                result.Add(Enzypes[i]);
            }
            return result;
        }
    }
}
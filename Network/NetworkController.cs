using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Enzypes.Network.Scripting;
using Enzypes.Network.Utilities;

namespace Enzypes.Network
{
    public class NetworkController
    {
        public List<RunScript> RunScripts { get; set; }
        public List<HeldAction> CurrentHeldActions { get; set; }
        public double Time { get; private set; }

        public NetworkController()
        {
            RunScripts = new List<RunScript>();
            CurrentHeldActions = new List<HeldAction>();
        }

        public void Update(NetworkState networkState, double delta_t)
        {
            //TODO: update scripts


            //production
            for (int i = 0; i < networkState.Operons.Count; i++)
            {
                Operon o = networkState.Operons[i];
                CircularList<Enzype> enzypes = networkState.GetEnzypes(i);

                for (int k = 0; k < enzypes.Count; k++)
                {
                    Enzype e = enzypes[k];

                    //check if N is being held constant
                    bool N_held = false;
                    foreach (HeldAction h in CurrentHeldActions)
                    {
                        if (h.TargetIndex == k && h.TargetProperty == Scripting.Action.ActionTargetProperty.N_k)
                            N_held = true;
                    }

                    if (!N_held)
                        e.Number += Bounds.RestrictLower(o.P_current * delta_t, 0);
                    
                    Console.WriteLine(e.Number);
                }
            }

            Time += delta_t;
        }

        public void ResetTime()
        {
            Time = 0;
        }
    }
}
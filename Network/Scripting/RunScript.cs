using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enzypes.Network.Scripting
{
    public class RunScript
    {
        public readonly List<int> TRACKED_ENZYPES;
        public readonly List<int> TRACKED_OPERONS;

        public readonly List<HeldAction> HELD_ACTIONS;
        public readonly List<StepAction> STEP_ACTIONS;

        public RunScript(List<int> trackedEnzypes, List<int> trackedOperons, List<HeldAction> heldActions, List<StepAction> stepActions)
        {
            TRACKED_ENZYPES = trackedEnzypes;
            TRACKED_OPERONS = trackedOperons;

            HELD_ACTIONS = heldActions;
            STEP_ACTIONS = stepActions;
        }
    }
}
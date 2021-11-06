using System;
using System.Collections.Generic;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._0_BeginningPhase._0_Untap
{
    public class UntapStep : Step
    {
        public UntapStep(List<Action> actions) : base(actions)
        { 
        }
    }
}
using System;
using System.Collections.Generic;
using Action = MTGEngine.Turn.BaseClasses.Action;

namespace MTGEngine.Turn._0_BeginningPhase._2_Draw
{
    public class DrawStep : Step
    {
        public DrawStep(List<Action> actions) : base(actions) 
        {
        }
    }
}